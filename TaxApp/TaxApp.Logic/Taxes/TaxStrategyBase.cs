using TaxApp.Common.Domain;

namespace TaxApp.Logic.Taxes
{
	public abstract class TaxStrategyBase
	{
		#region Properties
		public TaxConfiguration Configuration { get; private set;}
		
		public abstract Strategieart Strategieart {get;}
		#endregion

		#region Constructors
		public TaxStrategyBase(TaxConfiguration configuration)
		{
			this.Configuration = configuration;
		}
		#endregion

		#region Methods
		public abstract decimal Calculate(decimal betrag);
		#endregion
	}
}
