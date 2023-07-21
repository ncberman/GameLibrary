using GameLibrary.Request.Util;

namespace GameLibrary.Request
{
    public class GreetingRequest : IRequest, IRealtimeRequest
    {
        private string _Username;
        public string Username { get { return _Username; } set { _Username = value; } }

        public GreetingRequest(string username)
        {
            _Username = username;
        }
    }
}
