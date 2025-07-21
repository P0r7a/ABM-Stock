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
    public partial class ventanapr : Form
    {
        Metodos Metodos = new Metodos();

        public ventanapr()
        {
            InitializeComponent();
        }
        public ventanapr(bool admin)
        {
            InitializeComponent();
            if (admin)
                btnusua.Visible = true;
        }

        private void pctSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ventanapr_Load(object sender, EventArgs e)
        {
            
            checkBox1.Checked = true;
            comboBox1.Enabled = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            comboBox1.DataSource = Metodos.connR("SELECT Categoria,id_cat FROM Categorias");
            comboBox1.DisplayMember = "Categoria";
            comboBox1.ValueMember = "id_cat";
            dataGridView1.DataSource = Metodos.connR("SELECT Nombre,Cantidad,Descripcion FROM Stock");

        }

        private void comboBox1_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            if (txtbusqueda.Text=="")
            {
               dataGridView1.DataSource=Metodos.connR("SELECT Nombre,Cantidad,Descripcion FROM Stock WHERE id_cat="+comboBox1.SelectedValue);
            }
            else
            {
                dataGridView1.DataSource = Metodos.connR("SELECT Nombre,Cantidad,Descripcion FROM Stock WHERE id_cat=" + comboBox1.SelectedValue+"AND Nombre LIKE '%"+txtbusqueda.Text+"%'");
            }
    
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtbusqueda_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void bsq()
        { 
                if (checkBox1.Checked==true)
                {
                    if (txtbusqueda.Text=="")
                    {
                        dataGridView1.DataSource = Metodos.connR("SELECT Nombre,Cantidad,Descripcion FROM Stock");
                    }
                    else
                    {
                        dataGridView1.DataSource = Metodos.connR("SELECT Nombre,Cantidad,Descripcion FROM Stock WHERE Nombre LIKE '%"+txtbusqueda.Text+"%'");
                    }
                }
                else if (checkBox1.Checked == false)
                {
                    if (txtbusqueda.Text=="")
                    {
                        dataGridView1.DataSource = Metodos.connR("SELECT Nombre,Cantidad,Descripcion FROM Stock WHERE id_cat = " + comboBox1.SelectedValue);
                    }
                    else
                    {
                        dataGridView1.DataSource = Metodos.connR("SELECT Nombre,Cantidad,Descripcion FROM Stock WHERE Nombre LIKE '%" + txtbusqueda.Text + "%' AND id_cat = " + comboBox1.SelectedValue);

                    }
                }
                
        }

        private void btnAña_Click(object sender, EventArgs e)
        {
            using (var confirmationForm = new frmmant())
            {
                confirmationForm.ShowDialog();
            }
            Reload();
            bsq();
        }
        private void Reload()
        {
            comboBox1.DataSource = Metodos.connR("SELECT Categoria,id_cat FROM Categorias");
            comboBox1.DisplayMember = "Categoria";
            comboBox1.ValueMember = "id_cat";
        }

       
        private void btnEli_Click(object sender, EventArgs e)
        {
            try
            {
                int id =Convert.ToInt32(Metodos.ConnR_DR("SELECT ID FROM Stock WHERE Nombre='"+ dataGridView1.SelectedCells[0].Value.ToString() +"'" ,"ID")[0]);
                if (Metodos.SiNo("¿Está seguro de que desea eliminar este producto?") == true)
                {
                    Metodos.connW("DELETE * FROM Stock WHERE ID = " + id);
                    bsq();
                }
            }
            catch (Exception)
            {

                using (var confirmationForm = new frmError("Por favor seleccione un producto para eliminarlo"))
                {
                    confirmationForm.ShowDialog();
                }
            }
            
            

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string Nomb = dataGridView1.SelectedCells[0].Value.ToString();
                string Cant = dataGridView1.SelectedCells[1].Value.ToString();
                string Desc = dataGridView1.SelectedCells[2].Value.ToString();
                string idcat = Metodos.ConnR_DR("SELECT id_cat FROM Stock WHERE Nombre ='" + Nomb + "'", "id_cat")[0];
                string id = Metodos.ConnR_DR("SELECT ID FROM Stock WHERE Nombre='" + Nomb + "'", "ID")[0];
                using (var confirmationForm = new frmmant(Nomb, Cant, Desc, idcat, id))
                {
                    confirmationForm.ShowDialog();
                }
                Reload();
                bsq();
            }
            catch (Exception)
            {
                using (var confirmationForm = new frmError("Por favor seleccione un producto para editarlo"))
                {
                    confirmationForm.ShowDialog();
                }
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
                comboBox1.Enabled = false;
            if (checkBox1.Checked == false)
                comboBox1.Enabled = true;
            bsq();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Metodos.CharVer(e.KeyChar) == true)
            {
                e.Handled = true;
            }

        }



        private void txtbusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            bsq();
        }
    }
}

