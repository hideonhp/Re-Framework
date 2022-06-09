using OpenQA.Selenium;
using Re_Framework.CoreBase.Helper.Element;
using Re_Framework.CoreBase.Helper.Enum;
using SeleniumExtras.PageObjects;

namespace Re_Framework.CoreBase
{
    public class BasePage
    {
        private IWebDriver driver;
        public BasePage(IWebDriver _driver)
        {
            PageFactory.InitElements(_driver, this);
            this.driver = _driver;
        }

        #region WebElement

        private string HomeLink = "//header/a/img";

        #endregion

        #region Actions

        private void NaviGateToHomePage()
        {
            ButtonHelper.ClickButton(HomeLink, (int)Locator.XPath);
        }

        public string GetHomePageTitle
        {
            get { return driver.Title; }
        }

        public string GetHomePageUrl
        {
            get { return driver.Url; }
        }

        #endregion

    }
}
