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
    public partial class frmUsuarios : Form
    {
        Metodos Metodos = new Metodos();
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.DataSource = Metodos.connR("SELECT Usuario FROM Usuarios");
        }

        private void btnelim_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(Metodos.ConnR_DR("SELECT id FROM Usuarios WHERE Usuario='" + dataGridView1.SelectedCells[0].Value.ToString() + "'", "id")[0]);

                if (id == 1)
                {
                    using (var confirmationForm = new frmError("No se puede eliminar el Ususario de Administrador"))
                    {
                        confirmationForm.ShowDialog();
                        return;
                    }
                }
                
                if (Metodos.SiNo("¿Está seguro de que desea eliminar este Usuario?"))
                {
                    Metodos.connW("DELETE * FROM Usuarios WHERE id = " + id);
                    dataGridView1.DataSource = Metodos.connR("SELECT Usuario FROM Usuarios");
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

        private void button1_Click(object sender, EventArgs e)
        {
            var Form = new frmregistro();
            {
                Form.ShowDialog();
                dataGridView1.DataSource = Metodos.connR("SELECT Usuario FROM Usuarios");
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            //Boton de salir
            if (Metodos.SiNo("Esta seguro de que desea salir") == true)
            {
                Application.Exit();
            }
        }
    }
}
