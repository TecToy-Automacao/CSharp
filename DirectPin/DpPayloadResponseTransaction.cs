using System.Text.Json.Serialization;

namespace DirectPin
{
    public class DpPayloadResponseTransaction
    {
        [JsonPropertyName("type")] public string Type { get; set; }
        [JsonPropertyName("result")] public bool Result { get; set; }
        [JsonPropertyName("message")] public string Message { get; set; }
        [JsonPropertyName("amount")] public long Amount { get; set; }
        [JsonPropertyName("nsu")] public string Nsu { get; set; }
        [JsonPropertyName("nsuAcquirer")] public string NsuAcquirer { get; set; }
        [JsonPropertyName("panMasked")] public string PanMasked { get; set; }
        [JsonPropertyName("date")] public long Date { get; set; }
        [JsonPropertyName("typeCard")] public string TypeCard { get; set; }
        [JsonPropertyName("finalResult")] public string FinalResult { get; set; }
        [JsonPropertyName("codeResult")] public int CodeResult { get; set; }
        [JsonPropertyName("receiptContent")] public string ReceiptContent { get; set; }

        public void Clear()
        {
            Type = string.Empty;
            Result = false;
            Message = string.Empty;
            Amount = 0;
            Nsu = string.Empty;
            NsuAcquirer = string.Empty;
            PanMasked = string.Empty;
            Date = 0;
            TypeCard = string.Empty;
            FinalResult = string.Empty;
            CodeResult = 0;
            ReceiptContent = string.Empty;
        }

        public string AsJson() => System.Text.Json.JsonSerializer.Serialize(this);
        public void FromJson(string json)
        {
            var obj = System.Text.Json.JsonSerializer.Deserialize<DpPayloadResponseTransaction>(json);
            if (obj != null)
            {
                Type = obj.Type;
                Result = obj.Result;
                Message = obj.Message;
                Amount = obj.Amount;
                Nsu = obj.Nsu;
                NsuAcquirer = obj.NsuAcquirer;
                PanMasked = obj.PanMasked;
                Date = obj.Date;
                TypeCard = obj.TypeCard;
                FinalResult = obj.FinalResult;
                CodeResult = obj.CodeResult;
                ReceiptContent = obj.ReceiptContent;
            }
        }
    }
}
