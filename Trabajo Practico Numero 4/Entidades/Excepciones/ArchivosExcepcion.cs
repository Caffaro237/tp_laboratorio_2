using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ArchivosExcepcion : Exception
    {
        /// <summary>
        /// Recibe un string como parametro y llama a la base que recibe un mensaje
        /// </summary>
        /// <param name="message"></param>
        public ArchivosExcepcion(string message)
            : base("Se produjo un error en la lectura / escritura del archivo: " + message)
        {

        }
    }
}
