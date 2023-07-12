using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectodeLaboratorio
{
    public class Publico
    {
        public double metros_cuadrados, capacidad_tribunas, porcentaje_escenario;

        public double calcular()
        {
            double aux = (metros_cuadrados * 0.8); //auxiliar almacena la diferencia entre metros cuadrados y tamaño de la tribuna
            double resultado = ((aux - ((aux * porcentaje_escenario) / 100)) * 4) + capacidad_tribunas;
            return resultado;
        }
    }
}
