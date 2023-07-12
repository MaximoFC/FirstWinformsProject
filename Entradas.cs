using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectodeLaboratorio
{
    internal class Entradas
    {
        public double precio_comunes, precio_vip, cantidad_entradas;

        public double ganancias()
        {
            double cantidad_vip = (cantidad_entradas * 0.3);
            double cantidad_comunes = (cantidad_entradas * 0.7);
            double resultado = (cantidad_vip * precio_vip) + (cantidad_comunes * precio_comunes);
            return resultado;
        }
    }
}
