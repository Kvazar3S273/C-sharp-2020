﻿using System;
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

        public TimeSpan GetOverdueTime()
        {
            return this.OverdueTime;
        }

        public double GetOverpay()
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

        public Ticket(Car car)
        {
            this.brand = car.GetBrand();
            this.number = car.GetNumber();
            this.color = car.GetColor();
            this.ToParkingTime = car.GetTimer().GetTimeToParking();
            this.FromParkingTime = car.GetTimer().GetTimeFromParking();
            this.PayTime = car.GetTimer().GetPayTime();
            this.OverdueTime = car.GetTimer().GetOverdueTime();
            //this.parkerName = Parker.parkerName;
        }
        public void ShowTicket()
        {
            Console.WriteLine("==================================");
            Console.WriteLine();
            Console.WriteLine("       ТОВ \"АЛЬЯНС-ПАРКІНГ\"          ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("             ПАРКОВКА                ");
            Console.ResetColor();
            Console.WriteLine("    м.Рівне, вул. Степова, 20        ");
            //Console.WriteLine($"Паркувальник: {parkerName}");
            Console.WriteLine("                                   ");
            Console.WriteLine($"  Автомобіль: {brand}\t            ");
            Console.WriteLine($"  Колір: {color}\t            ");
            Console.WriteLine($"  Держ. номер: {number}");
            Console.WriteLine($"  Час заїзду: {ToParkingTime}");
            Console.WriteLine($"  Час виїзду: {FromParkingTime}");
            Console.WriteLine($"  Оплачений час: {PayTime}");
            Console.WriteLine($"  Штрафний час: {OverdueTime}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"  Штраф: {GetOverpay()} грн");
            Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine($"    Дата: {FromParkingTime}");
            Console.WriteLine();
            Console.WriteLine("==================================");
        }
        static public int OverPayFirstHour { get; set; } = 25;
        static public int OverPayNextHour { get; set; } = 10;

    }
}
