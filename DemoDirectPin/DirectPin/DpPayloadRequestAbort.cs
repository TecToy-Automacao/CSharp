using System.Text.Json.Serialization;

namespace DirectPin
{
    public class DpPayloadRequestAbort
    {
        [JsonPropertyName("type")] public string Type { get; set; } = "abort";

        public void Clear()
        {
            Type = "abort";
        }

        public string AsJson() => System.Text.Json.JsonSerializer.Serialize(this);

        public void FromJson(string json)
        {
            var obj = System.Text.Json.JsonSerializer.Deserialize<DpPayloadRequestAbort>(json);
            if (obj != null)
            {
                Type = obj.Type;
            }
        }
    }
}
