using OpenQA.Selenium;
using Re_Framework.CoreBase.Helper.Common;
using Re_Framework.CoreBase.Helper.Element;
using Re_Framework.CoreBase.Helper.Enum;
using SeleniumExtras.PageObjects;
using System.Threading.Tasks;

namespace Re_Framework.CoreBase
{
    public class BasePageAPI
    {
        protected IWebDriver driver;
        public BasePageAPI(IWebDriver _driver)
        {
            PageFactory.InitElements(_driver, this);
            this.driver = _driver;
        }

        #region WebElement

        protected string AuthenButton = ".btn";
        protected string BearerTextBox = ".wrapper:nth-child(5) input";
        protected string SubmitAuthenButton = ".auth-container:nth-child(2) .authorize";
        protected string SubmitLogOutButton = ".auth-container:nth-child(2) .btn:nth-child(1)";
        protected string CloseModalAuthen = ".auth-container:nth-child(2) .btn-done";
        protected string AuthorizedText = "//h6[contains(.,'Authorized')]";

        #endregion

        #region Actions

        public Task<bool> OpenAuthenModal(string bearer)
        {
            ButtonHelper.ClickButton(AuthenButton, (int)Locator.CssSelector);
            TextBoxHelper.TypeInTextBoxAsync(BearerTextBox, (int)Locator.CssSelector, bearer);
            ButtonHelper.ClickButton(SubmitAuthenButton, (int)Locator.CssSelector);
            CheckerHelper.CheckElementIsEnable(SubmitLogOutButton, (int)Locator.CssSelector);
            var text = TextHelper.GetTextInsideAsync(AuthorizedText, (int)Locator.XPath);
            AssertHelper.Equals(text, "Authorized");
            ButtonHelper.ClickButton(CloseModalAuthen, (int)Locator.CssSelector);
            return Task.FromResult(true);
        }

        #endregion
    }
}
