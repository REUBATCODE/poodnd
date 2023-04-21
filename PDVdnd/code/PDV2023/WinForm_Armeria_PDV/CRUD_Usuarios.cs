using Back_CRUDs_BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Armeria_PDV
{
    public partial class CRUD_Usuarios : Form
    {
        CRUDs_BD bd;
        public CRUD_Usuarios()
        {
            InitializeComponent();
        }

        private void CRUD_Usuarios_Load(object sender, EventArgs e)
        {
            this.cargardatos();
        }

        private void btnGuardarUser_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int celdas = e.RowIndex;
                txtIdUser.Text = dataGridView1.Rows[celdas].Cells[0].Value.ToString();
                txtUsuario.Text = dataGridView1.Rows[celdas].Cells[1].Value.ToString();
                txtPassword.Text = dataGridView1.Rows[celdas].Cells[2].Value.ToString();
                comboRol.SelectedItem = dataGridView1.Rows[celdas].Cells[3].Value.ToString();

            }
        }
    }
}
