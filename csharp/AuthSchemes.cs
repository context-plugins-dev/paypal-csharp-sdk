using PaypalSdk.Core;
using PaypalSdk.Core.Authentication;
using PaypalSdk.Core.Authentication.OAuth2;
using PaypalSdk.Core.Authentication.OAuth2.ClientCredentials;

namespace PaypalSdk;

internal sealed class AuthSchemes
{
    public IAuthScheme Oauth2 { get; }

    public AuthSchemes(PaypalSdkClientOptions options, Server server, RawClient rawClient)
    {
        Oauth2 =
            OAuth2Scheme<OAuth2ClientCredentials>.Create(
                options.Oauth2,
                options.Oauth2TokenStrategy ??
                    OAuth2ClientCredentialsStrategy.ForBasicAuthRequest(server.Default("/v1/oauth2/token"), rawClient),
                options.TimeProvider);
    }
}
