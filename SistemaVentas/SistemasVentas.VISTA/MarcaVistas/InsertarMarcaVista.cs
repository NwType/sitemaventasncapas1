﻿using SistemasVentas.BSS;
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

namespace SistemasVentas.VISTA.MarcaVistas
{
    public partial class InsertarMarcaVista : Form
    {
        public InsertarMarcaVista()
        {
            InitializeComponent();
        }
        MarcaBss bss = new MarcaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Marca m = new Marca();
            m.Nombre = textBox1.Text;
            bss.InsertarMarcaBss(m);
            MessageBox.Show("Se guardo correctamente");
        }
    }
}
