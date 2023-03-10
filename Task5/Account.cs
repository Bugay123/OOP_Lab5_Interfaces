using System;
namespace Task3
{
    abstract class Account : IEditAccount
    {
        public abstract void AddAccount();

        public abstract void DellAccount();
    }

    class Depo : Account
    {
        int debit = 0, credit = 0, balance = 0;
        int sum = 0, result = 0;

        public void putMoney(int sum)
        {
            this.sum = sum;
            if (sum > 0)
            {
                credit += sum; balance = credit - debit; result = 1;
            }
            else result = -1;
            Mes();
        }
        public void getMoney(int sum)
        {
            this.sum = sum;
            if (sum <= balance)
            {
                debit += sum; balance = credit - debit; result = 2;
            }
            else result = -2;
            Mes();
        }
        void Mes()
        {
            switch (result)
            {
                case 1:
                    Console.WriteLine("Операция зачисления денег прошла успешно!");
                    Console.WriteLine($"Cумма = {sum},Ваш текущий баланс = {balance}");
                    break;
                case 2:
                    Console.WriteLine("Операция снятия денег прошла успешно!");
                    Console.WriteLine($"Cумма = {sum},Ваш текущий баланс = {balance}");
                    break;
                case -1:
                    Console.WriteLine("Операция зачисления денег не выполнена!");
                    Console.WriteLine("Сумма должна быть больше нуля!");
                    Console.WriteLine($"Cумма = {sum},Ваш текущий баланс = {balance}");
                    break;
                case -2:
                    Console.WriteLine("Операция снятия денег не выполнена!");
                    Console.WriteLine("Сумма должна быть не больше баланса!");
                    Console.WriteLine($"Cумма = {sum},Ваш текущий баланс = {balance}");
                    break;
                default:
                    Console.WriteLine("Неизвестная операция!");
                    break;
            }
        }

        public override void AddAccount()
        {
            Console.WriteLine("Add acc");
        }

        public override void DellAccount()
        {
            Console.WriteLine("Del acc");
        }
    }
    class Flow : Account
    {
        int debit = 0, credit = 0, balance = 0;
        int sum = 0, result = 0;

        public void putMoney(int sum)
        {
            this.sum = sum;
            if (sum > 0)
            {
                credit += sum; balance = credit - debit; result = 1;
            }
            else result = -1;
            Mes();
        }
        public void getMoney(int sum)
        {
            this.sum = sum;
            if (sum <= balance)
            {
                debit += sum; balance = credit - debit; result = 2;
            }
            else result = -2;
            Mes();
        }
        void Mes()
        {
            switch (result)
            {
                case 1:
                    Console.WriteLine("Операция зачисления денег прошла успешно!");
                    Console.WriteLine($"Cумма = {sum},Ваш текущий баланс = {balance}");
                    break;
                case 2:
                    Console.WriteLine("Операция снятия денег прошла успешно!");
                    Console.WriteLine($"Cумма = {sum},Ваш текущий баланс = {balance}");
                    break;
                case -1:
                    Console.WriteLine("Операция зачисления денег не выполнена!");
                    Console.WriteLine("Сумма должна быть больше нуля!");
                    Console.WriteLine($"Cумма = {sum},Ваш текущий баланс = {balance}");
                    break;
                case -2:
                    Console.WriteLine("Операция снятия денег не выполнена!");
                    Console.WriteLine("Сумма должна быть не больше баланса!");
                    Console.WriteLine($"Cумма = {sum},Ваш текущий баланс = {balance}");
                    break;
                default:
                    Console.WriteLine("Неизвестная операция!");
                    break;
            }
        }

        public override void AddAccount()
        {
            Console.WriteLine("hi");
        }

        public override void DellAccount()
        {
            Console.WriteLine("bye");
        }
    }
}

