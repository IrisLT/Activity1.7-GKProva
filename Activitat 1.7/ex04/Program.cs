namespace ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader fitxer = new StreamReader("NUMEROS.TXT");
            string linia;
            int num, numero;
            Console.WriteLine("Diga'm un numero");
            numero=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Llegim el primer element");
            linia = fitxer.ReadLine();
            num = Convert.ToInt32(linia);


            //mentre no final i no trobat
            while (num != numero && num != null)
            {
                Console.WriteLine("Llegim el següent element");
                linia = fitxer.ReadLine();
                num = Convert.ToInt32(linia);
            }
            //Comprovar s l'element s'ha trobat o no
            if (num == numero)
            {
                //no se com calcular a la linia que esta
                Console.WriteLine($"Hem trobat numero a {linia}");
            }
            else
            {
                Console.WriteLine("-1");
            }
        }
    }
}
