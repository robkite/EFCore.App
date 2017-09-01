namespace EFCore.Domain {
    public class Address {
        public int Id { get; set; }
        public string BuildingName { get; set; }
        public string BuildingNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
    }
}