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
                int id = Convert.ToInt32(Metodos.ConnR_DR("SELECT ID FROM Stock WHERE Nombre='" + dataGridView1.SelectedCells[0].Value.ToString() + "'", "ID")[0]);
                if (Metodos.SiNo("¿Está seguro de que desea eliminar este producto?") == true)
                {
                    Metodos.connW("DELETE * FROM Stock WHERE ID = " + id);
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
    }
}
