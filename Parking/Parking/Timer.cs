using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    class Timer
    {
        public DateTime ToParkingTime;      //час заїзду на парковку
        public DateTime FromParkingTime;    //час виїзду з парковки
        public TimeSpan PayTime;            //оплачений час
        public TimeSpan OverdueTime;        //штрафний час
        Random rnd = new Random();
        public Timer()
        {
            DateTime rangeStartIn = new DateTime(2020, 7, 2, 10, 15, 3);    //початок діапазону дат заїзду на парковку
            DateTime rangeEndIn = new DateTime(2020, 7, 10, 23, 59, 0);     //кіннець діапазону дат заїзду
            DateTime rangeStartOut = new DateTime(2020, 7, 11, 9, 12, 1);   //початок діапазону дат виїзду з парковки
            DateTime rangeEndOut = new DateTime(2020, 7, 30, 22, 16, 50);   //кіннець діапазону дат виїзду

            TimeSpan spanIn = rangeEndIn - rangeStartIn;                    //проміжок діапазону для заїзду
            int randomMinutes = rnd.Next(0, (int)spanIn.TotalMinutes);      //генеруємо випадкову к-сть хвилин
            
            //----------рандомний час заїзду на парковку:
            this.ToParkingTime = rangeStartIn + TimeSpan.FromMinutes(randomMinutes); //додаємо її до початку діапазону часу заїзду

            TimeSpan spanOut = rangeEndOut - rangeStartOut;                 //проміжок діапазону для виїзду
            randomMinutes = rnd.Next(0, (int)spanOut.TotalMinutes);         //генеруємо випадкову к-сть хвилин
            
            //----------рандомний час виїзду з парковки:
            this.FromParkingTime = rangeStartOut + TimeSpan.FromMinutes(randomMinutes); //додаємо її до початку діапазону часу виїзду

            this.PayTime = TimeSpan.FromMinutes(rnd.Next(120, 1440));       //генеруємо оплачений час
        }
        public TimeSpan GetOverdueTime()        //визначаємо штрафний час
        {
            TimeSpan OverdueTime = this.FromParkingTime - this.ToParkingTime - this.PayTime;
            return OverdueTime;
        }

        public DateTime GetTimeToParking()
        {
           return ToParkingTime;
        }
        public DateTime GetTimeFromParking()
        {
            return FromParkingTime;
        }
        public TimeSpan GetPayTime()
        {
            return PayTime;
        }
    }
}
