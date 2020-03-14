using PlexBuilder.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PlexBuilder.Concrete
{
    public class PlexLogin
    {
        private string username { get; set; }
        private string pwd { get; set; }
        private Uri LoginUrl { get; }

        public PlexLogin(string username, string pwd)
        {
            LoginUrl = new Uri("https://plex.tv/users/sign_in.xml");

            this.username = username;
            this.pwd = pwd;
        }


        public async Task<string> Login()
        {
            using (HttpMessageHandler handler = new HttpClientHandler())
            {
                using (var httpClient = new HttpClient(handler) { BaseAddress = LoginUrl, Timeout = new TimeSpan(0, 2, 0) })
                {
                    httpClient.DefaultRequestHeaders.Add("ContentType", "application/json");
                    var plainTextBytes = Encoding.UTF8.GetBytes($"{username}:{pwd}");
                    string val = Convert.ToBase64String(plainTextBytes);

                    httpClient.DefaultRequestHeaders.Add("Authorization", $"Basic {val}");
                    httpClient.DefaultRequestHeaders.Add("X-Plex-Client-Identifier", "TESTSCRIPTV1");
                    httpClient.DefaultRequestHeaders.Add("X-Plex-Product", "Test script");
                    httpClient.DefaultRequestHeaders.Add("X-Plex-Version", "V1");

                    var values = new Dictionary<string, string>();
                    var content = new FormUrlEncodedContent(values);
                                       
                    var response = await httpClient.PostAsync(LoginUrl, content).ConfigureAwait(true);
                    
                    var responseString = await response.Content.ReadAsStringAsync().ConfigureAwait(true);
                    var loginResult = ProcessResults(responseString);
                                        
                    return loginResult.authToken;
                }
            }
        }


        private LoginResult.user ProcessResults(string xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(LoginResult.user));
            using (StringReader rdr = new StringReader(xml))
            {
                LoginResult.user resultingMessage = (LoginResult.user)serializer.Deserialize(rdr);
                return resultingMessage;
            }            
        }



    }
}
