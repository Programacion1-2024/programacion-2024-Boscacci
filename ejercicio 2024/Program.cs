internal class Program
{
    //private static void Main(string[] args)
    //{
        //int numero1, numero2, suma;
      //  Console.WriteLine("ingrese numero 1");
        //numero1 =
        //Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("ingrese numero 2");
        //numero2 =
          //  Convert.ToInt32(Console.ReadLine());
        //suma = numero1 + numero2;
        //Console.WriteLine("la suma de los dos numeros es:" + suma);
    
    static void Main (string[] args)
    {
        int numero;

        Console.Write("Ingrese un número entero: ");
        numero = Convert.ToInt32(Console.ReadLine());

        if (EsPar(numero))
        {
            Console.WriteLine("{0} es un número par.", numero);
        }
        else
        {
            Console.WriteLine("{0} es un número impar.", numero);
        }
    }

    static bool EsPar(int num)
    {
        // Si el residuo de dividir el número entre 2 es igual a 0, entonces es par
        return num % 2 == 0;
    }
}
