//Nombre                : SumaqMenu.cs
//Proposito             : Implementar un menu decorado por consola
//Autor                 : Cuscapi
//FCreacion             : 5/6/2026

using System;
using System.Collections.Generic;

namespace ProyectoArbolAVL
{
    class SumaqMenu
    {
        #region 1. Atributos
        private string rotulo;
        private List<string> opciones;
        #endregion

        #region 2. Constructores
        // 2.1. Constructor con parametros
        public SumaqMenu(string _rotulo)
        {
            rotulo = _rotulo;
            opciones = new List<string>();
        }
        #endregion

        #region 4. Metodos
        // 4.1. Metodo para agregar opcion
        public void AgregarOpcion(string opcion)
        {
            opciones.Add(opcion);
        }

        // 4.2. Mostrar menu completo
        public void MostrarMenu1()
        {
            // Caracteres UNICODE
            const char SI = '╭'; // Superior Izquierda
            const char SD = '╮'; // Superior Derecha
            const char II = '╰'; // Inferior Izquierda
            const char ID = '╯'; // Inferior Derecha
            const char H = '─';  // Horizontal
            const char V = '│';  // Vertical
            const char UI = '├'; // Unión Izquierda
            const char UD = '┤'; // Unión Derecha

            int tamanio = MaxTamOpcion();
           
            string sH = new string(H, tamanio + 4);
            string eV = new string(' ', tamanio - rotulo.Length + 4);

            // Dibujo del menu
            // Menu parte superior 
            Console.WriteLine(SI + sH + SD);
            Console.WriteLine(V +  rotulo + eV + V);
            Console.WriteLine(UI + sH + UD);
            
            // Menu parte media
            for (int i = 0; i < opciones.Count; i++)
            {
                string espaOpcion = new string(' ', tamanio - opciones[i].Length);
                Console.WriteLine($"{V}{i + 1}. {opciones[i]}{espaOpcion} {V}");
            }

            // Menu parte inferior
            Console.WriteLine(II + sH + ID);
        }

        // 4.3. Cadena mas larga
        private int MaxTamOpcion()
        {
            int maximo = 0;

            foreach (string opcion in opciones)
            {
                if (opcion.Length > maximo)
                {
                    maximo = opcion.Length;
                }
            }
            return maximo;
        }
        #endregion
    }
}