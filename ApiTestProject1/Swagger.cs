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
        private Helper helper;

        public Swagger()
        {
            helper = new Helper();
        }
        public Pets GetPets()
        {
            var client = helper.SetUrl("v2/pet/1230");
            var request = helper.CreateGetRequest();
            request.RequestFormat = DataFormat.Json;
            var response = helper.GetResponse(client, request);
            var pets = helper.GetContent<Pets>(response);
            return pets;

        }
        public RestResponse DeletingStore()
        {
            var client = helper.SetUrl("v2/store/order/5");
            var request = helper.CreateDeleteRequest();
            request.RequestFormat = DataFormat.Json;
            var response = helper.GetResponse(client, request);
            
            return response;

        }


        public CreateUserItems GetUserItems()
        {
            var client = helper.SetUrl("v2/user/JohnTony51");
            var request = helper.CreateGetRequest();
            request.RequestFormat = DataFormat.Json;
            var response = helper.GetResponse(client, request);
            var pets = helper.GetContent< CreateUserItems>(response);
            return pets;
        }

        public RestResponse CreateUser(CreateUserItems[] arr,String endPoint)
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
