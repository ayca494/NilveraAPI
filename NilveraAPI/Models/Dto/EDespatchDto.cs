using NilveraAPI.Models.Dto.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NilveraAPI.Models.Dto
{
    public class EDespatchDto
    {
        public DespatchInfoDto DespatchInfo { get; set; }
        public DespatchSupplierInfoDto DespatchSupplierInfo { get; set; }
        public DeliveryCustomerInfoDto DeliveryCustomerInfo { get; set; }
        public BuyerCustomerInfoDto BuyerCustomerInfo { get; set; }
        public SellerSupplierInfoDto SellerSupplierInfo { get; set; }
        public OriginatorCustomerInfoDto OriginatorCustomerInfo { get; set; }
        public List<string> Notes { get; set; }
        public List<DespatchLineDto> DespatchLines { get; set; }
        public ShipmentDetailDto ShipmentDetail { get; set; }
        public List<AdditionalDocumentReferenceDto> AdditionalDocumentReference { get; set; }
        public OrderReferenceDto OrderReference { get; set; }
    }
}
