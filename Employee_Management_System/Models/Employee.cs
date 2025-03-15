using System.ComponentModel.DataAnnotations;

namespace Employee_Management_System.Models
{
    public class Employee : BaseEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [MaxLength(50)]
        public string Position { get; set; }

        [Required]
        public decimal Salary { get; set; }
    }
}
