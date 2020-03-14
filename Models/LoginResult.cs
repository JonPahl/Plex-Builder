using System;

namespace PlexBuilder.Models
{
    public class LoginResult
    {

        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
        public partial class user
        {
            private byte certificateVersionField;

            /// <remarks/>
            public userSubscription subscription { get; set; }

            /// <remarks/>
            public userEntitlements entitlements { get; set; }

            /// <remarks/>
            public userProfile_settings profile_settings { get; set; }

            /// <remarks/>
            public userProviders providers { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItem("service", IsNullable = false)]
            public userService[] services { get; set; }

            /// <remarks/>
            public string username { get; set; }

            /// <remarks/>
            public string email { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("joined-at")]
            public userJoinedat joinedat { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("authentication-token")]
            public string authenticationtoken { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute("email")]
            public string email1 { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public uint id { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string uuid { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string mailing_list_status { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string thumb { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute("username")]
            public string username1 { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string title { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string cloudSyncDevice { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string locale { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string authenticationToken { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string authToken { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string scrobbleTypes { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public byte restricted { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public byte home { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public byte guest { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string queueEmail { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string queueUid { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public bool hasPassword { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public byte homeSize { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public byte maxHomeSize { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public bool rememberMe { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public byte secure { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public byte certificateVersion
            {
                get => certificateVersionField;
                set => certificateVersionField = value;
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public partial class userSubscription
        {

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("feature")]
            public userSubscriptionFeature[] feature { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public byte active { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string status { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string plan { get; set; }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public partial class userSubscriptionFeature
        {

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string id { get; set; }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public partial class userEntitlements
        {

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public byte all { get; set; }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public partial class userProfile_settings
        {

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string default_audio_language { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string default_subtitle_language { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public byte auto_select_subtitle { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public byte auto_select_audio { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public byte default_subtitle_accessibility { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public byte default_subtitle_forced { get; set; }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public partial class userProviders
        {

            /// <remarks/>
            public userProvidersProvider provider { get; set; }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public partial class userProvidersProvider
        {

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string id { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string uid { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string token { get; set; }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public partial class userService
        {

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string identifier { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string endpoint { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string token { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string status { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string secret { get; set; }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public partial class userJoinedat
        {

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string type { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlText()]
            public string Value { get; set; }
        }



    }
}
