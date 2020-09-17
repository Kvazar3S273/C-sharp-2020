using System;

namespace Figure
{

    class Program
    {
        static void Main(string[] args)
        {
            Triangle tr = new Triangle("Trip",20,15,32);
            tr.Perimeter();
            tr.Square();
            Console.WriteLine();
            Quadrate qua = new Quadrate("Quadro", 17);
            qua.Perimeter();
            //qua.Square();

        }
    }
}
