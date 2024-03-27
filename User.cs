using System.ComponentModel.DataAnnotations;

namespace _BackEnd_Assessment
{
    public class User
    {
        [Key]
        public string UserName { get; set; } // primary key
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? ThreeDigitNumber { get; set; }
        public int? Wins { get; set; }
        public int? Losses { get; set; }

        // Navigation property user
        public ICollection<Content> Contents { get; set; }
    }
}
