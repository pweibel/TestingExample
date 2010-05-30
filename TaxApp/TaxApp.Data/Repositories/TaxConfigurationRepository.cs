using System;
using System.Collections.Generic;
using TaxApp.Common.Domain;
using TaxApp.Common.RepositoryInterfaces;

namespace TaxApp.Data.Repositories
{
	public class TaxConfigurationRepository : ITaxConfigurationRepository
	{
		public IList<TaxConfiguration> FindByKantonAndBetragsart(Kanton kanton, Betragsart betragsart)
		{
			throw new NotImplementedException();
		}

		public void SaveAndUpdateTaxConfiguration(TaxConfiguration configuration)
		{
			throw new NotImplementedException();
		}

		public void RemoveTaxConfiguration(TaxConfiguration configuration)
		{
			throw new NotImplementedException();
		}
	}
}
