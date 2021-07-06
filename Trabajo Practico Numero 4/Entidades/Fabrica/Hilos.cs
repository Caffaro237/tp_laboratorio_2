using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void ManejarInformacion();

    public class Hilos
    {
        private Thread hilo;
        static event ManejarInformacion actualizarInfo;

        public Hilos()
        {

            //hilo.Start();
        }

        public static void Comenzar()
        {
            while (true)
            {
                Thread.Sleep(5000);
                actualizarInfo.Invoke();
            }
        }

        private void ConsultaSQL()
        {

        }
    }
}
