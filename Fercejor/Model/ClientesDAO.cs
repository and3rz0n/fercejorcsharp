using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Fercejor.Model
{
    public class ClientesDAO
    {
        //Crear metodo
        public DataSet Listar()
        {
            //Crear objeto de tipo connection
            SqlConnection cn = new SqlConnection("database=Fercejor2021;server=.;integrated security=true;");
            
            //Crear un objeto DataAdapter
            SqlDataAdapter dap = new SqlDataAdapter("select * from Cliente", cn);

            //Crear objeto DataSet
            DataSet ds = new DataSet();

            //Ejecutar la consulta
            dap.Fill(ds, "Cliente");

            //Retornamos el DS lleno
            return ds;
        }
    }
}