using log4net;
using OpenQA.Selenium;
using Re_Framework.CoreBase.Helper.Common;
using Re_Framework.CoreBase.Helper.Enum;
using System.Threading.Tasks;

namespace Re_Framework.CoreBase.Helper.Element
{
    public class TextHelper
    {
        protected static readonly ILog Logger = Log4NetHelper.GetXmlLogger(typeof(TextBoxHelper));
        protected static IWebElement element;

        public static async Task<string> GetTextInsideAsync(string locator, int type = (int)Locator.CssSelector)
        {
            await CheckerHelper.CheckElementIsEnable(locator, type);
            element = GenericHelper.GetElement(locator, type);
            var text = element.Text;
            Logger.Info($" Text inside the paragraph @ {locator} is {text}: ");
            return text;
        }
    }
}
