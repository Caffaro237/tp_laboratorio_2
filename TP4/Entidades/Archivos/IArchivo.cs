using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IArchivo<T>
    {
        #region Firma Guardar

        /// <summary>
        /// Firma de interfaz generica para guardar un archivo
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        bool Guardar(string archivo, T datos);

        #endregion

        #region Firma Leer

        /// <summary>
        /// Firma de interfaz generica para leer un archivo
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns> 
        bool Leer(string achivo, out T datos);

        #endregion
    }
}
