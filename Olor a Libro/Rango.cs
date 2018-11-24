using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olor_a_Libro
{
    public static class Rango
    {
        public static BindingList<string> rangos = new BindingList<string>() { "Unranked", "Soldado raso lector", "Sargento lector", "Teniente lector", "Mayor lector", "Teniente coronel lector", "Coronel lector", "General-mayor lector", "General-teniente lector", "General coronel lector", "Generalísimo lector" };

        public static string setRango(int puntos)
        {
            string rango;

            if (puntos < 10)
            {
                rango = rangos[0];
            }
            else if (puntos >= 10 && puntos < 20)
            {
                rango = rangos[1];
            }
            else if (puntos >= 20 && puntos < 40)
            {
                rango = rangos[2];
            }
            else if (puntos >= 40 && puntos < 80)
            {
                rango = rangos[3];
            }
            else if (puntos >= 80 && puntos < 100)
            {
                rango = rangos[4];
            }
            else if (puntos >= 100 && puntos < 150)
            {
                rango = rangos[5];
            }
            else if (puntos >= 150 && puntos < 250)
            {
                rango = rangos[6];
            }
            else if (puntos >= 250 && puntos < 500)
            {
                rango = rangos[7];
            }
            else if (puntos >= 500 && puntos < 800)
            {
                rango = rangos[8];
            }
            else if (puntos >= 800 && puntos < 1200)
            {
                rango = rangos[9];
            }
            else if (puntos >= 1200)
            {
                rango = rangos[10];
            }
            else
            {
                rango = "Error";
            }

            return rango;
        }
    }
}
