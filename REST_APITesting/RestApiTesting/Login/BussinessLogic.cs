using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace RestApiTesting.Login
{
    class BussinessLogic
    {
        public IRestClient client;
        public IRestRequest PostRequest;
        public IRestResponse Postresponse;
        public IRestResponse GetResponse;
        public IRestRequest GetRequest;

        public bool call()
        {
            client = new RestClient("https://reqres.in/api/ ");
            return true;
        }
        public IRestRequest Response()
        {
            PostRequest = new RestRequest("register", Method.POST);
            return PostRequest;
        }
        public bool Register(string username, string pass)
        {
            PostRequest.RequestFormat = DataFormat.Json;
            PostRequest.AddParameter("email", username);
            PostRequest.AddParameter("password", pass);
            return true;
        }

        public bool check()
        {

            Postresponse = client.Execute(PostRequest);
            
            if ((int)Postresponse.StatusCode == 200)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool userList()
        {

            GetResponse = client.Execute(GetRequest);
            var obj = JObject.Parse(GetResponse.Content);
            var list = obj.SelectToken("data");
            if (list != null)
            {
                return true;
            }

            else
            {
                return false;

            }

        }

        public IRestRequest Rest()
        {

            GetRequest = new RestRequest("users", Method.GET);
            return GetRequest;
        }

      

    }
}
