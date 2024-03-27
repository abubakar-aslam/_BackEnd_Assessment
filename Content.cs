using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _BackEnd_Assessment
{
    public class Content
    {
        [Key]
        public int Id { get; set; }
        public string? Question { get; set; }
        public string? AnswerA { get; set; }
        public string? AnswerB { get; set; }
        public string? AnswerC { get; set; }
        public string? AnswerD { get; set; }
        public string? CorrectAnswer { get; set; }
        public byte[]? Image { get; set; }

        // Foreign key property referencing UserName
        public string UserName { get; set; }

        // Navigation property for the associated User
        [ForeignKey("UserName")]
        public User User { get; set; }
    }
}
