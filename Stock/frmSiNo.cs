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
    public partial class frmSiNo : Form
    {
        public frmSiNo()
        {
            InitializeComponent();
        }
        public bool UsuarioDijoSi { get; private set; }


        public frmSiNo(string mensaje)
        {
            InitializeComponent();
            lblmsg.Text = mensaje;
            //lblmsg.Left = (this.Width / 2) / 2;
        }





        private void frmSiNo_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            UsuarioDijoSi = true;
            Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            UsuarioDijoSi = false;
            Close();
        }
    }
}
