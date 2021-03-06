﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Framework.Core
{
    public class BrowserFactory : BaseEntity
    {
        private const String DriverPath = "../../Resources/";

        /// <summary>
        /// setup webdriver. chromedriver is a default value
        /// </summary>
        /// <returns>driver</returns>
        public static IWebDriver SetupBrowser()
        {
            String browserName = Configuration.GetBrowser();

            if (browserName == "chrome")
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--start-maximized");
                return new ChromeDriver(Path.GetFullPath(DriverPath), options);
            }
            return new ChromeDriver(Path.GetFullPath(DriverPath));
        }
    }
}
