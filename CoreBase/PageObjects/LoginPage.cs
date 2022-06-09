using OpenQA.Selenium;
using Re_Framework.CoreBase.Helper.Element;
using Re_Framework.CoreBase.Helper.Enum;

namespace Re_Framework.CoreBase.PageObjects
{
    public class LoginPage : BasePage
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        #region WebElement

        private string CancelLoginModalButton = ".overlay-titleCloser";

        private string CancelRegisterModalButton = "//body/div[5]/div/div/a";

        private string LoginTextBox = "//input[@id='_xfUid-1-1654584004']";

        private string PassTextBox = "//input[@id='_xfUid-2-1654584004']";

        private string SubmitLoginButton = "//div[2]/button/span";

        #endregion

        #region Actions

        public void Login(string usename, string password)
        {
            TextBoxHelper.TypeInTextBox(LoginTextBox, (int)Locator.XPath, usename);
            TextBoxHelper.TypeInTextBox(PassTextBox, (int)Locator.XPath, password);
            ButtonHelper.ClickButton(SubmitLoginButton, (int)Locator.XPath);
            //GenericHelper.WaitForWebElementInPage(By.LinkText("Testng"), TimeSpan.FromSeconds(30));
        }

        #endregion

        #region Navigation

        #endregion
    }
}