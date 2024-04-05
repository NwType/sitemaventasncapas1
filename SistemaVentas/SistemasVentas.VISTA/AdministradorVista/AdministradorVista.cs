using SistemasVentas.BSS;
using SistemasVentas.VISTA.MarcaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.AdministradorVista
{
    public partial class AdministradorVista : Form
    {
        public AdministradorVista()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            VendedorVista.VendedorVista fr = new VendedorVista.VendedorVista();
            {
                dataGridView1.DataSource = dataGridView1.DataSource;
            }
        }
        ProductoBss bssp = new ProductoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bssp.ListarProductoBss();
        }
        VentaBss bssv= new VentaBss();

        private void button2_Click(object sender, EventArgs e)
        {
            VendedorVista.VendedorVista fr = new VendedorVista.VendedorVista();
            fr.ShowDialog();
            {
                dataGridView1.DataSource = bssv.ListarVentaBss();
            }
        }
    }
}
