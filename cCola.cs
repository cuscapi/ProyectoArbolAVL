using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoArbolAVL
{
    public class cCola
    {
        #region *************  ATRIBUTOS    **************** 
        private Object aElemento;
        private cCola aSubCola;
        #endregion ATRIBUTOS

        #region *************  CONSTRUCTORES    **************** 
        public cCola()
        {
            aElemento = null;
            aSubCola = null;
        }
        /* -------------------------------------------- */
        public cCola(Object pElemento, cCola pSubCola)
        {
            aElemento = pElemento;
            aSubCola = pSubCola;
        }
        #endregion CONSTRUCTORES

        #region ***********  METODOS ESTATICOS   *************
        public static cCola Crear()
        {
            return new cCola();
        }
        /* -------------------------------------------- */
        public static cCola Crear(Object pElemento, cCola pSubCola)
        {
            return new cCola(pElemento, pSubCola);
        }
        #endregion METODOS ESTATICOS
        #region ***********  PROPIEDADES   *************
        private object Elemento
        {
            get
            {
                return aElemento;
            }
            set
            {
                aElemento = value;
            }
        }
        /* --------------------------------------------- */
        private cCola SubCola
        {
            get
            {
                return aSubCola;
            }
            set
            {
                aSubCola = value;
            }
        }
        #endregion PROPIEDADES

        #region ***********  OTROS METODOS  *************     
        /* --------------------------------------------- */
        public bool EsVacia()
        {
            return ((aElemento == null) && (aSubCola == null));
        }

        /* --------------------------------------------- */
        public object Primero()
        {
            return aElemento;
        }

        /* --------------------------------------------- */
        public void PonerEnCola(Object pElemento)
        {
            if (EsVacia())
            {
                aSubCola = new cCola();
                aElemento = pElemento;
            }
            else
                aSubCola.PonerEnCola(pElemento);
        }

        /* --------------------------------------------- */
        public void Retirar()
        {
            if (!EsVacia())
            {
                aElemento = aSubCola.Elemento;
                aSubCola = aSubCola.SubCola;
            }
        }
        #endregion OTROS METODOS

    }
}
