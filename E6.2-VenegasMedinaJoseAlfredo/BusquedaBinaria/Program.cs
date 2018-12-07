using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Busqueda B = new Busqueda(); //Objeto de la Clase Busqueda
            int final, final2, opc = 0; 
            int[] Ejemplo1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }; //Dos ejemplos
            int[] Ejemplo2 = { 3, 25, 6, 7, 3, 7, 2, 3, 4, 56, 8, 9, 1, 23, 54, 7, 4, 1, 235, 64, 0 };
            final = Ejemplo1.Length;
            final2 = Ejemplo2.Length;

            B.Burbuja(Ejemplo1, final); //Llamamos al metodo burbuja, esto por si los arreglos no estan ordenados
            B.Burbuja(Ejemplo2, final2);

            Console.Write("Seleccione ejemplo: \n1. Ejemplo 1 \n2. Ejemplo 2 \nR = "); //Menu
            opc = int.Parse(Console.ReadLine());

            if (opc == 1) //Ejemplo 1
                B.BusquedaBinaria(Ejemplo1, 1);

            else if (opc == 2) //Ejemplo 2
                B.BusquedaBinaria(Ejemplo2, 2);

            else
                Console.WriteLine("ERROR");

            Console.ReadKey();
        }
    }
}
