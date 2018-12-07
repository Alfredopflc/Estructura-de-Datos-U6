using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionHash
{
    class Program
    {
        static void Main(string[] args)
        {
            //NOTA: ES NECESARIO TENER System.Collections
            int opc = 0;
            Hashtable Ejemplo1 = new Hashtable(); //Ejemplos
            Hashtable Ejemplo2 = new Hashtable();

            //Agregar Elementos de Ejemplo 1
            Ejemplo1.Add(1, "Banana");
            Ejemplo1.Add(2, "Manza");
            Ejemplo1.Add(3, "Pera");
            Ejemplo1.Add(4, "Uva");
            Ejemplo1.Add(5, "Naranja");
            Ejemplo1.Add(6, "Limon");

            //Agregar Elementos de Ejemplo 2
            Ejemplo2.Add(12, "Azul");
            Ejemplo2.Add(53, "Rojo");
            Ejemplo2.Add(65, "Verde");
            Ejemplo2.Add(72, "Amarillo");
            Ejemplo2.Add(18, "Morado");
            Ejemplo2.Add(46, "Rosa");

            Console.Write("En que ejemplo desea buscar el elemento? \n1. Ejemplo 1 \n2, Ejemplo 2 \nR = "); //Seleccionar Ejemplo
            opc = int.Parse(Console.ReadLine());

            if (opc == 1) //Ejemplo 1
                Buscar(Ejemplo1);

            else if (opc == 2) //Ejemplo 2
                Buscar(Ejemplo2);

            else
                Console.WriteLine("ERROR");

            Console.ReadKey();
        }

        static void Buscar(Hashtable H) //Metodo para buscar Elemento con llave
        {
            int id = 0; //Llave o identificador
            Console.Write("Ingresa identificador del elemento: "); //Pedimos llave para encontrar elemento
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\tLlaves y Elementos del Ejemplo\n");
            //Mostramos elementos
            foreach (DictionaryEntry elemento in H) //Se buscan los elementos de DictionaryEntre (que tengan llave y elemento)
                Console.WriteLine("({0} , {1})", elemento.Key, elemento.Value); //Imprimimos en orden

            if (H.Contains(id)) //Si contiene la llave, imprimira el elemento de dicha llave
                Console.WriteLine("\nSe encontro el elemento con la llave {0}: {1}", id, H[id]);

            else //Si no, elemento no encontrado
                Console.WriteLine("\nElemento no encontrado");
        }
    }
}
