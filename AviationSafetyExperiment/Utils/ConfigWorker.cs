using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviationSafetyExperiment.Utils
{
    public class ConfigWorker
    {
        public static string GetConfigValue(string key)
        {
            if (System.Configuration.ConfigurationManager.AppSettings[key] != null)
                return System.Configuration.ConfigurationManager.AppSettings[key];
            else
                return string.Empty;
        }

        public static void SetConfigValue(string key, string value)
        {
            Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (cfa.AppSettings.Settings.AllKeys.Contains(key))
            {
                cfa.AppSettings.Settings[key].Value = value;
            }
            else
            {
                cfa.AppSettings.Settings.Add(key, value);
            }
            cfa.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
