using System.Security.Authentication;

namespace Apache.NMS.ActiveMQ.Transport.Tcp
{
    public static class SslTransportManager
    {
        public static SslProtocols AllowedProtocols { get; set; } =
#if NETCORE
            SslProtocols.Tls | SslProtocols.Tls11 | SslProtocols.Tls12;
#else
            SslProtocols.Tls | SslProtocols.Tls11 | SslProtocols.Tls12 | SslProtocols.Ssl2 | SslProtocols.Ssl3;
#endif

        internal static readonly SslProtocols[] UnsupportedSslProtocols =
        {
#if NETCORE
            // Support for SslProtocols.Ssl2 and SslProtocols.Ssl3 have been removed from .Net Standard/Core
            SslProtocols.Ssl2, SslProtocols.Ssl3
#endif
        };
    }
}