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

namespace SistemasVentas.VISTA.PersonaVistas
{
    public partial class InsertarPersonaVista : Form
    {
        public InsertarPersonaVista()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        PersonaBss bss =new PersonaBss();

        private void button1_Click_1(object sender, EventArgs e)
        {
            Persona p = new Persona();
            p.Nombre = textBox1.Text;
            p.Apellido = textBox2.Text;
            p.Telefono = Convert.ToInt32(textBox3.Text);
            p.Ci = textBox4.Text;
            p.Correo = textBox5.Text;
            bss.InserarPersonaBss(p);
            MessageBox.Show("Se guardo correctamente");
        }
    }
}