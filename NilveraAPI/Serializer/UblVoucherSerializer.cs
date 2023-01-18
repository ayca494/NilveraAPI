using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NilveraAPI.Serializer
{
    public class UblVoucherSerializer
    {
        public readonly XmlSerializerNamespaces xmlns = new XmlSerializerNamespaces();
        public UblVoucherSerializer()
        {
            xmlns.Add("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
            xmlns.Add("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");
            xmlns.Add("xsd", "http://www.w3.org/2001/XMLSchema");
            xmlns.Add("", "urn:oasis:names:specification:ubl:schema:xsd:Voucher-2");
        }
    }
}
