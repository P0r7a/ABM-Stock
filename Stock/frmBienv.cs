﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class frmBienv : Form
    {
        public frmBienv(string bnv)
        {
            InitializeComponent();
            //Completo el mensaje recibido en el Textbox
            lblbn.Text = bnv;
        }

        private void pctSalir_Click(object sender, EventArgs e)
        {
            //Boton salir cierra la ventana
            this.Close();
        }

    }
}
