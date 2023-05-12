using GameLibrary.Response.Util;

namespace GameLibrary.Response
{
    public interface IResponse
    {
        public ResponseType ResponseType { get; }
        public ResponseStatus Status { get; }
    }
}
