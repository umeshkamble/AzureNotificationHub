using Microsoft.AspNetCore.Authentication;

namespace AZNotificationHub.Authentication
{
    public class ApiKeyAuthOptions : AuthenticationSchemeOptions
    {
        public const string DefaultScheme = "umeshkamble";
        public string Scheme => DefaultScheme;
        public string ApiKey { get; set; }
    }
}
