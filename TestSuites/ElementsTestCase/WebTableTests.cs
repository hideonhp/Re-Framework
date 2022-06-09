using Microsoft.VisualStudio.TestTools.UnitTesting;
using Re_Framework.CoreBase.Helper.Common;
using Re_Framework.CoreBase.Helper.Json;
using Re_Framework.CoreBase.PageObjects;
using Re_Framework.CoreBase.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re_Framework.TestSuites.ElementsTestCase
{
    [TestClass]
    public class WebTableTests
    {
        [TestMethod("Check Webtable submitable")]
        [TestCategory("WebTable tests")]
        public async Task WebTableTests1()
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
            await elementsPage.NaviGateToWebTableComponent();

            //
        }
    }
}
