namespace GameLibrary.Request
{
    public class CreateCharacterRequest : IRequest
    {
        #region Required For JsonConverter
        public CreateCharacterRequest() { }
        private readonly RequestType _RequestType = RequestType.CHARACTER_CREATE;
        public RequestType RequestType { get { return _RequestType; } }
        #endregion

        private string _CharacterName;
        public string CharacterName { get { return _CharacterName; } set { _CharacterName = value; } }

        public CreateCharacterRequest(string characterName)
        {
            _CharacterName = characterName;
        }

    }
}
