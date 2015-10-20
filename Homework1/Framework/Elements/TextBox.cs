using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Framework.Elements
{
    public class TextBox : BaseElement
    {
        public TextBox(By locator, String name) : base(locator, name) { }

        public void SetText(String text)
        {
            WaitForElementPresent();
            GetElement().Click();
            GetElement().SendKeys(text);
            Log.Info(String.Format("{0} :: type text '{1}'", GetName(), text));
        }
    }
}
