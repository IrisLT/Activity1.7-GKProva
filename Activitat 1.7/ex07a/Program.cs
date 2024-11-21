namespace ex07a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StreamReader fitxer = new StreamReader("PERDUT.TXT");
            StreamReader fitxer = new StreamReader("TROBAT.TXT");
            string linia;
            int numero;
            Console.WriteLine("Llegim el primer element");
            linia = fitxer.ReadLine();
            numero = Convert.ToInt32(linia);

            while (numero != 231)
            {
                Console.WriteLine("Llegim el primer element");
                linia = fitxer.ReadLine();
                numero = Convert.ToInt32(linia);
                if (numero !=231)
                {
                    Console.WriteLine("No l'hem trobat");
                }
            }

            if (numero == 231)
            {
                Console.WriteLine("L'hem trobat");
            }
            else
            {
                Console.WriteLine("No l'hem trobat");
            }
        }
    }
}
