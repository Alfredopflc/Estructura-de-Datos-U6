using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaBinaria
{
    class Busqueda
    {
        public void Burbuja(int[] nums, int n)
        {
            int m = 0;

            for (int x = 1; x < n; x++) //Este for ira desde la segunda posicion hasta el final
            {
                for (int y = 0; y < (n - 1); y++) //Este ira desde la primera posicion hasta la final menos una
                {
                    if (nums[x] < nums[y]) //Esta condicion permite que sea ordenado de mayor a menos o de menor a mayor
                    {
                        m = nums[x]; //Variable de apoyo para conservar los valores antes de ser cambiados
                        nums[x] = nums[y]; //cambio de valores de x 
                        nums[y] = m; //cambio de valores de y
                    }
                }
            }
        }

        public void BusquedaBinaria(int[] vector, int i ) //Metodo de Busqueda Binaria, cargado de un arreglo y una variable que indica el numero de problema
        {
            int numero = 0, mitad = 0, puntero = 0, final;
            final = vector.Length; //Utilizaremos la variable final para indicar el tamano del arreglo
            bool encontrar = false;

            Console.Write("Ingresar el elemento que quieres buscar: "); //Se solicita el elemento que se buscara
            numero = int.Parse(Console.ReadLine());

            while (!encontrar && puntero <= final) //Se va a ciclar hasta que encontrar sea true o puntero sea mayor a final
            {
                mitad = (int)((puntero + final) / 2); //Mitad nos indicara el valor que este en la mitad del arreglo segun puntero y final

                if (mitad >= vector.Length) //Si mitad es igual o mayor al tamano del arreglo no se encontro el elemento
                    final = 0;

                else if (numero == vector[mitad]) //Si numero es igual al elemento que se encuentre en el arreglo en la posicion mitad se habra encontrado el elemento
                    encontrar = true;

                else if (numero < vector[mitad]) //Si es menor, se le asignada a final el valor de mitad menos 1
                    final = mitad - 1;

                else //De lo contrario, se le asignara a puntero el valor de mitad mas 1
                    puntero = mitad + 1;              
            }

            Console.WriteLine("\nArreglo Ejemplo {0}: ", i);
            for (int r = 0; r < vector.Length; r++) //for para imprimir el vector ya ordenado
                Console.Write("  " + vector[r]);

            if (encontrar) //Diremos si el elemento se encontro o no, y en que posicion
                Console.WriteLine("\n\nEl dato se encuentra y esta en la posicion: " + (mitad + 1));

            else
                Console.WriteLine("\n\nEl dato no se encuentra");
        }
        
    }
}
