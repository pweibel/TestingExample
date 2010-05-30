using System;
using System.Collections.Generic;
using TaxApp.Common.Domain;
using TaxApp.Common.RepositoryInterfaces;
using TaxApp.Data.Repositories;

namespace TaxApp.Logic.Taxes
{
	public class TaxStrategyFactory
	{
		#region Fields
		private static TaxStrategyFactory _instance;

		private readonly ITaxConfigurationRepository _taxconfigurationRepository;
		private readonly Dictionary<Strategieart, Type> _strategyRegistry = new Dictionary<Strategieart, Type>();
		#endregion

		#region Constructors
		private TaxStrategyFactory(ITaxConfigurationRepository configurationRepository)
		{
			_taxconfigurationRepository = configurationRepository;
			RegisterStrategies();
		}
		#endregion

		#region Statics
		public static TaxStrategyFactory GetInstance()
		{
			return GetInstance(null);
		}

		public static TaxStrategyFactory GetInstance(ITaxConfigurationRepository configurationRepository)
		{
			if(_instance == null)
			{
				if (configurationRepository == null) configurationRepository = new TaxConfigurationRepository();

				_instance = new TaxStrategyFactory(configurationRepository);
			}

			return _instance;
		}
		#endregion

		#region Methods
		public TaxStrategyBase GetStrategy(Kanton kanton, Betragsart art)
		{
			TaxConfiguration configuration = GetSteuerkonfiguration(kanton, art);

			Type strategyType = _strategyRegistry[configuration.Strategieart];
			if (strategyType == null) throw new Exception(string.Format("Steuerberechnungsstrategie ist unbekannt: {0}!", configuration.Strategieart));

			TaxStrategyBase strategy = (TaxStrategyBase) Activator.CreateInstance(strategyType, new object[] { configuration });
			return strategy;
		}
		#endregion

		#region Privates
		private TaxConfiguration GetSteuerkonfiguration(Kanton kanton, Betragsart betragsart)
		{
			//Konfigurationen laden und holen
			IList<TaxConfiguration> configurations = _taxconfigurationRepository.FindByKantonAndBetragsart(kanton, betragsart);

			if (configurations.Count != 1) throw new ApplicationException(string.Format("Es sollte genau eine Steuerkonfiguration geben! Es gibt aber: {0}! Suchkriterien: Steueramt: {1}, Betragsart: {2}", configurations.Count, kanton, betragsart));

			return configurations[0];
		}

		private void RegisterStrategies()
		{
			Type[] types = typeof(TaxStrategyBase).Assembly.GetTypes();
			foreach(Type type in types)
			{
				if (type.IsSubclassOf(typeof(TaxStrategyBase)))
				{
					// Create dummy instance
					TaxStrategyBase strategyInstance = (TaxStrategyBase) Activator.CreateInstance(type, new object[] { null });
					_strategyRegistry.Add(strategyInstance.Strategieart, type);
				}
			}
		}
		#endregion
	}
}
