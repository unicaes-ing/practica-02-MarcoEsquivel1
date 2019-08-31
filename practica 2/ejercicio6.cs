using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_2
{
    class ejercicio6
    {
        //Marco René Esquivel Juárez
        //17-Julio
        public void ejer6()
        {
            DateTime fecha = DateTime.Now;
            Console.WriteLine("Hoy es {0} del mes {1} de {2}", fecha.Day, fecha.Month, fecha.Year);
            Console.ReadKey(); 
        }
    }
}
