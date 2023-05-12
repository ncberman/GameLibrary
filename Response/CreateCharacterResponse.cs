using GameLibrary.Model;
using GameLibrary.Response.Util;

namespace GameLibrary.Response
{
    public class CreateCharacterResponse : IResponse
    {
        #region Required For JsonConverter
        public CreateCharacterResponse() { }
        private readonly ResponseType _ResponseType = ResponseType.GREETING;
        public ResponseType ResponseType { get { return _ResponseType; } }
        private readonly ResponseStatus _Status;
        public ResponseStatus Status { get { return _Status; } }
        #endregion

        private string _Message;
        public string Message { get { return _Message; } set { _Message = value; } }

        private List<Character> _Characters;
        public List<Character> Characters { get { return _Characters; } set { _Characters = value; } }

        public CreateCharacterResponse(ResponseStatus status, string message, List<Character> characters) 
        { 
            _Status = status; _Message = message; _Characters = characters;
        }
    }
}
