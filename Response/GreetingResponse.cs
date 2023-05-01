namespace GameLibrary.Response
{
    public class GreetingResponse : IResponse
    {
        #region Required For JsonConverter
        public GreetingResponse() { }
        private readonly ResponseType _ResponseType = ResponseType.GREETING;
        public ResponseType ResponseType { get { return _ResponseType; } }
        #endregion

        private string _Message;
        public string Message { get { return _Message; } set { _Message = value; } }

        public GreetingResponse(string message) { _Message = message; }
    }
}
