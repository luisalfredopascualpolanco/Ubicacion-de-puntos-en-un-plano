using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto10._11
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Cantidad de puntos a vamos ingresar: ");
                int punto = int.Parse(Console.ReadLine());
                float x, y;
                int posicion;
                int primer = 0;
                int segundo = 0;
                int tercero = 0;
                int cuarto = 0;
                int centro = 0;

                for (int i = 0; i < punto; i++)
                {
                    posicion = i + 1;
                    Console.Write("Coordenada en x del punto #" + posicion + ": ");
                    x = float.Parse(Console.ReadLine());

                    Console.Write("Coordenada en y del punto #" + posicion + ": ");
                    y = float.Parse(Console.ReadLine());

                    if (x < 0 && y > 0)
                    {
                        primer = primer + 1;
                    }
                    else if (x > 0 && y > 0)
                    {
                        segundo = segundo + 1;
                    }
                    else if (x > 0 && y < 0)
                    {
                        tercero = tercero + 1;
                    }
                    else if (x < 0 && y < 0)
                    {
                        cuarto = cuarto + 1;
                    }
                    else
                    {
                        centro = centro + 1;
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Hay "+primer+" puntos en el primer cuadrante, "+segundo+" en el segundo, "+tercero+" en el tercero, "+cuarto+" en el" +
                    " cuarto y "+centro+" en el centro.");
            }
            catch (Exception)
            {
                Console.WriteLine("Ha introducido un dato invalido.");                
            }
            Console.ReadKey();
        }
    }
}
