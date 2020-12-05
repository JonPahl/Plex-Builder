using System;

namespace PlexBuilder.Models.Tv
{
    [Serializable]
    public static class Season
    {
        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <summary>
        /// Container from Plex.
        /// </summary>
        [Serializable]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
        public partial class MediaContainer
        {
            [System.Xml.Serialization.XmlElement("Directory")]
            public MediaContainerDirectory[] Directory { get; set; }

            [System.Xml.Serialization.XmlAttribute]
            public int size { get; set; }

            [System.Xml.Serialization.XmlAttribute]
            public int allowSync { get; set; }

            [System.Xml.Serialization.XmlAttribute]
            public string art { get; set; }

            [System.Xml.Serialization.XmlAttribute]
            public string banner { get; set; }

            [System.Xml.Serialization.XmlAttribute]
            public string identifier { get; set; }

            [System.Xml.Serialization.XmlAttribute]
            public int key { get; set; }

            [System.Xml.Serialization.XmlAttribute]
            public int librarySectionID { get; set; }

            [System.Xml.Serialization.XmlAttribute]
            public string librarySectionTitle { get; set; }

            [System.Xml.Serialization.XmlAttribute]
            public string librarySectionUUID { get; set; }

            [System.Xml.Serialization.XmlAttribute]
            public string mediaTagPrefix { get; set; }

            [System.Xml.Serialization.XmlAttribute]
            public int mediaTagVersion { get; set; }

            [System.Xml.Serialization.XmlAttribute]
            public int nocache { get; set; }

            [System.Xml.Serialization.XmlAttribute]
            public int parentIndex { get; set; }

            [System.Xml.Serialization.XmlAttribute]
            public string parentTitle { get; set; }

            [System.Xml.Serialization.XmlAttribute]
            public int parentYear { get; set; }

            [System.Xml.Serialization.XmlAttribute]
            public string summary { get; set; }

            [System.Xml.Serialization.XmlAttribute]
            public string theme { get; set; }

            [System.Xml.Serialization.XmlAttribute]
            public string thumb { get; set; }

            [System.Xml.Serialization.XmlAttribute]
            public string title1 { get; set; }

            [System.Xml.Serialization.XmlAttribute]
            public string title2 { get; set; }

            [System.Xml.Serialization.XmlAttribute]
            public string viewGroup { get; set; }

            [System.Xml.Serialization.XmlAttribute]
            public int viewMode { get; set; }
        }
    }

    [Serializable]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public partial class MediaContainerDirectory
    {
        [System.Xml.Serialization.XmlAttribute]
        public int leafCount { get; set; }

        [System.Xml.Serialization.XmlAttribute]
        public string thumb { get; set; }

        [System.Xml.Serialization.XmlAttribute]
        public int viewedLeafCount { get; set; }

        [System.Xml.Serialization.XmlAttribute]
        public string key { get; set; }

        [System.Xml.Serialization.XmlAttribute]
        public string title { get; set; }

        [System.Xml.Serialization.XmlAttribute]
        public int ratingKey { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public bool ratingKeySpecified { get; set; }

        [System.Xml.Serialization.XmlAttribute]
        public int parentRatingKey { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public bool parentRatingKeySpecified { get; set; }

        [System.Xml.Serialization.XmlAttribute]
        public string guid { get; set; }

        [System.Xml.Serialization.XmlAttribute]
        public string parentGuid { get; set; }

        [System.Xml.Serialization.XmlAttribute]
        public string type { get; set; }

        [System.Xml.Serialization.XmlAttribute]
        public string parentKey { get; set; }

        [System.Xml.Serialization.XmlAttribute]
        public string parentTitle { get; set; }

        [System.Xml.Serialization.XmlAttribute]
        public string summary { get; set; }

        [System.Xml.Serialization.XmlAttribute]
        public int index { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public bool indexSpecified { get; set; }

        [System.Xml.Serialization.XmlAttribute]
        public int parentIndex { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public bool parentIndexSpecified { get; set; }

        [System.Xml.Serialization.XmlAttribute]
        public string art { get; set; }

        [System.Xml.Serialization.XmlAttribute]
        public string parentThumb { get; set; }

        [System.Xml.Serialization.XmlAttribute]
        public string parentTheme { get; set; }

        [System.Xml.Serialization.XmlAttribute]
        public int addedAt { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public bool addedAtSpecified { get; set; }

        [System.Xml.Serialization.XmlAttribute]
        public uint updatedAt { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public bool updatedAtSpecified { get; set; }
    }
}