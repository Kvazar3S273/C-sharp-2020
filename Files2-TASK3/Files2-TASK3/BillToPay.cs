using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace Files2_TASK3
{
    [Serializable]
    class BillToPay
    {
        public static bool FlagSerialize = true;      // Мітка серіалізації
        
        [XmlElement]
        public string PaymentForDay { get; set; }       // Оплата за 1 день
        
        [XmlElement]
        public string FullDayCount { get; set; }        // Кількість днів
        
        [XmlElement]
        public string FineForDay { get; set; }          // Штраф за 1 день протермінування
        
        [XmlElement]
        public string FineDayCount { get; set; }        // Кількість протермінованих днів

        [XmlElement]
        public string SumPaymentNoFine { get; set; }    // Сума до оплати без штрафа
        
        [XmlElement]
        public string SumFine { get; set; }             // Сума штрафа
        
        [XmlElement]
        public string FullPaymentSum { get; set; }      // Загальна сума до оплати

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
