using GenericWinformTemplate.Models;

namespace GenericWinformTemplate.Infrastructures
{
    public class ConfigurationHelper
    {
        public AppSettings AppSettings { get; set; }

        public ConfigurationHelper(AppSettings appSettings)
        {
            AppSettings = appSettings;
        }

        public static ConfigurationHelper Current { get; set; }
    }
}
