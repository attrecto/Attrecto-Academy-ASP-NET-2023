using System.ComponentModel.DataAnnotations;

namespace Academy_2023.Dto
{
    public class CreateUserDto
    {
        [Required]
        public string Name { get; set; } = null!;

        public string? Password { get; set; }

        [StringLength(10)]
        public string? FirstName { get; set; }

        public string? LastName { get; set; }
        public string? Image { get; set; }
    }
}