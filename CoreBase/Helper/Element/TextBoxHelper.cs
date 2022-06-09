using log4net;
using OpenQA.Selenium;
using Re_Framework.CoreBase.Helper.Common;
using Re_Framework.CoreBase.Helper.Enum;

namespace Re_Framework.CoreBase.Helper.Element
{
    public class TextBoxHelper
    {
        private static readonly ILog Logger = Log4NetHelper.GetXmlLogger(typeof(TextBoxHelper));
        private static IWebElement element;
        public static void TypeInTextBox(string locator, int type = (int)Locator.CssSelector, string text = null)
        {
            element = GenericHelper.GetElement(locator, type);
            element.SendKeys(text);
            Logger.Info($" Type in Textbox @ {locator} : value : {text}");
        }

        public static void ClearTextBox(string locator, int type = (int)Locator.CssSelector)
        {
            element = GenericHelper.GetElement(locator, type);
            element.Clear();
            Logger.Info($" Clear the Textbox @ {locator}");
        }

        public static string GetTextInside(string locator, int type = (int)Locator.CssSelector)
        {
            element = GenericHelper.GetElement(locator, type);
            var text = element.GetAttribute("value");
            Logger.Info($" Text inside the Textbox @ {locator} is {text}: ");
            return text;
        }

        public static string GetHintText(string locator, int type = (int)Locator.CssSelector)
        {
            element = GenericHelper.GetElement(locator, type);
            var text = element.GetAttribute("placeholder");
            Logger.Info($" Hint text inside the Textbox @ {locator} is {text}: ");
            return text;
        }

        public static bool IsTextBoxEnabled(string locator, int type = (int)Locator.CssSelector)
        {
            element = GenericHelper.GetElement(locator, type);
            Logger.Info(" Checking Is Textbox Enabled ");
            return element.Enabled;
        }
    }
}
