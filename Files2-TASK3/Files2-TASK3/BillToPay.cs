using System.Runtime.Serialization;

namespace Files2_TASK3
{
    [DataContract]
    public class BillToPay
    {
        public static bool FlagSerialize = true;      // Мітка серіалізації

        [DataMember]
        public string PaymentForDay { get; set; }       // Оплата за 1 день

        [DataMember]
        public string FullDayCount { get; set; }        // Кількість днів

        [DataMember]
        public string FineForDay { get; set; }          // Штраф за 1 день протермінування

        [DataMember]
        public string FineDayCount { get; set; }        // Кількість протермінованих днів

        [DataMember]
        public string SumPaymentNoFine { get; private set; }    // Сума до оплати без штрафа

        [DataMember]
        public string SumFine { get; private set; }             // Сума штрафа
        
        [DataMember]
        public string FullPaymentSum { get; private set; }      // Загальна сума до оплати

        public BillToPay()
        {
        }

        
        public BillToPay(string paymentForDay, string fullDayCount, string fineForDay, string fineDayCount)
        {
            PaymentForDay = paymentForDay;
            FullDayCount = fullDayCount;
            FineForDay = fineForDay;
            FineDayCount = fineDayCount;

            SumPaymentNoFine = (int.Parse(paymentForDay) * int.Parse(fullDayCount)).ToString();
            SumFine = (int.Parse(fineForDay) * int.Parse(fineDayCount)).ToString();
            FullPaymentSum = (int.Parse(SumPaymentNoFine) + int.Parse(SumFine)).ToString();
        }
        public override string ToString()
        {
            return "\nОплата за 1 день - " + PaymentForDay 
                + "\nКількість днів - " + FullDayCount 
                + "\nШтраф за 1 день протермінування - " + FineForDay 
                + "\nКількість протермінованих днів - " + FineDayCount 
                + "\nСума до оплати без штрафа - " + SumPaymentNoFine 
                + "\nСума штрафа - " + SumFine 
                + "\nЗагальна сума до оплати - " + FullPaymentSum;
        }

    }
}
