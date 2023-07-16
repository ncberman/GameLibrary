using GameLibrary.Model;
using GameLibrary.Response.Util;

namespace GameLibrary.Response
{
    public class RetrieveUserResponse : IResponse
    {
        #region Required For JsonConverter
        public RetrieveUserResponse() { }
        private readonly ResponseType _ResponseType = ResponseType.USER_RETRIEVE;
        public ResponseType ResponseType { get { return _ResponseType; } }
        private readonly ResponseStatus _Status;
        public ResponseStatus Status { get { return _Status; } }
        #endregion

        private string _Message;
        public string Message { get { return _Message; } set { _Message = value; } }

        private SharedUser _User;
        public SharedUser User { get { return _User; } set { _User = value; } }

        public RetrieveUserResponse(ResponseStatus status, string message, SharedUser user) 
        { 
            _Status = status; _Message = message; _User = user;
        }
    }
}
