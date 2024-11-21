namespace ex06b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, acumulador = 0;
            Console.WriteLine("Introdueix un numero");
            numero = Convert.ToInt32(Console.ReadLine());

            if (NumeroPrimer(numero))
            {
                Console.WriteLine($"{numero} es un número primer");
            }
            else
            {
                Console.WriteLine($"{numero} no es un número primer");
            }
        }
        static bool NumeroPrimer(int num)
        {
            int acumulador = 0;
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
