using System;

namespace PlexBuilder.Models.Tv
{
    public class Episode
    {
        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
        public partial class MediaContainer
        {
            private int viewModeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("Video")]
            public MediaContainerVideo[] Video { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public int size { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public int allowSync { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string art { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string banner { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string grandparentContentRating { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public ushort grandparentRatingKey { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string grandparentStudio { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string grandparentTheme { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string grandparentThumb { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string grandparentTitle { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string identifier { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public ushort key { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public int librarySectionID { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string librarySectionTitle { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string librarySectionUUID { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string mediaTagPrefix { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public int mediaTagVersion { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public int nocache { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public int parentIndex { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string parentTitle { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string theme { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string thumb { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string title1 { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string title2 { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string viewGroup { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public int viewMode
            {
                get => this.viewModeField;
                set => this.viewModeField = value;
            }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public partial class MediaContainerVideo
        {
            private int updatedAtField;

            /// <remarks/>
            public MediaContainerVideoMedia Media { get; set; }

            /// <remarks/>
            public MediaContainerVideoDirector Director { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("Writer")]
            public MediaContainerVideoWriter[] Writer { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public ushort ratingKey { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string key { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public ushort parentRatingKey { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public ushort grandparentRatingKey { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string guid { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string parentGuid { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string grandparentGuid { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string type { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string title { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string grandparentKey { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string parentKey { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string grandparentTitle { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string parentTitle { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string contentRating { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string summary { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public int index { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public int parentIndex { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public decimal rating { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public ushort year { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string thumb { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string art { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string parentThumb { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string grandparentThumb { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string grandparentArt { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string grandparentTheme { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public UInt64 duration { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute(DataType = "date")]
            public DateTime originallyAvailableAt { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public int addedAt { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public int updatedAt
            {
                get => this.updatedAtField;
                set => this.updatedAtField = value;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string titleSort { get; set; }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public partial class MediaContainerVideoMedia
        {

            /// <remarks/>
            public MediaContainerVideoMediaPart Part { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public ushort id { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public UInt64 duration { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public ushort bitrate { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public ushort width { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public ushort height { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public decimal aspectRatio { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public int audioChannels { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string audioCodec { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string videoCodec { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string videoResolution { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string container { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string videoFrameRate { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string videoProfile { get; set; }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public partial class MediaContainerVideoMediaPart
        {

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public ushort id { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string key { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public UInt64 duration { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string file { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public UInt64 size { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string container { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string videoProfile { get; set; }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public partial class MediaContainerVideoDirector
        {
            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string tag { get; set; }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public partial class MediaContainerVideoWriter
        {
            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string tag { get; set; }
        }

    }
}
