using ApiTestProject1;
using ApiTestProject1.Model;
using NUnit.Framework;
using RestSharp;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Text.Unicode;

namespace SwaggerApiTestProject
{
    public class SwaggerTestClass
    {
        Swagger swagger=new Swagger();
        String endPoint = "v2/user/createWithArray";


        [Test]
        public void MakePostRequest()
        {
            var dto1 = new CreateUserItems
            {
                id = 59,
                username = "farukyucel5",
                firstName = "faruk",
                lastName = "yucel",
                email = "f@gmail.com",
                password = "ftest123f",
                phone = "1234523456",
                userStatus = 1

            };

             CreateUserItems[] arr = new CreateUserItems[] { dto1 };

             RestResponse response =swagger.CreateUser(arr,endPoint);
             //Console.WriteLine(response.Content);    
             Assert.That(response.StatusCode == HttpStatusCode.OK, Is.True);
            //Console.WriteLine((int)response.StatusCode);
            //Console.WriteLine(response.StatusCode);
            Assert.That((int)response.StatusCode==200, Is.True);

        }
    }
    }



