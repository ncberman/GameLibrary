﻿using GameLibrary.Response.Util;

namespace GameLibrary.Response
{
    public class GreetingResponse : IResponse
    {
        #region Required For JsonConverter
        public GreetingResponse() { }
        private readonly ResponseType _ResponseType = ResponseType.GREETING;
        public ResponseType ResponseType { get { return _ResponseType; } }
        private readonly ResponseStatus _Status;
        public ResponseStatus Status { get { return _Status; } }
        #endregion

        private string _Message;
        public string Message { get { return _Message; } set { _Message = value; } }

        public GreetingResponse(ResponseStatus status, string message) 
        {
            _Status = status; _Message = message; 
        }
    }
}
