using Homework1.Framework.Component;
using Homework1.Framework.Elements;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Framework.Page
{
    public class MainPage : BasePage
    {
        public NavigateMenu navigateMenu = new NavigateMenu();

        private static readonly By btnStatus = By.XPath("//h2[@class = 'uiHeaderTitle' and contains(.,'Добро пожаловать на Facebook,')]");

        public MainPage() : base(btnStatus, "Facebook main page") { }

        public void MainPageIsDisplayed()
        {
            IsDisplayed(btnStatus, "Button Status");
        }
    }
}
