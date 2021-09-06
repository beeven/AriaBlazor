using System;
using System.Threading.Tasks;
using System.Linq;

namespace AriaBlazor.Services
{
    public class TaskManagerFactory
    {
        public ITaskManager CreateTaskManager(RPCProtocol protocol, string url, string secret)
        {
            ITaskManager manager;
            switch(protocol)
            {
                case RPCProtocol.Http:
                    throw new NotImplementedException();
                case RPCProtocol.WebSocket:
                    manager = new WebSocketTaskManager(url, secret);
                    break;
                default:
                    throw new NotImplementedException();
            }
            return manager;
        }

        

    }

    public enum RPCProtocol
    {
        Http,
        WebSocket
    }
}