using Microsoft.VisualStudio.TestTools.UnitTesting;
using Re_Framework.CoreBase;
using Re_Framework.CoreBase.Helper.Json;
using Re_Framework.CoreBase.Models;
using Re_Framework.CoreBase.Settings;
using System.Threading.Tasks;

namespace Re_Framework.TestSuites.ApisTestCase
{
    [TestClass]
    public class BookStoreTests
    {
        [TestMethod("Get books and verify it")]
        [TestCategory("ApiBook tests")]
        public async Task AccountTests1()
        {
            var baseApi = new BaseApi();
            var response = await baseApi.GetBooks(ObjectRepository.Config.GetWebsite());

            var code = (int)response.StatusCode;
            var status = (string)response.StatusDescription;

            var returnData = HandleContent.GetContent<BooksReq>(response);
            var firstBooksAuthor = returnData.Books[0].Author.ToString();
            var firstBookDesc = returnData.Books[0].Description.ToString();
            var secondBooksAuthor = returnData.Books[1].Author.ToString();
            //Check book 1
            Assert.AreEqual("Richard E. Silverman", firstBooksAuthor);
            Assert.AreEqual("This pocket guide is the perfect on-the-job companion to Git, the distributed version control system. It provides a compact, readable introduction to Git for new users, as well as a reference to common commands and procedures for those of you with Git exp", firstBookDesc);
            Assert.AreEqual("Addy Osmani", secondBooksAuthor);

            Assert.AreEqual(200, code);
            Assert.AreEqual("OK", status);
        }
    }
}
