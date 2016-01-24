using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using webdriver_test_framework.Configuration;
using webdriver_test_framework.Settings;
using webdriver_test_framework.CustomException;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace webdriver_test_framework.BaseClasses
{
    [TestClass]
    public class BaseClass
    {
        private static IWebDriver getFireFoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }

        private static IWebDriver getChromeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            return driver;
        }

        private static IWebDriver getIEDriver()
        {
            IWebDriver driver = new InternetExplorerDriver();
            return driver;
        }

        [AssemblyInitialize]
        public static void initWebDriver(TestContext tc)
        {
            ObjectRepository.Config = new AppConfigReader();

            switch(ObjectRepository.Config.getBrowser())
            {
                case BrowserType.Firefox:
                    {
                        ObjectRepository.Driver = getFireFoxDriver();
                        break;
                    }

                case BrowserType.Chrome:
                    {
                        ObjectRepository.Driver = getChromeDriver();
                        break;
                    }

                case BrowserType.IExplorer:
                    {
                        ObjectRepository.Driver = getIEDriver();
                        break;
                    }

                default:
                    throw new NoSuitableDriverFound("No driver found: " + ObjectRepository.Config.getBrowser().ToString());
            }
        }
    }
}
