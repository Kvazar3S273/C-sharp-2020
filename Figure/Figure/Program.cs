using System;

namespace Figure
{

    class Program
    {
        static void Main(string[] args)
        {
            Triangle tr = new Triangle("Trip",20,15,12);    //створюємо трикутник
            tr.Perimeter();                                 //виводимо його периметр
            tr.Square();                                    //виводимо площу
            Console.WriteLine();
            Quadrate qua = new Quadrate("Quadro", 17);      //квадрат
            qua.Perimeter();
            qua.Square();
            Console.WriteLine();
            Rhomb rh = new Rhomb("Diamond", 30, 40);        //ромб
            rh.Perimeter();
            rh.Square();
            Console.WriteLine();
            Rectangle rect = new Rectangle("Rect", 18, 25); //прямокутник
            rect.Perimeter();
            rect.Square();
            Console.WriteLine();
            Parallelogram par = new Parallelogram("Paralel", 10, 35, 45);   //паралелограм
            par.Perimeter();
            par.Square();
            Console.WriteLine();
            Trapeze trap = new Trapeze("Tramp", 20, 30, 18, 22);    //трапеція
            trap.Perimeter();
            trap.Square();
            Console.WriteLine();
            Circle cr = new Circle("Ring", 10);             //круг
            cr.Perimeter();
            cr.Square();
            Console.WriteLine();
            Ellipse el = new Ellipse("Elli", 11, 22);       //еліпс
            el.Perimeter();
            el.Square();
            Console.WriteLine();
            
            Figure[] arr = new Figure [3] ;                 //складена фігура - масив простих фігур
            
            arr[0] = new Rectangle("Re", 18, 25);
            arr[1] = new Triangle("Tri", 15, 15, 14);
            arr[2] = new Rhomb("Rho", 30, 40);

            Polygon pol = new Polygon("Polli");             //створюємо об"єкт класу Полігон (складена фігура)

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Square of figure [{i}] = {arr[i].GetSquare()}");
            }
            
            Console.WriteLine($"Square of poligon = {pol.Square(arr)}");    //виводимо площу складеної фігури

            Console.WriteLine();
        }
    }
}
