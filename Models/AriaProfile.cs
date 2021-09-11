using System;

namespace AriaBlazor.Models
{
    public record AriaProfile
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = "Profile";
        public string Host { get; set; } = "localhost";
        public int Port { get; set; } = 6800;
        public string Path { get; set; } = "jsonrpc";
        public string Secret { get; set; } = "";
        public Services.RPCProtocol Protocol { get; set; } = Services.RPCProtocol.WS;
        public bool Expanded { get; set; } = false;
    }
}