using OpenQA.Selenium;
using Re_Framework.CoreBase.Helper.Common;
using Re_Framework.CoreBase.Helper.Enum;

namespace Re_Framework.CoreBase.Helper.Element
{
    public class RadioButtonHelper
    {
        protected static IWebElement element;

        public static void ClickRadioButton(string locator, int type = (int)Locator.CssSelector)
        {
            element = GenericHelper.GetElement(locator, type);
            string flag = element.GetAttribute("checked");

            if (flag == null)
                element.Click();
        }

        public static bool IsRadioButtonSelected(string locator, int type = (int)Locator.CssSelector)
        {
            element = GenericHelper.GetElement(locator, type);
            string flag = element.GetAttribute("checked");

            if (flag == null)
                return false;
            else
                return flag.Equals("true") || flag.Equals("checked");
        }

        public static bool IsRadioButtonDisabled(string locator, int type = (int)Locator.CssSelector)
        {
            element = GenericHelper.GetElement(locator, type);
            string flag = element.GetAttribute("disabled");

            if (flag == null)
                return false;
            else
                return flag.Equals("true") || flag.Equals("checked");
        }
    }
}
