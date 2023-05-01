using GameLibrary.Request.Util;
using GameLibrary.Request;
using Newtonsoft.Json;

namespace GameLibrary.Response
{
    public class ServerResponse
    {
        [JsonConverter(typeof(RequestConverter))]
        private IResponse _Response;
        public IResponse Response { get { return _Response; } set { _Response = value; } }

        public ServerResponse(IResponse request) { _Response = request; }
    }
}
