namespace Authenticator.Models
{
    public class TokenResponse
    {
        public string? token { get; set; }

        public int statusCode { get; set; }

        public TokenResponse(int code)
        {
            statusCode = code;
        }

        public TokenResponse(int code,string token) : this(code)
        {
            this.token = token;
        }
    }
}
