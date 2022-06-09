using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace unidad6
{
    class Amazon
    {
        string NombreProducto;
        string Descripcion;
        float Precio;
        int Stock;

        public Amazon(string NombreProducto, string Descripcion, float Precio, int Stock)
        {
            this.NombreProducto = NombreProducto;
            this.Descripcion = Descripcion;
            this.Precio = Precio;
            this.Stock = Stock;
        }
        public void InventarioAmazon()
        {
            Console.WriteLine("-------Inventario de los productos------");
            Console.WriteLine("El nombre del producto es: {0} " + NombreProducto);
            Console.WriteLine("Su descripcion del producto es:{0} " + Descripcion);
            Console.WriteLine("El precio del producto es: {0:C}" + Precio);
            Console.WriteLine("La cantidad de stock es: {0}" + Stock);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            StreamWriter sw = new StreamWriter("Productos.txt", true);
            string Nombre, Descripcion;
            float Precio;
            int Stock;
            Console.WriteLine("-----Captura de datos del producto------");
            Console.Write("Ingrese el nombre del procto: ");
            Nombre = Console.ReadLine();
            Console.Write("ingrese la descripcion del procto: ");
            Descripcion = Console.ReadLine();
            Console.Write("Ingrese el precio del producto: ");
            Precio = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de stock: ");
            Stock = int.Parse(Console.ReadLine());
            Console.Clear();

            Amazon amazon = new Amazon(Nombre, Descripcion, Precio, Stock);
            amazon.InventarioAmazon();
            sw.WriteLine("Nombre del procuto: " + Nombre);
            sw.WriteLine("Descripcion del producto: " + Descripcion);
            sw.WriteLine("El precio del producto es: " + Precio);
            sw.WriteLine("La cantidad del stock es: " + Stock);


        }
    }
}
