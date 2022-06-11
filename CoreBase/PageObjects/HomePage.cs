using OpenQA.Selenium;
using Re_Framework.CoreBase.Helper.Common;
using Re_Framework.CoreBase.Helper.Element;
using Re_Framework.CoreBase.Helper.Enum;
using System.Threading.Tasks;

namespace Re_Framework.CoreBase.PageObjects
{
    public class HomePage : BasePage
    {
        protected IWebDriver driver;
        public HomePage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        #region WebElement
        protected string ElementsLink = "/html/body/div[2]/div/div/div[2]/div/div[1]";

        #endregion

        #region Actions

        #endregion

        #region Navigation
        public Task<bool> NaviGateToElementsPage()
        {
            ButtonHelper.ClickButton(ElementsLink, (int)Locator.XPath);
            return Task.FromResult(true);
        }

        #endregion
    }
}
