namespace Task3;

/*Створити ієрархію класів Банківський рахунок,
Поточний, Депозитний. Розробити інтерфейс з двома
методами: Новий_рахунок(), Видалити_рахунок(). Реалізувати
інтерфейсні методи в базовому класі. В похідних класах
викликати ці методи та реалізувати методи: Поповнити
рахунок(), Зняти_з рахунку(). В програмі організувати роботу з
рахунками.*/


class Program
{
    static void TestAccounts()
    {
        Account myAccount = new Account("test");
        myAccount.putMoney(6000);
        myAccount.getMoney(2500);
        myAccount.putMoney(1000);
        myAccount.getMoney(4000);
        myAccount.getMoney(1000);
    }

    static void Main(string[] args)
    {
        TestAccounts();
    }
}

