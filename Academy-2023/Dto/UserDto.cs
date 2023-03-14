using System.ComponentModel.DataAnnotations;

namespace Academy_2023.Dto
{
    public class UserDto
    {
        [Required]
        public int? Id { get; set; }

        [Required]
        public string Email { get; set; } = null!;
        public string? Password { get; set; }

        [StringLength(10)]
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
