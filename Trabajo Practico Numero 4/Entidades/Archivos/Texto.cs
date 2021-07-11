using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public class Texto : IArchivo<string>
    {
        #region Implementacion Guardar

        /// <summary>
        /// Implementacion de la interfaz para guardar un archivo de texto
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns> Retorna true si se pudo guardar o false si no se pudo </returns>
        public bool Guardar(string archivo, string datos)
        {
            bool retorno = false;
            Encoding codificacion = Encoding.UTF8;

            try
            {
                using(StreamWriter streamWriter = new StreamWriter(archivo, false, codificacion))
                {
                    streamWriter.WriteLine(datos);
                }

                retorno = true;
            }
            catch(Exception e)
            {
                throw new ArchivosExcepcion(e.Message);
            }

            return retorno;
        }

        #endregion

        #region Implementacion Leer

        /// <summary>
        /// Lee un archivo de texto en una ruta determinada y lo devuelve como un string
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns> Retorna true si se pudo guardar o false si no se pudo </returns>
        public bool Leer(string archivo, out string datos)
        {
            bool retorno = false;
            Encoding codificacion = Encoding.UTF8;

            try
            {
                using(StreamReader streamReader = new StreamReader(archivo, codificacion))
                {
                    datos = streamReader.ReadToEnd();
                }

                retorno = true;
            }
            catch(Exception e)
            {
                throw new ArchivosExcepcion(e.Message);
            }

            return retorno;
        }

        #endregion

    }
}
