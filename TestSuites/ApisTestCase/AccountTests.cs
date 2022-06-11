using Microsoft.VisualStudio.TestTools.UnitTesting;
using Re_Framework.CoreBase;
using Re_Framework.CoreBase.Helper.Common;
using Re_Framework.CoreBase.Helper.Json;
using Re_Framework.CoreBase.Models;
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
            var response = await baseApi.CreateAccWithApi(ObjectRepository.Config.GetWebsite(), payload);

            var code = (int)response.StatusCode;
            var status = (string)response.StatusDescription;

            Assert.AreEqual(201, code);
            Assert.AreEqual("Created", status);
        }
    }
}
