using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Stock
{
    public partial class frmLogin : Form
    {
        //Instancio el archivo de metodos
        Metodos Metodos = new Metodos();

        public frmLogin()
        {
            InitializeComponent();    
            chkContra.Image = Properties.Resources.MostrarSub_AzulMarino; //El picturebox inicia vacio y se llena al iniciar el programa
        }

        private void pctSalir_Click(object sender, EventArgs e)
        {
            //Boton de salir
            if (Metodos.SiNo("Esta seguro de que desea salir")==true)
            {
                Application.Exit();               
            }

        }


      

        private void btnacce_Click(object sender, EventArgs e)
        {
            //verificacion de usurario Existente
            //defino las variables
            string Usu = txtus.Text;
            string Pass = txtcontra.Text;
            //Llamo al metodo de Usuario existente y le envio la consulta
            bool UE = Metodos.Ex("SELECT Usuario FROM Usuarios WHERE Usuario = '" + Usu + "' AND Contraseña = '" + Pass + "'");
            //verifico si el usuario es admin
            bool admin = Metodos.Ex("SELECT Usuario FROM Usuarios WHERE Usuario = '" + Usu + "' AND id = " + 1 + "");

            if (UE == true)
            {
                //en caso del usuario exista
                Form Principal = new ventanapr(admin);
                this.Hide();
                Principal.Show();
            }
            else
            {
                //en caso del usuario no exista
                using (var confirmationForm = new frmError("Usuario y/o contraseña no validos"))
                {
                    confirmationForm.ShowDialog();
                }
                //Login funcional aun sin Usuario y Contraseña a forma de Debug
                Form Usuarios = new frmUsuarios();
                this.Hide();
                Usuarios.Show();
            }


        }


        private void lblReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Boton para el form de registro

            using (var confirmationForm = new frmregistro())
            {
                confirmationForm.ShowDialog();
            }
            //Form Registro = new frmregistro();
            //this.Hide();
            //Registro.Show();
        }


        private void chkContra_CheckedChanged(object sender, EventArgs e)
        {
            if (chkContra.Checked == true) //Si el checkbox no está chequeado 
            {
                txtcontra.PasswordChar = '\0'; //Anula el PasswordChar
                chkContra.Image = Properties.Resources.Ocultar_AzulMarino; //Cambia la imagen del picturebox
            }
            else //Si el checkbox está chequeado
            {
                txtcontra.PasswordChar = '*'; //El PasswordChar se habilita y se cambia a "*"
                chkContra.Image = Properties.Resources.MostrarSub_AzulMarino; //Cambia la imagen del picturebox
            }
        }

        private void txtus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnacce.PerformClick();
            }
        }

        private void txtcontra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnacce.PerformClick();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtus_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* if (Metodos.CharVer(e.KeyChar)==true)
             {
                 e.Handled = true;
             }*/
        }

        private void txtcontra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Metodos.CharVer(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }


       



    }
}

