namespace Academy_2023.Dto
{
    public class TokenDto
    {
        public string Token { get; set; } = null!;
        public DateTimeOffset Expires { get; set; }
    }
}
