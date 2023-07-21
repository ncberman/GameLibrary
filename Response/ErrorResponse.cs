namespace GameLibrary.Response
{
    public class ErrorResponse : IResponse
    {
        private string _Message;
        public string Message { get { return _Message; } set { _Message = value; } }

        public ErrorResponse(string message) 
        { 
            _Message = message; 
        }
    }
}
