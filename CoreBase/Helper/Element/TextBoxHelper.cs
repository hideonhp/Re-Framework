using log4net;
using OpenQA.Selenium;
using Re_Framework.CoreBase.Helper.Common;
using Re_Framework.CoreBase.Helper.Enum;
using System.Threading.Tasks;

namespace Re_Framework.CoreBase.Helper.Element
{
    public class TextBoxHelper
    {
        protected static readonly ILog Logger = Log4NetHelper.GetXmlLogger(typeof(TextBoxHelper));
        protected static IWebElement element;
        public static async void TypeInTextBoxAsync(string locator, int type = (int)Locator.CssSelector, string text = null)
        {
            await CheckerHelper.CheckElementIsEnable(locator, type);
            element = GenericHelper.GetElement(locator, type);
            element.SendKeys(text);
            Logger.Info($" Type in Textbox @ {locator} : value : {text}");
        }

        public static async void ClearTextBoxAsync(string locator, int type = (int)Locator.CssSelector)
        {
            await CheckerHelper.CheckElementIsEnable(locator, type);
            element = GenericHelper.GetElement(locator, type);
            element.Clear();
            Logger.Info($" Clear the Textbox @ {locator}");
        }

        public static async Task<string> GetTextInsideAsync(string locator, int type = (int)Locator.CssSelector)
        {
            await CheckerHelper.CheckElementIsEnable(locator, type);
            element = GenericHelper.GetElement(locator, type);
            var text = element.GetAttribute("value");
            Logger.Info($" Text inside the Textbox @ {locator} is {text}: ");
            return text;
        }

        public static async Task<string> GetHintTextAsync(string locator, int type = (int)Locator.CssSelector)
        {
            await CheckerHelper.CheckElementIsEnable(locator, type);
            element = GenericHelper.GetElement(locator, type);
            var text = element.GetAttribute("placeholder");
            Logger.Info($" Hint text inside the Textbox @ {locator} is {text}: ");
            return text;
        }

    }
}
