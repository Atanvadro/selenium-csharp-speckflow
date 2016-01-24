using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using webdriver_test_framework;
using webdriver_test_framework.Interfaces;
using webdriver_test_framework.Configuration;

namespace webdriver_test_framework
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IConfig config = new AppConfigReader();

            Console.WriteLine(config.getBrowser());
            Console.WriteLine(config.getUsername());
            Console.WriteLine(config.getPassword());
        }
    }
}
