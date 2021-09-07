using System;

namespace AriaBlazor.Models
{
    public class AriaProfile
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "Profile";
        public string Host { get; set; } = "localhost";
        public int Port { get; set; } = 6800;
        public string Path { get; set; } = "jsonrpc";
        public string Secret { get; set; } = "";
        public Services.RPCProtocol Protocol { get; set; }
    }
}