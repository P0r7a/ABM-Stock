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
    public partial class frmregistro : Form
    {
        //Instancio el archivo de metodos
        Metodos Metodos = new Metodos();
        bool crearcon = false;
        bool conficon = false;
        public frmregistro()
        {
            
            InitializeComponent();
            chkContra.Image = Properties.Resources.MostrarSub_AzulMarino;
            chkconfcontra.Image = Properties.Resources.MostrarSub_AzulMarino;
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            //Boton de registro
            //Verifico si falta algun dato
            if (txtcrearus.Text == "" | txtcrearcon.Text == "")
            {
                //En caso de que falte se llama al form de error
                using (var confirmationForm = new frmError("Ningun campo puede estar vacio"))
                {
                    confirmationForm.ShowDialog();
                }
                
            }
            else
            {
                //En caso de que esten completos se Verifica los campos de contraseña 
                if (txtcrearcon.Text == txtconfcon.Text)
                {
                    //En caso de que sean iguales
                    try
                    {
                        //Se definen las variables
                        string usu = txtcrearus.Text;
                        string contr = txtcrearcon.Text;
                        //se llama el metodo de Usuario existente 
                        //para verficar que no haya un usiario con el mismo nombre enviandole la consulta
                        string sSQL = "SELECT Usuario FROM Usuarios WHERE Usuario = '" + usu + "'";
                        bool UE = Metodos.Ex(sSQL);
                        if (UE)
                        {
                            //En caso de que el usuario ya exista se llama al from de error
                            using (var confirmationForm = new frmError("Usuario ya existente"))
                            {
                                confirmationForm.ShowDialog();
                            }
                        }
                        else
                        {
                            //en caso de que no exista se la consulta SQL
                            //y se envia al metodo de conexion de lectura a la Base de datos
                            sSQL = "INSERT INTO Usuarios (Usuario, Contraseña) VALUES ('" + usu + "', '" + contr + "')";
                            Metodos.connW(sSQL);
                            //se llama al form de bienvenida
                            using (var confirmationForm = new frmBienv("Usuario registrado correctamente"))
                            {
                                confirmationForm.ShowDialog();
                            }

                        }
                    }
                    catch (Exception err)
                    {
                        //en caso de error se llama el form de error y se le envia el Exception
                        using (var confirmationForm = new frmError(err))
                        {
                            confirmationForm.ShowDialog();
                        }
                    }
                }
                else
                {
                    //En caso de que los campos de contraseña no sean iguales se avisa mediante el form de error
                    using (var confirmationForm = new frmError("Los campos de contraseña y confirmacion deben ser iguales"))
                    {
                        confirmationForm.ShowDialog();
                    }
                } 
            }  
        }


        private void pctSalir_Click(object sender, EventArgs e)
        {
            //Boton de salir que envia al form de login
            Form Ingreso = new frmLogin();
            Ingreso.Show();
            this.Close();
        }


        private void lblLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Boton de Ingreso que envia al form de login
            Form Ingreso = new frmLogin();
            Ingreso.Show();
            this.Close();
        }


        private void pctMostrar_Click(object sender, EventArgs e)
        {
            if (crearcon == true)
            {
                crearcon = false;
                txtcrearcon.PasswordChar = '\0';
            }
            else if (crearcon == false)
            {
                crearcon = true;
                txtcrearcon.PasswordChar = '*';
            }
            
        }


        private void pctMostrar2_Click(object sender, EventArgs e)
        {
            if (conficon == true)
            {
                conficon = false;
                txtconfcon.PasswordChar = '\0';
            }
            else if (conficon == false)
            {
                conficon = true;
                txtconfcon.PasswordChar = '*';
            }
        }


        private void chkContra_CheckedChanged(object sender, EventArgs e)
        {
            if (chkContra.Checked == true)
            {
                txtcrearcon.PasswordChar = '\0';
                chkContra.Image = Properties.Resources.Ocultar_AzulMarino;
            }
            else
            {
                txtcrearcon.PasswordChar = '*';
                chkContra.Image = Properties.Resources.MostrarSub_AzulMarino;
            }
        }


        private void chkconfcontra_CheckedChanged(object sender, EventArgs e)
        {
            if (chkconfcontra.Checked == true)
            {
                txtconfcon.PasswordChar = '\0';
                chkconfcontra.Image = Properties.Resources.Ocultar_AzulMarino;
            }
            else
            {
                txtconfcon.PasswordChar = '*';
                chkconfcontra.Image = Properties.Resources.MostrarSub_AzulMarino;
            }
        }

        private void txtcrearus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnregistro.PerformClick();
            }
        }

        private void txtcrearcon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnregistro.PerformClick();
            }
        }

        private void txtconfcon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnregistro.PerformClick();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtcrearus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Metodos.CharVer(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void txtcrearcon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Metodos.CharVer(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void txtconfcon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Metodos.CharVer(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }


    }
}
