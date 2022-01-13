using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;
using CapaPersistenciaDatos.Modelos;
using CapaNegocio.Observer;


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
                ProductoEscogido nProducto = new ProductoEscogido(); // Instancia de la clase ProductoEscogido

                CapaNegocio.Observer.Empresa empresa = new CapaNegocio.Observer.Empresa();

                GestionCliente gcliente = new GestionCliente(); // Instancia de la clase GestionCliente
                GestionProductos gproductos = new GestionProductos(); // Instancia de la clase GestionProducto
                GestionProductoEscogido gproductoEscogido = new GestionProductoEscogido(); // Instancia de la clase GestionProductoEscogido
                GestionImprimir gimprimir = new GestionImprimir(); // Instancia de la clase GestionImprimir

                List<Productos> inventario = new List<Productos> // Lista de los productos que estan en stock
                {
                    new Productos{NombreProducto="Mouse Gaming color Blanco", ValorUnitario=115},
                    new Productos{NombreProducto="Teclado Mecánico Redragon", ValorUnitario=100},
                    new Productos{NombreProducto="Samsung 27Pulg Curve 1.8M", ValorUnitario=788},
                    new Productos{NombreProducto="Cpu Core-i5 4taG 36gb Ram", ValorUnitario=329},
                    new Productos{NombreProducto="Aoc 'Rog' 32Pulg C32 G208", ValorUnitario=370},
                    new Productos{NombreProducto="Teclado Mecanico Apex Pro", ValorUnitario=172},
                };


                Cliente cliente1 = new Cliente();
                Cliente cliente2 = new Cliente();
                Cliente cliente3 = new Cliente();
                Cliente cliente4 = new Cliente();

                // Datos de los 4 subscritores predeterminados
                cliente1.Nombre = "Cristian Jair"; cliente1.Apellido = "Bonilla Moreira"; cliente1.Contacto = "0912345698";
                cliente2.Nombre = "Michael Leonardo"; cliente2.Apellido = "Vinces Andrade"; cliente2.Contacto = "0914647852";
                cliente3.Nombre = "Carol María Pamela"; cliente3.Apellido = "Vera Castro"; cliente3.Contacto = "0987945785";
                cliente4.Nombre = "Christopher Aaron"; cliente4.Apellido = "Tejena Chávez"; cliente4.Contacto = "0956474149";



                List<Suscriptor> suscriptores = new List<Suscriptor> 
                { 

                    new Suscriptor {clientee = cliente1},
                    new Suscriptor {clientee = cliente2},
                    new Suscriptor {clientee = cliente3},
                    new Suscriptor {clientee = cliente4},
                    
                    /*new Suscriptor{Nombre = "Cristian Jair", Apellido = "Bonilla Moreira", Contacto = "0984571236"},
                    new Suscriptor{Nombre = "Michael Leonardo", Apellido = "Vinces Andrade", Contacto = "0914647852"},
                    new Suscriptor{Nombre = "Carol Pamela          ", Apellido = "Vera Castro", Contacto = "0987945785"},
                    new Suscriptor{Nombre = "Christopher Aaron", Apellido = "Tejena Chávez", Contacto = "0956474149"},*/
                };



                List<ProductoEscogido> productosEscogidos = new List<ProductoEscogido> { };// Guarda el producto escogido con su nombre y producto

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
                Console.ForegroundColor = ConsoleColor.White;
                /*empresa.AgregarSuscriptor(cliente1);                         ASDFIAUDHSFIAGSDFOIGOFGSAFGIUSAIGFASFDASI
                empresa.AgregarSuscriptor(cliente2);
                empresa.AgregarSuscriptor(cliente3);
                empresa.AgregarSuscriptor(cliente4);*/
                Console.ForegroundColor = ConsoleColor.Black;
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
                        Console.WriteLine("\t\t*    5. Suscriptores                                                           *");
                        Console.WriteLine("\t\t*    6. Cerrar sesión                                                          *"); 
                        Console.WriteLine("\t\t*    7. Salir                                                                  *"); 
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

                                Console.WriteLine(gproductos.MostrarInventarioOrdenado(inventario));// Muestra la lista de productos del inventario
                                
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
                                Console.WriteLine("\t\t*    Ingrese los nombres del cliente");
                                Console.Write("\t\t     ");
                                Console.ForegroundColor = ConsoleColor.Black;
                                cliente.Nombre = Console.ReadLine();    // << Permite ingresar los nombres del cliente >>
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine("\t\t*    Ingrese los apellidos del cliente");
                                Console.Write("\t\t     ");
                                Console.ForegroundColor = ConsoleColor.Black;
                                cliente.Apellido = Console.ReadLine();    // << Permite ingresar los apellidos del cliente >>
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

                                            Console.WriteLine(gproductos.MostrarInventario(inventario));// Muestra la lista de productos del inventario

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

                                            while (agg <= 0 || agg >= inventario.Count + 1)
                                            {
                                                Console.Write("\t\t  Elige el producto: ");
                                                agg = Int32.Parse(Console.ReadLine());
                                            }

                                            nProducto = gproductoEscogido.EscogerProducto(agg, inventario, productosEscogidos); // LLama al metodo Escoger un Producto

                                            Console.Clear();

                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine("\t\t********************************************************************************");
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.WriteLine("\t\t***************         Ingrese la cantidad que requiera         ***************");
                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine("\t\t********************************************************************************");
                                            Console.ForegroundColor = ConsoleColor.Black;

                                            Console.WriteLine("\t\t" + nProducto.miProducto.NombreProducto + "~~~~~~~~~~~~~~~$" + nProducto.miProducto.ValorUnitario);

                                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine("\t\t********************************************************************************");
                                            productos.Cantidad = 0;
                                            while (productos.Cantidad <= 0)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Black;
                                                Console.Write("\t\tIngrese el número de unidades : ");
                                                productos.Cantidad = Int32.Parse(Console.ReadLine()); // Permite escoger un producto
                                            }

                                            gproductoEscogido.EscogerCantidad(productos.Cantidad, nProducto);

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
                                                Console.WriteLine("\t\t  Se ha agregado correctamente " + nProducto.miProducto.NombreProducto + " cuyo valor es $" + nProducto.miProducto.ValorUnitario);
                                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                Console.ForegroundColor = ConsoleColor.Black;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                Console.ForegroundColor = ConsoleColor.Black;
                                                Console.WriteLine("\t\tSe han agregado correctamente " + productos.Cantidad + " " + nProducto.miProducto.NombreProducto + " cuyo valor es $" + nProducto.miProducto.ValorUnitario + " c/u");
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

                                            if (productosEscogidos.Count == 0)
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
                                                
                                                Console.WriteLine(gproductoEscogido.MostrarVenta(productosEscogidos));// Muestra la Lista de los productos escogidos

                                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                Console.WriteLine("\t\t********************************************************************************");
                                                Console.ForegroundColor = ConsoleColor.Black;
                                                while (productos.EliminarCantidad <= 0 || productos.EliminarCantidad >= productosEscogidos.Count + 1)
                                                {
                                                    Console.Write("\t\t\n               Selecciona el producto a eliminar : ");
                                                    productos.EliminarCantidad = Int32.Parse(Console.ReadLine()); //permite escribir el producto que se desea eliminar
                                                }
                                                
                                                gproductoEscogido.EliminarProducto(productos.EliminarCantidad, productosEscogidos); // Elimina el producto deseado de la lista de la venta

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

                                                if (productosEscogidos.Count == 0) // Si no hay ningun producto en la lista entrar a este if y que vuelva al menu 
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

                                                    Console.WriteLine(gproductoEscogido.MostrarVentaOrdenada(productosEscogidos));// Muestra la Lista Ordenada de los productos escogidos
                                                    
                                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                    Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                    Console.ForegroundColor = ConsoleColor.Black;
                                                    Console.WriteLine("\t\t~~~~~~~~~~~~~~~          Presione enter para continuar           ~~~~~~~~~~~~~~~");
                                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                                    Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                break;

                                        case 4:
                                            if (productosEscogidos.Count == 0)  // Si no hay ningun producto agregado a la lista entrar a este if  y que vuelva al menu
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

                                                Console.WriteLine(gproductoEscogido.MostrarVentaOrdenada(productosEscogidos));// Muestra la Lista Ordenada de los productos escogidos
                                            
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
                                                        Console.WriteLine(gimprimir.MostrarFactura(productosEscogidos, cliente));
                                                        
                                                        Console.ForegroundColor = ConsoleColor.Green;
                                                        Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                        Console.ForegroundColor = ConsoleColor.Black;
                                                        Console.WriteLine("\t\t~~~~~~~~~~~          Presione enter para imprimir la factura         ~~~~~~~~~~~");
                                                        Console.ForegroundColor = ConsoleColor.Green;
                                                        Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                        Console.WriteLine("\n.\n");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        Console.ForegroundColor = ConsoleColor.Black;
                                                        Console.Write("\t\t");

                                                        //Console.WriteLine(empresa.AgregarSuscriptor(cliente));// Agrega al cliente a la lista de subscriptores

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
                                                        productosEscogidos.Clear(); // Limpia la lista de los productos agregados a la venta
                                                        break;

                                                    case 2:
                                                        Console.WriteLine(gimprimir.MostrarProforma(productosEscogidos, cliente));
                                                    
                                                        Console.ForegroundColor = ConsoleColor.Green;
                                                        Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                        Console.ForegroundColor = ConsoleColor.Black;
                                                        Console.WriteLine("\t\t~~~~~~~~~~~          Presione enter para imprimir la proforma        ~~~~~~~~~~~");
                                                        Console.ForegroundColor = ConsoleColor.Green;
                                                        Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                        Console.WriteLine("\n.\n");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        Console.ForegroundColor = ConsoleColor.Black;
                                                        Console.Write("\t\t");

                                                        //Console.WriteLine(empresa.AgregarSuscriptor(cliente)); // Agrega al cliente a la lista de subscriptores

                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                        Console.ForegroundColor = ConsoleColor.Black;
                                                        Console.WriteLine("\t\t~~~~~~~~~~~~~~~~~~              Compra Finalizada             ~~~~~~~~~~~~~~~~~~");
                                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                                        Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                                        Console.WriteLine("\n.\n");
                                                        accesoVenta = false;
                                                        productosEscogidos.Clear(); // Limpia la lista de los productos agregados a la venta
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                    break;

                                                    case 3:
                                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                        Console.WriteLine("\t\t********************************************************************************");
                                                        Console.ForegroundColor = ConsoleColor.Black;
                                                        Console.WriteLine("\t\t******************          La venta ha sido cancelada         *****************");
                                                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                        Console.WriteLine("\t\t********************************************************************************");

                                                        productosEscogidos.Clear(); // Limpia la lista de los productos agregados a la venta
                                                        
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

                                            productosEscogidos.Clear(); // Limpia la lista de los productos agregados a la venta

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

                                var productonuevo=new Productos { NombreProducto = productos.NuevoProducto, ValorUnitario = productos.NuevoPrecio };
                                inventario.Add(productonuevo);// Agrega el nuevo producto
                                
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("\t\t  Se ha agregado correctamente " + productos.NuevoProducto + " cuyo valor es $" + productos.NuevoPrecio);
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Black;

                                Console.WriteLine(empresa.NuevoProducto(productonuevo.NuevoProducto, suscriptores));    

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

                                if (inventario.Count == 0)
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

                                    Console.WriteLine(gproductos.MostrarInventario(inventario));// Muestra la lista de productos del inventario

                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                    Console.ForegroundColor = ConsoleColor.Black;

                                    while (productos.EliminarCantidad <= 0 || productos.EliminarCantidad >= inventario.Count + 1)
                                    {
                                        Console.Write("\t\tSelecciona el producto a eliminar: ");
                                        productos.EliminarCantidad = Int32.Parse(Console.ReadLine()); //Ingreso del numero del producto a eliminar
                                    }

                                gproductos.EliminarProductoinventario(productos.EliminarCantidad, inventario);

                                }
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("\t\t~~~~~~~~~~~~~~~          Presione enter para continuar           ~~~~~~~~~~~~~~~");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("\t\t--------------------------------------------------------------------------------");
                                Console.ReadKey();
                                productos.EliminarCantidad = 0;
                                Console.Clear();

                                break;


                            case 5:

                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("\t\t********************************************************************************");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("\t\t***********************            Suscriptores          ***********************");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("\t\t********************************************************************************");
                            Console.ForegroundColor = ConsoleColor.Black;

                            // Ordena segun el abecedario los productos del inventario y selecciona su nombre y precio segun el orden que le corresponde.
                            var consulta = suscriptores.OrderBy(p => p.clientee.Apellido).Select(x => new { nombres = x.clientee.Nombre, 
                                apellidos = x.clientee.Apellido, telefono = x.clientee.Contacto }); //[5]
                            int cont = 0;
                            Console.WriteLine("\n\t\t\t\t\tSuscriptor\t\t\t Contacto");
                            foreach (var item in consulta)
                            {
                                cont++;
                                Console.WriteLine("\t\t\t  "+cont+". "+item.apellidos+" "+item.nombres+"\t\t"+item.telefono);
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



                            case 6:

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

                            case 7:

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




