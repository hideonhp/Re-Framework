using OpenQA.Selenium;
using Re_Framework.CoreBase.Helper.Common;
using Re_Framework.CoreBase.Helper.Enum;
using System.Threading.Tasks;

namespace Re_Framework.CoreBase.Helper.Element
{
    public class RadioButtonHelper
    {
        protected static IWebElement element;

        public static async Task ClickRadioButtonAsync(string locator, int type = (int)Locator.CssSelector)
        {
            await CheckerHelper.CheckElementIsEnable(locator, type);
            element = GenericHelper.GetElement(locator, type);
            string flag = element.GetAttribute("checked");

            if (flag == null)
                element.Click();
        }

        public static async Task<bool> IsRadioButtonSelectedAsync(string locator, int type = (int)Locator.CssSelector)
        {
            await CheckerHelper.CheckElementIsEnable(locator, type);
            element = GenericHelper.GetElement(locator, type);
            string flag = element.GetAttribute("checked");

            if (flag == null)
                return false;
            else
                return flag.Equals("true") || flag.Equals("checked");
        }

        public static async Task<bool> IsRadioButtonDisabledAsync(string locator, int type = (int)Locator.CssSelector)
        {
            await CheckerHelper.CheckElementIsEnable(locator, type);
            element = GenericHelper.GetElement(locator, type);
            string flag = element.GetAttribute("disabled");

            if (flag == null)
                return false;
            else
                return flag.Equals("true") || flag.Equals("checked");
        }
    }
}
