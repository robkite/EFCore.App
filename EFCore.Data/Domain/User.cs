namespace EFCore.Domain {
    public class User {
        public int Id { get; set; }
        public int QuotationId { get; set; }
        public Quotation Quotation { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}