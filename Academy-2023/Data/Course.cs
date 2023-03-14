namespace Academy_2023.Data
{
    public class Course
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public ICollection<User> Users { get; set; } = new HashSet<User>();     // navigation property
    }
}
