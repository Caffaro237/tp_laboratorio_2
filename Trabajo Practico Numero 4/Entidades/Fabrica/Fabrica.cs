using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public static class Fabrica
    {
        #region Atributos

        public static List<Producto> listaProductos;

        #endregion

        #region Constructores

        /// <summary>
        /// Unico contrutor que inicializa la lista de productos
        /// </summary>
        static Fabrica()
        {
            listaProductos = new List<Producto>();
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedad de solo escritura que suma un producto a la lista de productos
        /// </summary>
        public static Producto Producto
        {
            set
            {
                Fabrica.listaProductos += value;
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Lee la lista de productos para ser mostrada
        /// </summary>
        /// <returns> Retornara un StringBuilder con todos los datos </returns>
        public static string MostrarFabricacion()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Producto item in listaProductos)
            {
                if (item is Notebook)
                {
                    sb.AppendLine("****** NOTEBOOK ******");
                    sb.AppendLine(item.ToString());
                }
                else if (item is PCEscritorio)
                {
                    sb.AppendLine("****** PC ESCRITORIO ******");
                    sb.AppendLine(item.ToString());
                }
            }

            return sb.ToString();
        }

        #endregion

    }
}
