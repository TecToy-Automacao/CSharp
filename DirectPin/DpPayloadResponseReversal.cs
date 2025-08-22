using System.Text.Json.Serialization;

namespace DirectPin
{
    public class DpPayloadResponseReversal
    {
        [JsonPropertyName("type")] public string Type { get; set; }
        [JsonPropertyName("result")] public bool Result { get; set; }
        [JsonPropertyName("message")] public string Message { get; set; }
        [JsonPropertyName("receiptContent")] public string ReceiptContent { get; set; }

        public void Clear()
        {
            Type = string.Empty;
            Result = false;
            Message = string.Empty;
            ReceiptContent = string.Empty;
        }

        public string AsJson() => System.Text.Json.JsonSerializer.Serialize(this);
        public void FromJson(string json)
        {
            var obj = System.Text.Json.JsonSerializer.Deserialize<DpPayloadResponseReversal>(json);
            if (obj != null)
            {
                Type = obj.Type;
                Result = obj.Result;
                Message = obj.Message;
                ReceiptContent = obj.ReceiptContent;
            }
        }
    }
}
