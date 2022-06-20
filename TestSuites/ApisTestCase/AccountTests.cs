using Microsoft.VisualStudio.TestTools.UnitTesting;
using Re_Framework.CoreBase;
using Re_Framework.CoreBase.Helper.Common;
using Re_Framework.CoreBase.Helper.Json;
using Re_Framework.CoreBase.Models;
using Re_Framework.CoreBase.PageObjects;
using Re_Framework.CoreBase.Settings;
using System.Net;
using System.Threading.Tasks;

namespace Re_Framework.TestSuites.ApisTestCase
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod("Create user and verify it")]
        [TestCategory("ApiAccount tests")]
        public async Task AccountTests1()
        {
            //Get data
            var payload = HandleContent.ParseJson<UserReq>(await FileHelper.GetFilePath("TestQaAccountUser.json"));
            var baseApi = new BaseApi();

            var responseCreAcc = await baseApi.CreateAccWithApi(ObjectRepository.Config.GetWebsite(), payload);
            var returnCreAcc = HandleContent.GetContent<UserDetailReq>(responseCreAcc);
            var userIdCreAcc = (string)returnCreAcc.UserId;

            Assert.AreEqual(201, (int)responseCreAcc.StatusCode);
            Assert.AreEqual("Created", (string)responseCreAcc.StatusDescription);

            //Get token
            var responseToken = await baseApi.GetTokenFromAccWithApi(ObjectRepository.Config.GetWebsite(), payload);
            var returnToken = HandleContent.GetContent<TokenReq>(responseToken);
            var tokenData = (string)returnToken.Token;

            Assert.AreEqual(200, (int)responseToken.StatusCode);
            Assert.AreEqual("Success", (string)returnToken.Status);

            //Get authen
            BrowserHelper.NavigateToUrl(ObjectRepository.Config.GetWebsiteAPI());

            BasePageAPI bpa = new BasePageAPI(ObjectRepository.Driver);
            await bpa.OpenAuthenModal(tokenData);

            //Get authorized
            var responseAutho = await baseApi.GetAuthoFromAccWithApi(ObjectRepository.Config.GetWebsite(), payload);

            Assert.AreEqual(200, (int)responseAutho.StatusCode);
            Assert.AreEqual("OK", (string)responseAutho.StatusDescription);

            //Delete account
            var responseDel = await baseApi.DelAccWithApi(ObjectRepository.Config.GetWebsite(), userIdCreAcc);

            Assert.AreEqual(401, (int)responseDel.StatusCode);
            Assert.AreEqual("Unauthorized", (string)responseDel.StatusDescription);

        }
    }
}
