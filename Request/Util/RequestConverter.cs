using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GameLibrary.Request.Util
{
    public class RequestConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IRequest);
        }
        public override void WriteJson(JsonWriter writer,
            object value, JsonSerializer serializer)
        {
            throw new InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader,
            Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var request = default(IRequest);
            var requestTypeStr = jsonObject["RequestType"]?.Value<string>();
            var requestType = (RequestType)Enum.Parse(typeof(RequestType), requestTypeStr);
            switch (requestType)
            {
                case RequestType.GREETING:
                    request = new GreetingRequest();
                    break;
                case RequestType.CHARACTER_CREATE:
                    request = new CreateCharacterRequest();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), request);
            return request;
        }
    }
}
