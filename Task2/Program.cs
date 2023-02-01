namespace Task2
{
    /*Модифікувати завдання 1, створивши ієрархію інтерфейсів
    (по одному методу в кожному). Реалізувати методи і
    властивості інтерфейсу у похідних класах Робочий, Інженер
    базового класу Персона.*/

    class Program
    {
        static void Main(string[] args)
        {
            Engineer engineer = new Engineer("Tom", 10, "слюсар", 3000);
            Console.WriteLine(engineer.Role());
            Console.WriteLine(engineer.Zarplata());

            Worker worker = new Worker("Bob", 15, "слюсар", 3500);
            Console.WriteLine(worker.Role());
            Console.WriteLine(worker.Zarplata());
        }
    }
}
