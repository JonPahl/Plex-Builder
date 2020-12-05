using System;

namespace PlexBuilder.Models.Movie
{
    [Serializable]
    public static class Movies
    {
        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
        public partial class MediaContainer
        {
            /// <remarks/>
            public MediaContainerVideo Video { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public int size { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public ushort totalSize { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public bool allowSync { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string art { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string identifier { get; set; }

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
            public uint mediaTagVersion { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public int offset { get; set; }

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
            public uint viewMode { get; set; }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public partial class MediaContainerVideo
        {
            /// <remarks/>
            public MediaContainerVideoMedia Media { get; set; }
            /// <remarks/>
            [System.Xml.Serialization.XmlElement("Genre")]
            public MediaContainerVideoGenre[] Genre { get; set; }

            /// <remarks/>
            public MediaContainerVideoDirector Director { get; set; }

            /// <remarks/>
            public MediaContainerVideoWriter Writer { get; set; }

            /// <remarks/>
            public MediaContainerVideoCountry Country { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement("Role")]
            public MediaContainerVideoRole[] Role { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public int ratingKey { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string key { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string guid { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string studio { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string type { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string title { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string contentRating { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string summary { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public decimal rating { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public ushort year { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string tagline { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string thumb { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string art { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public uint duration { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute(DataType = "date")]
            public DateTime originallyAvailableAt { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public uint addedAt { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public uint updatedAt { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string chapterSource { get; set; }
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
            public int id { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public uint duration { get; set; }

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
            public bool optimizedForStreaming { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string audioProfile { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public bool has64bitOffsets { get; set; }

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
            public int id { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string key { get; set; }

            // <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public uint duration { get; set; }

            // <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string file { get; set; }

            // <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public ulong size { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string audioProfile { get; set; }

            // <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string container { get; set; }

            // <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public bool has64bitOffsets { get; set; }

            // <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public int optimizedForStreaming { get; set; }

            // <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string videoProfile { get; set; }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public partial class MediaContainerVideoGenre
        {
            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string tag { get; set; }
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

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public partial class MediaContainerVideoCountry
        {
            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string tag { get; set; }
        }

        /// <remarks/>
        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public partial class MediaContainerVideoRole
        {
            /// <remarks/>
            [System.Xml.Serialization.XmlAttribute()]
            public string tag { get; set; }
        }
    }
}
//using System;

//namespace PlexBuilder.Models.Movie
//{
//    [Serializable]
//    public static class Movies
//    {
//        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
//        /// <remarks/>
//        [Serializable]
//        [System.ComponentModel.DesignerCategory("code")]
//        [System.Xml.Serialization.XmlType(AnonymousType = true)]
//        [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
//        public partial class MediaContainer
//        {
//            private string title2Field;

//            ///// <remarks/>
//            public MediaContainerVideo Video { get; set; }

//            ///// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public int size { get; set; }

//            ///// <remarks/>
//            //[System.Xml.Serialization.XmlAttribute]
//            public ulong totalSize { get; set; }

//            ///// <remarks/>
//            //[System.Xml.Serialization.XmlAttribute]
//            //public bool allowSync { get; set; }

//            ///// <remarks/>
//            //[System.Xml.Serialization.XmlAttribute]
//            //public string art { get; set; }

//            ///// <remarks/>
//            //[System.Xml.Serialization.XmlAttribute]
//            //public string Identifier { get; set; }

//            ///// <remarks/>
//            //[System.Xml.Serialization.XmlAttribute]
//            //public int librarySectionID { get; set; }

//            ///// <remarks/>
//            //[System.Xml.Serialization.XmlAttribute]
//            //public string librarySectionTitle { get; set; }

//            ///// <remarks/>
//            //[System.Xml.Serialization.XmlAttribute]
//            //public string librarySectionUUID { get; set; }

//            ///// <remarks/>
//            //[System.Xml.Serialization.XmlAttribute]
//            //public string mediaTagPrefix { get; set; }

//            ///// <remarks/>
//            //[System.Xml.Serialization.XmlAttribute]
//            //public uint mediaTagVersion { get; set; }

//            ///// <remarks/>
//            //[System.Xml.Serialization.XmlAttribute]
//            //public int offset { get; set; }

//            ///// <remarks/>
//            //[System.Xml.Serialization.XmlAttribute]
//            //public string thumb { get; set; }

//            ///// <remarks/>
//            //[System.Xml.Serialization.XmlAttribute]
//            //public string title1 { get; set; }

//            ///// <remarks/>
//            //[System.Xml.Serialization.XmlAttribute]
//            //public string title2
//            //{
//            //    get => title2Field;
//            //    set => title2Field = value;
//            //}

//            ///// <remarks/>
//            //[System.Xml.Serialization.XmlAttribute]
//            //public string viewGroup { get; set; }

//            ///// <remarks/>
//            //[System.Xml.Serialization.XmlAttribute]
//            //public uint viewMode { get; set; }
//        }

//        /// <remarks/>
//        [Serializable]
//        [System.ComponentModel.DesignerCategory("code")]
//        [System.Xml.Serialization.XmlType(AnonymousType = true)]
//        public partial class MediaContainerVideo
//        {
//            private string artField;

//            /// <remarks/>
//            public MediaContainerVideoMedia Media { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlElement("Genre")]
//            public MediaContainerVideoGenre[] Genre { get; set; }

//            /// <remarks/>
//            public MediaContainerVideoDirector Director { get; set; }

//            /// <remarks/>
//            public MediaContainerVideoWriter Writer { get; set; }

//            /// <remarks/>
//            public MediaContainerVideoCountry Country { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlElement("Role")]
//            public MediaContainerVideoRole[] Role { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public int ratingKey { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public string key { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public string guid { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public string studio { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public string type { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public string title { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public string contentRating { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public string summary { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public decimal rating { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public ushort year { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public string tagline { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public string thumb { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public string art
//            {
//                get => this.artField;
//                set => this.artField = value;
//            }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public uint duration { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute(DataType = "date")]
//            public DateTime originallyAvailableAt { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public uint addedAt { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public uint updatedAt { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public string chapterSource { get; set; }
//        }

//        /// <remarks/>
//        [Serializable]
//        [System.ComponentModel.DesignerCategory("code")]
//        [System.Xml.Serialization.XmlType(AnonymousType = true)]
//        public partial class MediaContainerVideoMedia
//        {
//            private string videoProfileField;

//            /// <remarks/>
//            public MediaContainerVideoMediaPart Part { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public int id { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public uint duration { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public ushort bitrate { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public ushort width { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public ushort height { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public decimal aspectRatio { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public int audioChannels { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public string audioCodec { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public string videoCodec { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public string videoResolution { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public string container { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public string videoFrameRate { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public bool optimizedForStreaming { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public string audioProfile { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public bool has64bitOffsets { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public string videoProfile
//            {
//                get => this.videoProfileField;
//                set => this.videoProfileField = value;
//            }
//        }

//        /// <remarks/>
//        [Serializable]
//        [System.ComponentModel.DesignerCategory("code")]
//        [System.Xml.Serialization.XmlType(AnonymousType = true)]
//        public partial class MediaContainerVideoMediaPart
//        {
//            private bool optimizedForStreamingField;

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public int id { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public string key { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public uint duration { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public string file { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public uint size { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public string audioProfile { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public string container { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public bool has64bitOffsets { get; set; }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public bool optimizedForStreaming
//            {
//                get => this.optimizedForStreamingField;
//                set => this.optimizedForStreamingField = value;
//            }

//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public string videoProfile { get; set; }
//        }

//        /// <remarks/>
//        [Serializable]
//        [System.ComponentModel.DesignerCategory("code")]
//        [System.Xml.Serialization.XmlType(AnonymousType = true)]
//        public partial class MediaContainerVideoGenre
//        {
//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public string tag { get; set; }
//        }

//        /// <remarks/>
//        [Serializable]
//        [System.ComponentModel.DesignerCategory("code")]
//        [System.Xml.Serialization.XmlType(AnonymousType = true)]
//        public partial class MediaContainerVideoDirector
//        {
//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public string tag { get; set; }
//        }

//        /// <remarks/>
//        [Serializable]
//        [System.ComponentModel.DesignerCategory("code")]
//        [System.Xml.Serialization.XmlType(AnonymousType = true)]
//        public partial class MediaContainerVideoWriter
//        {
//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public string tag { get; set; }
//        }

//        /// <remarks/>
//        [Serializable]
//        [System.ComponentModel.DesignerCategory("code")]
//        [System.Xml.Serialization.XmlType(AnonymousType = true)]
//        public partial class MediaContainerVideoCountry
//        {
//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public string tag { get; set; }
//        }

//        /// <remarks/>
//        [Serializable]
//        [System.ComponentModel.DesignerCategory("code")]
//        [System.Xml.Serialization.XmlType(AnonymousType = true)]
//        public partial class MediaContainerVideoRole
//        {
//            /// <remarks/>
//            [System.Xml.Serialization.XmlAttribute]
//            public string tag { get; set; }
//        }
//    }
//}