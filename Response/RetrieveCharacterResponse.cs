using GameLibrary.Model;
using GameLibrary.Response.Util;

namespace GameLibrary.Response
{
    public class RetrieveCharacterResponse : IResponse
    {
        #region Required For JsonConverter
        public RetrieveCharacterResponse() { }
        private readonly ResponseType _ResponseType = ResponseType.CHARACTER_RETRIEVE;
        public ResponseType ResponseType { get { return _ResponseType; } }
        private readonly ResponseStatus _Status;
        public ResponseStatus Status { get { return _Status; } }
        #endregion

        private string _Message;
        public string Message { get { return _Message; } set { _Message = value; } }

        private SharedCharacter _Character;
        public SharedCharacter Character { get { return _Character; } set { _Character = value; } }

        public RetrieveCharacterResponse(ResponseStatus status, string message, SharedCharacter character) 
        { 
            _Status = status; _Message = message; _Character = character;
        }
    }
}
