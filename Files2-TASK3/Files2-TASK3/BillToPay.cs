using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace Files2_TASK3
{
    [DataContract]
    class BillToPay
    {
        public static bool FlagSerialize = true;      // Мітка серіалізації




        // Пробую переробити з властивостей на змінні


        [DataMember]
        public string PaymentForDay;      // Оплата за 1 день

        [DataMember]
        public string FullDayCount;        // Кількість днів

        [DataMember]
        public string FineForDay;          // Штраф за 1 день протермінування

        [DataMember]
        public string FineDayCount;        // Кількість протермінованих днів

        public string SumPaymentNoFine;    // Сума до оплати без штрафа

        public string SumFine;             // Сума штрафа

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













        // Зроблено властивостями



        //[DataMember]
        //public string PaymentForDay { get; set; }       // Оплата за 1 день

        //[DataMember]
        //public string FullDayCount { get; set; }        // Кількість днів

        //[DataMember]
        //public string FineForDay { get; set; }          // Штраф за 1 день протермінування

        //[DataMember]
        //public string FineDayCount { get; set; }        // Кількість протермінованих днів

        //public string SumPaymentNoFine { get; private set; }    // Сума до оплати без штрафа

        //public string SumFine { get; private set; }             // Сума штрафа

        //public string FullPaymentSum { get; private set; }      // Загальна сума до оплати

        //public BillToPay()
        //{
        //}

        //public BillToPay(string paymentForDay, string fullDayCount, string fineForDay, string fineDayCount)
        //{
        //    PaymentForDay = paymentForDay;
        //    FullDayCount = fullDayCount;
        //    FineForDay = fineForDay;
        //    FineDayCount = fineDayCount;

        //    SumPaymentNoFine = (int.Parse(paymentForDay) * int.Parse(fullDayCount)).ToString();
        //    SumFine = (int.Parse(fineForDay) * int.Parse(fineDayCount)).ToString();
        //    FullPaymentSum = (int.Parse(SumPaymentNoFine) + int.Parse(SumFine)).ToString();
        //}
        public override string ToString()
        {
            return "\nСума до оплати без штрафа " + SumPaymentNoFine 
                + "\nСума штрафа " + SumFine + "\nЗагальна сума до оплати " + FullPaymentSum;
        }

        //[OnSerializing]
        //public void ToSerializeWhenFalse()
        //{
        //    SumPaymentNoFine = SumPaymentNoFine.Replace(SumPaymentNoFine,"-----------------");
        //    SumFine = SumFine.Replace(SumFine, "-----------------");
        //    FullPaymentSum = FullPaymentSum.Replace(FullPaymentSum, "-----------------");
        //}

        //[OnDeserialized]
        //public void ToDeserializeWhenFalse()
        //{
        //    this.SumPaymentNoFine = SumPaymentNoFine;
        //    this.SumFine = SumFine;
        //    this.FullPaymentSum = FullPaymentSum;
        //}




    }
}
