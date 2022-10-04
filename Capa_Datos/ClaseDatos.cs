using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Capa_Logica;

namespace Capa_Datos
{
    public class ClaseDatos
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable D_listar_libros()
        {
            SqlCommand cmd = new SqlCommand("pa_listar_libros", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }
        public DataTable D_buscar_libro(ClaseLogica objeto)
        {
            SqlCommand cmd = new SqlCommand("pa_buscar_libro", cn);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@titulo", objeto.titulo);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public String D_CUD(ClaseLogica objeto)
        {
            String accion = "";
            SqlCommand cmd = new SqlCommand("pa_CUD", cn);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo", objeto.codigo);
            cmd.Parameters.AddWithValue("@titulo", objeto.titulo);
            cmd.Parameters.AddWithValue("@autor", objeto.autor);
            cmd.Parameters.AddWithValue("@editorial", objeto.editorial);
            cmd.Parameters.AddWithValue("@precio", objeto.precio);
            cmd.Parameters.AddWithValue("@cantidad", objeto.cantidad);

            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = objeto.accion;
            cmd.Parameters["@accion"].Direction= ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accion= cmd.Parameters["@accion"].Value.ToString();
            cn.Close();
            return accion;
              

            

        }




    }
}
