namespace GameLibrary.Response
{
    public class ServerResponse
    {
        private Guid _CorrelationId;
        public Guid CorrelationId { get { return _CorrelationId; } set { _CorrelationId = value; } }

        private IResponse _Response;
        public IResponse Response { get { return _Response; } set { _Response = value; } }

        public ServerResponse(Guid correlation, IResponse response) 
        {
            _CorrelationId = correlation; _Response = response; 
        }
    }
}
