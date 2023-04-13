using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;

namespace SegundoLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Usuarios> list = new List<Usuarios>();

            Usuarios usuarios = new Usuarios();

            usuarios.id = 1;
            usuarios.nombre = "Nestor";
            usuarios.edad = 22;
            usuarios.nivel = "Admin";

            Usuarios usuarios2 = new Usuarios();

            usuarios2.id = 2;
            usuarios2.nombre = "Alexi";
            usuarios2.edad = 22;
            usuarios2.nivel = "Admin";

            Usuarios usuarios3 = new Usuarios();

            usuarios3.id = 3;
            usuarios3.nombre = "Adiel";
            usuarios3.edad = 22;
            usuarios3.nivel = "Vendedor";

            Usuarios usuarios4 = new Usuarios();

            usuarios4.id = 4;
            usuarios4.nombre = "Rocio";
            usuarios4.edad = 22;
            usuarios4.nivel = "Vendedor";
            Area area = new Area();
            List<string> listaArea = new List<string> { "Cocina", "Productos Basicos" };
            Categoria categoria = new Categoria();
            List<Tuple<string, string>> listaCategoria = new List<Tuple<string, string>>();
            listaCategoria.Add(Tuple.Create("Sartenes", "Cocina"));
            listaCategoria.Add(Tuple.Create("Granos", "Productos basicos"));
            Productos productos = new Productos();


            List<Tuple<string, string, string, string, double, int, string>> listaProductos = new List<Tuple<string, string, string, string, double, int, string>>();
            listaProductos.Add(Tuple.Create("Huevo", "Constancia", "12/09/23", "12/04/23", 12.5, 24, "Granos"));
            int a = 1;
            while(a ==1)
            {
                Console.Clear();
                string nombre;
                Console.WriteLine("Ingrese el nombre del Usuario");
                nombre = Console.ReadLine();

                if (usuarios.nombre == nombre || usuarios2.nombre == nombre)
                {
                
                    Console.WriteLine("Usuario " + nombre + " Activo, ROl ADMIN");
                    int x = 1;
                    while (x ==1)
                    {
                        Console.WriteLine("--------------Menu-------------");
                        Console.WriteLine("1-Crear Area");
                        Console.WriteLine("2-Crear Categoria");
                        Console.WriteLine("3-Crear Producto");
                        Console.WriteLine("4-Salir");

                        int opc = Convert.ToInt32(Console.ReadLine());

                        switch (opc)
                        {
                            case 1:
                               
                                Console.WriteLine("Ingrese el nombre del area");
                                area.nombreArea = Console.ReadLine();
                                listaArea.Add(area.nombreArea);


                                foreach (string l in listaArea)
                                {
                                    Console.WriteLine(l);
                                }
                                break;

                            case 2:

                                
                                Console.WriteLine("\nDatos existentes");
                                Console.WriteLine("\nCategoria   Area");
                                foreach (Tuple<string, string> l in listaCategoria)
                                {
                                    Console.WriteLine(l);
                                }


                                Console.WriteLine("Ingrese el nombre del Categoria");
                                categoria.nombreCat = Console.ReadLine();
                                Console.WriteLine("Ingrese el nombre del del Area");
                                categoria.nombreA = Console.ReadLine();
                                listaCategoria.Add(Tuple.Create(categoria.nombreCat, categoria.nombreA));

                                Console.WriteLine("\nCategoria   Area");
                                foreach (Tuple<string, string> l in listaCategoria)
                                {
                                    Console.WriteLine(l);
                                }

                                break;


                            case 3:

                               

                                foreach (Tuple<string, string, string, string, double, int, string> l in listaProductos)
                                {
                                    Console.WriteLine(l);
                                }

                                Console.WriteLine("Ingrese el nombre del Producto");
                                productos.nombreProd = Console.ReadLine();
                                Console.WriteLine("Ingrese el nombre del Proveedor");
                                productos.proveedor = Console.ReadLine();
                                Console.WriteLine("Ingrese fecha de caducidad");
                                productos.fechCaducidad = Console.ReadLine();
                                Console.WriteLine("Ingrese fecha de entrada");
                                productos.fechEntrada = Console.ReadLine();
                                Console.WriteLine("Ingrese precio");
                                productos.precio =Convert.ToDouble( Console.ReadLine());
                                Console.WriteLine("Ingrese las unidades");
                                productos.unidades =Convert.ToInt32( Console.ReadLine());
                                Console.WriteLine("Ingrese el nombre de la categoria");
                                productos.nombreCate = Console.ReadLine();

                                listaProductos.Add(Tuple.Create(productos.nombreProd, productos.proveedor, productos.fechCaducidad, productos.fechEntrada, productos.precio, productos.unidades, productos.nombreCate));

                                foreach (Tuple<string, string, string, string, double, int, string> l in listaProductos)
                                {
                                    Console.WriteLine(l);
                                }
                            
                                break;

                            case 4:
                                x = 0;
                                break;
                    }
                }
            }
            
            else if(usuarios3.nombre == nombre || usuarios4.nombre == nombre)
            {
                Console.WriteLine("Usuario " + nombre + " Activo, ROl Vendedor");

                    while (true)
                    {
                        Console.WriteLine("--------Menu--------");
                        Console.WriteLine("1-Vender");
                        Console.WriteLine("2-Facturar");
                        Console.WriteLine("3-Salir");

                        int opc = Convert.ToInt32(Console.ReadLine());

                        switch(opc)
                        {
                            case 1:


                                foreach (string l in listaArea)
                                {
                                    Console.WriteLine(l);
                                }
                                Console.WriteLine("Ingrese el nombre del Area:");
                                string nomArea = Console.ReadLine();


                                //Categoria categoria = new Categoria();

                                //List<Tuple<string, string>> listaCategoria = new List<Tuple<string, string>>();
                                //listaCategoria.Add(Tuple.Create("Sartenes", "Cocina"));
                                //listaCategoria.Add(Tuple.Create("Granos", "Productos basicos"));
                                foreach (Tuple<string, string> l in listaCategoria)
                                {
                                   
                                        Console.WriteLine(l);
                                   
                                   
                                }

                                Console.WriteLine("Ingrese el nombre de la categoria:");
                                string nomCate = Console.ReadLine();

                                foreach (Tuple<string, string, string, string, double, int, string> l in listaProductos)
                                {
                                    if(l.Item7== nomCate)
                                    {
                                        Console.WriteLine(l);
                                    }
                                   
                                }





                                break;

                            case 2:

                                break; 

                            case 3:

                                break;
                          
                        }
                        

                       

                    }
            }
            else
            {
                a= 0;
            } 
                
            }
        }


        


    }


}

public class Usuarios
{
    public int id { get; set; }
    public string nombre { get; set; }
    public int edad { get; set; }
    public string nivel { get; set; }
}

public class Area
{
    public string nombreArea { get; set; }
    public void MetArea()
    {  

       
    }

    public void MostrarArea()
    {
        List<string> listaArea = new List<string> { "Cocina", "Productos Basicos" };
        foreach (string l in listaArea)
        {
            Console.WriteLine(l);
        }
    }
}

public class Categoria
{
    public string nombreCat { get; set; }
    public string nombreA { get; set; }



}

public class Productos
{
    public string nombreProd { get; set; }
    public string proveedor { get; set; }
    public string fechCaducidad { get; set; }
    public string fechEntrada { get; set; }
    public double precio { get; set; }
    public int unidades { get; set; }
    public string nombreCate { get; set; }
}