//Nombre            : CLibro.cs
//Proposito         : Implementar la clase "CLibro"
//Autor             : Cristofer Uscapi Baez
//FCreacion         : 3/6/2026

using System;

namespace ProyectoArbolAVL
{
    public class CLibro
    {
        #region 1. Atributos
        private int idLibro;
        private string titulo;
        private string autor;
        private string anio;
        private string especialidad;
        #endregion

        #region 2. Constructores
        // 2.1. Constructor por defecto
        public CLibro()
        {
            idLibro = 0;
            titulo = "";
            autor = "";
            anio = "";
            especialidad = "";
        }

        // 2.2. Constructor con parametros
        public CLibro(int _idLibro, string _titulo, string _autor, string _anio, string _especialidad)
        {
            idLibro = _idLibro;
            titulo = _titulo;
            autor = _autor;
            anio = _anio;
            especialidad = _especialidad;
        }
        #endregion

        #region 3. Propiedades
        private int IdLibro
        {
            get => idLibro;
            set => idLibro = value;
        }

        private string Titulo
        {
            get => titulo;
            set => titulo = value;
        }

        private string Autor
        {
            get => autor;
            set => autor = value;
        }

        private string Anio
        {
            get => anio;
            set => anio = value;
        }

        private string Especialidad
        {
            get => especialidad;
            set => especialidad = value;
        }
        #endregion

        #region 4. Metodos
        // 4.1. Metodos de polimorfismo
        public override string ToString()
        {
            return IdLibro.ToString();
        }

        // 4.1. Metodo imprimir todos los datos
        public void ImprimirDatos()
        {
            Console.WriteLine("\n - DATOS DEL LIBRO");
            Console.WriteLine("-> IdLibro: " + idLibro);
            Console.WriteLine("-> Titulo: " + titulo);
            Console.WriteLine("-> Autor: " + autor);
            Console.WriteLine("-> Año: " + anio);
            Console.WriteLine("-> Especialidad: " + especialidad);
        }

        // 4.2. Metodo para agreagar los atributos del libro
        public void PedirDatos1()
        {
            Console.WriteLine("\n - INGRESAR DATOS DEL LIBRO");
            Console.Write("<- IdLibro: ");
            idLibro = int.Parse(Console.ReadLine()!);
            Console.Write("<- Titulo: ");
            titulo = Console.ReadLine()!;
            Console.Write("<- Autor: ");
            titulo = Console.ReadLine()!;
            Console.Write("<- Año: ");
            titulo = Console.ReadLine()!;
            Console.Write("<- Especialidad: ");
            titulo = Console.ReadLine()!;
        }

        // 4.2. Metodo para agreagar los atributos del libro
        public void PedirDatos2()
        {
            Console.Write("<- Titulo: ");
            titulo = Console.ReadLine()!;
            Console.Write("<- Autor: ");
            titulo = Console.ReadLine()!;
            Console.Write("<- Año: ");
            titulo = Console.ReadLine()!;
            Console.Write("<- Especialidad: ");
            titulo = Console.ReadLine()!;
        }
        #endregion
    }
}