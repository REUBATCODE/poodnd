using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Back_CRUDs_BD;
using Middle_Armeria_PDV;

namespace WinForm_Armeria_PDV
{
    public partial class CRUD : Form

    {
        Producto prod = new Producto(); //un tipo de producto vacio. 
        CRUDs_BD bd;//para utilizar la conexión a la bd
        int identificador = 0;

        public CRUD()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                int celdas = e.RowIndex;
                pictureBoxImagen.ImageLocation = "..\\..\\..\\..\\..\\..\\..\\prods\\" + txtimagen.Text;//recargar foto

                txtnombre.Text = dgridEquipamiento.Rows[celdas].Cells[1].Value.ToString();
                txtprecio.Text = dgridEquipamiento.Rows[celdas].Cells[2].Value.ToString();
                txtcodbarras.Text = dgridEquipamiento.Rows[celdas].Cells[3].Value.ToString();
                comboTipo.SelectedItem = dgridEquipamiento.Rows[celdas].Cells[4].Value.ToString();
                pictureBoxImagen.ImageLocation = dgridEquipamiento.Rows[celdas].Cells[5].Value.ToString();



                pictureBoxImagen.ImageLocation = "..\\..\\..\\..\\..\\..\\..\\prods\\" + txtimagen.Text;
                this.identificador = int.Parse(dgridEquipamiento.Rows[celdas].Cells[0].Value.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Tipo valorTipo;
            switch (comboTipo.SelectedItem.ToString())
            {
                case "ESPADA":
                    valorTipo = Tipo.ESPADA;
                    break;
                case "HACHA":
                    valorTipo = Tipo.HACHA;
                    break;
                case "LANZA":
                    valorTipo = Tipo.LANZA;
                    break;
                case "ESCUDO":
                    valorTipo = Tipo.ESCUDO;
                    break;
                case "ARMADURA":
                    valorTipo = Tipo.ARMADURA;
                    break;
                default:
                    valorTipo = Tipo.ESPADA;
                    break;
            }
            bool resultado = prod.crear(txtnombre.Text, int.Parse(txtprecio.Text), txtcodbarras.Text, txtimagen.Text, valorTipo);
            if (resultado == false)
            {
                MessageBox.Show("Error al registrar producto. Verifique los datos. " + Producto.msgError);
            }
            else
            {
                MessageBox.Show("Producto registrado con éxito. ");
                if (pictureBoxImagen.Image != null)
                {
                    pictureBoxImagen.Image.Save("..\\..\\..\\..\\..\\..\\..\\prods" + txtimagen.Text);
                }

                this.limpiarForm(true);
                this.CRUD_Load(sender, e);
            }
        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Tipo valorTipo;
            switch (comboTipo.SelectedItem.ToString())
            {
                case "ESPADA":
                    valorTipo = Tipo.ESPADA;
                    break;
                case "HACHA":
                    valorTipo = Tipo.HACHA;
                    break;
                case "LANZA":
                    valorTipo = Tipo.LANZA;
                    break;
                case "ESCUDO":
                    valorTipo = Tipo.ESCUDO;
                    break;
                case "ARMADURA":
                    valorTipo = Tipo.ARMADURA;
                    break;
                default:
                    valorTipo = Tipo.ESPADA;
                    break;
            }
            bool resultado = prod.modificar(txtnombre.Text, int.Parse(txtprecio.Text), txtcodbarras.Text, txtimagen.Text, valorTipo, this.identificador);
            if (resultado == false)
            {
                MessageBox.Show("ERROR AL MODIFICAR PRODUCTO" + Producto.msgError);
            }
            else
            {
                MessageBox.Show("PRODUCTO MODIFICADO CON ÉXITO");
                if (pictureBoxImagen.Image != null)
                {
                    pictureBoxImagen.Image.Save("..\\..\\..\\..\\..\\..\\..\\prods\\" +txtimagen.Text);
                }

            }
            this.limpiarForm(false);
            this.CRUD_Load(sender, e);
        }
        private void CRUD_Load(object sender, EventArgs e)
        {
            this.cargarDatos();
        }

        public void cargarDatos()
        {
            dgridEquipamiento.Rows.Clear();
            List<object[]> datos = prod.consultarTodos();
            for (int i = 0; i < datos.Count; i++)
            {
                //MessageBox.Show(datos[i].ElementAt(0).ToString() + datos[i].ElementAt(4).ToString());
                //dgridEquipamiento.Rows.Add(datos[i]);
                try
                {
                    dgridEquipamiento.Rows.Add(datos[i].ElementAt(0).ToString(), datos[i].ElementAt(1).ToString(), datos[i].ElementAt(2).ToString(), datos[i].ElementAt(3).ToString(), datos[i].ElementAt(5).ToString(), Image.FromFile("C:\\Users\\Usuario\\Desktop\\POO_2023\\" + datos[i].ElementAt(4).ToString()));

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        public void limpiarForm(bool habilitar)
        {
            if (habilitar)
            {
                txtnombre.Enabled = true;
                txtnombre.Clear();
                txtcodbarras.Enabled = true;
                txtcodbarras.Clear();
                txtprecio.Enabled = true;
                txtprecio.Clear();
                txtimagen.Enabled = true;
                txtimagen.Clear();
                //buttonExaminar.Enabled = true;
                //buttonGuardar.Enabled = true;

            }
            else
            {
                txtnombre.Enabled = false;
                txtnombre.Clear();
                txtcodbarras.Enabled = false;
                txtcodbarras.Clear();
                txtprecio.Enabled = false;
                txtprecio.Clear();
                txtimagen.Enabled = false;
                txtimagen.Clear();
                //buttonExaminar.Enabled = false;
                //buttonGuardar.Enabled = false;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            bool resultado = prod.borrar(identificador);
            if (resultado == false)
            {
                MessageBox.Show("PRODUCTO ELIMINADO CON ÉXITO");
                this.limpiarForm(true);
                this.CRUD_Load(sender, e);//recargar dgrid
            }

        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();
            //Cargar el archivo. 
            if (res == DialogResult.OK)
            {
                pictureBoxImagen.Image = new Bitmap(openFileDialog1.FileName);
                //crear el nombre único. 
                DateTime dtNombre = DateTime.Now;
                string nombreImg = "prod_" + dtNombre.Ticks + ".png";
                txtimagen.Text = nombreImg;
            }
            else
            {

            }
        }

        private void pictureBoxImagen_Click(object sender, EventArgs e)
        {

        }
    }
}
