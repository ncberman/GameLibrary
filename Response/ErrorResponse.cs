using GameLibrary.Request;
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
        #endregion

        private string _Message;
        public string Message { get { return _Message; } set { _Message = value; } }

        public ErrorResponse(string message) { _Message = message; }
    }
}
