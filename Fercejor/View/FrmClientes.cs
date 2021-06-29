using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fercejor.Controller;

namespace Fercejor.View
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = new ClientesBL().ListaCliente().Tables["Cliente"];

        }
    }
}
