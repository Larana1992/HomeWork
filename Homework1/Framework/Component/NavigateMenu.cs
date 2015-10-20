using Homework1.Framework.Elements;
using Homework1.Framework.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Framework.Component
{
    public class NavigateMenu : BaseElement
    {
        private readonly Button btnLogout = new Button(By.XPath("(//a[contains(@data-gt,'menu_logout')]//span)[last()]"), "logout button");
        private static readonly By lnkMain =
          By.XPath("//a[.='Facebook']");
        private readonly Button btnNavigation = new Button(By.XPath("//*[@id='userNavigationLabel']"), "Navigation button");

        public NavigateMenu() : base(lnkMain, "Facebook header component") { }

        public void clickNavigation()
        {
            btnNavigation.Click();
        }

        public LoginPage ClickLogout()
        {
            btnLogout.Click();
            return new LoginPage();
        }

        public void VerifyLogout()
        {
            WaitForElementPresent(btnLogout.GetLocator(), "button logout");
            Assert.AreEqual(btnLogout.IsPresent(), true);
        }
    }
}
