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
    public class LoginPage : BasePage
    {
        private static readonly By lkMain =
            By.XPath("//a[@title='Перейти на главную страницу Facebook']");
        private readonly TextBox tbLogin = new TextBox(By.XPath("//form[@id='login_form']//input[@id='email']"), "textbox login");
        private readonly TextBox tbPassword = new TextBox(By.XPath("//form[@id='login_form']//input[@id='pass']"), "textbox login");
        private readonly Button btnLogin = new Button(By.XPath("//form[@id='login_form']//*[@id='loginbutton']/input"), "login button");

        public LoginPage() : base(lkMain, "Facebook login page") { }

        public MainPage Login(String username, String password)
        {
            tbLogin.SetText(username);
            tbPassword.SetText(password);
            btnLogin.Click();
            return new MainPage();
        }

        public void VerifyLoginButton()
        {
            Assert.AreEqual(btnLogin.IsPresent(), true);
        }
    }
}
