// See https://aka.ms/new-console-template for more information
using System;
					
public class Program
{
    public static void Main()
    {
       
        SumaValores(LeeValores("suma"));
        WaitForUser();
        RestaValores(LeeValores("resta"));
        WaitForUser();
        DivisionValores(LeeValores("division"));
        WaitForUser();
        ModuloValores(LeeValores("multiplicacion"));
    }

    public static void WaitForUser()
    {
        Console.WriteLine("Presiona enter para continuar");
        Console.ReadLine();
        Console.Clear();
    }

    public static void MultiplicacionValores(int[] valores)
    {
        int multi = valores[0] * valores[1];
        ImprimeResultado("La multiplicaión de los dos números es", multi);
    }

    public static void ModuloValores(int[] valores)
    {
        int mod = valores[0] % valores[1];
        ImprimeResultado("El modulo de los dos números es", mod);
    }

    public static void DivisionValores(int[] valores)
    {
        int div = valores[0] / valores[1];
        ImprimeResultado("La división de los dos números es ", div);
    }

    public static void SumaValores(int[] valores)
    {
        int suma = valores[0] + valores[1];
        ImprimeResultado("La suma de los dos números es", suma);
    }

    public static void RestaValores(int[] valores)
    {
        int resta = valores[0] - valores[1];
        ImprimeResultado("La resta de los dos números es", resta);
    }

    public static int[] LeeValores(string operacion)
    {
        Console.WriteLine("Realizando " + operacion);

        int numero1, numero2;

        Console.WriteLine("Escribe el primer número");
        numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Escribe el segundo número");
        numero2 = int.Parse(Console.ReadLine());

        int[] valores = new int[2] {numero1, numero2};

        return valores;
    }

    public static void ImprimeResultado(string mensaje, int resultado)
    {
        Console.WriteLine(mensaje + " " + resultado);
    }
}