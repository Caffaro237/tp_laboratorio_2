using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void ActualizarInformacion();

    public static class Hilos
    {
        private static Thread hilo;
        public static event ActualizarInformacion actualizarInfo;

        static Hilos()
        {

        }

        public static void Comenzar()
        {
            while (true)
            {
                Thread.Sleep(750);
                actualizarInfo.Invoke();
            }
        }

    }
}
