using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("Address", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class Address
    {
        private string _citySubdivisionName;
        private string _cityName;

        [XmlElement("ID")]
        public IDType ID { get; set; }

        [XmlElement("Postbox")]
        public string Postbox { get; set; }

        [XmlElement("Room")]
        public string Room { get; set; }

        [XmlElement("StreetName")]
        public string StreetName { get; set; }

        [XmlElement("BlockName")]
        public string BlockName { get; set; }

        [XmlElement("BuildingName")]
        public string BuildingName { get; set; }

        [XmlElement("BuildingNumber")]
        public string BuildingNumber { get; set; }

        [XmlElement("CitySubdivisionName")]
        public string CitySubdivisionName
        {
            get => _citySubdivisionName;
            set
            {
                if (value != null)
                {
                    _citySubdivisionName = value;
                }
                else
                {
                    _citySubdivisionName = string.Empty;
                }
            }
        }

        [XmlElement("CityName")]
        public string CityName
        {
            get => _cityName;
            set
            {
                if (value != null)
                {
                    _cityName = value;
                }
                else
                {
                    _cityName = string.Empty;
                }
            }
        }

        [XmlElement("PostalZone")]
        public string PostalZone { get; set; }

        [XmlElement("Region")]
        public string Region { get; set; }

        [XmlElement("District")]
        public string District { get; set; }

        [XmlElement("Country", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public virtual Country Country { get; set; }
    }
}
