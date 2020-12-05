using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace PlexBuilder
{
    public static class Serializer
    {
        public static T Deserialize<T>(string input) where T : class
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            using StringReader stream = new StringReader(input);
            using XmlReader sr = XmlReader.Create(stream);
            return (T)ser.Deserialize(sr);
        }

        public static string Serialize<T>(T ObjectToSerialize) where T : class
        {
            if (ObjectToSerialize == null)
                throw new ArgumentNullException(nameof(ObjectToSerialize));

            XmlSerializer xmlSerializer = new XmlSerializer(ObjectToSerialize.GetType());
            using StringWriter textWriter = new StringWriter();
            xmlSerializer.Serialize(textWriter, ObjectToSerialize);
            return textWriter.ToString();
        }
    }
}