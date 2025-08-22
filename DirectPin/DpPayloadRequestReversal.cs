using System.Text.Json.Serialization;

namespace DirectPin
{
    public class DpPayloadRequestReversal
    {
        [JsonPropertyName("type")] public string Type { get; set; } = "cancelTransaction";
        [JsonPropertyName("nsu")] public string Nsu { get; set; }

        public void Clear()
        {
            Type = "cancelTransaction";
            Nsu = string.Empty;
        }

        public string AsJson() => System.Text.Json.JsonSerializer.Serialize(this);
        public void FromJson(string json)
        {
            var obj = System.Text.Json.JsonSerializer.Deserialize<DpPayloadRequestReversal>(json);
            if (obj != null)
            {
                Type = obj.Type;
                Nsu = obj.Nsu;
            }
        }
    }
}
