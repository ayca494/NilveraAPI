using System.Collections.Generic;
using System.Xml.Serialization;

namespace NilveraAPI.Models.UblModels.Shared
{
    [XmlType("DocumentResponse")]
    public class DocumentResponse
    {
        private List<LineResponse> _lineResponse;

        [XmlElement("Response")]
        public virtual Response Response { get; set; }

        [XmlElement("DocumentReference")]
        public virtual DocumentReference DocumentReference { get; set; }

        [XmlElement("LineResponse", Type = typeof(LineResponse))]
        public virtual List<LineResponse> LineResponses
        {
            get => _lineResponse;
            set
            {
                if (value != null)
                {
                    _lineResponse = value;
                }
                else
                {
                    _lineResponse = new List<LineResponse>();
                }
            }
        }
    }
}
