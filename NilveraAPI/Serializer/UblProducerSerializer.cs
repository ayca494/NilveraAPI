using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace NilveraAPI.Serializer
{
    public class UblProducerSerializer
    {
        public readonly XmlSerializerNamespaces xmlns = new XmlSerializerNamespaces();

        public UblProducerSerializer()
        {
            xmlns.Add("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
            xmlns.Add("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");
            xmlns.Add("", "urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2");
        }
    }
}
