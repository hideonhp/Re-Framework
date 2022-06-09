using log4net;
using OpenQA.Selenium;
using Re_Framework.CoreBase.Helper.Common;
using Re_Framework.CoreBase.Helper.Enum;

namespace Re_Framework.CoreBase.Helper.Element
{
    public class ButtonHelper
    {
        private static readonly ILog Logger = Log4NetHelper.GetXmlLogger(typeof(ButtonHelper));
        private static IWebElement _element;

        public static void ClickButton(string locator, int type = (int)Locator.CssSelector)
        {
            _element = GenericHelper.GetElement(locator, type);
            _element.Click();
            Logger.Info(" Button Click @ " + locator);
        }

        public static bool IsButtonEnabled(string locator, int type = (int)Locator.CssSelector)
        {
            _element = GenericHelper.GetElement(locator, type);
            Logger.Info(" Checking Is Button Enabled ");
            return _element.Enabled;
        }

        public static string GetButtonText(string locator, int type = (int)Locator.CssSelector)
        {
            _element = GenericHelper.GetElement(locator, type);
            if (_element.GetAttribute("value") == null)
                return string.Empty;
            return _element.GetAttribute("value");
        }
    }
}
