namespace ex05d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader fitxer = new StreamReader("PERFECTES.TXT");
            string linia;
            int numero;
            Console.WriteLine("Llegim el primer element");
            linia = fitxer.ReadLine();
            numero = Convert.ToInt32(linia);

            while (!(NumeroPerfecte(numero)) && numero != null)
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

        static bool NumeroPerfecte(int num)
        {
            int acumulador = 0;
            for (int i = 1; i <= num / 2; i++)
            {

                if (num % i == 0)
                {
                    acumulador += i;
                }

            }
            return acumulador == num;
        }
    }
}
