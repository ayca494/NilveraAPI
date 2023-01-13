using System.Collections.Generic;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("ItemProperty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ItemProperty
    {
        [XmlElement("ID")]
        public IDType ID { get; set; }

        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("NameCode")]
        public string NameCode { get; set; }

        [XmlElement("TestMethod")]
        public string TestMethod { get; set; }

        [XmlElement("Value")]
        public string Value { get; set; }

        [XmlElement("ValueQuantity")]
        public decimal ValueQuantity { get; set; }

        [XmlElement("ValueQualifier")]
        public string ValueQualifier { get; set; }

        [XmlElement("ImportanceCode")]
        public string ImportanceCode { get; set; }

        [XmlElement("ListValue")]
        public List<string> ListValue { get; set; }

        [XmlElement("UsabilityPeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Period UsabilityPeriod { get; set; }

        [XmlElement("ItemPropertyGroup", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ItemPropertyGroup ItemPropertyGroup { get; set; }

        [XmlElement("RangeDimension", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Dimension RangeDimension { get; set; }

        [XmlElement("ItemPropertyRange", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ItemPropertyRange ItemPropertyRange { get; set; }
    }
}
