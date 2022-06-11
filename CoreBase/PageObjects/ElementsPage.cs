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

        protected string WebTableComponent = ".rt-table";

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

        #region Public Method
        public Task<bool> SendKeyToUserMailTextBoxAsync(string text)
        {
            TextBoxHelper.TypeInTextBoxAsync(UserMailTextBox, (int)Locator.CssSelector, text);
            return Task.FromResult(true);
        }
        public Task<bool> SendKeyToUserCurrentAdressTextBoxAsync(string text)
        {
            TextBoxHelper.TypeInTextBoxAsync(UserCurrentAdressTextBox, (int)Locator.CssSelector, text);
            return Task.FromResult(true);
        }
        public Task<bool> SendKeyToUserPermanentAdressTextBoxAsync(string text)
        {
            TextBoxHelper.TypeInTextBoxAsync(UserPermanentAdressTextBox, (int)Locator.CssSelector, text);
            return Task.FromResult(true);
        }
        public Task<bool> SendKeyToUserNameTextBoxBoxAsync(string text)
        {
            TextBoxHelper.TypeInTextBoxAsync(UserNameTextBox, (int)Locator.CssSelector, text);
            return Task.FromResult(true);
        }
        public Task<bool> ClickTextBoxSubmitButtonAsync()
        {
            ButtonHelper.ClickButton(TextBoxSubmitButton, (int)Locator.XPath);
            return Task.FromResult(true);
        }

        public Task<bool> ClickCheckBoxHomeAsync()
        {
            CheckBoxHelper.CheckedCheckBoxAsync(CheckBoxHome, (int)Locator.XPath);
            return Task.FromResult(true);
        }
        public Task<bool> ClickCheckBoxDesktopAsync()
        {
            CheckBoxHelper.CheckedCheckBoxAsync(CheckBoxDesktop, (int)Locator.XPath);
            return Task.FromResult(true);
        }
        public async Task<bool> CheckCheckBoxHomeHalfAsync()
        {
            await CheckBoxHelper.IsCheckBoxIntermediateAsync(CheckBoxHome, (int)Locator.XPath);
            return await Task.FromResult(true);
        }
        public Task<bool> ClickExpandCheckBoxHomeButtonAsync()
        {
            ButtonHelper.ClickButton(ExpandCheckBoxHomeButton, (int)Locator.XPath);
            return Task.FromResult(true);
        }
        public Task<bool> ClickExpandCheckBoxDesktopButtonAsync()
        {
            ButtonHelper.ClickButton(ExpandCheckBoxDesktopButton, (int)Locator.XPath);
            return Task.FromResult(true);
        }
        public Task<bool> ClickExpandCheckBoxDocumentButtonAsync()
        {
            ButtonHelper.ClickButton(ExpandCheckBoxDocumentButton, (int)Locator.XPath);
            return Task.FromResult(true);
        }
        public Task<bool> ClickExpandCheckBoxDownloadsButtonAsync()
        {
            ButtonHelper.ClickButton(ExpandCheckBoxDownloadsButton, (int)Locator.XPath);
            return Task.FromResult(true);
        }
        public Task<string> GetTextFromCheckBoxResultReturnAsync()
        {
            var text = TextHelper.GetTextInsideAsync(CheckBoxResultReturn, (int)Locator.CssSelector);
            return Task.FromResult(text.Result);
        }
        public Task<string> GetTextFromUserNameReturnAsync()
        {
            var text = TextHelper.GetTextInsideAsync(UserNameReturn, (int)Locator.XPath);
            return Task.FromResult(text.Result);
        }
        public Task<string> GetTextFromUserMailReturnAsync()
        {
            var text = TextHelper.GetTextInsideAsync(UserMailReturn, (int)Locator.XPath);
            return Task.FromResult(text.Result);
        }
        public Task<string> GetTextFromUserCurrentAdressReturnAsync()
        {
            var text = TextHelper.GetTextInsideAsync(UserCurrentAdressReturn, (int)Locator.XPath);
            return Task.FromResult(text.Result);
        }
        public Task<string> GetTextFromUserPermanentAdressReturnAsync()
        {
            var text = TextHelper.GetTextInsideAsync(UserPermanentAdressReturn, (int)Locator.XPath);
            return Task.FromResult(text.Result);
        }

        /*public Task<List<string>> GetWebTableTDAsync()
        {
            List<string> text = WebTableHelper.GetAllRowTDFromTableAsync(WebTableComponent, (int)Locator.CssSelector);
            return Task.FromResult(text);
        }
        public Task<List<string>> GetWebTableTRAsync()
        {
            List<string> text = WebTableHelper.GetAllRowTRFromTableAsync(WebTableComponent, (int)Locator.CssSelector);
            return Task.FromResult(text);
        }*/

        #endregion

        #region Navigation

        public Task<bool> NaviGateToTextBoxComponent()
        {
            ButtonHelper.ClickButton(TextBoxLink, (int)Locator.XPath);
            return Task.FromResult(true);
        }
        public Task<bool> NaviGateToCheckBoxComponent()
        {
            ButtonHelper.ClickButton(CheckBoxLink, (int)Locator.XPath);
            return Task.FromResult(true);
        }
        public Task<bool> NaviGateToWebTableComponent()
        {
            ButtonHelper.ClickButton(WebTablesLink, (int)Locator.XPath);
            return Task.FromResult(true);
        }

        #endregion
    }
}
