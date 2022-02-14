using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercico_POO_EstruturadeRepeticao
{
    class Matematica
    {
        public static long Exponeciacao(int valor1, int valor2)
        {
            long resultado = 0;

            if (valor2 == 0)
            {
                resultado = 1;
            }

            if(valor2 < 0)
            {
                valor1 = valor1 * -1;
                valor2 = valor2 * -1;
            }

            if(valor2 > 1)
            {
                for(var i = 1; i <= valor2; i++)
                {
                    if(i == 1)
                    {
                        resultado = valor1;
                    }
                    else
                    {
                        resultado = resultado * valor1;
                    }
                }
            }
            else
            {
                resultado = valor1;
            }


            return resultado;
        }
    }
}
