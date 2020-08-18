using System;
using System.Xml.Serialization;
using System.ComponentModel;

namespace PlexBuilder.Models
{
    [Serializable]
    public static class Containers
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
            public int size { get; set; }

            [XmlAttribute]
            public byte allowCameraUpload { get; set; }

            [XmlAttribute]
            public byte allowChannelAccess { get; set; }

            [XmlAttribute]
            public byte allowMediaDeletion { get; set; }

            [XmlAttribute]
            public byte allowSharing { get; set; }

            [XmlAttribute]
            public byte allowSync { get; set; }

            [XmlAttribute]
            public byte allowTuners { get; set; }

            [XmlAttribute]
            public byte backgroundProcessing { get; set; }

            [XmlAttribute]
            public byte certificate { get; set; }

            [XmlAttribute]
            public byte companionProxy { get; set; }

            [XmlAttribute]
            public string countryCode { get; set; }

            [XmlAttribute]
            public string diagnostics { get; set; }

            [XmlAttribute]
            public byte eventStream { get; set; }

            [XmlAttribute]
            public string friendlyName { get; set; }

            [XmlAttribute]
            public byte hubSearch { get; set; }

            [XmlAttribute]
            public byte itemClusters { get; set; }

            [XmlAttribute]
            public byte livetv { get; set; }

            [XmlAttribute]
            public string machineIdentifier { get; set; }

            [XmlAttribute]
            public byte mediaProviders { get; set; }

            [XmlAttribute]
            public byte multiuser { get; set; }

            [XmlAttribute]
            public byte myPlex { get; set; }

            [XmlAttribute]
            public string myPlexMappingState { get; set; }

            [XmlAttribute]
            public string myPlexSigninState { get; set; }

            [XmlAttribute]
            public byte myPlexSubscription { get; set; }

            [XmlAttribute]
            public string myPlexUsername { get; set; }

            [XmlAttribute]
            public string ownerFeatures { get; set; }

            [XmlAttribute]
            public byte photoAutoTag { get; set; }

            [XmlAttribute]
            public string platform { get; set; }

            [XmlAttribute]
            public string platformVersion { get; set; }

            [XmlAttribute]
            public byte pluginHost { get; set; }

            [XmlAttribute]
            public byte pushNotifications { get; set; }

            [XmlAttribute]
            public byte readOnlyLibraries { get; set; }

            [XmlAttribute]
            public byte requestParametersInCookie { get; set; }

            [XmlAttribute]
            public byte streamingBrainABRVersion { get; set; }

            [XmlAttribute]
            public byte streamingBrainVersion { get; set; }

            [XmlAttribute]
            public byte sync { get; set; }

            [XmlAttribute]
            public byte transcoderActiveVideoSessions { get; set; }

            [XmlAttribute]
            public byte transcoderAudio { get; set; }

            [XmlAttribute]
            public byte transcoderLyrics { get; set; }

            [XmlAttribute]
            public byte transcoderPhoto { get; set; }

            [XmlAttribute]
            public byte transcoderSubtitles { get; set; }

            [XmlAttribute]
            public byte transcoderVideo { get; set; }

            [XmlAttribute]
            public string transcoderVideoBitrates { get; set; }

            [XmlAttribute]
            public string transcoderVideoQualities { get; set; }

            [XmlAttribute]
            public string transcoderVideoResolutions { get; set; }

            [XmlAttribute]
            public uint updatedAt { get; set; }

            [XmlAttribute]
            public byte updater { get; set; }

            [XmlAttribute]
            public string version { get; set; }

            [XmlAttribute]
            public byte voiceSearch { get; set; }
        }

        [Serializable]
        [DesignerCategory("code")]
        [XmlType(AnonymousType = true)]
        public class MediaContainerDirectory
        {
            [XmlAttribute]
            public byte count { get; set; }

            [XmlAttribute]
            public string key { get; set; }

            [XmlAttribute]
            public string title { get; set; }
        }
    }
}
