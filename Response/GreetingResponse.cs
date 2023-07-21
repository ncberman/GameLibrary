namespace GameLibrary.Response
{
    public class GreetingResponse : IResponse
    {
        private string _Message;
        public string Message { get { return _Message; } set { _Message = value; } }

        public GreetingResponse(string message) 
        {
            _Message = message; 
        }
    }
}
