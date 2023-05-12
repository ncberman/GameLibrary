using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GameLibrary.Response.Util
{
    public class ResponseConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IResponse);
        }
        public override void WriteJson(JsonWriter writer,object value, JsonSerializer serializer)
        {
            throw new InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var response = default(IResponse);
            var responseTypeStr = jsonObject["ResponseType"]?.Value<string>();
            var responseType = (ResponseType)Enum.Parse(typeof(ResponseType), responseTypeStr);
            switch (responseType)
            {
                case ResponseType.ERROR:
                    response = new ErrorResponse();
                    break;
                case ResponseType.GREETING:
                    response = new GreetingResponse();
                    break;
                case ResponseType.CHARACTER_CREATE:
                    response = new CreateCharacterResponse();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), response);
            return response;
        }
    }
}
