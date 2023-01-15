namespace Core5ApiAuth.Models
{
    public class TokenDto
    {
        public string Token { get; set; }
        public string? RefreshToken { get; set; }
    }
}
