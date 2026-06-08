//Nombre            : CPrestamo.cs
//Proposito         : Implementar la clase "CPrestamo"
//Autor             : Cristofer Uscapi Baez
//FCreacion         : 3/6/2026

using System;

namespace ProyectoArbolAVL
{
    public class CPrestamo
    {
        #region 1. Atributos
        private int nroFicha;
        private int idLector;
        private int idLibro;
        private string fechaPrestamo;
        private string fechaDevolucion;
        #endregion

        #region 2. Constructores
        // 2.1. Constructor por defecto
        public CPrestamo()
        {
            nroFicha = 0;
            idLector =0;
            idLibro = 0;
            fechaPrestamo = "";
            fechaDevolucion = "";
        }

        // 2.2. Constructor con parametros
        public CPrestamo(int _nroFicha, int _idLector, int _idLibro)
        {
            nroFicha = _nroFicha;
            idLector = _idLector;
            idLibro = _idLibro;
        }

        // 2.3. Constructor con parametros
        public CPrestamo(int _nroFicha, int _idLector, int _idLibro, string _fechaPrestamo, string _fechaDevolucion)
        {
            nroFicha = _nroFicha;
            idLector = _idLector;
            idLibro = _idLibro;
            fechaPrestamo = _fechaPrestamo;
            fechaDevolucion = _fechaDevolucion;
        }
        #endregion

        #region 3. Propiedades
        private int NroFicha
        {
            get => nroFicha;
            set => nroFicha = value;
        }

        private int IdLector
        {
            get => idLector;
            set => idLector = value;
        }

        private int IdLibro
        {
            get => idLibro;
            set => idLibro = value;
        }

        private string FechaPrestamo
        {
            get => fechaPrestamo;
            set => fechaPrestamo = value;
        }

        private string FechaDevolucion
        {
            get => fechaDevolucion;
            set => fechaDevolucion = value;
        }
        #endregion

        #region 4. Metodos
        // 4. Polimorfismo
        public override string ToString()
        {
            return nroFicha.ToString();
        }

        // 4.1. Metodo imprimir todos los datos
        public void ImprimirDatos()
        {
            Console.WriteLine("\n - DATOS DEL PRESTAMO");
            Console.WriteLine("-> nroFicha: " + nroFicha);
            Console.WriteLine("-> IdLector: " + idLector);
            Console.WriteLine("-> IdLibro: " + idLibro);
            Console.WriteLine("-> Fecha de prestamo: " + fechaPrestamo);
            Console.WriteLine("-> fecha de devolucion: " + fechaDevolucion);
        }

        // 4.2. Metodo para agregar los atributos al prestamo
        public void PedirDatos1()
        {
            Console.WriteLine("\n - INGRESAR DATOS DEL PRESTAMO");
            Console.Write("<- nroFicha: ");
            nroFicha = int.Parse(Console.ReadLine()!);
            Console.Write("<- IdLector: ");
            idLector = int.Parse(Console.ReadLine()!);
            Console.Write("<- IdLibro: ");
            idLibro = int.Parse(Console.ReadLine()!);
            Console.Write("<- Fecha de prestamo: ");
            fechaPrestamo = Console.ReadLine()!;
            Console.Write("<- Fecha de devolucion: ");
            fechaDevolucion = Console.ReadLine()!;
        }

        // 4.3. Metodo para agregar los atributos al prestamo
        public void PedirDatos2()
        {
            Console.Write("<- Fecha de prestamo: ");
            fechaPrestamo = Console.ReadLine()!;
            Console.Write("<- Fecha de devolucion: ");
            fechaDevolucion = Console.ReadLine()!;
        }
        #endregion
    }
}
