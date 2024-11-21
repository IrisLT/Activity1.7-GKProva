namespace ex06c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader fitxer = new StreamReader("ALGUNSPRIMERS.TXT");
            string linia;
            int num;
            Console.WriteLine("Llegim el primer element");
            linia = fitxer.ReadLine();
            num = Convert.ToInt32(linia);


            //mentre no final i no trobat
            while (linia != null)
            {
                num = Convert.ToInt32(linia);
                if (NumeroPrimer(num))
                {
                    Console.WriteLine("El numero es perfecte");
                }
                else
                {
                    Console.WriteLine("El numero no es perfecte");

                }
                linia = fitxer.ReadLine();
                num = Convert.ToInt32(linia);


            }
            fitxer.Close();

        }
        static bool NumeroPrimer(int num)
        {
            for (int i = num; i <= Math.Sqrt(num); i++)
            {

                if (num % i == 0)
                {
                    return false;
                }

            }
            return true;
        }
    }
}
