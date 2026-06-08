//Nombre            : Program.cs
//Proposito         : Implementar el programa principal del proyecto
//Autor             : Cristofer Uscapi Baez
//FCreacion         : 3/6/2026

using System;

namespace ProyectoArbolAVL
{
    class Program
    {
        // 1. Programa principal
        static void Main(string[] args)
        {
            int opcion1;
            int opcion2;

            // Objeto Menu principal
            SumaqMenu menu1 = new SumaqMenu("MENU PRINCIPAL");
            menu1.AgregarOpcion("Gestion de Libros");
            menu1.AgregarOpcion("Gestion de Lectores");
            menu1.AgregarOpcion("Gestion de Prestamos");
            menu1.AgregarOpcion("Reportes");
            menu1.AgregarOpcion("Salir");

            // Objeto Menu Libros
            SumaqMenu menu11 = new SumaqMenu("GESTION DE LIBROS");
            menu11.AgregarOpcion("Agregar libro");
            menu11.AgregarOpcion("Listar libros");
            menu11.AgregarOpcion("Modificar libro");
            menu11.AgregarOpcion("Eliminar libro");
            
            // Objeto Menu Lectores
            SumaqMenu menu12 = new SumaqMenu("GESTION DE LECTORES");
            menu12.AgregarOpcion("Agregar lector");
            menu12.AgregarOpcion("Listar lector");
            menu12.AgregarOpcion("Modificar lector");
            menu12.AgregarOpcion("Eliminar lector");

            // Objeto Menu Prestamos
            SumaqMenu menu13 = new SumaqMenu("GESTION DE PRESTAMOS");
            menu13.AgregarOpcion("Agregar prestamo");
            menu13.AgregarOpcion("Listar prestamos");
            menu13.AgregarOpcion("Modificar prestamo");
            menu13.AgregarOpcion("Eliminar prestamo");
                        
            // Objeto Menu de reportes
            SumaqMenu menu14 = new SumaqMenu("REPORTES");
            menu14.AgregarOpcion("Listar libros por especialidad");
            menu14.AgregarOpcion("Listar prestamos que aún no tienen fecha de devolución del préstamo");
            menu14.AgregarOpcion("Listar lectores que tengan pendiente la devolucion de algún libro");
            menu14.AgregarOpcion("Salir");

            // Objetos AVL
            cArbolAVL librosAVL = new cArbolAVL();
            cArbolAVL lectoresAVL = new cArbolAVL();
            cArbolAVL prestamosAVL = new cArbolAVL();

            // Carga inicial de datos
            CargaLibros(librosAVL);
            CargaLectores(lectoresAVL);
            CargaPrestamos(prestamosAVL, lectoresAVL, librosAVL);

            do
            {
                Console.WriteLine("\nBLIBLIOTECA ESPECIALIZADA UNSAAC");
                menu1.MostrarMenu1();
                Console.Write("<- Opcion: ");
                opcion1 = int.Parse(Console.ReadLine()!);

                switch (opcion1)
                {
                    case 1:
                    	menu11.MostrarMenu1();
                        RegistrarLibro(librosAVL);
                        break;
                        
                    case 2:
                    	menu12.MostrarMenu1();
                        RegistrarLectores(lectoresAVL);
                        break;

                    case 3:
                    	menu13.MostrarMenu1();
                        RegistrarPrestamo(prestamosAVL, lectoresAVL, librosAVL);
                        break;

                    case 4:
                    	menu14.MostrarMenu1();
                        Console.Write("<- Opcion: ");
                        opcion2 = int.Parse(Console.ReadLine()!);

                        switch (opcion2)
                        {
                            case 1:

                                break;

                            case 2:
                                break;

                            case 3:
                                break;
                        }
                        break;
                }

            } while (opcion1 != 5);

            // Mensaje de salida
            Console.WriteLine("-> Adios :( ...");
            Console.ReadKey();
        }

        #region 1. Carga de datos
        // 1.1. Metodo carga de libros
        static void CargaLibros(cArbolAVL arbol)
        {
            // Objetos tipo libro
            CLibro l1  = new CLibro(1,  "Programación en Python", "Guido van Rossum", "2020", "Ing. Informatica");
            CLibro l2  = new CLibro(2,  "Fundamentos de Algoritmos", "Thomas Cormen", "2019", "Ing. Informatica");
            CLibro l3  = new CLibro(3,  "Estructuras de Datos en C#", "Mark Weiss", "2021", "Ing. Informatica");
            CLibro l4  = new CLibro(4,  "Bases de Datos Relacionales", "Abraham Silberschatz", "2018", "Ing. Informatica");
            CLibro l5  = new CLibro(5,  "Ingeniería de Software", "Ian Sommerville", "2022", "Ing. Informatica");
            CLibro l6  = new CLibro(6,  "Programación Orientada a Objetos", "Bertrand Meyer", "2019", "Ing. Informatica");
            CLibro l7  = new CLibro(7,  "Redes de Computadoras", "Andrew Tanenbaum", "2020", "Ing. Informatica");
            CLibro l8  = new CLibro(8,  "Sistemas Operativos Modernos", "Andrew Tanenbaum", "2021", "Ing. Informatica");
            CLibro l9  = new CLibro(9,  "Desarrollo Web con ASP.NET", "Jon Galloway", "2023", "Ing. Informatica");
            CLibro l10 = new CLibro(10, "Inteligencia Artificial", "Stuart Russell", "2022", "Ing. Informatica");
            CLibro l11 = new CLibro(11, "Machine Learning", "Tom Mitchell", "2021", "Ing. Informatica");
            CLibro l12 = new CLibro(12, "Ciencia de Datos", "Joel Grus", "2023", "Ing. Informatica");
            CLibro l13 = new CLibro(13, "Seguridad Informática", "William Stallings", "2020", "Ing. Informatica");
            CLibro l14 = new CLibro(14, "Criptografía Aplicada", "Bruce Schneier", "2019", "Ing. Informatica");
            CLibro l15 = new CLibro(15, "Arquitectura de Computadoras", "David Patterson", "2022", "Ing. Informatica");
            CLibro l16 = new CLibro(16, "Programación en Java", "Herbert Schildt", "2021", "Ing. Informatica");
            CLibro l17 = new CLibro(17, "Programación en C++", "Bjarne Stroustrup", "2020", "Ing. Informatica");
            CLibro l18 = new CLibro(18, "Desarrollo de Aplicaciones Móviles", "Bill Phillips", "2023", "Ing. Informatica");
            CLibro l19 = new CLibro(19, "Computación en la Nube", "Rajkumar Buyya", "2022", "Ing. Informatica");
            CLibro l20 = new CLibro(20, "Análisis y Diseño de Sistemas", "Kendall & Kendall", "2021", "Ing. Informatica");

            // Agregamos al arbol AVL
            arbol.Agregar(l1);
            arbol.Agregar(l2);
            arbol.Agregar(l3);
            arbol.Agregar(l4);
            arbol.Agregar(l5);
            arbol.Agregar(l6);
            arbol.Agregar(l7);
            arbol.Agregar(l8);
            arbol.Agregar(l9);
            arbol.Agregar(l10);
            arbol.Agregar(l11);
            arbol.Agregar(l12);
            arbol.Agregar(l13);
            arbol.Agregar(l14);
            arbol.Agregar(l15);
            arbol.Agregar(l16);
            arbol.Agregar(l17);
            arbol.Agregar(l18);
            arbol.Agregar(l19);
            arbol.Agregar(l20);
        }

        // 1.2. Carga de lectores
        static void CargaLectores(cArbolAVL arbol)
        {
            CLector l1  = new CLector(1,  "Perez", "Gomez", "Juan", "Estudiante", "juan@unsa.edu.pe");
            CLector l2  = new CLector(2,  "Quispe", "Mamani", "Maria", "Estudiante", "maria@unsa.edu.pe");
            CLector l3  = new CLector(3,  "Torres", "Lopez", "Carlos", "Docente", "carlos@unsa.edu.pe");
            CLector l4  = new CLector(4,  "Flores", "Diaz", "Ana", "Estudiante", "ana@unsa.edu.pe");
            CLector l5  = new CLector(5,  "Rojas", "Soto", "Luis", "Docente", "luis@unsa.edu.pe");
            CLector l6  = new CLector(6,  "Vargas", "Castro", "Elena", "Administrativo", "elena@unsa.edu.pe");
            CLector l7  = new CLector(7,  "Huaman", "Paredes", "Pedro", "Estudiante", "pedro@unsa.edu.pe");
            CLector l8  = new CLector(8,  "Cruz", "Valdez", "Rosa", "Estudiante", "rosa@unsa.edu.pe");
            CLector l9  = new CLector(9,  "Mendoza", "Salas", "Jorge", "Docente", "jorge@unsa.edu.pe");
            CLector l10 = new CLector(10, "Garcia", "Nuñez", "Lucia", "Estudiante", "lucia@unsa.edu.pe");

            arbol.Agregar(l1);
            arbol.Agregar(l2);
            arbol.Agregar(l3);
            arbol.Agregar(l4);
            arbol.Agregar(l5);
            arbol.Agregar(l6);
            arbol.Agregar(l7);
            arbol.Agregar(l8);
            arbol.Agregar(l9);
            arbol.Agregar(l10);
        }

        // 1.3. Carga de prestamos
        static void CargaPrestamos(cArbolAVL arbol1, cArbolAVL arbol2, cArbolAVL arbol3)
        {
            CPrestamo p1  = new CPrestamo(1, 1, 1,  "01/06/2026", "08/06/2026");
            CPrestamo p2  = new CPrestamo(2, 2, 2,  "02/06/2026", "09/06/2026");
            CPrestamo p3  = new CPrestamo(3, 3, 3,  "03/06/2026", "10/06/2026");
            CPrestamo p4  = new CPrestamo(4, 4, 4,  "04/06/2026", "11/06/2026");
            CPrestamo p5  = new CPrestamo(5, 5, 5,  "05/06/2026", "12/06/2026");
            CPrestamo p6  = new CPrestamo(6, 6, 6,  "06/06/2026", "13/06/2026");
            CPrestamo p7  = new CPrestamo(7, 7, 7,  "07/06/2026", "14/06/2026");
            CPrestamo p8  = new CPrestamo(8, 8, 8,  "08/06/2026", "15/06/2026");
            CPrestamo p9  = new CPrestamo(9, 9, 9,  "09/06/2026", "16/06/2026");
            CPrestamo p10 = new CPrestamo(10, 10, 10, "10/06/2026", "17/06/2026");

            arbol1.Agregar(p1);
            arbol1.Agregar(p2);
            arbol1.Agregar(p3);
            arbol1.Agregar(p4);
            arbol1.Agregar(p5);
            arbol1.Agregar(p6);
            arbol1.Agregar(p7);
            arbol1.Agregar(p8);
            arbol1.Agregar(p9);
            arbol1.Agregar(p10);
        }
        #endregion

        #region 2. Metodos adicionales
        // 2.1. Registrar libro
        static void RegistrarLibro(cArbolAVL arbol)
        {
            int idLibro;
            Console.WriteLine("\n - INGRESAR DATOS DEL LIBRO");
            Console.Write("<- IdLibro: ");
            idLibro = int.Parse(Console.ReadLine()!);

            // Verificamos si el libro existe en el arbol
            while (arbol.Existe(idLibro)!)
            {
                Console.WriteLine("Error, ¡el libro ya existe! :( ...");
                Console.Write("\n<- IdLibro: ");
                idLibro = int.Parse(Console.ReadLine()!);
            }

            // Creamos el libro
            CLibro libro = new CLibro();
            libro.PedirDatos2();
            arbol.Agregar(libro);
            Console.WriteLine("\nLibro agregado :) ...");
        }

        // 2.3. Registrar lectores
        static void RegistrarLectores(cArbolAVL arbol)
        {
            int idLector;
            Console.WriteLine("\n - INGRESAR DATOS DEL LIBRO");
            Console.Write("<- idLector: ");
            idLector = int.Parse(Console.ReadLine()!);

            // Verificamos si el lector existe en el arbol
            while (arbol.Existe(idLector)!)
            {
                Console.WriteLine("Error, ¡el lector ya existe! :( ...");
                Console.Write("\n<- idLector: ");
                idLector = int.Parse(Console.ReadLine()!);
            }
            
            // Creamos el lector
            CLector lector = new CLector();
            lector.PedirDatos2();
            arbol.Agregar(lector);
            Console.WriteLine("\nLector agregado :) ...");
        }

        // 2.4. Registrar prestamo
        static void RegistrarPrestamo(cArbolAVL arbol1, cArbolAVL arbol2, cArbolAVL arbol3)
        {
            int nroFicha;
            int idLector;
            int idLibro;

            Console.WriteLine("\n - INGRESAR DATOS DEL PRESTAMO");

            // Primer filtro nroFicha
            Console.Write("<- nroFicha: ");
            nroFicha = int.Parse(Console.ReadLine()!);

            // Verificamos si el lector existe en el arbol
            while (arbol1.Existe(nroFicha)!)
            {
                Console.WriteLine("Error, ¡el prestamo ya existe! :( ...");
                Console.Write("\n<- nroFicha: ");
                nroFicha = int.Parse(Console.ReadLine()!);
            }
        
            // Segundo filtro idLector
            Console.Write("<- idLector: ");
            idLector = int.Parse(Console.ReadLine()!);

            // Verificamos si el lector existe en el arbol
            if (arbol2.Existe(idLector))
            {                            
                // Tercer filtro idLibro
                Console.Write("<- IdLibro: ");
                idLibro = int.Parse(Console.ReadLine()!);

                // Verificamos si el libro existe en el arbol
                if (arbol3.Existe(idLibro))
                {
                    CPrestamo prestamo = new CPrestamo(nroFicha, idLector, idLibro);
                    prestamo.PedirDatos2();
                    arbol1.Agregar(prestamo);
                    Console.WriteLine("\nPrestamo agregado :) ...");
                }
                else
                {
                    Console.WriteLine("Error, ¡el no libro no existe! :( ...");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Error, ¡el lector no existe! :( ...");
                return;
            }
            
        }

        #endregion
    }
}
