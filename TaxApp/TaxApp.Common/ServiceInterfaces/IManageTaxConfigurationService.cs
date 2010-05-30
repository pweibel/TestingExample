using System.Collections.Generic;
using TaxApp.Common.Domain;

namespace TaxApp.Common.ServiceInterfaces
{
	public interface IManageTaxConfigurationService
	{
		IList<TaxConfiguration> LoadConfigurations();
		void AddConfiguration(TaxConfiguration config);
		void UpdateConfiguration(TaxConfiguration config);
		void RemoveConfiguration(TaxConfiguration config);
	}
}
