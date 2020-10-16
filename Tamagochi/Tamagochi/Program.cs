using System;
using System.Collections;
using System.Text;

namespace Tamagochi
{
    class Program
    {
        public delegate void Method();

        //public void Hashtable(int key, Tamagocha meth)
        //{

        //}
        static void Hello()
        {
            Console.WriteLine("Hello");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Tamagocha kitti = new Tamagocha();
            kitti.Form();

            Method method = Hello;

            Method[] request = new Method[]
            { kitti.Eat, kitti.Play, kitti.Sleep, kitti.Treat, kitti.Walk };

            method();

            method = request[1];
            method();
            method = request[4];
            method();

            


        }
    }
}
