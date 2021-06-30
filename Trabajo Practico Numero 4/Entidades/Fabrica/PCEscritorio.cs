using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PCEscritorio : Producto
    {
        #region Constructores

        /// <summary>
        /// Unico constructor que recibe todos los parametros para una PC de Escritorio
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="cpu"></param>
        /// <param name="tarjetaGrafica"></param>
        /// <param name="cantidadRAM"></param>
        /// <param name="cantidadAlmacenamiento"></param>
        public PCEscritorio(string marca, string cpu, string tarjetaGrafica, int cantidadRAM, int cantidadAlmacenamiento)
            : base(marca, cpu, tarjetaGrafica, cantidadRAM, cantidadAlmacenamiento)
        {

        }

        #endregion

        #region Metodos

        /// <summary>
        /// Override del ToString que llama a la base para mostrar los datos
        /// </summary>
        /// <returns> Retornara todos los datos como string </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(base.ToString());

            return sb.ToString();
        }

        #endregion

    }
}
