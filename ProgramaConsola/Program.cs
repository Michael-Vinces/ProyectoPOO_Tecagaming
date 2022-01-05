using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaPersistenciaDatos;
using CapaPersistenciaDatos.Modelos;


// Proyecto grupal "Programa de consola para negocio"
//***************************************************************************************************************
//************************************                IMPORTANTE        *****************************************
//***************************************************************************************************************
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//*             Para poder ingresar al programa es requerido un nombre de usuario y una contrasña               *
//*                                             User : tecagaming                                               *
//*                                             Pass : tecagaming                                               * 
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//***************************************************************************************************************


namespace CapaPresentacion

{
    public class Program
    {
        public static void Main(string[] args)
        {
                Console.BackgroundColor = ConsoleColor.Gray; // Color gris para el fondo de la consola
                Console.Clear(); // Limpiar consola

                Usuario usuario = new Usuario(); // Instancia de la clase Usuario
                Productos productos = new Productos(); // Instancia de la clase Productos
                Cliente cliente = new Cliente(); // Instancia de la clase Cliente
                TotalPago totalPago = new TotalPago(); // Instancia de la clase TotalPago
                DateTime fechaEmision = DateTime.Now; // Instancia para la fecha en tiempo real

                // Lista que contiene el catalogo de los productos 
                List<string> catalogo = new List<string>();

                catalogo.Add("Lg 27Pulg, 155Ghz,120 Fps");
                catalogo.Add("Aoc 'Rog' 32Pulg C32 G208");
                catalogo.Add("Samsung 27Pulg Curve 1.8M");
                catalogo.Add("Gigabyte 32 P Pantalla Pc");
                catalogo.Add("Teclado Mecánico Redragon");
                catalogo.Add("Mouse Gaming color Blanco");
                catalogo.Add("Teclado Mecanico Apex Pro");
                catalogo.Add("Cpu Core-i5 4taG 36gb Ram");
                catalogo.Add("Logitech wirelessRGB G320");
                catalogo.Add("Kit GamingRGB Charge Fast");

                // Lista que contiene el precio de los productos 
                List<double> precios = new List<double>();

                precios.Add(346);
                precios.Add(370);
                precios.Add(788);
                precios.Add(572);
                precios.Add(100);
                precios.Add(100);
                precios.Add(279);
                precios.Add(329);
                precios.Add(150);
                precios.Add(100);

                //Listas que permiten guardar los productos que el usuario escoja

                List<string> VentaProducto = new List<string>(); // Lista que permite guardar el nombre del producto
                List<double> VentaPrecio = new List<double>(); // Lista que permite guardar el precio del producto


                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\t\t********************************************************************************");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\t\t******************        DESARROLLADORES DEL PROGRAMA        ******************");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\t\t********************************************************************************");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\t\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("\t\t*     Bonilla Moreira Cristian Jair                                            *");
                Console.WriteLine("\t\t*     Tejena Chavez Cristopher Aaron                                           *");
                Console.WriteLine("\t\t*     Vera Castro Carol Pamela                                                 *");
                Console.WriteLine("\t\t*     Vinces Andrade Michael Leonardo                                          *");
                Console.WriteLine("\t\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("\t\t*                                                                              *");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\t\t********************************************************************************");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\t\t*   Ingrese su nombre: ");
                Console.Write("\t\t\t");
                Console.ForegroundColor = ConsoleColor.Black;
                usuario.Nombre = Console.ReadLine(); // Ingreso de nombre del usuario

                // Codigo que recibe datos de usuario, para acceder al programa 

                bool acceso = false;

                // Ciclo que permite que mientras el usuario o contraseña no sean validos
                // no le permita ingresar al menu del programa

                while (true)
                {

                    if (acceso == false)
                    {
                        InicioSesion();
                    }
                    else
                    {
                        menu();
                    }
                }
                void InicioSesion()
                {

                    while (true)

                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\t\t********************************************************************************");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\t\t********************************************************************************");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\t\t\t\t\tWelcome " + usuario.Nombre + " To TECAGAMING");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\t\t********************************************************************************");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\t\t********************************************************************************");
                        Console.WriteLine("");
                        Console.WriteLine("\t\t\t 1. Ingrese su usuario y contraseña a continuacion:");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("\t\t\t*Ingrese su username:");
                        Console.Write("\t\t\t");
                        Console.ForegroundColor = ConsoleColor.Black;
                        usuario.Username = Console.ReadLine();  // Ingreso del Username
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("\t\t\t*Ingrese su contraseña:");
                        Console.Write("\t\t\t");
                        Console.ForegroundColor = ConsoleColor.Black;
                        usuario.Password = Console.ReadLine();  // Ingreso de la Password

                        if (usuario.Username == "tecagaming" && usuario.Password == "tecagaming")
                        {
                            // Si el usuario ingresa los datos correctos se mostrara un mensaje por pantalla 
                            // Notificandole su inicio de sesion exitoso

                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("\t\t********************************************************************************");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("\t\t********************        Inicio de sesion exitoso        *********************");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("\t\t********************************************************************************");

                            acceso = true;

                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("\t\t~~~~~~~~~~~~~~~          Presione enter para continuar           ~~~~~~~~~~~~~~~");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            // Si el usuario ingresa los datos erroneos se mostrara un mensaje por pantalla 
                            // Notificandole un posible error en el inicio de sesion 

                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("\t\t********************************************************************************");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\t\t******************       Usuario o Contraseña erróneos       *******************");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("\t\t********************************************************************************");

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("\t\t~~~~~~~~~~~~~~~          Presione enter para continuar           ~~~~~~~~~~~~~~~");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                }

                void menu()
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    int opcion;

                    while (true)

                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\t\t********************************************************************************");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\t\t**********************         Menu de TECA GAMING         *********************");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\t\t********************************************************************************");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\t\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine("\t\t*    1. Lista de productos                                                     *");
                        Console.WriteLine("\t\t*    2. Realizar venta                                                         *");
                        Console.WriteLine("\t\t*    3. Agregar un producto                                                    *");
                        Console.WriteLine("\t\t*    4. Eliminar un producto                                                   *");
                        Console.WriteLine("\t\t*    5. Cerrar sesión                                                          *");
                        Console.WriteLine("\t\t*    6. Salir                                                                  *");
                        Console.WriteLine("\t\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine("\t\t*                                                                              *");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\t\t********************************************************************************");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("\t\t     Elige una opción : ");
                        opcion = Int32.Parse(Console.ReadLine());  // Ingreso de opcion del menu principal 

                        Console.Clear();

                        switch (opcion)
                        {
                            case 1:

                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("\t\t********************************************************************************");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("\t\t**********************          Lista de Productos         *********************");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("\t\t********************************************************************************");
                                Console.ForegroundColor = ConsoleColor.Black;

                                for (int i = 0; i < catalogo.Count; i++)
                                {
                                    string ImprimirProducto = catalogo[i];

                                    Console.Write("\t\t*  " + ImprimirProducto + "");

                                    for (int n = 0; n < precios.Count; n++)
                                    {
                                        double ImprimirPrecio = precios[i];
                                        Console.Write("---------$" + ImprimirPrecio + "                                      *\n");

                                        break;
                                    }

                                }
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("\t\t********************************************************************************");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("\t\t~~~~~~~~~~~~~~~          Presione enter para continuar           ~~~~~~~~~~~~~~~");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 2:
                                // Permite el ingreso de los datos del cliente, para posteriormente imprirlo en la factura

                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\t\t********************************************************************************");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("\t\t**********************          Datos del cliente          *********************");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\t\t********************************************************************************");
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\t\t*    Ingrese el nombre del cliente");
                                Console.Write("\t\t     ");
                                Console.ForegroundColor = ConsoleColor.Black;
                                cliente.Nombre = Console.ReadLine();    // << Permite ingresar el nombre del cliente >>
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\t\t*    Ingrese su cedula");
                                Console.Write("\t\t     ");
                                Console.ForegroundColor = ConsoleColor.Black;
                                cliente.Cedula = int.Parse(Console.ReadLine());  // << Permite ingresar DNI del cliente >>
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\t\t*    Ingrese su número telefónico");
                                Console.Write("\t\t     ");
                                Console.ForegroundColor = ConsoleColor.Black;
                                cliente.Contacto = Console.ReadLine();     // << Permite ingresar la informacion de contacto del cliente >>
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\t\t*    Ingrese su domicilio");
                                Console.Write("\t\t     ");
                                Console.ForegroundColor = ConsoleColor.Black;
                                cliente.Domicilio = Console.ReadLine();    // << Permite ingresar la dirrecion del cliente >>
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\t\t********************************************************************************");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("\t\t****************          Presione enter para continuar          ***************");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\t\t********************************************************************************");

                                Console.ReadKey();
                                Console.Clear();
                                bool accesoVenta = true;
                                // Mostrar menu para realizar la venta 
                                while (true)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("\t\t*********************************************************************************");
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.WriteLine("\t\t**********************         Ingrese sus productos        *********************");
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("\t\t*********************************************************************************");
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.WriteLine("\t\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                    Console.WriteLine("\t\t*    1. Agregar producto                                                        *");
                                    Console.WriteLine("\t\t*    2. Eliminar producto                                                       *");
                                    Console.WriteLine("\t\t*    3. Ver la lista de venta                                                   *");
                                    Console.WriteLine("\t\t*    4. Continuar                                                               *");
                                    Console.WriteLine("\t\t*    5. Cancelar                                                                *");
                                    Console.WriteLine("\t\t~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("\t\t*********************************************************************************");
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.Write("\t\t      Elija una opción :  ");

                                    opcion = Int32.Parse(Console.ReadLine());

                                    Console.Clear();

                                    switch (opcion)
                                    {

                                        case 1:

                                            Console.Clear();

                                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                                            Console.WriteLine("\t\t********************************************************************************");
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.WriteLine("\t\t**********************          Lista de Productos         *********************");
                                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                                            Console.WriteLine("\t\t********************************************************************************");
                                            Console.ForegroundColor = ConsoleColor.Black;

                                            for (int i = 0; i < catalogo.Count; i++)
                                            {
                                                string ImprimirProducto = catalogo[i];
                                                Console.Write("\t\t*  " + (i + 1) + ". " + ImprimirProducto + " ");

                                                for (int n = 0; n < precios.Count; n++)
                                                {
                                                    double ImprimirPrecio = precios[i];
                                                    Console.Write("\t$" + ImprimirPrecio + "\n");
                                                    break;
                                                }
                                            }

                                            // Se inicializan las variables

                                            productos.NombreProducto = "";
                                            productos.ValorUnitario = 0;
                                            int agg = 0;

                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("\t\t********************************************************************************");
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.WriteLine("\t\t**********************          Elija los productos         ********************");
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("\t\t********************************************************************************");
                                            Console.ForegroundColor = ConsoleColor.Black;

                                            while (agg <= 0 || agg >= catalogo.Count + 1)
                                            {
                                                Console.Write("\t\t  Elige el producto: ");
                                                agg = Int32.Parse(Console.ReadLine());
                                            }

                                            for (int i = 0; i < agg; i++)
                                            {
                                                productos.NombreProducto = catalogo[i];

                                                for (int n = 0; n < agg; n++)
                                                {

                                                    productos.ValorUnitario = precios[i];
                                                    break;

                                                }

                                            }
                                            Console.Clear();

                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine("\t\t********************************************************************************");
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.WriteLine("\t\t***************         Ingrese la cantidad que requiera         ***************");
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine("\t\t********************************************************************************");
                                            Console.ForegroundColor = ConsoleColor.Black;

                                            Console.WriteLine("\t\t" + productos.NombreProducto + "~~~~~~~~~~~~~~~$" + productos.ValorUnitario);

                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine("\t\t********************************************************************************");
                                            productos.Cantidad = 0;
                                            while (productos.Cantidad <= 0)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Black;
                                                Console.Write("\t\tIngrese el número de unidades : ");
                                                productos.Cantidad = Int32.Parse(Console.ReadLine()); // Permite escoger un producto
                                            }

                                            for (int i = 0; i < productos.Cantidad; i++)
                                            {
                                                VentaProducto.Add(productos.NombreProducto); //Se agrega el producto escogido a la lista de productos
                                                VentaPrecio.Add(productos.ValorUnitario); //Se agrega el valor unitario del producto escogido a la lista de precios
                                            }

                                            Console.Clear();

                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("\t\t********************************************************************************");
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.WriteLine("\t\t**********************          Operacion Exitosa         **********************");
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("\t\t********************************************************************************");
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            if (productos.Cantidad == 1)
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                Console.ForegroundColor = ConsoleColor.Black;
                                                Console.WriteLine("\t\t  Se ha agregado correctamente " + productos.NombreProducto + " cuyo valor es $" + productos.ValorUnitario);
                                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                Console.ForegroundColor = ConsoleColor.Black;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                Console.ForegroundColor = ConsoleColor.Black;
                                                Console.WriteLine("\t\tSe han agregado correctamente " + productos.Cantidad + " " + productos.NombreProducto + " cuyo valor es $" + productos.ValorUnitario + " c/u");
                                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                Console.ForegroundColor = ConsoleColor.Black;
                                            }

                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.WriteLine("\t\t~~~~~~~~~~~~~~~          Presione enter para continuar          ~~~~~~~~~~~~~~~");
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("\t\t--------------------------------------------------------------------------------");


                                            Console.ReadKey();
                                            Console.Clear();

                                            break;

                                        case 2:

                                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                                            Console.WriteLine("\t\t********************************************************************************");
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.WriteLine("\t\t*****************         Elimine el producto que desee         ****************");
                                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                                            Console.WriteLine("\t\t********************************************************************************");
                                            Console.ForegroundColor = ConsoleColor.Black;

                                            if (VentaProducto.Count == 0)
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                Console.ForegroundColor = ConsoleColor.Black;
                                                Console.WriteLine("\t\t~~~~~~~~~~~~~~~~~~~~~            LISTA DE VENTA            ~~~~~~~~~~~~~~~~~~~~~");
                                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                Console.ForegroundColor = ConsoleColor.Black;
                                                Console.WriteLine("\t\t La lista está vacía.\n");
                                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                Console.ForegroundColor = ConsoleColor.Black;
                                                Console.WriteLine("\t\t~~~~~~~~~~~~~~~~~~~~~            LISTA DE VENTA            ~~~~~~~~~~~~~~~~~~~~~");
                                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                Console.ForegroundColor = ConsoleColor.Black;
                                                for (int i = 0; i < VentaProducto.Count; i++)
                                                {
                                                    string ImprimirProducto = VentaProducto[i];
                                                    Console.Write("\t\t " + (i + 1) + ". " + ImprimirProducto + " ");

                                                    for (int n = 0; n < VentaPrecio.Count; n++)
                                                    {
                                                        double ImprimirPrecio = VentaPrecio[i];
                                                        Console.Write("----------------$" + ImprimirPrecio + "\n");
                                                        break;
                                                    }
                                                }
                                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                Console.WriteLine("\t\t********************************************************************************");
                                                Console.ForegroundColor = ConsoleColor.Black;
                                                while (productos.EliminarCantidad <= 0 || productos.EliminarCantidad >= VentaProducto.Count + 1)
                                                {
                                                    Console.Write("\t\t\n               Selecciona el producto a eliminar : ");
                                                    productos.EliminarCantidad = Int32.Parse(Console.ReadLine()); //permite escribir el producto que se desea eliminar
                                                }
                                                for (int i = 0; i < productos.EliminarCantidad; i++)
                                                {
                                                    productos.EliminarProducto = VentaProducto[i];

                                                    for (int n = 0; n < productos.EliminarCantidad; n++)
                                                    {

                                                        productos.EliminarPrecio = VentaPrecio[i];
                                                        break;

                                                    }

                                                }

                                                VentaProducto.Remove(productos.EliminarProducto); //Se elimina el producto escogido en la lista de productos de venta
                                                VentaPrecio.Remove(productos.EliminarPrecio); //Se elimina el precio del producto escogido en la lista de precios de venta

                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                Console.ForegroundColor = ConsoleColor.Black;
                                                Console.WriteLine("\t\t~~~~~~~~~~~~~~~~~~~~~             El producto              ~~~~~~~~~~~~~~~~~~~~~");
                                                Console.WriteLine("\t\t                           " + productos.EliminarProducto + " $" + productos.EliminarPrecio);
                                                Console.WriteLine("\t\t~~~~~~~~~~~~~~~~~~~~~            fue eliminado             ~~~~~~~~~~~~~~~~~~~~~");
                                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                            }
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.WriteLine("\t\t~~~~~~~~~~~~~~~          Presione enter para continuar           ~~~~~~~~~~~~~~~");
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("\t\t--------------------------------------------------------------------------------");

                                            Console.ReadKey();
                                            Console.Clear();
                                            break;

                                        case 3:

                                            if (VentaProducto.Count == 0) // Si no hay ningun producto en la lista entrar a este if y que vuelva al menu 
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                Console.ForegroundColor = ConsoleColor.Black;
                                                Console.WriteLine("\t\t~~~~~~~~~~~~~~~~~~~~~            LISTA DE VENTA            ~~~~~~~~~~~~~~~~~~~~~");
                                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                Console.ForegroundColor = ConsoleColor.Black;
                                                Console.WriteLine("\t\t La lista está vacía.");
                                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                Console.ForegroundColor = ConsoleColor.Black;
                                                Console.WriteLine("\t\t~~~~~~~~~~~~~~~~~~~~~            LISTA DE VENTA            ~~~~~~~~~~~~~~~~~~~~~");
                                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                Console.ForegroundColor = ConsoleColor.Black;

                                                for (int i = 0; i < VentaProducto.Count; i++)
                                                {
                                                    string ImprimirProducto = VentaProducto[i];
                                                    Console.Write("\t\t " + (i + 1) + ". " + ImprimirProducto + " ");

                                                    for (int n = 0; n < VentaPrecio.Count; n++)
                                                    {
                                                        double ImprimirPrecio = VentaPrecio[i];
                                                        Console.Write("---------------$" + ImprimirPrecio + "\n");
                                                        break;
                                                    }

                                                }
                                            }
                                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                            Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.WriteLine("\t\t~~~~~~~~~~~~~~~          Presione enter para continuar           ~~~~~~~~~~~~~~~");
                                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                            Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                            Console.ReadKey();
                                            Console.Clear();

                                            break;

                                        case 4:
                                            if (VentaProducto.Count == 0)  // Si no hay ningun producto agregado a la lista entrar a este if  y que vuelva al menu
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                Console.WriteLine("\t\t********************************************************************************");
                                                Console.ForegroundColor = ConsoleColor.Black;
                                                Console.WriteLine("\t\t*****************          Agregue productos a la lista         ****************");
                                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                Console.WriteLine("\t\t********************************************************************************");
                                                Console.ForegroundColor = ConsoleColor.Black;

                                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                Console.ForegroundColor = ConsoleColor.Black;
                                                Console.WriteLine("\t\t~~~~~~~~~~~~~~~          Presione enter para continuar           ~~~~~~~~~~~~~~~");
                                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                Console.ReadKey();
                                                Console.Clear();
                                            }
                                            else
                                            {

                                                Console.Clear();

                                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                Console.WriteLine("\t\t********************************************************************************");
                                                Console.ForegroundColor = ConsoleColor.Black;
                                                Console.WriteLine("\t\t******************             Consolidar la venta             *****************");
                                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                Console.WriteLine("\t\t********************************************************************************");
                                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                Console.ForegroundColor = ConsoleColor.Black;
                                                Console.WriteLine("\t\t~~~~~~~~~~~~~~~~~~~            LISTA DE PRODUCTOS            ~~~~~~~~~~~~~~~~~~~");
                                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                Console.WriteLine("\t\t--------------------------------------------------------------------------------\n");
                                                Console.ForegroundColor = ConsoleColor.Black;

                                                for (int i = 0; i < VentaProducto.Count; i++)
                                                {
                                                    string ImprimirProducto = VentaProducto[i];
                                                    Console.Write("\t\t " + (i + 1) + ". " + ImprimirProducto + " ");

                                                    for (int n = 0; n < VentaPrecio.Count; n++)
                                                    {
                                                        double ImprimirPrecio = VentaPrecio[i];

                                                        totalPago.Subtotal += ImprimirPrecio;

                                                        Console.Write("~~~~~~~~~~~~~~~~$" + ImprimirPrecio + "\n");
                                                        break;
                                                    }

                                                }
                                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                Console.WriteLine("\n\t\t********************************************************************************");
                                                Console.ForegroundColor = ConsoleColor.Black;
                                                Console.WriteLine("\t\t  SUBTOTAL: \t$" + totalPago.Subtotal);
                                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                Console.WriteLine("\t\t********************************************************************************");
                                                opcion = 0;
                                                Console.ForegroundColor = ConsoleColor.Black;
                                                Console.WriteLine("\n\t\t 1. Factura");
                                                Console.WriteLine("\t\t 2. Proforma");
                                                Console.WriteLine("\t\t 3. Cancelar\n");
                                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                Console.WriteLine("\t\t********************************************************************************");
                                                Console.ForegroundColor = ConsoleColor.Black;
                                                while (opcion <= 0 || opcion >= 4)
                                                {
                                                    Console.Write("\t\t Elige una opcion: ");
                                                    opcion = Int32.Parse(Console.ReadLine()); // Permitir ingresar una de las opciones 
                                                }

                                                Console.Clear();

                                                switch (opcion)
                                                {

                                                    case 1:
                                                        Console.WriteLine("\t\t\t-----------------------------------------------------------------");
                                                        Console.WriteLine("\t\t\t|                      TECAGAMING FACTURA                       |");
                                                        Console.WriteLine("\t\t\t-----------------------------------------------------------------");
                                                        Console.WriteLine("\t\t\t-----------------------------------------------------------------");
                                                        Console.WriteLine("\t\t\t| Dirección        |  Calle 14 y Av 30 (Dentro de Plaza Forum)  |");
                                                        Console.WriteLine("\t\t\t| Contacto         |  2928205                                   |");
                                                        Console.WriteLine("\t\t\t| Ciudad           |  Manta, Manabi                             |");
                                                        Console.WriteLine("\t\t\t| Fecha de Emisión |  " + fechaEmision + "                       |");
                                                        Console.WriteLine("\t\t\t-----------------------------------------------------------------");
                                                        Console.WriteLine(cliente.MostrarCliente()); // Metodo que muestra los datos del cliente
                                                        Console.WriteLine(" \n");

                                                        for (int i = 0; i < VentaProducto.Count; i++) // Muestra la lista de productos y sus precios de la venta 
                                                        {
                                                            Console.WriteLine("\t\t\t-----------------------------------------------------------------");
                                                            string ImprimirProducto = VentaProducto[i];
                                                            Console.Write("\t\t\t|\t" + (i + 1) + ". " + ImprimirProducto + " ");

                                                            for (int n = 0; n < VentaPrecio.Count; n++)
                                                            {
                                                                double ImprimirVenta = VentaPrecio[i];
                                                                Console.Write("\t$" + ImprimirVenta + "\t\t\t|\n");
                                                                break;
                                                            }

                                                        }
                                                        Console.WriteLine("\t\t\t-----------------------------------------------------------------\n");
                                                        Console.WriteLine(totalPago.MostrarTotalPago()); // Muestra los datos de pago de la venta
                                                        Console.ForegroundColor = ConsoleColor.Green;
                                                        Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                        Console.ForegroundColor = ConsoleColor.Black;
                                                        Console.WriteLine("\t\t~~~~~~~~~~~          Presione enter para imprimir la factura         ~~~~~~~~~~~");
                                                        Console.ForegroundColor = ConsoleColor.Green;
                                                        Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                        Console.WriteLine("\n.\n");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                        Console.ForegroundColor = ConsoleColor.Black;
                                                        Console.WriteLine("\t\t~~~~~~~~~~~~~~~~~~              Compra Finalizada             ~~~~~~~~~~~~~~~~~~");
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                        Console.WriteLine("\n.\n");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        accesoVenta = false;
                                                        VentaProducto.Clear();
                                                        VentaPrecio.Clear();
                                                        break;

                                                    case 2:
                                                        Console.WriteLine("\t\t\t-----------------------------------------------------------------");
                                                        Console.WriteLine("\t\t\t|                     TECAGAMING PROFORMA                       |");
                                                        Console.WriteLine("\t\t\t-----------------------------------------------------------------");
                                                        Console.WriteLine("\t\t\t-----------------------------------------------------------------");
                                                        Console.WriteLine("\t\t\t| Dirección        |  Calle 14 y Av 30 (Dentro de Plaza Forum)  |");
                                                        Console.WriteLine("\t\t\t| Contacto         |  2928205                                   |");
                                                        Console.WriteLine("\t\t\t| Ciudad           |  Manta, Manabi                             |");
                                                        Console.WriteLine("\t\t\t| Fecha de Emisión |  " + fechaEmision + "                       |");
                                                        Console.WriteLine("\t\t\t-----------------------------------------------------------------");
                                                        Console.WriteLine(cliente.MostrarCliente()); // Metodo que muestra los datos del cliente
                                                        Console.WriteLine(" \n");

                                                        for (int i = 0; i < VentaProducto.Count; i++) // Muestra la lista de productos y sus precios de la venta 
                                                        {
                                                            Console.WriteLine("\t\t\t-----------------------------------------------------------------");
                                                            string ImprimirProducto = VentaProducto[i];
                                                            Console.Write("\t\t\t|\t" + (i + 1) + ". " + ImprimirProducto + " ");

                                                            for (int n = 0; n < VentaPrecio.Count; n++)
                                                            {
                                                                double ImprimirVenta = VentaPrecio[i];
                                                                Console.Write("\t$" + ImprimirVenta + "\t\t\t|\n");
                                                                break;
                                                            }

                                                        }
                                                        Console.WriteLine("\t\t\t-----------------------------------------------------------------\n");
                                                        Console.WriteLine(totalPago.MostrarTotalPago()); // Muestra los datos de pago de la venta
                                                        Console.ForegroundColor = ConsoleColor.Green;
                                                        Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                        Console.ForegroundColor = ConsoleColor.Black;
                                                        Console.WriteLine("\t\t~~~~~~~~~~~          Presione enter para imprimir la factura         ~~~~~~~~~~~");
                                                        Console.ForegroundColor = ConsoleColor.Green;
                                                        Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                        Console.WriteLine("\n.\n");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                        Console.ForegroundColor = ConsoleColor.Black;
                                                        Console.WriteLine("\t\t~~~~~~~~~~~~~~~~~~              Compra Finalizada             ~~~~~~~~~~~~~~~~~~");
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                        Console.WriteLine("\n.\n");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        accesoVenta = false;
                                                        VentaProducto.Clear();
                                                        VentaPrecio.Clear();
                                                        break;

                                                    case 3:
                                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                        Console.WriteLine("\t\t********************************************************************************");
                                                        Console.ForegroundColor = ConsoleColor.Black;
                                                        Console.WriteLine("\t\t******************          La venta ha sido cancelada         *****************");
                                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                        Console.WriteLine("\t\t********************************************************************************");

                                                        VentaProducto.Clear(); // Limpia la lista de los productos agregados a la venta
                                                        VentaPrecio.Clear(); // Limpia la lista de los precios de los productos agregados a la venta

                                                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                        Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                        Console.ForegroundColor = ConsoleColor.Black;
                                                        Console.WriteLine("\t\t~~~~~~~~~~~~~~~          Presione enter para continuar           ~~~~~~~~~~~~~~~");
                                                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                        Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                        Console.ForegroundColor = ConsoleColor.Black;
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        accesoVenta = false;
                                                        break;
                                                    default:
                                                        break;
                                                }
                                            }
                                            break;
                                        case 5:
                                            // Este caso permite cancelar la venta si el usuario lo requiere

                                            VentaProducto.Clear();
                                            VentaPrecio.Clear();
                                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                                            Console.WriteLine("\t\t********************************************************************************");
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.WriteLine("\t\t******************          La venta ha sido cancelada         *****************");
                                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                                            Console.WriteLine("\t\t********************************************************************************");
                                            Console.WriteLine("");
                                            Console.WriteLine("");
                                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                            Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.WriteLine("\t\t~~~~~~~~~~~~~~~          Presione enter para continuar           ~~~~~~~~~~~~~~~");
                                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                                            Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                            Console.ReadKey();
                                            Console.Clear();

                                            accesoVenta = false;

                                            break;

                                        default:

                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("\t\t********************************************************************************");
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.WriteLine("\t\t*******************          Elige una opción correcta         ******************");
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine("\t\t********************************************************************************");
                                            Console.ForegroundColor = ConsoleColor.Black;

                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.WriteLine("\t\t~~~~~~~~~~~~~~~          Presione enter para continuar           ~~~~~~~~~~~~~~~");
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                            Console.ReadKey();
                                            Console.Clear();
                                            break;
                                    }

                                    if (accesoVenta == false)
                                    {
                                        break;
                                    }
                                }
                                break;
                            case 3:

                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("\t\t********************************************************************************");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("\t\t*******************          Agrege un nuevo Producto          *****************");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("\t\t********************************************************************************");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("\t\t~~~~~~~~~~~~~~~          Ingrese el nombre del producto          ~~~~~~~~~~~~~~~");
                                Console.Write("\t\t");
                                productos.NuevoProducto = Console.ReadLine();

                                productos.NuevoPrecio = 0;

                                while (productos.NuevoPrecio <= 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.WriteLine("\t\t~~~~~~~~~~~~~~~          Ingrese el precio del producto          ~~~~~~~~~~~~~~~");
                                    Console.Write("\t\t");
                                    productos.NuevoPrecio = Double.Parse(Console.ReadLine());
                                }

                                catalogo.Add(productos.NuevoProducto);
                                precios.Add(productos.NuevoPrecio);

                                Console.Clear();

                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("\t\t  Se ha agregado correctamente " + productos.NuevoProducto + " cuyo valor es $" + productos.NuevoPrecio);
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");

                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("\t\t~~~~~~~~~~~~~~~          Presione enter para continuar           ~~~~~~~~~~~~~~~");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                Console.ReadKey();
                                Console.Clear();
                                break;

                            case 4:

                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("\t\t********************************************************************************");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("\t\t*****************         Elimine el producto que desee         ****************");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("\t\t********************************************************************************");
                                Console.ForegroundColor = ConsoleColor.Black;

                                if (catalogo.Count == 0)
                                {
                                    // Si no hay ningun producto agregado se muestra lo siguiente...
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.WriteLine("\t\t~~~~~~~~~~~~~~~~~~~            LISTA DE PRODUCTOS            ~~~~~~~~~~~~~~~~~~~");
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.WriteLine("\t\t La lista está vacía.");
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.WriteLine("\t\t~~~~~~~~~~~~~~~~~~~            LISTA DE PRODUCTOS            ~~~~~~~~~~~~~~~~~~~");
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                    Console.ForegroundColor = ConsoleColor.Black;

                                    for (int i = 0; i < catalogo.Count; i++)
                                    {
                                        string ImprimirProducto = catalogo[i];
                                        Console.Write("\t\t " + (i + 1) + ". " + ImprimirProducto + " ");

                                        for (int n = 0; n < precios.Count; n++)
                                        {
                                            double ImprimirPrecio = precios[i];
                                            Console.Write("------------------$" + ImprimirPrecio + "\n");
                                            break;
                                        }

                                    }
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                    Console.ForegroundColor = ConsoleColor.Black;

                                    while (productos.EliminarCantidad <= 0 || productos.EliminarCantidad >= catalogo.Count + 1)
                                    {
                                        Console.Write("\t\tSelecciona el producto a eliminar: ");
                                        productos.EliminarCantidad = Int32.Parse(Console.ReadLine()); //Ingreso del numero del producto a eliminar
                                    }

                                    for (int i = 0; i < productos.EliminarCantidad; i++)
                                    {
                                        productos.EliminarProducto = catalogo[i];

                                        for (int n = 0; n < productos.EliminarCantidad; n++)
                                        {

                                            productos.EliminarPrecio = precios[i];
                                            break;

                                        }

                                    }

                                    catalogo.Remove(productos.EliminarProducto); // Elimina el producto escogido de la Lista catalogo
                                    precios.Remove(productos.EliminarPrecio);    // Elimina el precio del producto escogido de la Lista precios

                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.WriteLine("\t\t~~~~~~~~~~~~~~~~~~~~~             El producto              ~~~~~~~~~~~~~~~~~~~~~");
                                    Console.WriteLine("\t\t                           " + productos.EliminarProducto + " $" + productos.EliminarPrecio);
                                    Console.WriteLine("\t\t~~~~~~~~~~~~~~~~~~~~~            fue eliminado             ~~~~~~~~~~~~~~~~~~~~~");
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                }
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("\t\t~~~~~~~~~~~~~~~          Presione enter para continuar           ~~~~~~~~~~~~~~~");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                Console.ReadKey();
                                Console.Clear();

                                break;

                            case 5:

                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\t\t********************************************************************************");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("\t\t***********************          Cerrando Sesion         ***********************");
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\t\t********************************************************************************");
                                Console.ForegroundColor = ConsoleColor.Black;
                                acceso = false; // Permite volver al Inicio de Sesión
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("\t\t~~~~~~~~~~~~~~~          Presione enter para continuar           ~~~~~~~~~~~~~~~");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                Console.ReadKey();
                                Console.Clear();

                                break;

                            case 6:

                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("\t\t********************************************************************************");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("\t\t******************          Finalizando el programa           ******************");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("\t\t********************************************************************************");
                                acceso = false;
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("\t\t~~~~~~~~~~~~~~~          Presione enter para continuar           ~~~~~~~~~~~~~~~");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                Console.ReadKey();
                                Environment.Exit(1); // Permite cerrar la consola

                                break;

                            default:
                                // En caso de escribir una opcion diferente a las existentes, mostrar el siguiente mensaje

                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("\t\t********************************************************************************");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("\t\t****************         Seleccione una opcion valida           ****************");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("\t\t********************************************************************************");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("\t\t~~~~~~~~~~~~~~~          Presione enter para continuar           ~~~~~~~~~~~~~~~");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                        }

                        if (acceso == false)
                        {
                            break;
                        }
                    }
                }
            }
        }
    }




