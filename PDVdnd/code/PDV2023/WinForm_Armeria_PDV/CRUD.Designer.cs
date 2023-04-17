namespace WinForm_Armeria_PDV
{
    partial class CRUD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD));
            label_armeria = new Label();
            pictureBox_npc_tienda = new PictureBox();
            dataGridView1 = new DataGridView();
            txt_id = new TextBox();
            txtnombre = new TextBox();
            txtprecio = new TextBox();
            txtcodbarras = new TextBox();
            txtimagen = new TextBox();
            comboBox_tipo = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_npc_tienda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label_armeria
            // 
            label_armeria.BackColor = Color.Transparent;
            label_armeria.BorderStyle = BorderStyle.Fixed3D;
            label_armeria.Font = new Font("Anton", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_armeria.ForeColor = Color.White;
            label_armeria.Location = new Point(986, 9);
            label_armeria.Name = "label_armeria";
            label_armeria.Size = new Size(389, 134);
            label_armeria.TabIndex = 0;
            label_armeria.Text = "ARMERÍA DUNGEONS AND DRAGONS";
            label_armeria.TextAlign = ContentAlignment.MiddleCenter;
            label_armeria.Click += label1_Click;
            // 
            // pictureBox_npc_tienda
            // 
            pictureBox_npc_tienda.BackColor = Color.Transparent;
            pictureBox_npc_tienda.BackgroundImage = (Image)resources.GetObject("pictureBox_npc_tienda.BackgroundImage");
            pictureBox_npc_tienda.Location = new Point(80, 107);
            pictureBox_npc_tienda.Name = "pictureBox_npc_tienda";
            pictureBox_npc_tienda.Size = new Size(389, 553);
            pictureBox_npc_tienda.TabIndex = 1;
            pictureBox_npc_tienda.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(475, 9);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(505, 616);
            dataGridView1.TabIndex = 2;
            // 
            // txt_id
            // 
            txt_id.BackColor = Color.MediumPurple;
            txt_id.Font = new Font("Kanit Black", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            txt_id.ForeColor = SystemColors.InactiveBorder;
            txt_id.Location = new Point(986, 210);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(389, 25);
            txt_id.TabIndex = 3;
            txt_id.Text = "ID DEL PRODUCTO";
            txt_id.TextAlign = HorizontalAlignment.Center;
            // 
            // txtnombre
            // 
            txtnombre.BackColor = Color.MediumPurple;
            txtnombre.Font = new Font("Kanit Black", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            txtnombre.ForeColor = SystemColors.InactiveBorder;
            txtnombre.Location = new Point(986, 241);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(389, 25);
            txtnombre.TabIndex = 4;
            txtnombre.Text = "NOMBRE";
            txtnombre.TextAlign = HorizontalAlignment.Center;
            // 
            // txtprecio
            // 
            txtprecio.BackColor = Color.MediumPurple;
            txtprecio.Font = new Font("Kanit Black", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            txtprecio.ForeColor = SystemColors.InactiveBorder;
            txtprecio.Location = new Point(986, 272);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(389, 25);
            txtprecio.TabIndex = 5;
            txtprecio.Text = "PRECIO";
            txtprecio.TextAlign = HorizontalAlignment.Center;
            // 
            // txtcodbarras
            // 
            txtcodbarras.BackColor = Color.MediumPurple;
            txtcodbarras.Font = new Font("Kanit Black", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            txtcodbarras.ForeColor = SystemColors.InactiveBorder;
            txtcodbarras.Location = new Point(986, 303);
            txtcodbarras.Name = "txtcodbarras";
            txtcodbarras.Size = new Size(389, 25);
            txtcodbarras.TabIndex = 6;
            txtcodbarras.Text = "CÓDIGO DE BARRAS";
            txtcodbarras.TextAlign = HorizontalAlignment.Center;
            // 
            // txtimagen
            // 
            txtimagen.BackColor = Color.MediumPurple;
            txtimagen.Font = new Font("Kanit Black", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            txtimagen.ForeColor = SystemColors.InactiveBorder;
            txtimagen.Location = new Point(986, 334);
            txtimagen.Name = "txtimagen";
            txtimagen.Size = new Size(389, 25);
            txtimagen.TabIndex = 7;
            txtimagen.Text = "IMAGEN";
            txtimagen.TextAlign = HorizontalAlignment.Center;
            // 
            // comboBox_tipo
            // 
            comboBox_tipo.BackColor = Color.MediumPurple;
            comboBox_tipo.Font = new Font("Kanit Black", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox_tipo.ForeColor = SystemColors.InactiveBorder;
            comboBox_tipo.FormattingEnabled = true;
            comboBox_tipo.Location = new Point(986, 365);
            comboBox_tipo.Name = "comboBox_tipo";
            comboBox_tipo.Size = new Size(389, 27);
            comboBox_tipo.TabIndex = 8;
            comboBox_tipo.Text = "TIPO DE PRODUCTO";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Font = new Font("Anton", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(255, 255, 128);
            button1.Location = new Point(1035, 398);
            button1.Name = "button1";
            button1.Size = new Size(140, 140);
            button1.TabIndex = 12;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Location = new Point(1193, 565);
            button2.Name = "button2";
            button2.Size = new Size(140, 60);
            button2.TabIndex = 13;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 255, 192);
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.Font = new Font("Anton", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(255, 255, 128);
            button3.Location = new Point(1193, 398);
            button3.Name = "button3";
            button3.Size = new Size(140, 140);
            button3.TabIndex = 14;
            button3.UseVisualStyleBackColor = false;
            // 
            // Caja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(146, 149, 138);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1387, 637);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox_tipo);
            Controls.Add(txtimagen);
            Controls.Add(txtcodbarras);
            Controls.Add(txtprecio);
            Controls.Add(txtnombre);
            Controls.Add(txt_id);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox_npc_tienda);
            Controls.Add(label_armeria);
            Name = "Caja";
            Text = "Caja";
            ((System.ComponentModel.ISupportInitialize)pictureBox_npc_tienda).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_armeria;
        private PictureBox pictureBox_npc_tienda;
        private DataGridView dataGridView1;
        private TextBox txt_id;
        private TextBox txtnombre;
        private TextBox txtprecio;
        private TextBox txtcodbarras;
        private TextBox txtimagen;
        private ComboBox comboBox_tipo;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}