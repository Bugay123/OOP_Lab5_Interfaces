using System;
namespace Task2
{
    public class Worker:Persona,ITask2
    {
        public string Name { get; set; }
        public int Stag_Rob { get; set; }
        public string _Role { get; set; }
        public double Salary { get; set; }

        public Worker(string n, int s, string r, double zar)
        {
            Name = n;
            Stag_Rob = s;
            _Role = r;
            Salary = zar;
        }


        public string Role() { return _Role; }
        public double Zarplata() { return Salary; }
    }
}

