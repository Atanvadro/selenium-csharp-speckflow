using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using webdriver_test_framework.Interfaces;
using webdriver_test_framework.Settings;
using webdriver_test_framework.CustomException;

namespace webdriver_test_framework.Configuration
{
    public class AppConfigReader : IConfig
    {
        public BrowserType getBrowser()
        {

            string sBrowser = ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
            BrowserType eBrowser;
            try
            {
                eBrowser = (BrowserType)Enum.Parse(typeof(BrowserType), sBrowser);
            }
            catch
            {
                throw new BrowserNotSupported(sBrowser);
            }
            return eBrowser;
        }
        public string getUsername()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Username);
        }
        public string getPassword()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Password);
        }
    }
}
