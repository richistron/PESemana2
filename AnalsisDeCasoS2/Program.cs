// See https://aka.ms/new-console-template for more information

// Se necesita desarrollar un programa que solicite al usuario 3 cantidades, pueden ser enteros o décimales, 
// posteriormente  realice la suma de éstos y  muestre en resultado obtenido en pantalla. 

namespace AnalisisDeCaso
{
    class Program
    {
        public static void Main()
        {
            int[] numeros = SolicitaNumeros();
            Console.WriteLine($"La suma de los números es: {numeros.Sum().ToString()}");
        }

        private static int[] SolicitaNumeros()
        {
            int[] numeros = new int[3];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = LeeNumero();
            }

            return numeros;
        }

        private static int LeeNumero()
        {
            int numero = 0;
            string entrada;
            bool numeroValido = false;

            while (!numeroValido)
            {
                Console.WriteLine("Ingresa un número");
                entrada = Console.ReadLine();
                if (!int.TryParse(entrada, out numero))
                    Console.WriteLine("El Número es invalido");
                else numeroValido = true;
            }

            return numero;
        }
    }
}