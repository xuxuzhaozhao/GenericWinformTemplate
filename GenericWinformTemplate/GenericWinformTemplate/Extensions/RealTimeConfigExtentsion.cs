using GenericWinformTemplate.Infrastructures;
using GenericWinformTemplate.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;

namespace GenericWinformTemplate.Extensions
{
    public static class RealTimeConfigExtentsion
    {
        public static void SetAppSettings(this IConfiguration configuration)
        {
            SetCurrentConfig(configuration);

            ChangeToken.OnChange(
                configuration.GetReloadToken,
                () => SetCurrentConfig(configuration)
             );
        }

        private static void SetCurrentConfig(IConfiguration configuration)
        {
            var appSettings = configuration.GetSection(nameof(AppSettings)).Get<AppSettings>();
            ConfigurationHelper.Current = new ConfigurationHelper(appSettings!);
        }
    }
}
