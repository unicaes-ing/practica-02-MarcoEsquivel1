using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_2
{
    class ejercicio5
    {
        //Marco René Esquivel Juárez
        //17-Julio
        public void ejer5()
        {
            DateTime horaInicio, horaFinalizacion;
            decimal valorHora, total;
            Console.WriteLine("Ingrese la hora de inicio en formato H:m");
            horaInicio = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingrese la hora de finalizacion en formato H:m");
            horaFinalizacion = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingrese el valor por hora");
            valorHora = Convert.ToDecimal(Console.ReadLine());

            TimeSpan ts = horaFinalizacion - horaInicio;
            decimal horas = ts.Hours;
            total = horas * valorHora;
            Console.WriteLine("El valor a pagar es: {0}", total.ToString("c2"));
            Console.ReadKey();
        }
    }
}
