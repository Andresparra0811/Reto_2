using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Logica;



namespace Capa_Presentacion
{
    public class ClasePresentacion
    {
        ClaseDatos objd = new ClaseDatos();

        public DataTable N_listar_libros()
        {
            return objd.D_listar_libros();

        }
        public DataTable N_buscar_libro(ClaseLogica obje)
        {
            return objd.D_buscar_libro(obje);

        }
        public String N_CUD (ClaseLogica obje)
        {
            return objd.D_CUD(obje);

        }
    }
}
