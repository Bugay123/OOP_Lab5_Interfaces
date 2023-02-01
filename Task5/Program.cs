namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var depo = new Depo();
            depo.AddAccount();
            depo.putMoney(3000);
            depo.DellAccount();

            var flow = new Flow();
            flow.AddAccount();
            flow.putMoney(1000);
            flow.DellAccount();
        }
    }

}