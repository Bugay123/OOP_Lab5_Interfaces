namespace Task1
{
    /*Створити інтерфейс з двома методами: Zarplata() I Role() та
    шаблонами властивостей Name, Stag_Rob. Реалізувати методи
    і властивості інтерфейсу у похідних класах Робочий, Інженер
    базоаого класу Персона. Оголошення класів розмістити в
    окремих файлах.*/

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