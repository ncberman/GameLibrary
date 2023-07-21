using GameLibrary.Model;
namespace GameLibrary.Response
{
    public class RetrieveCharacterResponse : IResponse
    {
        private string _Message;
        public string Message { get { return _Message; } set { _Message = value; } }

        private SharedCharacter _Character;
        public SharedCharacter Character { get { return _Character; } set { _Character = value; } }

        public RetrieveCharacterResponse(string message, SharedCharacter character) 
        { 
            _Message = message; _Character = character;
        }
    }
}
