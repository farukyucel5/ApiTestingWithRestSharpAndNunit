using ApiTestProject1.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTestProject1
{
    public class Swagger
    {
        private  Helper helper = new();

        public RestResponse DeletingUser(String Endpoint)
        {
            var client = helper.SetUrl(Endpoint);
            var request = helper.CreateDeleteRequest();
            request.RequestFormat = DataFormat.Json;
            var response = helper.GetResponse(client, request);
            
            return response;

        }


        public UserItems GetUserItems(String endPoint)
        {
            var client = helper.SetUrl(endPoint);
            var request = helper.CreateGetRequest();
            request.RequestFormat = DataFormat.Json;
            var response = helper.GetResponse(client, request);
            var users = helper.GetContent< UserItems>(response);
            return users;
        }

        public RestResponse CreateUser(UserItems[] arr,String endPoint)
        {
            var client = helper.SetUrl(endPoint);
            var request = helper.CreatePostRequest();
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(arr);
            var response = helper.GetResponse(client, request);
            return response;
         }

        public RestResponse NegativeCreateUser(NegativeUserItems[] arr, String endPoint)
        {
            var client = helper.SetUrl(endPoint);
            var request = helper.CreatePostRequest();
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(arr);
            var response = helper.GetResponse(client, request);
            return response;
        }
    }
}
