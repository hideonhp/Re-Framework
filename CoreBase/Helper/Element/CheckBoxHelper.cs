using log4net;
using OpenQA.Selenium;
using Re_Framework.CoreBase.Helper.Common;
using Re_Framework.CoreBase.Helper.Enum;

namespace Re_Framework.CoreBase.Helper.Element
{
    public class CheckBoxHelper
    {
        private static readonly ILog Logger = Log4NetHelper.GetXmlLogger(typeof(CheckBoxHelper));
        private static IWebElement element;

        public static void CheckedCheckBox(string locator, int type = (int)Locator.CssSelector)
        {
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

        public static bool IsCheckBoxChecked(string locator, int type = (int)Locator.CssSelector)
        {
            element = GenericHelper.GetElement(locator, type);
            string flag = element.GetAttribute("checked");
            Logger.Info(" Is CheckBox Checked : " + locator);
            if (flag == null)
                return false;
            else
                return flag.Equals("true") || flag.Equals("checked");
        }

        public static bool IsCheckBoxEnable(string locator, int type = (int)Locator.CssSelector)
        {
            element = GenericHelper.GetElement(locator, type);
            Logger.Info(" Is CheckBox Checked : " + locator);
            return element.Enabled;
        }
        public static bool IsCheckBoxIntermediate(string locator, int type = (int)Locator.CssSelector)
        {
            element = GenericHelper.GetElement(locator, type);
            string flag = element.GetAttribute("intermediate");
            Logger.Info(" Is CheckBox Intermediate : " + locator);
            if (flag == null)
                return false;
            else
                return flag.Equals("true") || flag.Equals("checked");
        }
    }
}
