using Microsoft.VisualStudio.TestTools.UnitTesting;
using Re_Framework.CoreBase.Helper.Common;
using Re_Framework.CoreBase.PageObjects;
using Re_Framework.CoreBase.Settings;
using System.Threading.Tasks;

namespace Re_Framework.TestSuites.ElementsTestCase
{
    [TestClass]
    public class CheckBoxTests
    {
        [TestMethod("Check all CheckBox will be enable when only Home checkbox was checked")]
        [TestCategory("CheckBox tests")]
        public async Task CheckBoxTests1()
        {
            //Go to Base Page
            BrowserHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());

            //Define Home Page
            HomePage homePage = new HomePage(ObjectRepository.Driver);

            //Go to Elements Page
            await homePage.NaviGateToElementsPage();

            //Define Elements Page
            ElementsPage elementsPage = new ElementsPage(ObjectRepository.Driver);

            //Go to CheckBox Sector
            await elementsPage.NaviGateToCheckBoxComponent();

            //Click to CheckBox
            await elementsPage.ClickCheckBoxHomeAsync();
            await elementsPage.ClickExpandCheckBoxHomeButtonAsync();
            await elementsPage.ClickExpandCheckBoxDesktopButtonAsync();
            await elementsPage.ClickExpandCheckBoxDocumentButtonAsync();
            await elementsPage.ClickExpandCheckBoxDownloadsButtonAsync();

            //Get Data after Click
            string result = await elementsPage.GetTextFromCheckBoxResultReturnAsync();

            //Assert Value after Click
            AssertHelper.ShouldContain("home", result);
            AssertHelper.ShouldContain("desktop", result);
            AssertHelper.ShouldContain("notes", result);
            AssertHelper.ShouldContain("commands", result);
            AssertHelper.ShouldContain("documents", result);
            AssertHelper.ShouldContain("workspace", result);
            AssertHelper.ShouldContain("react", result);
            AssertHelper.ShouldContain("angular", result);
            AssertHelper.ShouldContain("veu", result);
            AssertHelper.ShouldContain("office", result);
            AssertHelper.ShouldContain("public", result);
            AssertHelper.ShouldContain("private", result);
            AssertHelper.ShouldContain("classified", result);
            AssertHelper.ShouldContain("general", result);
            AssertHelper.ShouldContain("downloads", result);
            AssertHelper.ShouldContain("wordFile", result);
            AssertHelper.ShouldContain("excelFile", result);

            //Report.PassTest();
        }

        [TestMethod("Check Home CheckBox will be half-check when only One checkbox inside was checked")]
        [TestCategory("CheckBox tests")]
        public async Task CheckBoxTests2()
        {
            //Go to Base Page
            BrowserHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());

            //Define Home Page
            HomePage homePage = new HomePage(ObjectRepository.Driver);

            //Go to Elements Page
            await homePage.NaviGateToElementsPage();

            //Define Elements Page
            ElementsPage elementsPage = new ElementsPage(ObjectRepository.Driver);

            //Go to CheckBox Sector
            await elementsPage.NaviGateToCheckBoxComponent();

            //Click to CheckBox
            await elementsPage.ClickExpandCheckBoxHomeButtonAsync();
            await elementsPage.ClickCheckBoxDesktopAsync();

            //Check half-checked
            await elementsPage.CheckCheckBoxHomeHalfAsync();

            //Get Data after Click
            string result = await elementsPage.GetTextFromCheckBoxResultReturnAsync();

            //Assert Data
            AssertHelper.ShouldContain("desktop", result);
            AssertHelper.ShouldContain("notes", result);
            AssertHelper.ShouldContain("commands", result);
        }
    }
}
