

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Re_Framework.CoreBase.Helper.Common;
using Re_Framework.CoreBase.Helper.Json;
using Re_Framework.CoreBase.PageObjects;
using Re_Framework.CoreBase.Settings;
using System.Threading.Tasks;

namespace Re_Framework.TestSuites.ElementsTestCase
{
    [TestClass]
    public class TextBoxTests
    {
        [TestMethod("Check TextBox submitable")]
        [TestCategory("TextBox tests")]
        public async Task TextBoxTests1()
        {
            //Get data
            var payload = HandleContent.ParseJson<ObjectData>(await FileHelper.GetFilePath("TestQa.json"));

            //Go to Base Page
            BrowserHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());

            //Define Home Page
            HomePage homePage = new HomePage(ObjectRepository.Driver);

            //Go to Elements Page
            await homePage.NaviGateToElementsPage();

            //Define Elements Page
            ElementsPage elementsPage = new ElementsPage(ObjectRepository.Driver);

            //Go to TextBox Sector
            await elementsPage.NaviGateToTextBoxComponent();

            //Send key to TextBox
            await elementsPage.SendKeyToUserNameTextBoxBoxAsync(payload.name);
            await elementsPage.SendKeyToUserMailTextBoxAsync(payload.mail);
            await elementsPage.SendKeyToUserCurrentAdressTextBoxAsync(payload.currAdress);
            await elementsPage.SendKeyToUserPermanentAdressTextBoxAsync(payload.permAdress);

            //Click submit
            await elementsPage.ClickTextBoxSubmitButtonAsync();

            //Get data after submit
            string name = await elementsPage.GetTextFromUserNameReturnAsync();
            string mail = await elementsPage.GetTextFromUserMailReturnAsync();
            string currAdree = await elementsPage.GetTextFromUserCurrentAdressReturnAsync();
            string PermAdress = await elementsPage.GetTextFromUserPermanentAdressReturnAsync();

            //Assert Value after Submit
            AssertHelper.ShouldContain(payload.name.ToString(), name);
            AssertHelper.ShouldContain(payload.mail.ToString(), mail);
            AssertHelper.ShouldContain(payload.currAdress.ToString(), currAdree);
            AssertHelper.ShouldContain(payload.permAdress.ToString(), PermAdress);

            //Report.PassTest();
        }
    }
}
