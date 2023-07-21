using GameLibrary.Request.Util;

namespace GameLibrary.Request
{
    public class RetrieveUserRequest : IRequest, IRealtimeRequest
    {
        private string _UserId;
        public string UserId { get { return _UserId; } set { _UserId = value; } }

        public RetrieveUserRequest(string userId)
        {
            _UserId = userId;
        }
    }
}
