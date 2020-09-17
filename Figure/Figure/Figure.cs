namespace Figure
{
    public abstract class Figure
    {
        string _name;
        public Figure(string name)
        {
            _name = name;
        }
        public abstract void Square();
        public abstract double GetSquare();
        public abstract void Perimeter();
    }
}
