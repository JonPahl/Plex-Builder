using System;
using System.Collections.Generic;

namespace PlexBuilder.Models
{

    [Serializable()]

    public class Libraries
    {

        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class MediaContainer
        {
            private byte sizeField;
            private string identifierField;
            private uint mediaTagVersionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Directory")]
            public MediaContainerDirectory[] Directory { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte size
            {
                get => this.sizeField;
                set => this.sizeField = value;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte allowSync { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string identifier
            {
                get => this.identifierField;
                set => this.identifierField = value;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string mediaTagPrefix { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint mediaTagVersion
            {
                get => this.mediaTagVersionField;
                set => this.mediaTagVersionField = value;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string title1 { get; set; }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MediaContainerDirectory
        {
            private byte allowSyncField;
            private string compositeField;
            private byte refreshingField;
            private string uuidField;
            private uint scannedAtField;
            private byte directoryField;
            private bool enableAutoPhotoTagsFieldSpecified;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Location")]
            public MediaContainerDirectoryLocation[] Location { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte allowSync
            {
                get => this.allowSyncField;
                set => this.allowSyncField = value;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string art { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string composite
            {
                get => this.compositeField;
                set => this.compositeField = value;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte filters { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte refreshing
            {
                get => this.refreshingField;
                set => this.refreshingField = value;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string thumb { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte key { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string title { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string agent { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string scanner { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string language { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string uuid
            {
                get => this.uuidField;
                set => this.uuidField = value;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint updatedAt { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint createdAt { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint scannedAt
            {
                get => this.scannedAtField;
                set => this.scannedAtField = value;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte content { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte directory
            {
                get => this.directoryField;
                set => this.directoryField = value;
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint contentChangedAt { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte enableAutoPhotoTags { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool enableAutoPhotoTagsSpecified
            {
                get => this.enableAutoPhotoTagsFieldSpecified;
                set => this.enableAutoPhotoTagsFieldSpecified = value;
            }

            internal IEnumerable<object> ToList()
            {
                throw new NotImplementedException();
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class MediaContainerDirectoryLocation
        {
            private string pathField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte id { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string path
            {
                get => this.pathField;
                set => this.pathField = value;
            }
        }




    }
}
