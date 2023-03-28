using System.ComponentModel.DataAnnotations;

namespace Academy_2023.Data
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Email { get; set; } = null!;
        public string? Password { get; set; }

        [StringLength(10)]
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ImageUrl { get; set; }
        public DateTimeOffset? CreatedAt { get; set; }

        public string? Role { get; set; }

        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();     // navigation property
    }
}
