using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Fercejor.Model;

namespace Fercejor.Controller
{
    public class ProductosBL
    {
        ProductosDAO dao;
        //Constructor de la clase

        public ProductosBL()
        {
            dao = new ProductosDAO();
        }

        //Metodo de la clase
        public DataSet ListaProductos()
        {
            return dao.Listar();
        }
    }
}
