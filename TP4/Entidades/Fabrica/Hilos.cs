using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    #region Delegados

    /// <summary>
    /// Delegado encargado de mantener toda la informacion actualizada
    /// que se muestre en el cuadro de texto del formulario principal
    /// </summary>
    public delegate void ActualizarInformacion();

    #endregion

    public static class Hilos
    {
        #region Atributos

        public static event ActualizarInformacion actualizarInfo;

        #endregion

        #region Metodos

        /// <summary>
        /// Metodo que pausara el hilo por 500 milisegundos
        /// y luego invocara a actualizarInfo
        /// </summary>
        public static void Comenzar()
        {
            while (true)
            {
                Thread.Sleep(500);
                actualizarInfo.Invoke();
            }
        }

        #endregion

    }
}
