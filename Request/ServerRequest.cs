using GameLibrary.Request.Util;
using Newtonsoft.Json;

namespace GameLibrary.Request
{
    public class ServerRequest
    {
        private Guid _CorrelationId;
        public Guid CorrelationId { get { return _CorrelationId; } set { _CorrelationId = value; } }

        private string _SessionId;
        public string SessionId { get { return _SessionId; } set { _SessionId = value; } }

        [JsonConverter(typeof(RequestConverter))]
        private IRequest _Request;
        public IRequest Request { get { return _Request; } set { _Request = value; } }

        public ServerRequest(Guid correlationId, string sessionId, IRequest request)
        {
            _CorrelationId = correlationId; _SessionId = sessionId; _Request = request;
        }
    }
}