using System.Text.Json.Serialization;

namespace DirectPin
{
    public class DpPayloadRequestTransaction
    {
        [JsonPropertyName("type")] public string Type { get; set; } = "transaction";
        [JsonPropertyName("amount")] public long Amount { get; set; }
        [JsonPropertyName("typeTransaction")] public string TypeTransaction { get; set; }
        [JsonPropertyName("creditType")] public string CreditType { get; set; }
        [JsonPropertyName("installment")] public int Installment { get; set; }
        [JsonPropertyName("isTyped")] public bool IsTyped { get; set; }
        [JsonPropertyName("isPreAuth")] public bool IsPreAuth { get; set; }
        [JsonPropertyName("interestType")] public string InterestType { get; set; }
        [JsonPropertyName("printReceipt")] public bool PrintReceipt { get; set; }

        public void Clear()
        {
            Amount = 0;
            TypeTransaction = "NONE";
            CreditType = "NO_INSTALLMENT";
            Installment = 0;
            IsTyped = false;
            IsPreAuth = false;
            InterestType = "MERCHANT";
            PrintReceipt = false;
        }

        public string AsJson() => System.Text.Json.JsonSerializer.Serialize(this);
        public void FromJson(string json)
        {
            var obj = System.Text.Json.JsonSerializer.Deserialize<DpPayloadRequestTransaction>(json);
            if (obj != null)
            {
                Type = obj.Type;
                Amount = obj.Amount;
                TypeTransaction = obj.TypeTransaction;
                CreditType = obj.CreditType;
                Installment = obj.Installment;
                IsTyped = obj.IsTyped;
                IsPreAuth = obj.IsPreAuth;
                InterestType = obj.InterestType;
                PrintReceipt = obj.PrintReceipt;
            }
        }
    }
}
