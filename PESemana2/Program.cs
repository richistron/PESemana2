// See https://aka.ms/new-console-template for more information
using System;
					
public class Program
{
    public static void Main()
    {
       
        SumaValores();
        RestaValores();
        DivisionValores();
        MultiplicacionValores();
        ModuloValores();
    }

    public static void WaitForUser()
    {
        Console.WriteLine("Presiona enter para continuar");
        Console.ReadLine();
        Console.Clear();
    }

    public static void MultiplicacionValores()
    {
        int[] valores = LeeValores("multiplicaión");
        int multi = valores[0] * valores[1];
        ImprimeResultado("La multiplicaión de los dos números es", multi);
        WaitForUser();
    }

    public static void ModuloValores()
    {
        int[] valores = LeeValores("modulo");
        int mod = valores[0] % valores[1];
        ImprimeResultado("El modulo de los dos números es", mod);
        WaitForUser();
    }

    public static void DivisionValores()
    {
        int[] valores = LeeValores("division");
        int div = valores[0] / valores[1];
        ImprimeResultado("La división de los dos números es ", div);
        WaitForUser();
    }

    public static void SumaValores()
    {
        int[] valores = LeeValores("suma");
        int suma = valores[0] + valores[1];
        ImprimeResultado("La suma de los dos números es", suma);
        WaitForUser();
    }

    public static void RestaValores()
    {
        int[] valores = LeeValores("resta");
        int resta = valores[0] - valores[1];
        ImprimeResultado("La resta de los dos números es", resta);
        WaitForUser();
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