using GameLibrary.Request.Util;

namespace GameLibrary.Request
{
    public class RetrieveCharacterRequest : IRequest, IRealtimeRequest
    {
        private string _CharacterName;
        public string CharacterName { get { return _CharacterName; } set { _CharacterName = value; } }

        public RetrieveCharacterRequest(string characterName)
        {
            _CharacterName = characterName;
        }
    }
}
