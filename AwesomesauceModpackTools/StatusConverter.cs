using System;
using Newtonsoft.Json;

namespace AwesomesauceModpackTools {

    public class StatusConverter : JsonConverter {

        public override bool CanConvert(Type objectType) {
            return objectType == typeof(string);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
            string enumString = (string)reader.Value;
            Status? status = null;
            switch (enumString) {
                case "":
                    status = Status._Blank;
                    break;

                case "Accepted":
                    status = Status.Accepted;
                    break;

                case "OnHold":
                    status = Status.OnHold;
                    break;

                case "Rejected":
                    status = Status.Rejected;
                    break;

                case "Testing":
                    status = Status.Testing;
                    break;

                default:
                    status = Status._Blank;
                    break;
            }

            return status;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
            Status status = (Status)value;
            switch (status) {
                case Status._Blank:
                    writer.WriteValue("_Blank");
                    break;

                case Status.Accepted:
                    writer.WriteValue("Accepted");
                    break;

                case Status.OnHold:
                    writer.WriteValue("OnHold");
                    break;

                case Status.Rejected:
                    writer.WriteValue("Rejected");
                    break;

                case Status.Testing:
                    writer.WriteValue("Testing");
                    break;
            }
        }

    }
}
