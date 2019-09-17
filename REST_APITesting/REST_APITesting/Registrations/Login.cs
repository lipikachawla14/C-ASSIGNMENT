using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace REST_APITesting.Registration
{
    class Login
    {
        public static IRestClient client;
        public IRestRequest request;
        public IRestResponse response;
        public IRestResponse GetResponse;
        public IRestRequest GetRequest;

        public bool call()
        {
            client = new RestClient("https://reqres.in/ ");
            return true;
        }
        public  bool Register(string username , string pass)
           {
            request = new RestRequest("register", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddParameter("email","username");
            request.AddParameter("password", "pass");
            return true;
          }

        public bool check()
        {
            
            response = client.Execute(request);
            if ((int)response.StatusCode == 200)
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
            String response = GetResponse.Content;
            if (response != " ")
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
    

    
