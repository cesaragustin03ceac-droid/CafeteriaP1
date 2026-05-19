using System.Runtime.Intrinsics.X86;

namespace PRACTICA_1_CAFETERIA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string tamano;
            float precio;

            Console.WriteLine("Productos");
            Console.WriteLine("-Cafe"+"\n"+"-Latte"+"\n"+"-Americano");
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese el nombre de la bebida");
            nombre = Console.ReadLine();

            Console.WriteLine("Tamaños");
            Console.WriteLine("-Chico" + "\n" + "-Mediano" + "\n" + "-Grande");
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese el tamano:"+ nombre);
            tamano = Console.ReadLine();

            Console.WriteLine("Ingrese el costo de la bebida:");
            precio = float.Parse(Console.ReadLine());

            Console.Clear();


            Bebida Bebida1 = new Bebida(nombre, tamano, precio);
            Console.WriteLine("Productos");
            Console.WriteLine("-Cafe" + "\n" + "-Latte" + "\n" + "-Americano");
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese el nombre de la bebida");
            nombre = Console.ReadLine();

            Console.WriteLine("Tamaños");
            Console.WriteLine("-Chico" + "\n" + "-Mediano" + "\n" + "-Grande");
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese el tamano:" + nombre);
            tamano = Console.ReadLine();

            Console.WriteLine("Ingrese el costo de la bebida:");
            precio = float.Parse(Console.ReadLine());


            Console.Clear();


            Bebida Bebida2 = new Bebida(nombre, tamano, precio);
            Console.WriteLine("Productos");
            Console.WriteLine("-Cafe" + "\n" + "-Latte" + "\n" + "-Americano");
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese el nombre de la bebida");
            nombre = Console.ReadLine();

            Console.WriteLine("Tamaños");
            Console.WriteLine("-Chico" + "\n" + "-Mediano" + "\n" + "-Grande");
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese el tamano:" + nombre);
            tamano = Console.ReadLine();

            Console.WriteLine("Ingrese el costo de la bebida:");
            precio = float.Parse(Console.ReadLine());

            Bebida Bebida3 = new Bebida(nombre, tamano, precio);

            Console.Clear();

            Bebida1.Descuento(20);
            Bebida2.Descuento(0);    
            Bebida3.Descuento(90);


            Console.WriteLine("\n");
            
            Console.WriteLine("PREPARANDO:");
            Bebida1.Preparar();
            Bebida2.Preparar();
            Bebida3.Preparar();

            Console.WriteLine("\n");

            Console.WriteLine("INFORMACION:");
            Bebida1.MostrarDescripcion();
            Bebida2.MostrarDescripcion();
            Bebida3.MostrarDescripcion();

        }
    }
}
