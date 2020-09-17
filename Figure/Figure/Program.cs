using System;

namespace Figure
{

    class Program
    {
        static void Main(string[] args)
        {
            Triangle tr = new Triangle("Trip",20,15,12);
            tr.Perimeter();
            tr.Square();
            Console.WriteLine();
            Quadrate qua = new Quadrate("Quadro", 17);
            qua.Perimeter();
            qua.Square();
            Console.WriteLine();
            Rhomb rh = new Rhomb("Diamond", 30, 40);
            rh.Perimeter();
            rh.Square();
            Console.WriteLine();
            Rectangle rect = new Rectangle("Rect", 18, 25);
            rect.Perimeter();
            rect.Square();
            Console.WriteLine();
            Parallelogram par = new Parallelogram("Paralel", 10, 35, 45);
            par.Perimeter();
            par.Square();
            Console.WriteLine();
            Trapeze trap = new Trapeze("Trap", 20, 30, 18, 22);
            trap.Perimeter();
            trap.Square();
            Console.WriteLine();
            Circle cr = new Circle("Ring", 10);
            cr.Perimeter();
            cr.Square();
            Console.WriteLine();
            Ellipse el = new Ellipse("Elli", 11, 22);
            el.Perimeter();
            el.Square();
            Console.WriteLine();


            //--------------доробити--------------
            Figure[] arr = new Figure [3] ;
            arr[0] = new Rectangle("Re", 18, 25);
            arr[1] = new Triangle("Tri", 20, 15, 12);
            arr[2] = new Rhomb("Rho", 30, 40);

            Polygon pol = new Polygon("Polli");
            pol.Square(arr);

            Console.WriteLine();
        }
    }
}
