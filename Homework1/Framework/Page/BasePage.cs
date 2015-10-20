using Homework.Framework.Core;
using Homework1.Framework.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Framework.Page
{
   public class BasePage : BaseEntity
    {
        private readonly String _name;
        private readonly By _locator;

        protected BasePage(By locator, String name)
        {
            _locator = locator;
            _name = name;
            AssertIsPresent();
        }

        private void AssertIsPresent()
        {
            BaseElement.WaitForElementPresent(_locator, _name);
            Log.Info(String.Format("Form '{0}' has appeared", _name));
        }
        
        public void IsDisplayed(By element, String elementName)
        {
            BaseElement.WaitForElementPresent(element, elementName);
            Log.Info(String.Format("Text '{0}' is shown on the page", elementName));
        }
    }
}
