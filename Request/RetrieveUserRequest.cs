using GameLibrary.Request.Util;

namespace GameLibrary.Request
{
    public class RetrieveUserRequest : IRequest, IRealtimeRequest
    {
        #region Required For JsonConverter
        public RetrieveUserRequest() { }
        private readonly RequestType _RequestType = RequestType.USER_RETRIEVE;
        public RequestType RequestType { get { return _RequestType; } }
        #endregion

        private string _UserId;
        public string UserId { get { return _UserId; } set { _UserId = value; } }

        public RetrieveUserRequest(string userId)
        {
            _UserId = userId;
        }
    }
}
