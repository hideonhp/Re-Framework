using OpenQA.Selenium;
using Re_Framework.CoreBase.Helper.Common;
using Re_Framework.CoreBase.Helper.Element;
using Re_Framework.CoreBase.Helper.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re_Framework.CoreBase.PageObjects
{
    public class ElementsPage : BasePage
    {
        protected IWebDriver driver;
        public ElementsPage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        #region WebElement

        protected string TextBoxLink = "//li[@id='item-0']";
        protected string CheckBoxLink = "//*[@id='item-1']";
        protected string RadioButtonLink = "//*[@id='item-2']";
        protected string WebTablesLink = "//*[@id='item-3']";
        protected string TextBoxSubmitButton = "//*[@id='submit']";

        protected string UserMailTextBox = "#userEmail";
        protected string UserNameTextBox = "#userName";
        protected string UserCurrentAdressTextBox = "#currentAddress";
        protected string UserPermanentAdressTextBox = "#permanentAddress";

        protected string UserNameReturn = "//*[@id='name']";
        protected string UserMailReturn = "//*[@id='email']";
        protected string UserCurrentAdressReturn = "//*[@id='currentAddress']";
        protected string UserPermanentAdressReturn = "//*[@id='permanentAddress']";

        protected string ExpandCheckBoxHomeButton = "/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div/ol/li/span/button";
        protected string ExpandCheckBoxDesktopButton = "/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div/ol/li/ol/li[1]/span/button";
        protected string ExpandCheckBoxDocumentButton = "/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div/ol/li/ol/li[2]/span/button";
        protected string ExpandCheckBoxDownloadsButton = "/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div/ol/li/ol/li[3]/span/button";

        protected string CheckBoxHome = "/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div/ol/li/span/label/span[1]";
        protected string CheckBoxDesktop = "/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div/ol/li/ol/li[1]/span/label/span[1]";
        protected string CheckBoxDocument = "/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div/ol/li/ol/li[2]/span/label/span[1]";
        protected string CheckBoxDownloads = "/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div/ol/li/ol/li[3]/span/label/span[1]";
        protected string CheckBoxResultReturn = "#result";
        #endregion

        #region Private Method
        protected Task<bool> CheckUserMailTextBoxIsEnable()
        {
            WaitHelper.NaniWait(() => TextBoxHelper.IsTextBoxEnabled(UserMailTextBox, (int)Locator.CssSelector));
            return Task.FromResult(true);
        }
        protected Task<bool> CheckUserCurrentAdressTextBoxIsEnable()
        {
            WaitHelper.NaniWait(() => TextBoxHelper.IsTextBoxEnabled(UserCurrentAdressTextBox, (int)Locator.CssSelector));
            return Task.FromResult(true);
        }
        protected Task<bool> CheckUserPermanentAdressTextBoxIsEnable()
        {
            WaitHelper.NaniWait(() => TextBoxHelper.IsTextBoxEnabled(UserPermanentAdressTextBox, (int)Locator.CssSelector));
            return Task.FromResult(true);
        }
        protected Task<bool> CheckUserNameTextBoxIsEnable()
        {
            WaitHelper.NaniWait(() => TextBoxHelper.IsTextBoxEnabled(UserNameTextBox, (int)Locator.CssSelector));
            return Task.FromResult(true);
        }

        protected Task<bool> CheckUserNameReturnIsEnable()
        {
            WaitHelper.NaniWait(() => TextBoxHelper.IsTextBoxEnabled(UserNameReturn, (int)Locator.XPath));
            return Task.FromResult(true);
        }
        protected Task<bool> CheckUserMailReturnIsEnable()
        {
            WaitHelper.NaniWait(() => TextBoxHelper.IsTextBoxEnabled(UserMailReturn, (int)Locator.XPath));
            return Task.FromResult(true);
        }
        protected Task<bool> CheckUserCurrentAdressReturnIsEnable()
        {
            WaitHelper.NaniWait(() => TextBoxHelper.IsTextBoxEnabled(UserCurrentAdressReturn, (int)Locator.XPath));
            return Task.FromResult(true);
        }
        protected Task<bool> CheckUserPermanentAdressReturnIsEnable()
        {
            WaitHelper.NaniWait(() => TextBoxHelper.IsTextBoxEnabled(UserPermanentAdressReturn, (int)Locator.XPath));
            return Task.FromResult(true);
        }

        protected Task<bool> CheckTextBoxLinkIsEnable()
        {
            WaitHelper.NaniWait(() => ButtonHelper.IsButtonEnabled(TextBoxLink, (int)Locator.XPath));
            return Task.FromResult(true);
        }
        protected Task<bool> CheckCheckBoxLinkIsEnable()
        {
            WaitHelper.NaniWait(() => ButtonHelper.IsButtonEnabled(CheckBoxLink, (int)Locator.XPath));
            return Task.FromResult(true);
        }
        protected Task<bool> CheckWebTableLinkIsEnable()
        {
            WaitHelper.NaniWait(() => ButtonHelper.IsButtonEnabled(WebTablesLink, (int)Locator.XPath));
            return Task.FromResult(true);
        }
        protected Task<bool> CheckTextBoxSubmitButtonIsEnable()
        {
            WaitHelper.NaniWait(() => ButtonHelper.IsButtonEnabled(TextBoxSubmitButton, (int)Locator.XPath));
            return Task.FromResult(true);
        }

        protected Task<bool> CheckCheckBoxHomeIsEnable()
        {
            WaitHelper.NaniWait(() => CheckBoxHelper.IsCheckBoxEnable(CheckBoxHome, (int)Locator.XPath));
            return Task.FromResult(true);
        }
        protected Task<bool> CheckExpandCheckBoxHomeButtonIsEnable()
        {
            WaitHelper.NaniWait(() => ButtonHelper.IsButtonEnabled(ExpandCheckBoxHomeButton, (int)Locator.XPath));
            return Task.FromResult(true);
        }
        protected Task<bool> CheckCheckBoxDesktopIsEnable()
        {
            WaitHelper.NaniWait(() => CheckBoxHelper.IsCheckBoxEnable(CheckBoxDesktop, (int)Locator.XPath));
            return Task.FromResult(true);
        }
        protected Task<bool> CheckExpandCheckBoxDesktopButtonIsEnable()
        {
            WaitHelper.NaniWait(() => ButtonHelper.IsButtonEnabled(ExpandCheckBoxDesktopButton, (int)Locator.XPath));
            return Task.FromResult(true);
        }
        protected Task<bool> CheckCheckBoxDocumentIsEnable()
        {
            WaitHelper.NaniWait(() => CheckBoxHelper.IsCheckBoxEnable(CheckBoxDocument, (int)Locator.XPath));
            return Task.FromResult(true);
        }
        protected Task<bool> CheckExpandCheckBoxDocumentButtonIsEnable()
        {
            WaitHelper.NaniWait(() => ButtonHelper.IsButtonEnabled(ExpandCheckBoxDocumentButton, (int)Locator.XPath));
            return Task.FromResult(true);
        }
        protected Task<bool> CheckCheckBoxDownloadsIsEnable()
        {
            WaitHelper.NaniWait(() => CheckBoxHelper.IsCheckBoxEnable(CheckBoxDownloads, (int)Locator.XPath));
            return Task.FromResult(true);
        }
        protected Task<bool> CheckExpandCheckBoxDownloadsButtonIsEnable()
        {
            WaitHelper.NaniWait(() => ButtonHelper.IsButtonEnabled(ExpandCheckBoxDownloadsButton, (int)Locator.XPath));
            return Task.FromResult(true);
        }
        protected Task<bool> CheckCheckBoxResultReturnIsEnable()
        {
            WaitHelper.NaniWait(() => TextBoxHelper.IsTextBoxEnabled(CheckBoxResultReturn, (int)Locator.CssSelector));
            return Task.FromResult(true);
        }

        #endregion

        #region Public Method
        public async Task<bool> SendKeyToUserMailTextBoxAsync(string text)
        {
            await CheckUserMailTextBoxIsEnable();
            TextBoxHelper.TypeInTextBox(UserMailTextBox, (int)Locator.CssSelector, text);
            return true;
        }
        public async Task<bool> SendKeyToUserCurrentAdressTextBoxAsync(string text)
        {
            await CheckUserCurrentAdressTextBoxIsEnable();
            TextBoxHelper.TypeInTextBox(UserCurrentAdressTextBox, (int)Locator.CssSelector, text);
            return true;
        }
        public async Task<bool> SendKeyToUserPermanentAdressTextBoxAsync(string text)
        {
            await CheckUserPermanentAdressTextBoxIsEnable();
            TextBoxHelper.TypeInTextBox(UserPermanentAdressTextBox, (int)Locator.CssSelector, text);
            return true;
        }
        public async Task<bool> SendKeyToUserNameTextBoxBoxAsync(string text)
        {
            await CheckUserNameTextBoxIsEnable();
            TextBoxHelper.TypeInTextBox(UserNameTextBox, (int)Locator.CssSelector, text);
            return true;
        }
        public async Task<bool> ClickTextBoxSubmitButtonAsync()
        {
            await CheckTextBoxSubmitButtonIsEnable();
            ButtonHelper.ClickButton(TextBoxSubmitButton, (int)Locator.XPath);
            return true;
        }

        public async Task<bool> ClickCheckBoxHomeAsync()
        {
            await CheckCheckBoxHomeIsEnable();
            CheckBoxHelper.CheckedCheckBox(CheckBoxHome, (int)Locator.XPath);
            return true;
        }
        public async Task<bool> ClickCheckBoxDesktopAsync()
        {
            await CheckCheckBoxDesktopIsEnable();
            CheckBoxHelper.CheckedCheckBox(CheckBoxDesktop, (int)Locator.XPath);
            return true;
        }
        public async Task<bool> CheckCheckBoxHomeHalfAsync()
        {
            await CheckCheckBoxHomeIsEnable();
            CheckBoxHelper.IsCheckBoxIntermediate(CheckBoxHome, (int)Locator.XPath);
            return true;
        }
        public async Task<bool> ClickExpandCheckBoxHomeButtonAsync()
        {
            await CheckExpandCheckBoxHomeButtonIsEnable();
            ButtonHelper.ClickButton(ExpandCheckBoxHomeButton, (int)Locator.XPath);
            return true;
        }
        public async Task<bool> ClickExpandCheckBoxDesktopButtonAsync()
        {
            await CheckExpandCheckBoxDesktopButtonIsEnable();
            ButtonHelper.ClickButton(ExpandCheckBoxDesktopButton, (int)Locator.XPath);
            return true;
        }
        public async Task<bool> ClickExpandCheckBoxDocumentButtonAsync()
        {
            await CheckExpandCheckBoxDocumentButtonIsEnable();
            ButtonHelper.ClickButton(ExpandCheckBoxDocumentButton, (int)Locator.XPath);
            return true;
        }
        public async Task<bool> ClickExpandCheckBoxDownloadsButtonAsync()
        {
            await CheckExpandCheckBoxDownloadsButtonIsEnable();
            ButtonHelper.ClickButton(ExpandCheckBoxDownloadsButton, (int)Locator.XPath);
            return true;
        }
        public async Task<string> GetTextFromCheckBoxResultReturnAsync()
        {
            await CheckCheckBoxResultReturnIsEnable();
            var text = TextHelper.GetTextInside(CheckBoxResultReturn, (int)Locator.CssSelector);
            return text;
        }
        public async Task<string> GetTextFromUserNameReturnAsync()
        {
            await CheckUserNameReturnIsEnable();
            var text = TextHelper.GetTextInside(UserNameReturn, (int)Locator.XPath);
            return text;
        }
        public async Task<string> GetTextFromUserMailReturnAsync()
        {
            await CheckUserMailReturnIsEnable();
            var text = TextHelper.GetTextInside(UserMailReturn, (int)Locator.XPath);
            return text;
        }
        public async Task<string> GetTextFromUserCurrentAdressReturnAsync()
        {
            await CheckUserCurrentAdressReturnIsEnable();
            var text = TextHelper.GetTextInside(UserCurrentAdressReturn, (int)Locator.XPath);
            return text;
        }
        public async Task<string> GetTextFromUserPermanentAdressReturnAsync()
        {
            await CheckUserPermanentAdressReturnIsEnable();
            var text = TextHelper.GetTextInside(UserPermanentAdressReturn, (int)Locator.XPath);
            return text;
        }

        public async Task<string> GetWebTableTDAsync()
        {
            await CheckWebTableLinkIsEnable();
            var text = TextHelper.GetTextInside(WebTablesLink, (int)Locator.XPath);
            return text;
        }
        public async Task<string> GetWebTableTRAsync()
        {
            await CheckWebTableLinkIsEnable();
            var text = TextHelper.GetTextInside(UserPermanentAdressReturn, (int)Locator.XPath);
            return text;
        }

        #endregion

        #region Navigation

        public async Task<bool> NaviGateToTextBoxComponent()
        {
            await CheckTextBoxLinkIsEnable();
            ButtonHelper.ClickButton(TextBoxLink, (int)Locator.XPath);
            return true;
        }
        public async Task<bool> NaviGateToCheckBoxComponent()
        {
            await CheckCheckBoxLinkIsEnable();
            ButtonHelper.ClickButton(CheckBoxLink, (int)Locator.XPath);
            return true;
        }
        public async Task<bool> NaviGateToWebTableComponent()
        {
            await CheckWebTableLinkIsEnable();
            ButtonHelper.ClickButton(WebTablesLink, (int)Locator.XPath);
            return true;
        }

        #endregion
    }
}
