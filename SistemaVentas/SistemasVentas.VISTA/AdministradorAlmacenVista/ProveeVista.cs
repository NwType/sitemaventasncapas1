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

namespace SistemasVentas.VISTA.AdministradorAlmacenVista
{
    public partial class ProveeVista : Form
    {
        public ProveeVista()
        {
            InitializeComponent();
        }
        ProveeBss bss = new ProveeBss();
        private void ProveeVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProveeBss();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ProveeVistas.InsertarProveeVista fr = new ProveeVistas.InsertarProveeVista();
            fr.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ProveedorVista fr = new ProveedorVista();
            fr.ShowDialog();
        }
    }
}
