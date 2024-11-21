using static System.Net.Mime.MediaTypeNames;

namespace ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StreamReader fitxer = new StreamReader("COMPLEIX.TXT");
            StreamReader fitxer = new StreamReader("NOCOMPLEIX.TXT");
            string linia;
            int numero;
            Console.WriteLine("Llegim el primer element");
            linia = fitxer.ReadLine();
            numero = Convert.ToInt32(linia);

            for (int cont = 0; cont < numero; cont++)
            {
                Console.WriteLine("Llegim el primer element");
                linia = fitxer.ReadLine();
                numero = Convert.ToInt32(linia);
                if (cont < numero)
                {
                    Console.WriteLine("Si compleix");
                }
            }
        }
    }
}
