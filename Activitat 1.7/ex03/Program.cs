using System.Runtime.ConstrainedExecution;

namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader fitxer = new StreamReader("NUMEROS.TXT");
            string linia;
            int num;
            Console.WriteLine("Llegim el primer element");
            linia= fitxer.ReadLine();
            num = Convert.ToInt32(linia);

            
            //mentre no final i no trobat
            while (num%2!=0 && num!=null)
            {
                Console.WriteLine("Llegim el següent element");
                linia = fitxer.ReadLine();
                num=Convert.ToInt32(linia);
            }
          //Comprovar s l'element s'ha trobat o no
          if(num%2==0)
          {
                Console.WriteLine("Hem arribat al final" + "i hem trobat l'element");
          }
          else 
          {
                Console.WriteLine("No hem arribat al final");
          }
        }
    }
}
