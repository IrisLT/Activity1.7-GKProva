namespace ex05c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader fitxer = new StreamReader("PERFECTES.TXT");
            string linia;
            int num;
            Console.WriteLine("Llegim el primer element");
            linia = fitxer.ReadLine();
            num = Convert.ToInt32(linia);


            //mentre no final i no trobat
            while ( linia!= null)
            {
                num= Convert.ToInt32(linia);
                if (NumeroPerfecte(num))
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
