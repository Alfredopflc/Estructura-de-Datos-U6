using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6._1_VenegasMedinaJoseAlfredo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, pos = 0, opc = 0;
            double num;
            bool buscar = false;
            double[] Vector = { 4, 7, 4, 0, 3, 8, 32, 9, 654, 0, 1 };
            double[] Vector2 = { 5.5, 8.8, 11.8, 8.3, 0.2, 1.9, 6.4, 2.5, 6.7, 100.4, 1.1};

            Console.Write("En donde desea buscar su elemento? \n1 = Ejemplo 1 \n2 = Ejemplo 2 \nR = ");
            opc = int.Parse(Console.ReadLine());

            Console.Write("Ingresar numero que se buscara: ");
            num = double.Parse(Console.ReadLine());

            if (opc == 1)
            {
                while (!(buscar) && i < Vector.Length)
                {
                    if (num == Vector[i])
                    {
                        buscar = true;
                        pos = i;
                    }
                    i++;
                }
            }

            if(opc == 2)
            {
                while (!(buscar) && i < Vector2.Length)
                {
                    if (num == Vector2[i])
                    {
                        buscar = true;
                        pos = i;
                    }
                    i++;
                }
            }

            if (buscar == true)
                Console.WriteLine("El elemento se encontro en la posicion: {0}", (pos + 1));

            else
                Console.WriteLine("El elemento no se encontro");

            Console.ReadKey();

        }

        static void Busqueda(bool buscar, double[] Vector, double num, int i, int pos)
        {
            
        }
    }
}
