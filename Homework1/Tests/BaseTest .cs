using Homework.Framework.Core;
using Homework1.Framework.Page;
using NUnit.Framework;
using System.Diagnostics;

namespace Homework.Tests
{
    [TestFixture]
    public class BaseTest :BaseEntity
    {
        public LoginPage loginPage;
        public MainPage mainPage;

        [SetUp]
        public void SetUp()
        {
            Browser.GetInstance();
            Browser.GetDriver().Navigate().GoToUrl(Configuration.GetBaseUrl());
            loginPage = new LoginPage();
        }

        [TearDown]
        public void TearDown()
        {
            var processes = Process.GetProcessesByName(Configuration.GetBrowser());
            foreach (var process in processes)
            {
                process.Kill();
            }
            Browser.GetDriver().Quit();
        }
    }
}
