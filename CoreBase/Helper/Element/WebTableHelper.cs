using log4net;
using OpenQA.Selenium;
using Re_Framework.CoreBase.Helper.Common;
using Re_Framework.CoreBase.Helper.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re_Framework.CoreBase.Helper.Element
{
    public class WebTableHelper
    {
        private static readonly ILog Logger = Log4NetHelper.GetXmlLogger(typeof(TextBoxHelper));
        private static IWebElement element;

        public static List<string> GetAllRowTDFromTable(string locator, int type = (int)Locator.CssSelector)
        {
            element = GenericHelper.GetElement(locator, type);
            List<IWebElement> lstTrElem = new List<IWebElement>(element.FindElements(By.TagName("tr")));
            String[] allTextTD = new String[lstTrElem.Count];

            int i = 0;
            foreach (var elemTr in lstTrElem)
            {
                List<IWebElement> lstTdElem = new List<IWebElement>(elemTr.FindElements(By.TagName("td")));
                if (lstTdElem.Count > 0)
                {
                    foreach (var elemTd in lstTdElem)
                    {
                        allTextTD[i++] = elemTd.Text;
                    }
                }
            }

            List<string> list = new List<string>(allTextTD);
            return list;
        }

        public static List<string> GetAllRowTRFromTable(string locator, int type = (int)Locator.CssSelector)
        {
            element = GenericHelper.GetElement(locator, type);
            List<IWebElement> lstTrElem = new List<IWebElement>(element.FindElements(By.TagName("tr")));
            String[] allTextTR = new String[lstTrElem.Count];

            int i = 0;
            foreach (var elemTr in lstTrElem)
            {
                allTextTR[i++] = elemTr.Text;
            }

            List<string> list = new List<string>(allTextTR);
            return list;
        }
    }
}
