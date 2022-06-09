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
            string nombre, descripcion;
            float precio;
            int cantidad, opc;

            do
            {
                Console.Write("\nMenú de Opciones\n\n1) Registrar Producto\n2) Consultar Productos\n3) Salir\n\nElija la opción: ");
                opc = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opc)
                {
                    case 1:
                        StreamWriter sw = new StreamWriter("inventario.txt", true);
                        Console.WriteLine("----- Captura de Datos -----");
                        Console.Write("\nNombre: ");
                        nombre = Console.ReadLine();
                        Console.Write("Descripción: ");
                        descripcion = Console.ReadLine();
                        Console.Write("Precio: ");
                        precio = float.Parse(Console.ReadLine());
                        Console.Write("Cantidad: ");
                        cantidad = int.Parse(Console.ReadLine());
                        Console.Clear();

                        Amazon inv = new Amazon(nombre, descripcion, precio, cantidad);

                        sw.WriteLine("Nombre Producto: " + nombre + "\nDescripción: " + descripcion + "\nPrecio: $" + precio + "\nCantidad en Inventario: " + cantidad + "\n");
                        Console.WriteLine("Producto registrado exitosamente!!\n");
                        inv.InventarioAmazon();
                        Console.WriteLine("\nPresione ENTER para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        sw.Close();
                        break;
                    case 2:
                        try
                        {
                            StreamReader sr = new StreamReader("inventario.txt");
                            string line = "";
                            Console.WriteLine("Productos Registrados\n");
                            while ((line = sr.ReadLine()) != null)
                            {
                                Console.WriteLine(line);
                            }
                            sr.Close();
                            Console.WriteLine("Presione ENTER para continuar...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        catch(IOException e)
                        {
                            Console.WriteLine("Error, Archivo no encontrado\nDebe Capturar un producto primero");
                            Console.WriteLine(e.Message);
                            Console.WriteLine("Presione ENTER para continuar...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Presione ENTER para salir del programa...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Error, elija una opción correcta!\nPresione ENTER para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (opc != 3);
        }
    }
}
