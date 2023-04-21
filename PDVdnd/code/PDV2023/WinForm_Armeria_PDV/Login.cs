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
using Middle_Armeria_PDV;

namespace WinForm_Armeria_PDV
{
    public partial class Login : Form
    {
        CRUDs_BD bd;
        Usuario nuevasesion = new Usuario();

        public Login()
        {
            InitializeComponent();
            bd = new Back_CRUDs_BD.MySql("localhost", "root", "", "armeria_dnd", "3306");

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            nuevasesion = nuevasesion.login(txtUserLogin.Text, txtPasswordLogin.Text);
            try
            {
                if (nuevasesion == null)
                {
                    MessageBox.Show("No coinciden las credenciales. " + Usuario.msgError);
                }
                else
                {

                    //Menu.nuevasesion = this.nuevasesion;
                    this.Hide();
                    //Menu.ShowDialog
                    Menu Menu = new Menu();
                    Menu.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message);
            }
        }
    }
}
