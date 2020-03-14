using System;
using System.Xml.Serialization;

namespace PlexBuilder.Models.Movies
{
    [Serializable()]
    public class Movies
    {
        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        [XmlRoot(Namespace = "", IsNullable = false)]
        public partial class MediaContainer
        {

            /// <remarks/>
            [XmlElement("Video")]
            public MediaContainerVideo[] Video { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public UInt64 size { get; set; }

            [XmlAttribute]
            public UInt64 totalSize { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public byte allowSync { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string art { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string identifier { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public int librarySectionID { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string librarySectionTitle { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string librarySectionUUID { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string mediaTagPrefix { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public uint mediaTagVersion { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string thumb { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string title1 { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string title2 { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string viewGroup { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public uint viewMode { get; set; }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public partial class MediaContainerVideo
        {
            private string summaryField;

            /// <remarks/>
            [XmlElement("Media")]
            public MediaContainerVideoMedia[] Media { get; set; }

            /// <remarks/>
            [XmlElement("Genre")]
            public MediaContainerVideoGenre[] Genre { get; set; }

            /// <remarks/>
            public MediaContainerVideoDirector Director { get; set; }

            /// <remarks/>
            [XmlElement("Writer")]
            public MediaContainerVideoWriter[] Writer { get; set; }

            /// <remarks/>
            [XmlElement("Country")]
            public MediaContainerVideoCountry[] Country { get; set; }

            /// <remarks/>
            [XmlElement("Role")]
            public MediaContainerVideoRole[] Role { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public ushort ratingKey { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string key { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string guid { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string studio { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string type { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string title { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string contentRating { get; set; }

            /// <remarks/>
            public string Getsummary()
            {
                return this.summaryField;
            }

            /// <remarks/>
            public void Setsummary(string value)
            {
                this.summaryField = ""; // value;
            }

            /// <remarks/>
            [XmlAttribute()]
            public decimal rating { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public ushort year { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string tagline { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string thumb { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string art { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public UInt64 duration { get; set; }

            /// <remarks/>
            [XmlAttribute(DataType = "date")]
            public DateTime originallyAvailableAt { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public uint addedAt { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public uint updatedAt { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string chapterSource { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public decimal audienceRating { get; set; }

            /// <remarks/>
            [XmlIgnore()]
            public bool audienceRatingSpecified { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string audienceRatingImage { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public byte hasPremiumExtras { get; set; }

            /// <remarks/>
            [XmlIgnore()]
            public bool hasPremiumExtrasSpecified { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public byte hasPremiumPrimaryExtra { get; set; }

            /// <remarks/>
            [XmlIgnore()]
            public bool hasPremiumPrimaryExtraSpecified { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string ratingImage { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public int viewCount { get; set; }

            /// <remarks/>
            [XmlIgnore()]
            public bool viewCountSpecified { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public uint lastViewedAt { get; set; }

            /// <remarks/>
            [XmlIgnore()]
            public bool lastViewedAtSpecified { get; set; }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public partial class MediaContainerVideoMedia
        {

            /// <remarks/>
            public MediaContainerVideoMediaPart Part { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public int id { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public UInt64 duration { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public UInt64 bitrate { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public UInt64 width { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public UInt64 height { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public decimal aspectRatio { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public byte audioChannels { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string audioCodec { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string videoCodec { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string videoResolution { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string container { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string videoFrameRate { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public byte optimizedForStreaming { get; set; }

            /// <remarks/>
            [XmlIgnore()]
            public bool optimizedForStreamingSpecified { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string audioProfile { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public byte has64bitOffsets { get; set; }

            /// <remarks/>
            [XmlIgnore()]
            public bool has64bitOffsetsSpecified { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string videoProfile { get; set; }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public partial class MediaContainerVideoMediaPart
        {

            /// <remarks/>
            [XmlAttribute()]
            public UInt64 id { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string key { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public UInt64 duration { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string file { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public UInt64 size { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string audioProfile { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string container { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public byte has64bitOffsets { get; set; }

            /// <remarks/>
            [XmlIgnore()]
            public bool has64bitOffsetsSpecified { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public byte optimizedForStreaming { get; set; }

            /// <remarks/>
            [XmlIgnore()]
            public bool optimizedForStreamingSpecified { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string videoProfile { get; set; }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public partial class MediaContainerVideoGenre
        {

            /// <remarks/>
            [XmlAttribute()]
            public string tag { get; set; }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public partial class MediaContainerVideoDirector
        {

            /// <remarks/>
            [XmlAttribute()]
            public string tag { get; set; }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public partial class MediaContainerVideoWriter
        {

            /// <remarks/>
            [XmlAttribute()]
            public string tag { get; set; }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public partial class MediaContainerVideoCountry
        {

            /// <remarks/>
            [XmlAttribute()]
            public string tag { get; set; }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public partial class MediaContainerVideoRole
        {

            /// <remarks/>
            [XmlAttribute()]
            public string tag { get; set; }
        }

    }
}