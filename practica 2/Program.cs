﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_2
{
    class Program
    {
        //Marco René Esquivel Juárez
        //17-Julio
        static void Main(string[] args)
        {
            int op;
            ejercicio1 eje1 = new ejercicio1();
            ejercicio2 eje2 = new ejercicio2();
            ejercicio3 eje3 = new ejercicio3();
            ejercicio4 eje4 = new ejercicio4();
            ejercicio5 eje5 = new ejercicio5();
            ejercicio6 eje6 = new ejercicio6();
            do
            {
                Console.WriteLine("Elija el ejercicio que desa ejecutar");
                Console.WriteLine("1- Ejercicio 1");
                Console.WriteLine("2- Ejercicio 2");
                Console.WriteLine("3- Ejercicio 3");
                Console.WriteLine("4- Ejercicio 4");
                Console.WriteLine("5- Ejercicio 5");
                Console.WriteLine("6- Ejercicio 6");
                op = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 1:
                        eje1.ejer1();
                        break;
                    case 2:
                        eje2.ejer2();
                        break;
                    case 3:
                        eje3.ejer3();
                        break;
                    case 4:
                        eje4.ejer4();
                        break;
                    case 5:
                        eje5.ejer5();
                        break;
                    case 6:
                        eje6.ejer6();
                        break;
                }
                Console.Clear();
            } while (op != 0);
        }
    }
}
