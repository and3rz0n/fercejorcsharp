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
    public class ClientesBL
    {
        ClientesDAO dao;
        //Constructor de la clase

        public ClientesBL()
        {
            dao = new ClientesDAO();
        }

        //Metodo de la clase
        public DataSet ListaCliente()
        {
            return dao.Listar();
        }
    }
}
