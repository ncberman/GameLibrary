using GameLibrary.Request;
using GameLibrary.Response.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Response
{
    public class ErrorResponse : IResponse
    {
        #region Required For JsonConverter
        public ErrorResponse() { }
        private readonly ResponseType _ResponseType = ResponseType.ERROR;
        public ResponseType ResponseType { get { return _ResponseType; } }
        private readonly ResponseStatus _Status;
        public ResponseStatus Status { get { return _Status; } }
        #endregion

        private string _Message;
        public string Message { get { return _Message; } set { _Message = value; } }

        public ErrorResponse(ResponseStatus status, string message) 
        { 
            _Status = status; _Message = message; 
        }
    }
}
