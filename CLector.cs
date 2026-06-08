//Nombre            : CLector.cs
//Proposito         : Implementar la clase "Clector"
//Autor             : Cristofer Uscapi Baez
//FCreacion         : 3/6/2026

using System;

namespace ProyectoArbolAVL
{
    public class CLector
    {
        #region 1. Atributos
        private int idLector;
        private string aPaterno;
        private string aMaterno;
        private string nombres;
        private string condicion;
        private string email;
        #endregion

        #region 2. Constructores
        // 2.1. Constructor por defecto
        public CLector()
        {
            idLector = 0;
            aPaterno = "";
            aMaterno = "";
            nombres = "";
            condicion = "";
            email = "";
        }

        // 2.2. Constructor con parametros
        public CLector(int _idLector, string _aPaterno, string _aMaterno, string _nombres, string _condicion, string _email)
        {
            idLector = _idLector;
            aPaterno = _aPaterno;
            aMaterno = _aMaterno;
            nombres = _nombres;
            condicion = _condicion;
            email = _email;
        }
        #endregion

        #region 3. Propiedades
        private int IdLector
        {
            get => idLector;
            set => idLector = value;
        }

        private string APaterno
        {
            get => aPaterno;
            set => aPaterno = value;
        }

        private string AMaterno
        {
            get => aMaterno;
            set => aMaterno = value;
        }

        private string Nombres
        {
            get => nombres;
            set => nombres = value;
        }

        private string Condicion
        {
            get => condicion;
            set => condicion = value;
        }

        private string Email
        {
            get => email;
            set => email = value;
        }
        #endregion

        #region 4. Metodos
        // 4, Polimorfismo
        public override string ToString()
        {
            return idLector.ToString();
        }

        // 4.1. Metodo imprimir todos los datos
        public void ImprimirDatos()
        {
            Console.WriteLine("\n - DATOS DEL LECTOR");
            Console.WriteLine("-> IdLector: " + idLector);
            Console.WriteLine("-> Apellido Paterno: " + aPaterno);
            Console.WriteLine("-> Apellido Materno: " + aMaterno);
            Console.WriteLine("-> Nombres: " + nombres);
            Console.WriteLine("-> Condicion: " + condicion);
            Console.WriteLine("-> Email: " + email);
        }

        // 4.2. Método para agregar los atributos al lector
        public void PedirDatos1()
        {
            Console.WriteLine("\n - INGRESAR DATOS DEL LECTOR");
            Console.Write("<- IdLector: ");
            idLector = int.Parse(Console.ReadLine()!);
            Console.Write("<- Apellido Paterno: ");
            aPaterno = Console.ReadLine()!;
            Console.Write("<- Apellido Materno: ");
            aMaterno = Console.ReadLine()!;
            Console.Write("<- Nombres: ");
            nombres = Console.ReadLine()!;
            Console.Write("<- Condicion: ");
            condicion = Console.ReadLine()!;
            Console.Write("<- Email: ");
            email = Console.ReadLine()!;
        }

        // 4.3. Método para agregar los atributos al lector sin el ID
        public void PedirDatos2()
        {
            Console.Write("<- Apellido Paterno: ");
            aPaterno = Console.ReadLine()!;
            Console.Write("<- Apellido Materno: ");
            aMaterno = Console.ReadLine()!;
            Console.Write("<- Nombres: ");
            nombres = Console.ReadLine()!;
            Console.Write("<- Condicion: ");
            condicion = Console.ReadLine()!;
            Console.Write("<- Email: ");
            email = Console.ReadLine()!;
        }
        #endregion
    }
}