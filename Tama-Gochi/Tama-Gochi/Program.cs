using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Tamagochi;
using System.Diagnostics;

namespace Tama_Gochi
{
    class Program
    {
        public delegate string Method();

        static System.Timers.Timer aTimer = new System.Timers.Timer(10000);

        static string HHello()
        {
            return "Hello";
        }
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Tamagocha kitti = new Tamagocha();
            kitti.Form();

            Method[] request = new Method[]
            { kitti.EEat, kitti.PPlay, kitti.SSleep, kitti.WWalk, kitti.TTreat };

            Method method = HHello;
            
            int life = 3;

            Random r = new Random();

            Stack<int> numbers = new Stack<int>();
            
            int temp = r.Next(4);
            numbers.Push(temp);
            
            for (int i = 0; i < 30; i++)
            {
                int tem = r.Next(4);
                if (tem == numbers.Peek())
                {
                    tem = r.Next(4);
                    temp = tem;
                    numbers.Push(temp);
                }
                else
                {
                    temp = tem;
                    numbers.Push(temp);
                }
            }

            Stopwatch st = new Stopwatch();
            Stopwatch st0 = new Stopwatch();
            Console.WriteLine($"LIFE = {life}");

            // 1 варіант - якщо тричі не задовільнив прохання - захворіває, якщо захворів і не полікували - помирає

            while (life > 0)
            {
                while (life > 1)
                {
                    int index = numbers.Pop();  //беремо випадковий індекс зі стеку
                    st.Start();         //старт таймера
                    method = request[index];    //випадковий запрос
                    string mes = method();      //створюємо текст запроса
                    var result = MessageBox.Show(mes, "Тамагочі Кітті", MessageBoxButtons.OKCancel);    //видає повідомлення
                    if (result == DialogResult.OK)  //якщо натиснули ОК
                    {
                        st.Stop();      //стоп таймер

                        if (st.ElapsedMilliseconds / 1000 > 2)  //якщо довго думали
                        {
                            Console.WriteLine($"Тамагочі може від такого захворіти! LIFE={life}");
                            life--; //мінус 1 життя
                        }
                        else    //якщо швидко думали
                        {
                            MessageBox.Show("Дякую!", "Тамагочі Кітті", MessageBoxButtons.OK);
                        }
                        st.Reset();
                    }
                    else    //якщо натиснули Отмена
                    {
                        life--;
                        st.Stop();      //або стоп 1
                        Console.WriteLine($"Тамагочі може від такого захворіти! LIFE={life}");
                        st.Reset();

                    }
                }

                //запуск лікування
                st0.Start();     //старт 2 таймера
                var result0 = MessageBox.Show(request[4](), "Тамагочі Кітті", MessageBoxButtons.OKCancel);

                if (result0 == DialogResult.OK)
                {
                    st0.Stop();  //стоп 2
                    if (st0.ElapsedMilliseconds / 1000 > 2)
                    {
                        life = 0;
                        Console.WriteLine("Тамагочі загинув!((");
                        return;
                    }

                    MessageBox.Show("Дякую!", "Тамагочі Кітті", MessageBoxButtons.OK);
                }
                else
                {
                    st0.Stop();
                    life = 0;
                    Console.WriteLine($"Тамагочі захворів, бо хтось ним не хотів піклуватись!!! LIFE={life}");
                }
                st0.Reset();
            }



            //2 варіант - якщо не задовільнив прохання - помирає, якщо довго думав -1 життя

            //while (life > 0)
            //{
            //    int index = numbers.Pop();
            //    st.Start();         //старт 1
            //    method = request[index];
            //    string mes = method();
            //    var result = MessageBox.Show(mes, "Тамагочі Кітті", MessageBoxButtons.OKCancel);
            //    if (result == DialogResult.OK)
            //    {
            //        st.Stop();      //стоп 1

            //        if (st.ElapsedMilliseconds / 1000 > 2)
            //        {
            //            st0.Start();     //старт 2
            //            var result0 = MessageBox.Show(request[4](), "Тамагочі Кітті", MessageBoxButtons.OKCancel);

            //            if (result0 == DialogResult.OK)
            //            {
            //                st0.Stop();  //стоп 2
            //                             //if (st0.ElapsedMilliseconds / 1000 > 2)
            //                             //{
            //                             //    life--;
            //                             //}
            //                MessageBox.Show("Дякую!", "Тамагочі Кітті", MessageBoxButtons.OK);
            //            }
            //            else
            //            {
            //                st0.Stop();
            //                Console.WriteLine($"Тамагочі захворів, бо хтось ним не хотів піклуватись!!! LIFE={life}");
            //            }
            //            st0.Reset();
            //            st.Stop();
            //            life--;
            //            Console.WriteLine($"Тамагочі захворів, бо хтось ним не хотів піклуватись!!! LIFE={life}");
            //        }
            //        else
            //        {
            //            MessageBox.Show("Дякую!", "Тамагочі Кітті", MessageBoxButtons.OK);
            //        }
            //        st.Reset();
            //    }
            //    else
            //    {
            //        st.Stop();      //або стоп 1
            //        Console.WriteLine("Тамагочі загинув, бо хтось ним не хотів піклуватись!!!");
            //        life = 0;
            //    }
            //}

            Console.WriteLine("Треба мати хоч грам совісті!\n");
        }
    }
}
