using System;
namespace Task2
{
    public class Engineer : Persona, ITask1
    {
        public string Name { get; set; }
        public int Stag_Rob { get; set; }
        public string _Role { get; set; }
        public double Salary { get; set; }

        public Engineer(string n, int s, string r, double sal)
        {
            Name = n;
            Stag_Rob = s;
            _Role = r;
            Salary = sal;
        }

        public string Role()
        {
            return _Role;
        }
        public double Zarplata()
        {
            return Salary;
        }
    }
}

