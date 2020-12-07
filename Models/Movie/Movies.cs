using System;

namespace PlexBuilder.Models.Movie
{
    [Serializable]
    public static class Movies
    {
        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.

        [Serializable]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
        public partial class MediaContainer
        {
            public MediaContainerVideo Video { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public int size { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public ushort totalSize { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public bool allowSync { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public string art { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public string identifier { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public int librarySectionID { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public string librarySectionTitle { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public string librarySectionUUID { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public string mediaTagPrefix { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public uint mediaTagVersion { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public int offset { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public string thumb { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public string title1 { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public string title2 { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public string viewGroup { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public uint viewMode { get; set; }
        }

        [Serializable]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public partial class MediaContainerVideo
        {
            public MediaContainerVideoMedia Media { get; set; }

            [System.Xml.Serialization.XmlElement("Genre")]
            public MediaContainerVideoGenre[] Genre { get; set; }

            public MediaContainerVideoDirector Director { get; set; }

            public MediaContainerVideoWriter Writer { get; set; }

            public MediaContainerVideoCountry Country { get; set; }

            [System.Xml.Serialization.XmlElement("Role")]
            public MediaContainerVideoRole[] Role { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public int ratingKey { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public string key { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public string guid { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public string studio { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public string type { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public string title { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public string contentRating { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public string summary { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public decimal rating { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public ushort year { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public string tagline { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public string thumb { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public string art { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public uint duration { get; set; }

            [System.Xml.Serialization.XmlAttribute(DataType = "date")]
            public DateTime originallyAvailableAt { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public uint addedAt { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public uint updatedAt { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public string chapterSource { get; set; }
        }

        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public partial class MediaContainerVideoMedia
        {
            public MediaContainerVideoMediaPart Part { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public int id { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public uint duration { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public ushort bitrate { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public ushort width { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public ushort height { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public decimal aspectRatio { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public int audioChannels { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public string audioCodec { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public string videoCodec { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public string videoResolution { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public string container { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public string videoFrameRate { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public bool optimizedForStreaming { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public string audioProfile { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public bool has64bitOffsets { get; set; }

            [System.Xml.Serialization.XmlAttribute()]
            public string videoProfile { get; set; }
        }

        [Serializable]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public partial class MediaContainerVideoMediaPart
        {
            [System.Xml.Serialization.XmlAttribute()]
            public int id { get; set; }

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

        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public partial class MediaContainerVideoGenre
        {
            [System.Xml.Serialization.XmlAttribute()]
            public string tag { get; set; }
        }

        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public partial class MediaContainerVideoDirector
        {
            [System.Xml.Serialization.XmlAttribute()]
            public string tag { get; set; }
        }

        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public partial class MediaContainerVideoWriter
        {
            [System.Xml.Serialization.XmlAttribute()]
            public string tag { get; set; }
        }

        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public partial class MediaContainerVideoCountry
        {
            [System.Xml.Serialization.XmlAttribute()]
            public string tag { get; set; }
        }

        [Serializable()]
        [System.ComponentModel.DesignerCategory("code")]
        [System.Xml.Serialization.XmlType(AnonymousType = true)]
        public partial class MediaContainerVideoRole
        {
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
//
//        [Serializable]
//        [System.ComponentModel.DesignerCategory("code")]
//        [System.Xml.Serialization.XmlType(AnonymousType = true)]
//        [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
//        public partial class MediaContainer
//        {
//            private string title2Field;

// // public MediaContainerVideo Video { get; set; }

// // [System.Xml.Serialization.XmlAttribute] public int size { get; set; }

// // //[System.Xml.Serialization.XmlAttribute] public ulong totalSize { get; set; }

// // //[System.Xml.Serialization.XmlAttribute] //public bool allowSync { get; set; }

// // //[System.Xml.Serialization.XmlAttribute] //public string art { get; set; }

// // //[System.Xml.Serialization.XmlAttribute] //public string Identifier { get; set; }

// // //[System.Xml.Serialization.XmlAttribute] //public int librarySectionID { get; set; }

// // //[System.Xml.Serialization.XmlAttribute] //public string librarySectionTitle { get; set; }

// // //[System.Xml.Serialization.XmlAttribute] //public string librarySectionUUID { get; set; }

// // //[System.Xml.Serialization.XmlAttribute] //public string mediaTagPrefix { get; set; }

// // //[System.Xml.Serialization.XmlAttribute] //public uint mediaTagVersion { get; set; }

// // //[System.Xml.Serialization.XmlAttribute] //public int offset { get; set; }

// // //[System.Xml.Serialization.XmlAttribute] //public string thumb { get; set; }

// // //[System.Xml.Serialization.XmlAttribute] //public string title1 { get; set; }

// // //[System.Xml.Serialization.XmlAttribute] //public string title2 //{ // get => title2Field; //
// set => title2Field = value; //}

// // //[System.Xml.Serialization.XmlAttribute] //public string viewGroup { get; set; }

// // //[System.Xml.Serialization.XmlAttribute] //public uint viewMode { get; set; } }

// [Serializable] [System.ComponentModel.DesignerCategory("code")]
// [System.Xml.Serialization.XmlType(AnonymousType = true)] public partial class MediaContainerVideo
// { private string artField;

// public MediaContainerVideoMedia Media { get; set; }

// [System.Xml.Serialization.XmlElement("Genre")] public MediaContainerVideoGenre[] Genre { get;
// set; }

// public MediaContainerVideoDirector Director { get; set; }

// public MediaContainerVideoWriter Writer { get; set; }

// public MediaContainerVideoCountry Country { get; set; }

// [System.Xml.Serialization.XmlElement("Role")] public MediaContainerVideoRole[] Role { get; set; }

// [System.Xml.Serialization.XmlAttribute] public int ratingKey { get; set; }

// [System.Xml.Serialization.XmlAttribute] public string key { get; set; }

// [System.Xml.Serialization.XmlAttribute] public string guid { get; set; }

// [System.Xml.Serialization.XmlAttribute] public string studio { get; set; }

// [System.Xml.Serialization.XmlAttribute] public string type { get; set; }

// [System.Xml.Serialization.XmlAttribute] public string title { get; set; }

// [System.Xml.Serialization.XmlAttribute] public string contentRating { get; set; }

// [System.Xml.Serialization.XmlAttribute] public string summary { get; set; }

// [System.Xml.Serialization.XmlAttribute] public decimal rating { get; set; }

// [System.Xml.Serialization.XmlAttribute] public ushort year { get; set; }

// [System.Xml.Serialization.XmlAttribute] public string tagline { get; set; }

// [System.Xml.Serialization.XmlAttribute] public string thumb { get; set; }

// [System.Xml.Serialization.XmlAttribute] public string art { get => this.artField; set =>
// this.artField = value; }

// [System.Xml.Serialization.XmlAttribute] public uint duration { get; set; }

// [System.Xml.Serialization.XmlAttribute(DataType = "date")] public DateTime originallyAvailableAt
// { get; set; }

// [System.Xml.Serialization.XmlAttribute] public uint addedAt { get; set; }

// [System.Xml.Serialization.XmlAttribute] public uint updatedAt { get; set; }

// [System.Xml.Serialization.XmlAttribute] public string chapterSource { get; set; } }

// [Serializable] [System.ComponentModel.DesignerCategory("code")]
// [System.Xml.Serialization.XmlType(AnonymousType = true)] public partial class
// MediaContainerVideoMedia { private string videoProfileField;

// public MediaContainerVideoMediaPart Part { get; set; }

// [System.Xml.Serialization.XmlAttribute] public int id { get; set; }

// [System.Xml.Serialization.XmlAttribute] public uint duration { get; set; }

// [System.Xml.Serialization.XmlAttribute] public ushort bitrate { get; set; }

// [System.Xml.Serialization.XmlAttribute] public ushort width { get; set; }

// [System.Xml.Serialization.XmlAttribute] public ushort height { get; set; }

// [System.Xml.Serialization.XmlAttribute] public decimal aspectRatio { get; set; }

// [System.Xml.Serialization.XmlAttribute] public int audioChannels { get; set; }

// [System.Xml.Serialization.XmlAttribute] public string audioCodec { get; set; }

// [System.Xml.Serialization.XmlAttribute] public string videoCodec { get; set; }

// [System.Xml.Serialization.XmlAttribute] public string videoResolution { get; set; }

// [System.Xml.Serialization.XmlAttribute] public string container { get; set; }

// [System.Xml.Serialization.XmlAttribute] public string videoFrameRate { get; set; }

// [System.Xml.Serialization.XmlAttribute] public bool optimizedForStreaming { get; set; }

// [System.Xml.Serialization.XmlAttribute] public string audioProfile { get; set; }

// [System.Xml.Serialization.XmlAttribute] public bool has64bitOffsets { get; set; }

// [System.Xml.Serialization.XmlAttribute] public string videoProfile { get =>
// this.videoProfileField; set => this.videoProfileField = value; } }

// [Serializable] [System.ComponentModel.DesignerCategory("code")]
// [System.Xml.Serialization.XmlType(AnonymousType = true)] public partial class
// MediaContainerVideoMediaPart { private bool optimizedForStreamingField;

// [System.Xml.Serialization.XmlAttribute] public int id { get; set; }

// [System.Xml.Serialization.XmlAttribute] public string key { get; set; }

// [System.Xml.Serialization.XmlAttribute] public uint duration { get; set; }

// [System.Xml.Serialization.XmlAttribute] public string file { get; set; }

// [System.Xml.Serialization.XmlAttribute] public uint size { get; set; }

// [System.Xml.Serialization.XmlAttribute] public string audioProfile { get; set; }

// [System.Xml.Serialization.XmlAttribute] public string container { get; set; }

// [System.Xml.Serialization.XmlAttribute] public bool has64bitOffsets { get; set; }

// [System.Xml.Serialization.XmlAttribute] public bool optimizedForStreaming { get =>
// this.optimizedForStreamingField; set => this.optimizedForStreamingField = value; }

// [System.Xml.Serialization.XmlAttribute] public string videoProfile { get; set; } }

// [Serializable] [System.ComponentModel.DesignerCategory("code")]
// [System.Xml.Serialization.XmlType(AnonymousType = true)] public partial class
// MediaContainerVideoGenre {
//
// [System.Xml.Serialization.XmlAttribute] public string tag { get; set; } }

// [Serializable] [System.ComponentModel.DesignerCategory("code")]
// [System.Xml.Serialization.XmlType(AnonymousType = true)] public partial class
// MediaContainerVideoDirector {
//
// [System.Xml.Serialization.XmlAttribute] public string tag { get; set; } }

// [Serializable] [System.ComponentModel.DesignerCategory("code")]
// [System.Xml.Serialization.XmlType(AnonymousType = true)] public partial class
// MediaContainerVideoWriter {
//
// [System.Xml.Serialization.XmlAttribute] public string tag { get; set; } }

// [Serializable] [System.ComponentModel.DesignerCategory("code")]
// [System.Xml.Serialization.XmlType(AnonymousType = true)] public partial class
// MediaContainerVideoCountry {
//
// [System.Xml.Serialization.XmlAttribute] public string tag { get; set; } }

//
//        [Serializable]
//        [System.ComponentModel.DesignerCategory("code")]
//        [System.Xml.Serialization.XmlType(AnonymousType = true)]
//        public partial class MediaContainerVideoRole
//        {
//
//            [System.Xml.Serialization.XmlAttribute]
//            public string tag { get; set; }
//        }
//    }
//}