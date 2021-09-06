using System;
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http.Json;
using StreamJsonRpc;
using System.Net.WebSockets;

namespace AriaBlazor.Services
{
    public class WebSocketTaskManager : ITaskManager, IDisposable
    {
        ClientWebSocket _socks = new ClientWebSocket();
        string _rpcUri; 
        string _secret;
        JsonRpc _rpc;

        CancellationTokenSource _tokenSource;
        public WebSocketTaskManager(string rpcUri, string secret)
        {
            this._rpcUri = rpcUri;
            this._secret = "token:"+secret;
            this._tokenSource = new CancellationTokenSource();
            var handler = new StreamJsonRpc.WebSocketMessageHandler(_socks);
            _rpc = new JsonRpc(handler);
        }

        public async Task InitializeAsync()
        {
            await _socks.ConnectAsync(new Uri(_rpcUri), _tokenSource.Token);
            _rpc.StartListening();
        }
        public Task<AriaTaskStatus[]> GetActiveAsync(string[] keys)
        {
            throw new NotImplementedException();
        }

        public async Task<AriaVersion> GetVersionAsync()
        {
            var result = await _rpc.InvokeAsync<AriaVersion>("aria2.getVersion",_secret);
            return result;
        }

        public void Dispose()
        {
            _socks.Dispose();
            
        }
    }
}