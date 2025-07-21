using System;
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
    public partial class frmError : Form
    {
        public frmError()
        {
            InitializeComponent();
        }
        public frmError(string err)
        {
            InitializeComponent();
            //Completo el mensage recibido en el Textbox
            lblErr.Text = err;

        }
        public frmError(Exception err)
        {
            InitializeComponent();
            //Completo el Exception recibido en el Textbox
            lblErr.Text = err.Message;

        }

        private void pctSalir_Click(object sender, EventArgs e)
        {
            //Boton de salir cierra la ventana de error
            this.Close();
        }


    }
}
