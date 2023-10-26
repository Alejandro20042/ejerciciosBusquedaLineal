using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosBusquedaLineal
{
    public class Ejercicios
    {
        public static int BusquedaLinealEnteros(int[] numeros, int numeroBuscado)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numeroBuscado)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int BusquedaLinealCadenas(string[] cadenas, string cadenaBuscada)
        {
            for (int i = 0; i < cadenas.Length; i++)
            {
                if (cadenas[i] == cadenaBuscada)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int BusquedaLinealNumeroPar(int[] numeros)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        public static void BuscarNumerosPares(int[] numeros)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    Console.WriteLine("Número par encontrado en la posición: " + i);
                }
            }
        }
    }
}
