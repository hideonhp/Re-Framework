using log4net;
using OpenQA.Selenium;
using Re_Framework.CoreBase.Helper.Common;
using Re_Framework.CoreBase.Helper.Enum;
using System.Threading.Tasks;

namespace Re_Framework.CoreBase.Helper.Element
{
    public class CheckBoxHelper
    {
        protected static readonly ILog Logger = Log4NetHelper.GetXmlLogger(typeof(CheckBoxHelper));
        protected static IWebElement element;

        public static async void CheckedCheckBoxAsync(string locator, int type = (int)Locator.CssSelector)
        {
            await CheckerHelper.CheckElementIsEnable(locator, type);
            element = GenericHelper.GetElement(locator, type);
            string flag = element.GetAttribute("checked");
            if (flag == null)
            {
                element.Click();
                Logger.Info(" Click on Check box : " + locator);
            }
            else
                Logger.Info(" Check box a;ready checked : " + locator);
        }

        public static async Task<bool> IsCheckBoxCheckedAsync(string locator, int type = (int)Locator.CssSelector)
        {
            await CheckerHelper.CheckElementIsEnable(locator, type);
            element = GenericHelper.GetElement(locator, type);
            string flag = element.GetAttribute("checked");
            Logger.Info(" Is CheckBox Checked : " + locator);
            if (flag == null)
                return await Task.FromResult(false);
            else
                return await Task.FromResult(flag.Equals("true") || flag.Equals("checked"));
        }

        public static async Task<bool> IsCheckBoxIntermediateAsync(string locator, int type = (int)Locator.CssSelector)
        {
            await CheckerHelper.CheckElementIsEnable(locator, type);
            element = GenericHelper.GetElement(locator, type);
            string flag = element.GetAttribute("intermediate");
            Logger.Info(" Is CheckBox Intermediate : " + locator);
            if (flag == null)
                return await Task.FromResult(false);
            else
                return await Task.FromResult(flag.Equals("true") || flag.Equals("checked"));
        }
    }
}
