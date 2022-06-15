using Re_Framework.CoreBase.Helper.Common;
using Re_Framework.CoreBase.Helper.Json;
using Re_Framework.CoreBase.Models;
using RestSharp;
using System.Threading.Tasks;

namespace Re_Framework.CoreBase
{
    public class BaseApi
    {
        private ApiHelper apiHelper;

        public BaseApi()
        {
            apiHelper = new ApiHelper();
        }
        public async Task<RestResponse> GetBooks(string baseUrl, bool requiredCertificate = false)
        {
            if (requiredCertificate)
            {
                apiHelper.AddCertificate("", "");
            }

            var client = apiHelper.SetUrl(baseUrl, "BookStore/v1/Books");
            var request = apiHelper.CreateGetRequest();
            request.RequestFormat = DataFormat.Json;
            var response = await apiHelper.GetResponseAsync(client, request);
            return response;
        }

        public async Task<RestResponse> CreateAccWithApi(string baseUrl, dynamic payload)
        {
            var client = apiHelper.SetUrl(baseUrl, "Account/v1/User");
            //var jsonString = HandleContent.SerializeJsonString(payload);
            var request = apiHelper.CreatePostRequest<UserReq>(payload);
            var response = await apiHelper.GetResponseAsync(client, request);
            return response;
        }

        public async Task<RestResponse> GetTokenFromAccWithApi(string baseUrl, dynamic payload)
        {
            var client = apiHelper.SetUrl(baseUrl, "Account/v1/GenerateToken", true);
            var request = apiHelper.CreatePostRequest<UserReq>(payload);
            var response = await apiHelper.GetResponseAsync(client, request);
            return response;
        }
        public async Task<RestResponse> GetAuthoFromAccWithApi(string baseUrl, dynamic payload)
        {
            var client = apiHelper.SetUrl(baseUrl, "Account/v1/Authorized", true);
            var request = apiHelper.CreatePostRequest<UserReq>(payload);
            var response = await apiHelper.GetResponseAsync(client, request);
            return response;
        }
        public async Task<RestResponse> DelAccWithApi(string baseUrl, dynamic id)
        {
            var client = apiHelper.SetUrl(baseUrl, "Account/v1/User/" + id, true);
            var request = apiHelper.CreateDeleteRequest();
            var response = await apiHelper.GetResponseAsync(client, request);
            return response;
        }
    }
}
