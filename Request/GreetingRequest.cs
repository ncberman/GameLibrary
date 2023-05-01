namespace GameLibrary.Request
{
    public class GreetingRequest : IRequest
    {
        #region Required For JsonConverter
        public GreetingRequest() { }
        private readonly RequestType _RequestType = RequestType.GREETING;
        public RequestType RequestType { get { return _RequestType; } }
        #endregion

        private string _Username;
        public string Username { get { return _Username; } set { _Username = value; } }

        public GreetingRequest(string username)
        {
            _Username = username;
        }
    }
}
