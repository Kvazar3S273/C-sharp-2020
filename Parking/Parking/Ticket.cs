using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    class Ticket
    {
        private string brand;
        private string number;
        private string color;
        private DateTime ToParkingTime;      //час заїзду на парковку
        private DateTime FromParkingTime;    //час виїзду з парковки
        private TimeSpan PayTime;            //оплачений час
        private TimeSpan Overdue_Time;        //штрафний час
        private double overpay;                 //штраф
        private string parkerName;           //ім"я паркувальника

        public string GetParkerName()
        {
            return this.parkerName;
        }
        public string GetBrand()
        {
            return this.brand;
        }

        public string GetNumber()
        {
            return this.number;
        }
        public string GetColor()
        {
            return this.color;
        }

        public DateTime GetToParkingTime()
        {
            return this.ToParkingTime;
        }

        public DateTime GetFromParkingTime()
        {
            return this.FromParkingTime;
        }

        public TimeSpan Get_PayTime()
        {
            return this.PayTime;
        }

        public TimeSpan Get_OverdueTime()
        {
            return this.Overdue_Time;
        }

        public double GetOverpay()
        {
            return this.overpay;
        }
        //public double odt; //повна кількість протермінованих годин (в годинах)
        public Ticket(Car car)
        {
            this.brand = car.GetBrand();
            this.number = car.GetNumber();
            this.color = car.GetColor();
            this.ToParkingTime = car.GetTimer().GetTimeToParking();
            this.FromParkingTime = car.GetTimer().GetTimeFromParking();
            this.PayTime = car.GetTimer().GetPayTime();
            this.Overdue_Time = car.GetTimer().GetOverdueTime();


            //this.parkerName = Parker.parkerName;

            //int days = OverdueTime.Days;
            //int hours = OverdueTime.Hours;
            //int minutes = OverdueTime.Minutes;

            //this.overpay = (OverdueTime.Days * 24 + OverdueTime.Hours + OverdueTime.Minutes / 60 - 1) * OverPayNextHour + OverPayFirstHour;

            //odt = OverdueTime.ToString();

            //int ODT = int.Parse(odt);
            //this.overpay = ODT;

            
        }
        public void ShowTicket()
        {
            Console.WriteLine($"протерміновано днів: {Overdue_Time.Days}");
            Console.WriteLine($"протерміновано годин: {Overdue_Time.Hours}");
            Console.WriteLine($"протерміновано хвилин: {Overdue_Time.Minutes}");
            //Console.WriteLine($"штраф = {this.overpay} грн");
        }
        static public int OverPayFirstHour { get; set; } = 25;
        static public int OverPayNextHour { get; set; } = 10;

    }
}
