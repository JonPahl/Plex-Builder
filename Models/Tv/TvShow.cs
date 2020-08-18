using System;
using System.Xml.Serialization;
using System.ComponentModel;

namespace PlexBuilder.Models.Tv
{
    public static class TvShow
    {
        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.        
        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        [XmlRoot(Namespace = "", IsNullable = false)]
        public class MediaContainer
        {
            [XmlElement("Directory")]
            public MediaContainerDirectory[] Directory { get; set; }

            [XmlAttribute]
            public UInt64 size { get; set; }

            [XmlAttribute]
            public Int64 totalSize { get; set; }

            [XmlAttribute]
            public UInt64 allowSync { get; set; }

            [XmlAttribute]
            public string art { get; set; }

            [XmlAttribute]
            public string identifier { get; set; }

            [XmlAttribute]
            public UInt64 librarySectionID { get; set; }

            [XmlAttribute]
            public string librarySectionTitle { get; set; }

            [XmlAttribute]
            public string librarySectionUUID { get; set; }

            [XmlAttribute]
            public string mediaTagPrefix { get; set; }

            [XmlAttribute]
            public UInt64 mediaTagVersion { get; set; }

            [XmlAttribute]
            public byte nocache { get; set; }

            [XmlAttribute]
            public byte offset { get; set; }

            [XmlAttribute]
            public string thumb { get; set; }

            [XmlAttribute]
            public string title1 { get; set; }

            [XmlAttribute]
            public string title2 { get; set; }

            [XmlAttribute]
            public string viewGroup { get; set; }

            [XmlAttribute]
            public UInt64 viewMode { get; set; }
        }

        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public class MediaContainerDirectory
        {
            [XmlElement("Genre")]
            public MediaContainerDirectoryGenre[] Genre { get; set; }

            [XmlElement("Role")]
            public MediaContainerDirectoryRole[] Role { get; set; }

            [XmlAttribute]
            public ushort ratingKey { get; set; }

            [XmlAttribute]
            public string key { get; set; }

            [XmlAttribute]
            public string guid { get; set; }

            [XmlAttribute]
            public string studio { get; set; }

            [XmlAttribute]
            public string type { get; set; }

            [XmlAttribute]
            public string title { get; set; }

            [XmlAttribute]
            public string contentRating { get; set; }

            [XmlAttribute]
            public string summary { get; set; }

            [XmlAttribute]
            public int index { get; set; }

            [XmlAttribute]
            public decimal rating { get; set; }

            [XmlAttribute]
            public int year { get; set; }

            [XmlAttribute]
            public string thumb { get; set; }

            [XmlAttribute]
            public string art { get; set; }

            [XmlAttribute]
            public string banner { get; set; }

            [XmlAttribute]
            public string theme { get; set; }

            [XmlAttribute]
            public UInt64 duration { get; set; }

            [XmlAttribute(DataType = "date")]
            public DateTime originallyAvailableAt { get; set; }

            [XmlAttribute]
            public UInt64 leafCount { get; set; }

            [XmlAttribute]
            public UInt64 viewedLeafCount { get; set; }

            [XmlAttribute]
            public UInt64 childCount { get; set; }

            [XmlAttribute]
            public UInt64 addedAt { get; set; }

            [XmlAttribute]
            public UInt64 updatedAt { get; set; }

            [XmlAttribute]
            public UInt64 viewCount { get; set; }

            [XmlIgnore]
            public bool viewCountSpecified { get; set; }

            [XmlAttribute]
            public UInt64 lastViewedAt { get; set; }

            [XmlIgnore]
            public bool lastViewedAtSpecified { get; set; }

            [XmlAttribute]
            public string titleSort { get; set; }
        }

        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public partial class MediaContainerDirectoryGenre
        {
            [XmlAttribute]
            public string tag { get; set; }
        }

        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public partial class MediaContainerDirectoryRole
        {
            [XmlAttribute]
            public string tag { get; set; }
        }
    }
}
