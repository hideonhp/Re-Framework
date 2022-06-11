using log4net;
using OpenQA.Selenium;
using Re_Framework.CoreBase.Helper.Common;
using Re_Framework.CoreBase.Helper.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re_Framework.CoreBase.Helper.Element
{
    public class CheckerHelper
    {
        protected static readonly ILog Logger = Log4NetHelper.GetXmlLogger(typeof(ButtonHelper));
        protected static IWebElement _element;

        public static Task<bool> CheckElementIsEnable(string locator, int type = (int)Locator.CssSelector)
        {
            WaitHelper.NaniWait(() => IsEnabled(locator, type));
            return Task.FromResult(true);
        }
        protected static bool IsEnabled(string locator, int type = (int)Locator.CssSelector)
        {
            _element = GenericHelper.GetElement(locator, type);
            Logger.Info(" Checking Is Enabled ");
            return _element.Enabled;
        }
    }
}
