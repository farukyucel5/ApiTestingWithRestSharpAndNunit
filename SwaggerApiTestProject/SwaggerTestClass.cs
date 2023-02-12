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
        String PostEndPoint = "v2/user/createWithArray";
        


        [Test,Order(1)]public void MakePostRequest()
        {
            var dto1 = new UserItems
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

             UserItems[] arr = new UserItems[] { dto1 };

             RestResponse response =swagger.CreateUser(arr,PostEndPoint);
           
             Assert.That(response.StatusCode == HttpStatusCode.OK, Is.True);
             Assert.That((int)response.StatusCode==200, Is.True);

        }

        [Test,Order(2)] public void MakeGetRequest() {
            String GetEndPoint = "v2/user/farukyucel5";
            var ExpectedBody = new UserItems
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

            UserItems response=swagger.GetUserItems(GetEndPoint);

            Assert.That(ExpectedBody.id, Is.EqualTo(response.id));
            Assert.That(ExpectedBody.username, Is.EqualTo(response.username));
            Assert.That(ExpectedBody.firstName, Is.EqualTo(response.firstName));
            Assert.That(ExpectedBody.lastName, Is.EqualTo(response.lastName));
            Assert.That(ExpectedBody.email, Is.EqualTo(response.email));
            Assert.That(ExpectedBody.password, Is.EqualTo(response.password));
            Assert.That(ExpectedBody.phone, Is.EqualTo(response.phone));
            Assert.That(ExpectedBody.userStatus, Is.EqualTo(response.userStatus));
        }

        [Test, Order(3)]
        public void MakeDeleteRequest()
        {
            String EndPoint = "v2/user/farukyucel5";
            

            RestResponse response = swagger.DeletingUser(EndPoint);

            Assert.That(response.StatusCode==HttpStatusCode.OK,Is.True);
            
        }




        [Test,Order(4)]public void MakeNegativePostRequest()
        {
            //we should not have been able to make a post request with an username with an integer value
            //but we were able to carry out the request
            var dto1 = new NegativeUserItems
            {
                id = 159,
                username = 23,
                firstName = "harun",
                lastName = "yucel",
                email = "H@gmail.com",
                password = "Htest123f",
                phone = "1234523456123",
                userStatus = 1

            };

            NegativeUserItems[] arr = new NegativeUserItems[] { dto1 };

            RestResponse response = swagger.NegativeCreateUser(arr, PostEndPoint);
            //Console.WriteLine(response.Content);    
            Assert.That(response.StatusCode == HttpStatusCode.OK, Is.True);
            //Console.WriteLine((int)response.StatusCode);
            //Console.WriteLine(response.StatusCode);
            Assert.That((int)response.StatusCode == 200, Is.False);

        }
    }
    }



