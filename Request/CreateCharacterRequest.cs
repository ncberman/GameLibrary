using GameLibrary.Request.Util;

namespace GameLibrary.Request
{
    public class CreateCharacterRequest : IRequest, IRealtimeRequest
    {
        private string _CharacterName;
        public string CharacterName { get { return _CharacterName; } set { _CharacterName = value; } }

        public CreateCharacterRequest(string characterName)
        {
            _CharacterName = characterName;
        }
    }
}
