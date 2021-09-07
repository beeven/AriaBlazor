using System;
using System.Threading.Tasks;
using System.Linq;

namespace AriaBlazor.Services
{
    public class TaskManagerFactory
    {
        private ITaskManager _manager;
        public ITaskManager CreateTaskManager(RPCProtocol protocol, string url, string secret)
        {
            ITaskManager manager;
            switch(protocol)
            {
                case RPCProtocol.HTTP:
                    throw new NotImplementedException();
                case RPCProtocol.WS:
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
        HTTP,
        HTTPS,
        WS,
        WSS
    }
}