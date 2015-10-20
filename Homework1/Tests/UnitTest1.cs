using System;
using Homework.Tests;
using Homework.Framework.Core;
using NUnit.Framework;

namespace Homework
{
    [TestFixture]
    public class UnitTest1 : BaseTest
    {
        private readonly String username = RunConfigurator.GetLogin();
        private readonly String password = RunConfigurator.GetPassword();

       [Test]
        public void TestMethod1()
        {
            Log.Step(1);
            loginPage.VerifyLoginButton();
            Log.Step(2);
            mainPage = loginPage.Login(username, password);
            Log.Step(3);
            mainPage.MainPageIsDisplayed();
            Log.Step(4);
            mainPage.navigateMenu.clickNavigation();
            Log.Step(5);
            mainPage.navigateMenu.VerifyLogout();
            Log.Step(6);
            loginPage = mainPage.navigateMenu.ClickLogout();
        }
    }
}
