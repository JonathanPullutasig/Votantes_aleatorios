using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Votantes_aleatorios
{
    class Presidentes
    {
        int opcion;
        public void Elecciones(double vot, ref double an,ref double gl,ref double xh)
        {
            Random oRan = new Random();
            for(int i = 1; i <= vot; i++)
            {
                opcion = oRan.Next(3);
                switch (opcion)
                {
                    case 0:
                        an++;
                        break;
                    case 1:
                        gl++;
                        break;
                    case 2:
                        xh++;
                        break;
                }
            }
        }
        public string ganador(double a,double g,double x)
        {
            if (a > g)
                if (a > x) return "Alvaro Noboa";
                else return "Xavier hervas";
            else
                if (g > x) return "Guillermo lasso";
            else return "Xavier Hervas";

        }
    }
}
