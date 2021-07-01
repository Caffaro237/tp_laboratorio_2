using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class ProductoDAO
    {
        private SqlConnection conexion;
        private SqlCommand comando;

        public ProductoDAO()
        {
            this.conexion = new SqlConnection(Properties.Settings.Default.StringConnection);
            this.comando = new SqlCommand();

            this.comando.Connection = this.conexion;
        }

        public List<Producto> GetProductos(bool PCoNotebook)
        {
            List<Producto> lista = new List<Producto>();

            if(PCoNotebook)
            {
                comando.CommandText = "SELECT id, Marca, CPU, GPU, RAM, Almacenamiento FROM PCEscritorio";
            }
            else
            {
                comando.CommandText = "SELECT id, Marca, CPU, GPU, RAM, Almacenamiento, Pulgadas, Hertz FROM Notebook";
            }

            try
            {
                if (this.conexion.State != System.Data.ConnectionState.Open && this.conexion.State != System.Data.ConnectionState.Connecting)
                {
                    conexion.Open();
                }

                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    int id;
                    int RAM;
                    int almacenamiento;
                    double pulgadas;
                    int hertz;

                    int.TryParse(oDr["id"].ToString(), out id);
                    string marca = oDr["Marca"].ToString();
                    string CPU = oDr["CPU"].ToString();
                    string GPU = oDr["GPU"].ToString();
                    int.TryParse(oDr["RAM"].ToString(), out RAM);
                    int.TryParse(oDr["Almacenamiento"].ToString(), out almacenamiento);

                    if(!PCoNotebook)
                    {
                        double.TryParse(oDr["Pulgadas"].ToString(), out pulgadas);
                        int.TryParse(oDr["Hertz"].ToString(), out hertz);

                        lista.Add(new Notebook(id, marca, CPU, GPU, RAM, almacenamiento, pulgadas, hertz));
                    }
                    else
                    {
                        lista.Add(new PCEscritorio(id, marca, CPU, GPU, RAM, almacenamiento));
                    }

                }

                return lista;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.conexion.Close();
            }

        }

    }
}
