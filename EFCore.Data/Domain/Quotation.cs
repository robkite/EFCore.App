using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCore.Domain {
    public class Quotation {
        public int Id { get; set; }

        public int SalesPersonId { get; set; }

        public PropertyTypeE PropertyType { get; set; }
        public List<User> Users { get; set; } = new List<User>();
    }
}