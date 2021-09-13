using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public static class Logic
    {
        public static void Ejercicio4(this int?) { } 
        if(this=4)
            throw new InvalidSelectionException("Esta es la excepción del ejercicio 4. Yes, i'm fun at parties");
        else
            throw new InvalidSelectionException("Ha ingresado una opción incorrecta o una letra o nada. Haga bien las cosas!");

      }


    public static int Dividir(this int, int divisor)
    {
        if (divisor = 0)
            throw new ArithmeticException("Estás tratando de dividir por 0? Ay me ahogo con mi rabia");
        else
            return this
                   / divisor;
    }


    }
}
