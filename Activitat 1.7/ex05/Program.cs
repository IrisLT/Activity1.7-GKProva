namespace ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, acumulador=0;
            Console.WriteLine("Introdueix un numero");
            numero=Convert.ToInt32(Console.ReadLine());

            if (NumeroPerfecte(numero))
            {
                Console.WriteLine($"{numero} es un número perfecte");
            }
            else
            {
                Console.WriteLine($"{numero} no es un número perfecte");
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
