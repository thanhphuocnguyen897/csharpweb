using System;
using System.IO;
using System.Xml.Serialization;

namespace Serialization
{
    class DemoXmlSerialization
    {
        static void Main(string[] args)
        {
            AddressDetails details = new AddressDetails();
            details.HouseNo = 4;
            details.StreetName = "Ha Noi";
            details.City = "Hue";
            XmlSerializer serializer = new XmlSerializer(typeof(AddressDetails));
            using (TextWriter writer = new StreamWriter(@"D:\Hoc\AddressDetails.xml"))
            {
                serializer.Serialize(writer, details);
            }
        }
    }
    public class AddressDetails
    {
        //ta có thể tuỳ biến lại các thẻ trong xml như sau
        //[XmlElement("Number")]
        public int HouseNo { get; set; }
        //[XmlElement("Name")]
        public string StreetName { get; set; }
        //[XmlElement("CityName")]
        public string City { get; set; }
        private string PoAddress { get; set; }
    }
}
