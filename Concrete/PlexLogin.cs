using PlexBuilder.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace PlexBuilder.Concrete
{
    public sealed class PlexLogin
    {
        private string username { get; }
        private string pwd { get; }
        private Uri LoginUrl { get; }

        public PlexLogin(AppSettings appSettings )
        {
            LoginUrl = new Uri(appSettings.PlexLogin);
            username = appSettings.PlexName;
            pwd = appSettings.PlexPwd;
        }

        public async Task<string> Login()
        {
            LoginResult.user user;

            using HttpMessageHandler handler = new HttpClientHandler();
            using var httpClient = new HttpClient(handler)
            {
                BaseAddress = LoginUrl, Timeout = new TimeSpan(0, 2, 0)
            };

            httpClient.DefaultRequestHeaders.Add("ContentType", "application/json");
            var plainTextBytes = Encoding.UTF8.GetBytes($"{username}:{pwd}");
            string encodedValue = Convert.ToBase64String(plainTextBytes);

            httpClient.DefaultRequestHeaders.Add("Authorization", $"Basic {encodedValue}");
            httpClient.DefaultRequestHeaders.Add("X-Plex-Client-Identifier", "TESTSCRIPTV1");
            httpClient.DefaultRequestHeaders.Add("X-Plex-Product", "Test script");
            httpClient.DefaultRequestHeaders.Add("X-Plex-Version", "V1");

            using (var content = new FormUrlEncodedContent(new Dictionary<string, string>()))
            {
                var response = await httpClient.PostAsync(LoginUrl, content).ConfigureAwait(true);
                var responseString = await response.Content.ReadAsStringAsync().ConfigureAwait(true);
                user = ProcessResults(responseString);
            }
            return user.authToken;
        }

        private static LoginResult.user ProcessResults(string xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(LoginResult.user));
            using StringReader rdr = new StringReader(xml);
            using XmlReader xmlReader = XmlReader.Create(rdr);
            return (LoginResult.user)serializer.Deserialize(xmlReader);
        }
    }
}
