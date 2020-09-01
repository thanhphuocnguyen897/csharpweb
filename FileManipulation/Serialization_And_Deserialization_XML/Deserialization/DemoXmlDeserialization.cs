using System;
using System.IO;
using System.Xml.Serialization;

namespace Deserialization
{
    class DemoXmlDeserialization
    {
        static void Main(string[] args)
        {
            Address details = new Address();
            details.HouseNo = 4;
            details.StreetName = "Ha Noi";
            details.City = "Hue";
            XmlSerializer serializer = new XmlSerializer(typeof(Address));
            using (TextWriter writer = new StreamWriter(@"D:\Hoc\myXml.xml"))
            {
                serializer.Serialize(writer, details);
            }

            XmlSerializer deserializer = new XmlSerializer(typeof(Address));
            using (var reader = new StreamReader(@"D:\Hoc\myXml.xml"))
            {
                object obj = deserializer.Deserialize(reader);
                Address xmlData = (Address)obj;
                Console.WriteLine(xmlData.HouseNo);
                Console.WriteLine(xmlData.StreetName);
            }
        }
    }
    public class Address
    {
        public int HouseNo { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
    }
}
