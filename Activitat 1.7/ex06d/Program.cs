namespace ex06d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader fitxer = new StreamReader("ALGUNSPRIMERS.TXT");
            string linia;
            int numero;
            Console.WriteLine("Llegim el primer element");
            linia = fitxer.ReadLine();
            numero = Convert.ToInt32(linia);

            while (!(NumeroPrimer(numero)) && numero != null)
            {
                Console.WriteLine("Llegim el primer element");
                linia = fitxer.ReadLine();
                numero = Convert.ToInt32(linia);
            }

            if (numero == null)
            {
                Console.WriteLine("Hem arribat al final i no hem trobat l'element");
            }
            else
            {
                Console.WriteLine($"Hem trobat l'element {numero}");
            }
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
