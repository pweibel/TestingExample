using System.Collections.Generic;

namespace TaxApp.Common.Domain
{
	public class TaxConfiguration
	{
		public Kanton Kanton { get; set; }
		public Betragsart Betragsart { get; set; }
		public Strategieart Strategieart { get; set; }
		public decimal Tarif { get; set; }
		public IList<TaxTranche> Tranchen { get; set; }
	}
}
