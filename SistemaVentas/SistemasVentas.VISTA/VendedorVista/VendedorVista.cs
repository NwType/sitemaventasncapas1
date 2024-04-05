using SistemasVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.VendedorVista
{
    public partial class VendedorVista : Form
    {
        public VendedorVista()
        {
            InitializeComponent();
        }
        VentaBss bssv = new VentaBss();
        private void VendedorVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bssv.ListarVentaBss();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
           
        }
    }
}
