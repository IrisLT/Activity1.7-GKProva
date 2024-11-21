namespace ex06e
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, acumulador = 0;
            Console.WriteLine("Introdueix un numero");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(NumeroPrimer(numero));

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
