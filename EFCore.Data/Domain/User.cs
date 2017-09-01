using System.ComponentModel.DataAnnotations;

namespace EFCore.Domain {
    public class User {
        public int Id { get; set; }

        [Required]
        public int QuotationId { get; set; }
        public Quotation Quotation { get; set; }

        public bool PrimaryUser { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public RelationTypeE Relation { get; set; }

        [Required]
        public int AddressId { get; set; }
        public Address Address { get; set; } = new Address();

        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }

        public double Weight { get; set; }
        public double SeatToHeadDimension { get; set; }
        public double SpineToKneesDimension { get; set; }
        public double SeatToFootrestDimension { get; set; }
    }
}