using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_2
{
    class ejercicio4
    {
        //Marco René Esquivel Juárez
        //17-Julio
        public void ejer4()
        {
            DateTime fechaInicio, fechaDevolucion;
            decimal valorDia, total;
            Console.WriteLine("Ingrese la fecha de inicio");
            fechaInicio = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha de devolucion");
            fechaDevolucion = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingrese el valor por dia");
            valorDia = Convert.ToDecimal(Console.ReadLine());

            TimeSpan ts= fechaDevolucion - fechaInicio;
            int dias = ts.Days;
            total = dias * valorDia;

            Console.WriteLine("El valor a pagar es: {0}", total.ToString("c2"));
            Console.ReadKey();
        }
    }
}
