using System;
namespace Task1
{
    public interface ITask
    {
        public double Zarplata();
        public string Role();
        public string Name { get; set; }
        public int Stag_Rob { get; set; }
    }
}

