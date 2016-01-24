using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webdriver_test_framework.Configuration;

namespace webdriver_test_framework.Interfaces
{
    public interface IConfig
    {
        BrowserType getBrowser();
        string getUsername();
        string getPassword();
    }
}
