using GameLibrary.Request.Util;
using GameLibrary.Request;
using Newtonsoft.Json;

namespace GameLibrary.Response
{
    public class ServerResponse
    {
        private Guid _CorrelationId;
        public Guid CorrelationId { get { return _CorrelationId; } set { _CorrelationId = value; } }

        [JsonConverter(typeof(RequestConverter))]
        private IResponse _Response;
        public IResponse Response { get { return _Response; } set { _Response = value; } }

        public ServerResponse(Guid correlation, IResponse response) 
        {
            _CorrelationId = correlation; _Response = response; 
        }
    }
}
