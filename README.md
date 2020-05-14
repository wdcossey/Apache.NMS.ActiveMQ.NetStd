# Apache.NMS.ActiveMQ.NetStd
Apache NMS for ActiveMQ Class Library (.Net Messaging Library Implementation): An implementation of the NMS API for ActiveMQ

Requires [Apache.NMS.NetStd](https://www.nuget.org/packages/Apache.NMS.NetStd).

This was an exact copy of the original [Apache.NMS.ActiveMQ](http://activemq.apache.org/nms/apachenmsactivemq.html) project (v 1.7.2.4108), the difference is it targets .NET Standard 2.0 with some modifications for SslProtocols.

# Version 1.7.3
Added static class **TcpTransportManager** to configure **ReceiveBufferSize** and **SendBufferSize**

> TcpTransportManager.ReceiveBufferSize = (1024 * 64); //64kb

> TcpTransportManager.SendBufferSize = (1024 * 8); //8kb

See the raised [issue](https://github.com/wdcossey/Apache.NMS.ActiveMQ.NetStd/issues/6) for more information.

# Version 1.7.2.4114
Added static class **SslTransportManager** to configure **SslProtocols** for **SslTransport**

> i.e SslTransportManager.AllowedProtocols = SslProtocols.Tls | SslProtocols.Tls11 | SslProtocols.Tls12;

**NOTE:** SslProtocols.Ssl2 & SslProtocols.Ssl3 will always be stripped when targeting .Net Core as they are deprecated.
