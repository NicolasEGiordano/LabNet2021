using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese el ejecricio que desea testear:")
            Console.WriteLine("Punto 1");
            Console.WriteLine("Punto 2");
            Console.WriteLine("Punto 3");
            Console.WriteLine("Punto 4");
            try
            {
                switch (int.TryParse(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Ingrese un número para romper:");
                        int dividendo = Int.TryParse(Console.ReadLine());
                        int resultado = dividendo / 0;
                        Console.WriteLine("El Resultado es: " + resultado);
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el dividendo y luego el divisor:");
                        int dividendo = Int32.TryParse(Console.ReadLine());
                        int resultado = dividendo.Logic.Dividir(Int32.TryParse(Console.ReadLine()));
                        Console.WriteLine("El resultado es: " + resultado);
                        break;
                    case 3:
                        Console.WriteLine("This is the InvalidSelectionException");
                        Logic.Ejercicio4(null);
                        break;
                    default:

                        Logic.Ejercicio4(int.TryParse(Console.ReadLine()));

                        break;
                }
            }
            catch (DivideByZeroException | ArgumentException exception1)
            {
                String tipo = exception1.GetType().Name.ToString();
                Console.WriteLine(exception1.Message + tipo);
            }
            catch (InvalidSelectionException exception4)
            {
                String tipo = exception4.GetType().Name.ToString();
                Console.Write("Errror!".Concat(exception4.Message) + tipo);
            }
            finally { Console.WriteLine("El programa ha terminado."); }




    }

}
