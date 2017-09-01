using System.Collections.Generic;

namespace EFCore.Domain {
    public class Quotation {
        public int Id { get; set; }
        public List<User> Users { get; set; } = new List<User>();
    }
}