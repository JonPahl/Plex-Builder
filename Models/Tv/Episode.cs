using System;
using System.Xml.Serialization;
using System.ComponentModel;

namespace PlexBuilder.Models.Tv
{
    public static class Episode
    {
        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        [XmlRoot(Namespace = "", IsNullable = false)]
        public class MediaContainer
        {
            [XmlElement("Video")]
            public MediaContainerVideo[] Video { get; set; }

            [XmlAttribute]
            public int size { get; set; }

            [XmlAttribute]
            public int allowSync { get; set; }

            [XmlAttribute]
            public string art { get; set; }

            [XmlAttribute]
            public string banner { get; set; }

            [XmlAttribute]
            public string grandparentContentRating { get; set; }

            [XmlAttribute]
            public ushort grandparentRatingKey { get; set; }

            [XmlAttribute]
            public string grandparentStudio { get; set; }

            [XmlAttribute]
            public string grandparentTheme { get; set; }

            [XmlAttribute]
            public string grandparentThumb { get; set; }

            [XmlAttribute]
            public string grandparentTitle { get; set; }

            [XmlAttribute]
            public string identifier { get; set; }

            [XmlAttribute]
            public ushort key { get; set; }

            [XmlAttribute]
            public int librarySectionID { get; set; }

            [XmlAttribute]
            public string librarySectionTitle { get; set; }

            [XmlAttribute]
            public string librarySectionUUID { get; set; }

            [XmlAttribute]
            public string mediaTagPrefix { get; set; }

            [XmlAttribute]
            public int mediaTagVersion { get; set; }

            [XmlAttribute]
            public int nocache { get; set; }

            [XmlAttribute]
            public int parentIndex { get; set; }

            [XmlAttribute]
            public string parentTitle { get; set; }

            [XmlAttribute]
            public string theme { get; set; }

            [XmlAttribute]
            public string thumb { get; set; }

            [XmlAttribute]
            public string title1 { get; set; }

            [XmlAttribute]
            public string title2 { get; set; }

            [XmlAttribute]
            public string viewGroup { get; set; }

            [XmlAttribute]
            public int viewMode { get; set; }
        }

        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public class MediaContainerVideo
        {
            public MediaContainerVideoMedia Media { get; set; }

            public MediaContainerVideoDirector Director { get; set; }

            [XmlElement("Writer")]
            public MediaContainerVideoWriter[] Writer { get; set; }

            [XmlAttribute]
            public ushort ratingKey { get; set; }

            [XmlAttribute]
            public string key { get; set; }

            [XmlAttribute]
            public ushort parentRatingKey { get; set; }

            [XmlAttribute]
            public ushort grandparentRatingKey { get; set; }

            [XmlAttribute]
            public string guid { get; set; }

            [XmlAttribute]
            public string parentGuid { get; set; }

            [XmlAttribute]
            public string grandparentGuid { get; set; }

            [XmlAttribute]
            public string type { get; set; }

            [XmlAttribute]
            public string title { get; set; }

            [XmlAttribute]
            public string grandparentKey { get; set; }

            [XmlAttribute]
            public string parentKey { get; set; }

            [XmlAttribute]
            public string grandparentTitle { get; set; }

            [XmlAttribute]
            public string parentTitle { get; set; }

            [XmlAttribute]
            public string contentRating { get; set; }

            [XmlAttribute]
            public string summary { get; set; }

            [XmlAttribute]
            public int index { get; set; }

            [XmlAttribute]
            public int parentIndex { get; set; }

            [XmlAttribute]
            public decimal rating { get; set; }

            [XmlAttribute]
            public ushort year { get; set; }

            [XmlAttribute]
            public string thumb { get; set; }

            [XmlAttribute]
            public string art { get; set; }

            [XmlAttribute]
            public string parentThumb { get; set; }

            [XmlAttribute]
            public string grandparentThumb { get; set; }

            [XmlAttribute]
            public string grandparentArt { get; set; }

            [XmlAttribute]
            public string grandparentTheme { get; set; }

            [XmlAttribute]
            public UInt64 duration { get; set; }

            [XmlAttribute(DataType = "date")]
            public DateTime originallyAvailableAt { get; set; }

            [XmlAttribute]
            public int addedAt { get; set; }

            [XmlAttribute]
            public int updatedAt { get; set; }

            [XmlAttribute]
            public string titleSort { get; set; }
        }

        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public class MediaContainerVideoMedia
        {
            public MediaContainerVideoMediaPart Part { get; set; }

            [XmlAttribute]
            public ushort id { get; set; }

            [XmlAttribute]
            public UInt64 duration { get; set; }

            [XmlAttribute]
            public ushort bitrate { get; set; }

            [XmlAttribute]
            public ushort width { get; set; }

            [XmlAttribute]
            public ushort height { get; set; }

            [XmlAttribute]
            public decimal aspectRatio { get; set; }

            [XmlAttribute]
            public int audioChannels { get; set; }

            [XmlAttribute]
            public string audioCodec { get; set; }

            [XmlAttribute]
            public string videoCodec { get; set; }

            [XmlAttribute]
            public string videoResolution { get; set; }

            [XmlAttribute]
            public string container { get; set; }

            [XmlAttribute]
            public string videoFrameRate { get; set; }

            [XmlAttribute]
            public string videoProfile { get; set; }
        }

        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public class MediaContainerVideoMediaPart
        {
            [XmlAttribute]
            public ushort id { get; set; }

            [XmlAttribute]
            public string key { get; set; }

            [XmlAttribute]
            public UInt64 duration { get; set; }

            [XmlAttribute]
            public string file { get; set; }

            [XmlAttribute]
            public UInt64 size { get; set; }

            [XmlAttribute]
            public string container { get; set; }

            [XmlAttribute]
            public string videoProfile { get; set; }
        }

        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public class MediaContainerVideoDirector
        {
            [XmlAttribute]
            public string tag { get; set; }
        }

        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public class MediaContainerVideoWriter
        {
            [XmlAttribute]
            public string tag { get; set; }
        }
    }
}
