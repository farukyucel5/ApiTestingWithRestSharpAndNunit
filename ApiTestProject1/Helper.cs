using Newtonsoft.Json;
using RestSharp;

namespace ApiTestProject1
{
    public class Helper
    {
        private RestClient client;
        private RestRequest request;
        private const String baseUrl = "https://petstore.swagger.io/";

        public RestClient SetUrl(String endpoint){
            var url = baseUrl + endpoint;
            client= new RestClient(url);
            return client;
        }
        public RestRequest CreatePostRequest()
        {
            request = new RestRequest("https://petstore.swagger.io/v2/user/createWithArray",Method.Post);
            request.AddHeader("accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            return request;

        }

        public RestRequest CreateGetRequest() {
            request = new RestRequest()
            {
                Method = Method.Get
            };
            request.AddHeader("Accept", "application/json");
            return request;

        }

        public RestRequest CreateDeleteRequest()
        {
            request = new RestRequest()
            {
                Method = Method.Delete
            };
            request.AddHeader("accept", "application/json");
            return request;

        }


        public RestResponse GetResponse(RestClient restClient,RestRequest restRequest)
        {
            return restClient.Execute(restRequest);
        }

        public T GetContent<T>(RestResponse response)
        {
            var content = response.Content;
            return JsonConvert.DeserializeObject<T>(content);
        }

    }
}
