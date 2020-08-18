using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;
namespace PlexBuilder.Models
{
    [Serializable]
    public static class Libraries
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
            public byte size { get; set; }

            [XmlAttribute]
            public byte allowSync { get; set; }

            [XmlAttribute]
            public string identifier { get; set; }

            [XmlAttribute]
            public string mediaTagPrefix { get; set; }

            [XmlAttribute]
            public uint mediaTagVersion { get; set; }

            [XmlAttribute]
            public string title1 { get; set; }
        }

        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public class MediaContainerDirectory
        {
            [XmlElement("Location")]
            public MediaContainerDirectoryLocation[] Location { get; set; }

            [XmlAttribute]
            public byte allowSync { get; set; }

            [XmlAttribute]
            public string art { get; set; }

            [XmlAttribute]
            public string composite { get; set; }

            [XmlAttribute]
            public byte filters { get; set; }

            [XmlAttribute]
            public byte refreshing { get; set; }

            [XmlAttribute]
            public string thumb { get; set; }

            [XmlAttribute]
            public byte key { get; set; }

            [XmlAttribute]
            public string type { get; set; }

            [XmlAttribute]
            public string title { get; set; }

            [XmlAttribute]
            public string agent { get; set; }

            [XmlAttribute]
            public string scanner { get; set; }

            [XmlAttribute]
            public string language { get; set; }

            [XmlAttribute]
            public string uuid { get; set; }

            [XmlAttribute]
            public uint updatedAt { get; set; }

            [XmlAttribute]
            public uint createdAt { get; set; }

            [XmlAttribute]
            public uint scannedAt { get; set; }

            [XmlAttribute]
            public byte content { get; set; }

            [XmlAttribute]
            public byte directory { get; set; }

            [XmlAttribute]
            public uint contentChangedAt { get; set; }

            [XmlAttribute]
            public byte enableAutoPhotoTags { get; set; }

            [XmlIgnore]
            public bool enableAutoPhotoTagsSpecified { get; set; }

            internal IEnumerable<object> ToList()
            {
                throw new NotImplementedException();
            }
        }

        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public class MediaContainerDirectoryLocation
        {
            [XmlAttribute]
            public byte id { get; set; }

            [XmlAttribute]
            public string path { get; set; }
        }
    }
}