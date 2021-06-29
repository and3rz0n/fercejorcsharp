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
    public class PedidosBL
    {
        PedidosDAO dao;
        //Constructor de la clase

        public PedidosBL()
        {
            dao = new PedidosDAO();
        }

        //Metodo de la clase
        public DataSet ListaPedidos()
        {
            return dao.Listar();
        }
    }
}
