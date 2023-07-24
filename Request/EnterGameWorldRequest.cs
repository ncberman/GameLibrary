using GameLibrary.Request.Util;

namespace GameLibrary.Request
{
    public class EnterGameWorldRequest : IRequest, IRealtimeRequest
    {
        private string _CharacterName;
        public string CharacterName { get { return _CharacterName; } set { _CharacterName = value; } }

        public EnterGameWorldRequest(string characterName)
        {
            _CharacterName = characterName;
        }
    }
}
