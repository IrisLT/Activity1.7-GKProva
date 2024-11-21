using System.IO;

namespace ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader fitxer = new StreamReader("TIQUET.TXT");
            string linia;
            int productes, quantitat;
            double preu, total = 0;

            //Llegir fitxer
            productes = Convert.ToInt32(fitxer.ReadLine());

            for (int i = 0; i < productes; i++)
            {
                linia = fitxer.ReadLine(); //nom del producte
                linia = fitxer.ReadLine();
                quantitat = Convert.ToInt32(linia);
                linia = fitxer.ReadLine();
                preu = Convert.ToDouble(linia);
                total += quantitat * preu;

                if (linia=="PIZZ")
                {
                    Console.WriteLine("Compra no valida");
                }
                else if (linia=="EMBOTIT")
                {
                    Console.WriteLine("Compra no valida");
                }
                else
                {
                    Console.WriteLine("Compra valida");
                }
            }
            fitxer.Close();
            Console.WriteLine($"El preu total del tiquet és {total}");
        }
    }
}
