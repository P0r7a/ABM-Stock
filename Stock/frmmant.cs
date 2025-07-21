using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{

    public partial class frmmant : Form
    {

        int Idcat;
        int Id;
        bool Edit = false;
        Metodos Metodos = new Metodos();
        int Cant = 0;
        public frmmant()
        {
            InitializeComponent();
        }
        public frmmant(string Nomb, string Cant, string Desc, string Idcatt, string Idd)
        {
            InitializeComponent();
            
            txtnomb.Text = Nomb;
            txtcant.Text = Cant;
            txtdesc.Text = Desc;
            Edit = true;
            Idcat = Convert.ToInt32(Idcatt);
            Id = Convert.ToInt32(Idd);
        }

       
        private void frmmant_Load(object sender, EventArgs e)
        {
            Reload();
            if (Edit == true) 
                comboBox1.SelectedValue = Idcat;
        }

        private void btningresar_Click(object sender, EventArgs e)
        {

            int idcat = Convert.ToInt32(comboBox1.SelectedValue);
            //Verificaciones de campos necesarios
            if (txtnomb.Text == "")
            {
                using (var confirmationForm = new frmError("El campo de Nombre no puede estar vacio"))
                {
                    confirmationForm.ShowDialog();
                    return;
                }
            }
            if (txtcant.Text == "")
            {
                using (var confirmationForm = new frmError("El campo de Cantidad no puede estar vacio"))
                {
                    confirmationForm.ShowDialog();
                    return;
                }
            }
            if (checkBox1.Checked)
            {
                if (txtcat.Text == "")
                {
                    using (var confirmationForm = new frmError("El campo de Categoria no puede estar vacio"))
                    {
                        confirmationForm.ShowDialog();
                        return;
                    }
                }
            }


            //Verifico que el campo de cantidad sea un numero
            try
            {
                Cant = Convert.ToInt32(txtcant.Text);
            }
            catch (Exception)
            {
                //si no es un numero se iguala a 0
                Cant = 0;
            }

            
            //Verifico que no exista una Cat Con el mismo nombre
            if (Metodos.Ex("SELECT Categoria FROM Categorias WHERE Categoria = '"+txtcat.Text+"'"))
            {
                using (var confirmationForm = new frmError("La categoria ya existe"))
                {
                    confirmationForm.ShowDialog();
                    return;
                }
            }


            //Creo nueva Cat si Chekbox de Cat Nuevo esta activo
            if (checkBox1.Checked)
            {
                Metodos.connW("INSERT INTO Categorias (Categoria) VALUES ('" + txtcat.Text + "')");
                idcat = Convert.ToInt32(Metodos.ConnR_DR("SElECT id_cat FROM Categorias WHERE Categoria='" + txtcat.Text + "'", "id_cat")[0]);
            }

            //Verifico que no exista un producto con el mismo nombre
            
            if (Metodos.Ex("SELECT Nombre FROM Stock WHERE Nombre = '" + txtnomb.Text + "' AND ID <> " + Id))
            {
                using (var confirmationForm = new frmError("Ya existe un producto con ese nombre"))
                {
                    confirmationForm.ShowDialog();
                    return;
                }
            }


            //Añado o actualizo el producto dependiendo la variable Edit
            if (Edit)
            {
                Metodos.connW("UPDATE Stock SET Nombre ='" + txtnomb.Text + "', Cantidad=" + txtcant.Text + ", Descripcion ='" + txtdesc.Text + "', id_cat =" + idcat + " WHERE ID=" + Id);
                Reload();
                using (var confirmationForm = new frmBienv("El producto fue actualizado exitosamente"))
                {
                    confirmationForm.ShowDialog();
                }
            }
            else
            {
                Metodos.connW("INSERT INTO Stock (Nombre,Cantidad,Descripcion,id_cat) VALUES ('" + txtnomb.Text + "', " + Cant + ", '" + txtdesc.Text + "', " + idcat + ")");
                Reload();
                using (var confirmationForm = new frmBienv("El producto fue creado exitosamente"))
                {
                    confirmationForm.ShowDialog();
                }
            }

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtcat.Visible = true;
                comboBox1.Visible = false;
                btnelCat.Enabled = false;
            }
            if (checkBox1.Checked == false)
            {
                txtcat.Visible = false;
                comboBox1.Visible = true;
                btnelCat.Enabled = true;
            }
        }

        private void btnelCat_Click(object sender, EventArgs e)
        {

            if (Metodos.Ex("SELECT * FROM Stock WHERE id_cat =" + comboBox1.SelectedValue)==true)
            {
                using (var confirmationForm = new frmError("Debe vaciar los productos de esta categoria antes de eliminarla"))
                {
                    confirmationForm.ShowDialog();
                }
            }
            else
            {
                if (Metodos.SiNo("¿Esta seguro de eliminar esta categoria?")==true)
                {
                    Metodos.connW("DELETE * FROM Categorias WHERE id_cat = " + comboBox1.SelectedValue);
                    Reload();
                } 
                
            }
        }
        private void Reload()
        {
            comboBox1.DataSource = Metodos.connR("SELECT Categoria,id_cat FROM Categorias");
            comboBox1.DisplayMember = "Categoria";
            comboBox1.ValueMember = "id_cat";
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtnomb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Metodos.CharVer(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void txtcant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }

        private void txtdesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Metodos.CharVer(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        
    }
}
