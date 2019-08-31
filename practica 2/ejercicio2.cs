using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_2
{
    class ejercicio2
    {
        //Marco René Esquivel Juárez
        //17-Julio
        public void ejer2()
        {
            string producto;
            decimal iva, precio, subtotal, total;
            int cant;
            iva = 0.13m;
            Console.WriteLine("Ingrese el nombre del producto");
            producto = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad del producto que desea comprar");
            cant = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del producto");
            precio = Convert.ToDecimal(Console.ReadLine());
            subtotal = precio * cant;
            total = subtotal * iva;
            Console.WriteLine("Producto: {0}", producto);
            Console.WriteLine("Precio: {0}", precio.ToString("c2"));
            Console.WriteLine("Cantidad: {0}", cant);
            Console.WriteLine("Subtotal: {0}", subtotal.ToString("c2"));
            Console.WriteLine("Total: {0}", total.ToString("c2"));
            Console.ReadKey();
        }
    }
}
