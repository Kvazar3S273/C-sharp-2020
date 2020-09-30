using System;

namespace Parking
{
    public enum Brands { Volvo, Skoda, Lexus, Iveco, Honda, Dodge, Tesla, Smart, Dacia, Mazda }
    public enum Numbers { AA, AB, BB, BC, CD, BD, EF, FF, DR, RA }
    public enum Colors { сірий, чорний, білий, жовтий, синій, срібний }

    class Car
    {
        private string brand;
        private string number;
        private string color;
        private Timer timer = new Timer();
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
        public Timer GetTimer()
        {
            return this.timer;
        }

        public Car()
        {
            Random rnd = new Random();

            int num = rnd.Next(0, 4);   //генеруємо порядковий номер, по якому будемо з Енама брати перші літери для номера
            string letterFirst = Enum.GetName(typeof(Numbers), num);    //отримуємо перші дві літери
            num = rnd.Next(5, 9);   //генеруємо порядковий номер, по якому будемо з Енама брати останні літери для номера
            string letterEnd = Enum.GetName(typeof(Numbers), num);      //отримуємо останні дві літери
            int RNDnumber = rnd.Next(100, 999);                         //генеруємо цифри номера
            this.number = letterFirst + "-" + RNDnumber + "-" + letterEnd;  //з"єднуємо докупи літери і цифри

            num = rnd.Next(0, 9);   //генеруємо порядковий номер, по якому будемо з Енама брати марку авто
            this.brand = Enum.GetName(typeof(Brands), num);        //отримуємо марку авто

            num = rnd.Next(0, 5);   //генеруємо порядковий номер, по якому будемо з Енама брати колір авто
            this.color = Enum.GetName(typeof(Colors), num);         //отримуємо колір авто

        }
    }
}
