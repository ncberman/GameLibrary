using GameLibrary.Request.Util;

namespace GameLibrary.Request
{
    public class RetrieveCharacterRequest : IRequest, IRealtimeRequest
    {
        #region Required For JsonConverter
        public RetrieveCharacterRequest() { }
        private readonly RequestType _RequestType = RequestType.CHARACTER_RETRIEVE;
        public RequestType RequestType { get { return _RequestType; } }
        #endregion

        private string _CharacterName;
        public string CharacterName { get { return _CharacterName; } set { _CharacterName = value; } }

        public RetrieveCharacterRequest(string characterName)
        {
            _CharacterName = characterName;
        }
    }
}
