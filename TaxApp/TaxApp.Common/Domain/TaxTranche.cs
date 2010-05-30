namespace TaxApp.Common.Domain
{
	public class TaxTranche
	{
		public TaxConfiguration Configuration { get; set; }
		public decimal BetragVon { get; set; }
		public decimal? BetragBis { get; set; }
		public decimal Tarif { get; set; }
	}
}