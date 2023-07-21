using GameLibrary.Model;
namespace GameLibrary.Response
{
    public class RetrieveUserResponse : IResponse
    {
        private string _Message;
        public string Message { get { return _Message; } set { _Message = value; } }

        private SharedUser _User;
        public SharedUser User { get { return _User; } set { _User = value; } }

        public RetrieveUserResponse(string message, SharedUser user) 
        { 
            _Message = message; _User = user;
        }
    }
}
