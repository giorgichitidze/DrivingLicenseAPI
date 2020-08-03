using System;
using Microsoft.Extensions.Configuration;

namespace DrivingLicense.WebApi.Factories
{
    public class DatabaseConfiguration : ConfigurationBase
    {
        private string DataConnectionKey = "dataConnection";

        public string GetDataConnectionString()
        {
            return GetConfiguration().GetConnectionString(DataConnectionKey);
        }
    }
}
