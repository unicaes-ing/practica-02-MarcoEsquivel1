using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_2
{
    class ejercicio1
    {
        //Marco René Esquivel Juárez
        //17-Julio
        public void ejer1()
        {
            string nombre;
            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine();
            nombre = nombre.ToUpper();
            nombre = nombre.Replace("A", "#");
            nombre = nombre.Replace("E", "%");
            nombre = nombre.Replace("I", "$");
            nombre = nombre.Replace("O", "?");
            nombre = nombre.Replace("U", "*");
            Console.WriteLine("El nuevo nombre es: {0}", nombre);
            Console.ReadKey();
        }
    }
}
