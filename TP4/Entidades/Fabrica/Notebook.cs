﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Notebook : Producto
    {
        #region Atributos

        private double pulgadas;
        private int hzPantalla;

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor sin parametros. Requerido por el serializer de la clase ArchivoXml.cs
        /// </summary>
        public Notebook()
        {

        }

        /// <summary>
        /// Unico constructor que recibe todos los parametros para una notebook
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="cpu"></param>
        /// <param name="tarjetaGrafica"></param>
        /// <param name="cantidadRAM"></param>
        /// <param name="cantidadAlmacenamiento"></param>
        /// <param name="pulgadas"></param>
        /// <param name="hzPantalla"></param>
        public Notebook(int id, string marca, string cpu, string tarjetaGrafica, int cantidadRAM, int cantidadAlmacenamiento, double pulgadas, int hzPantalla) 
            : base(id, marca, cpu, tarjetaGrafica, cantidadRAM, cantidadAlmacenamiento)
        {
            this.pulgadas = pulgadas;
            this.hzPantalla = hzPantalla;
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedad de lectura y escritura para las pulgadas de la pantalla del producto
        /// </summary>
        public double Pulgadas
        {
            get
            {
                return this.pulgadas;
            }
            set
            {
                this.pulgadas = value;
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura para los hertz de la pantalla del producto
        /// </summary>
        public int Hertz
        {
            get
            {
                return this.hzPantalla;
            }
            set
            {
                this.hzPantalla = value;
            }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Override del ToString que llama a la base para mostrar los datos
        /// Y anexar las pulgadas y los Hertz de la pantalla
        /// </summary>
        /// <returns> Retornara todos los datos como string </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(base.ToString());
            sb.Append($"La pantalla tiene: {this.pulgadas} pulgadas y");
            sb.AppendLine($" {this.hzPantalla}Hz");

            return sb.ToString();
        }

        #endregion

    }
}
