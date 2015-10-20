using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Framework.Elements
{
    public class Button : BaseElement
    {
        public Button(By locator, String name) : base(locator, name) { }
    }
}
