namespace Apache.NMS.ActiveMQ.Transport.Tcp
{
    public static class TcpTransportManager
    {
        public static int ReceiveBufferSize { get; set; } =
#if NETCORE
            (1024 * 32);
#else
            (1024 * 8);
#endif

        public static int SendBufferSize { get; set; } =
#if NETCORE
            (1024 * 32);
#else
            (1024 * 8);
#endif
    }
}