using System;

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
        private TimeSpan OverdueTime;        //штрафний час
        private double overpay;              //штраф
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

        public TimeSpan GetPayTime()
        {
            return this.PayTime;
        }

        public int GetMinutesPayTime()      //обрахунок оплачених хвилин паркування
        {
            return this.PayTime.Days * 1440 + this.PayTime.Hours * 60 + this.PayTime.Minutes;
        }

        public TimeSpan GetOverdueTime()
        {
            return this.OverdueTime;
        }
        public int GetMinutesOverdueTime()  //обрахунок штрафних хвилин
        {
            return this.OverdueTime.Days * 1440 + this.OverdueTime.Hours * 60 + this.OverdueTime.Minutes;
        }
        public double GetOverpay()          //обрахунок штрафу за протерміновані години по тарифу
        {
            int days = this.OverdueTime.Days;
            int hours = this.OverdueTime.Hours;
            int minutes = this.OverdueTime.Minutes;

            if (this.OverdueTime.Minutes > 0)
            {
                hours++;
                overpay = (days * 24 + hours + minutes / 60 - 1) * OverPayNextHour + OverPayFirstHour;
            }
            else
            {
                overpay = (days * 24 + hours + minutes / 60 - 1) * OverPayNextHour + OverPayFirstHour;
            }
            return this.overpay;
        }

        public Ticket(Car car)          //конструктор класу квитка
        {
            this.brand = car.GetBrand();
            this.number = car.GetNumber();
            this.color = car.GetColor();
            this.ToParkingTime = car.GetTimer().GetTimeToParking();
            this.FromParkingTime = car.GetTimer().GetTimeFromParking();
            this.PayTime = car.GetTimer().GetPayTime();
            this.OverdueTime = car.GetTimer().GetOverdueTime();
            this.parkerName = Parker.parkerName;
        }
        public void ShowTicket()        //друкуємо квиток
        {
            Console.WriteLine("======================================");
            Console.WriteLine();
            Console.WriteLine("       ТОВ \"АЛЬЯНС-ПАРКІНГ\"          ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("             ПАРКОВКА                ");
            Console.ResetColor();
            Console.WriteLine("    м.Рівне, вул. Степова, 20        ");
            Console.WriteLine($"  Паркувальник: {parkerName}");
            Console.WriteLine("                                   ");
            Console.WriteLine($"  Автомобіль: {brand}\t            ");
            Console.WriteLine($"  Колір: {color}\t            ");
            Console.WriteLine($"  Держ. номер: {number}");
            Console.WriteLine($"  Час заїзду: {ToParkingTime}");
            Console.WriteLine($"  Час виїзду: {FromParkingTime}");
            Console.WriteLine($"  Оплачений час: {PayTime} = {GetMinutesPayTime()} хв");
            Console.WriteLine($"  Штрафний час: {OverdueTime} = {GetMinutesOverdueTime()} хв");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"  Штраф: {GetOverpay()} грн");
            Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine($"    Дата: {FromParkingTime}");
            Console.WriteLine();
            Console.WriteLine("======================================");
        }
        static public int OverPayFirstHour { get; set; } = 25;  //тариф за штрафну першу годину
        static public int OverPayNextHour { get; set; } = 10;   //тариф за штрафну кожну наступну годину

    }
}
