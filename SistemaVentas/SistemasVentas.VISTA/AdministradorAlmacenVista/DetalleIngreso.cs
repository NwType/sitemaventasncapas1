using SistemasVentas.BSS;
using SistemaVentas.Modelos;
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
    public partial class DetalleIngreso : Form
    {
        public DetalleIngreso()
        {
            InitializeComponent();
        }
        private void DetalleIngreso_Load(object sender, EventArgs e)
        {
            DetalleingBss bssi= new DetalleingBss();
            dataGridView1.DataSource = bssi.ListarDetalleingAdmBss();
        }
        IngresoBss bss= new IngresoBss();
        private void button4_Click(object sender, EventArgs e)
        {
            IngresoVistas.InsertarIngresoVista fr = new IngresoVistas.InsertarIngresoVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarIngresoBss();
            }
        }
    }
}
