

namespace ejerciciosBusquedaLineal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 3, 4, 6, 8, 10 };
            string[] cadenas = { "uno", "dos", "tres", "cuatro", "cinco" };

            // Búsqueda lineal para números enteros
            Console.Write("Ingrese un número para buscar en la lista de enteros: ");
            int numeroBuscado = Convert.ToInt32(Console.ReadLine());
            int resultadoEnteros = Ejercicios.BusquedaLinealEnteros(numeros, numeroBuscado);
            if (resultadoEnteros != -1)
            {
                Console.WriteLine("El número se encuentra en la posición: " + resultadoEnteros);
            }
            else
            {
                Console.WriteLine("El número no se encuentra en la lista de enteros.");
            }

            // Búsqueda lineal para cadenas
            Console.Write("Ingrese una cadena para buscar en la lista de cadenas: ");
            string cadenaBuscada = Console.ReadLine();
            int resultadoCadenas = Ejercicios.BusquedaLinealCadenas(cadenas, cadenaBuscada);
            if (resultadoCadenas != -1)
            {
                Console.WriteLine("La cadena se encuentra en la posición: " + resultadoCadenas);
            }
            else
            {
                Console.WriteLine("La cadena no se encuentra en la lista de cadenas.");
            }

            // Búsqueda lineal para encontrar el primer número par
            int resultadoNumeroPar = Ejercicios.BusquedaLinealNumeroPar(numeros);
            if (resultadoNumeroPar != -1)
            {
                Console.WriteLine("El primer número par se encuentra en la posición: " + resultadoNumeroPar);
            }
            else
            {
                Console.WriteLine("No se encontraron números pares en la lista de enteros.");
            }

            // Búsqueda lineal para encontrar todos los números pares
            Console.WriteLine("Posiciones de los números pares en la lista de enteros:");
            Ejercicios.BuscarNumerosPares(numeros);
        }
    }
}