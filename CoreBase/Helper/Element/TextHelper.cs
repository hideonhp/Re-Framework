using log4net;
using OpenQA.Selenium;
using Re_Framework.CoreBase.Helper.Common;
using Re_Framework.CoreBase.Helper.Enum;

namespace Re_Framework.CoreBase.Helper.Element
{
    public class TextHelper
    {
        private static readonly ILog Logger = Log4NetHelper.GetXmlLogger(typeof(TextBoxHelper));
        private static IWebElement element;

        public static string GetTextInside(string locator, int type = (int)Locator.CssSelector)
        {
            element = GenericHelper.GetElement(locator, type);
            var text = element.Text;
            Logger.Info($" Text inside the paragraph @ {locator} is {text}: ");
            return text;
        }
    }
}
