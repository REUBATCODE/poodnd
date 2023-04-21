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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void accederACRUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form CRUD = new CRUD();
            CRUD.Show();
            //Application.Run(new CRUD());
        }

        private void accederACajaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form CAJA = new Caja_Venta();
            CAJA.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aCCEDERALCRUDDEUSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form CRUD_USUARIOS = new CRUD_Usuarios();
            CRUD_USUARIOS.Show();
        }

        private void cRUDDEUSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
