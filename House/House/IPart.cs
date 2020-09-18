using System;

namespace HouseBuilding
{
    public interface IPart
    {
        string Name { get; set; }   //назва частини, задається ззовні
        
        bool IsReady { get; set; }  //статус готовності частини - заповнюється робітником у методі DoWork
    }

    //Фундамент
    public enum BasementType    //тип фундамента
    { 
        String,
        Complex, 
        Column, 
        Solid, 
        Weld 
    }

    public class Basement : IPart
    {
        public BasementType Type { get; set; }

        public string Name { get; set; }
        public bool IsReady { get; set; }
    }

    //Стіна
    public class Wall : IPart   
    {
        public string Name { get; set; }
        public bool IsReady { get; set; }
    }

    //Вікно
    public class Window : IPart
    {
        public string Name { get; set; }
        public bool IsReady { get; set; }
    }

    //Двері
    public enum DoorType    //тип дверей
    { 
        Glass, 
        Metal, 
        Wood, 
        Profile 
    }

    public class Door : IPart
    {
        public DoorType Type { get; set; }

        public string Name { get; set; }
        public bool IsReady { get; set; }
    }

    //Дах
    public class Roof : IPart
    {
        public string Name { get; set; }
        public bool IsReady { get; set; }
    }

    public class House : IPart
    {
        public string Name { get; set; }    //назва будинку
        
        public bool IsReady { get; set; }   //готовність будинку - заповнюється бригадиром, якщо усі частини будинку готові

        //перелік частин будинку
        public Basement Basement { get; set; }

        public Wall Wall1 { get; set; }
        public Wall Wall2 { get; set; }
        public Wall Wall3 { get; set; }
        public Wall Wall4 { get; set; }

        public Door Door { get; set; }

        public Window Window1 { get; set; }
        public Window Window2 { get; set; }
        public Window Window3 { get; set; }
        public Window Window4 { get; set; }

        public Roof Roof { get; set; }

        //масив усіх частин будинку
        public IPart[] Parts
        {
            get
            {
                return new IPart[]
                {
                    Basement,
                    Wall1,
                    Wall2,
                    Wall3,
                    Wall4,
                    Door,
                    Window1,
                    Window2,
                    Window3,
                    Window4,
                    Roof,
                };
            }
        }

        public bool Validate()  //перевіряємо проект, щоб у ньому було все заповнено
        {
            foreach (var part in Parts)
            {
                if (part == null)
                {
                    Console.WriteLine("Проект будинку не завершений!");
                    return false;
                }
            }

            return true;
        }
    }
}
