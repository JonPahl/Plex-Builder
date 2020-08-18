using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace PlexBuilder.Models
{
    public static class LoginResult
    {
        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        [XmlRoot(Namespace = "", IsNullable = false)]
        public class user
        {
            public userSubscription subscription { get; set; }
            public userEntitlements entitlements { get; set; }
            public userProfile_settings profile_settings { get; set; }
            public userProviders providers { get; set; }

            [XmlArrayItem("service", IsNullable = false)]
            public userService[] services { get; set; }

            public string username { get; set; }

            public string email { get; set; }

            [XmlElement("joined-at")]
            public userJoinedat joinedat { get; set; }

            [XmlElement("authentication-token")]
            public string authenticationtoken { get; set; }

            [XmlAttribute("email")]
            public string email1 { get; set; }

            [XmlAttribute]
            public uint id { get; set; }

            [XmlAttribute]
            public string uuid { get; set; }

            [XmlAttribute]
            public string mailing_list_status { get; set; }

            [XmlAttribute]
            public string thumb { get; set; }

            [XmlAttribute("username")]
            public string username1 { get; set; }

            [XmlAttribute]
            public string title { get; set; }

            [XmlAttribute]
            public string cloudSyncDevice { get; set; }

            [XmlAttribute]
            public string locale { get; set; }

            [XmlAttribute]
            public string authenticationToken { get; set; }

            [XmlAttribute]
            public string authToken { get; set; }

            [XmlAttribute]
            public string scrobbleTypes { get; set; }

            [XmlAttribute]
            public byte restricted { get; set; }

            [XmlAttribute]
            public byte home { get; set; }

            [XmlAttribute]
            public byte guest { get; set; }

            [XmlAttribute]
            public string queueEmail { get; set; }

            [XmlAttribute]
            public string queueUid { get; set; }

            [XmlAttribute]
            public bool hasPassword { get; set; }

            [XmlAttribute]
            public byte homeSize { get; set; }

            [XmlAttribute]
            public byte maxHomeSize { get; set; }

            [XmlAttribute]
            public bool rememberMe { get; set; }

            [XmlAttribute]
            public byte secure { get; set; }

            [XmlAttribute]
            public byte certificateVersion { get; set; }
        }

        [Serializable]
        [System.ComponentModel.DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public partial class userSubscription
        {
            [XmlElement("feature")]
            public userSubscriptionFeature[] feature { get; set; }

            [XmlAttribute]
            public byte active { get; set; }

            [XmlAttribute]
            public string status { get; set; }

            [XmlAttribute]
            public string plan { get; set; }
        }

        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public class userSubscriptionFeature
        {
            [XmlAttribute]
            public string id { get; set; }
        }

        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public class userEntitlements
        {
            [XmlAttribute]
            public byte all { get; set; }
        }

        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public class userProfile_settings
        {
            [XmlAttribute]
            public string default_audio_language { get; set; }

            [XmlAttribute]
            public string default_subtitle_language { get; set; }

            [XmlAttribute]
            public byte auto_select_subtitle { get; set; }

            [XmlAttribute]
            public byte auto_select_audio { get; set; }

            [XmlAttribute]
            public byte default_subtitle_accessibility { get; set; }

            [XmlAttribute]
            public byte default_subtitle_forced { get; set; }
        }

        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public class userProviders
        {
            public userProvidersProvider provider { get; set; }
        }

        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public class userProvidersProvider
        {
            [XmlAttribute]
            public string id { get; set; }

            [XmlAttribute]
            public string uid { get; set; }

            [XmlAttribute]
            public string token { get; set; }
        }

        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public class userService
        {
            [XmlAttribute]
            public string identifier { get; set; }

            [XmlAttribute]
            public string endpoint { get; set; }

            [XmlAttribute]
            public string token { get; set; }

            [XmlAttribute]
            public string status { get; set; }

            [XmlAttribute]
            public string secret { get; set; }
        }

        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public class userJoinedat
        {
            [XmlAttribute]
            public string type { get; set; }

            [XmlText]
            public string Value { get; set; }
        }
    }
}
