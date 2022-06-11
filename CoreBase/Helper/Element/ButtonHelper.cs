using log4net;
using OpenQA.Selenium;
using Re_Framework.CoreBase.Helper.Common;
using Re_Framework.CoreBase.Helper.Enum;
using System.Threading.Tasks;

namespace Re_Framework.CoreBase.Helper.Element
{
    public class ButtonHelper
    {
        protected static readonly ILog Logger = Log4NetHelper.GetXmlLogger(typeof(ButtonHelper));
        protected static IWebElement _element;

        public static async void ClickButton(string locator, int type = (int)Locator.CssSelector)
        {
            await CheckerHelper.CheckElementIsEnable(locator, type);
            _element = GenericHelper.GetElement(locator, type);
            _element.Click();
            Logger.Info(" Button Click @ " + locator);
        }

        public static async Task<string> GetButtonTextAsync(string locator, int type = (int)Locator.CssSelector)
        {
            await CheckerHelper.CheckElementIsEnable(locator, type);
            _element = GenericHelper.GetElement(locator, type);
            if (_element.GetAttribute("value") == null)
                return string.Empty;
            return _element.GetAttribute("value");
        }
    }
}
