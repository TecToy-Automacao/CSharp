using System;

namespace DirectPin
{
    public static class Mappers
    {
        public static string TypeTransactionToString(DpTypeTransaction t) => t.ToString().ToUpperInvariant();
        public static DpTypeTransaction StringToTypeTransaction(string s) =>
            Enum.TryParse<DpTypeTransaction>(s, true, out var r) ? r : DpTypeTransaction.NONE;

        public static string CreditTypeToString(DpCreditType t) => t == DpCreditType.INSTALLMENT ? "INSTALLMENT" : "NO_INSTALLMENT";
        public static DpCreditType StringToCreditType(string s) =>
            s.Trim().ToUpper() == "INSTALLMENT" ? DpCreditType.INSTALLMENT : DpCreditType.NO_INSTALLMENT;

        public static string InterestTypeToString(DpInterestType t) => t == DpInterestType.ISSUER ? "ISSUER" : "MERCHANT";
        public static DpInterestType StringToInterestType(string s) =>
            s.Trim().ToUpper() == "ISSUER" ? DpInterestType.ISSUER : DpInterestType.MERCHANT;
    }
}
