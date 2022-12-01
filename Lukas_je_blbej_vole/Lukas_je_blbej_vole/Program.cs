namespace ggo
{
    class f
    {
        static void Main(string[] args)
        {
            Console.WriteLine("number");
            int a = int.Parse(Console.ReadLine());
            int vysledek = a;
            for (int i = 1; i <= 10; i++) ;
            vysledek = vysledek * a;
            Console.WriteLine("vysledek: {0} ", vysledek);
            Console.ReadKey();
        }
    }
}