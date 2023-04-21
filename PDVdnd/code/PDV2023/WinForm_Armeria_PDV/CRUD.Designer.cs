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
            dgridEquipamiento = new DataGridView();
            txt_id = new TextBox();
            txtnombre = new TextBox();
            txtprecio = new TextBox();
            txtcodbarras = new TextBox();
            txtimagen = new TextBox();
            comboTipo = new ComboBox();
            btnGuardar = new Button();
            btnBorrar = new Button();
            btnModificar = new Button();
            btnImagen = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBoxImagen = new PictureBox();
            pictureBox1 = new PictureBox();
            colId = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colCodBarras = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colImagen = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dgridEquipamiento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgridEquipamiento
            // 
            dgridEquipamiento.AllowUserToAddRows = false;
            dgridEquipamiento.AllowUserToDeleteRows = false;
            dgridEquipamiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridEquipamiento.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colPrecio, colCodBarras, colTipo, colImagen });
            dgridEquipamiento.Location = new Point(12, 9);
            dgridEquipamiento.Name = "dgridEquipamiento";
            dgridEquipamiento.ReadOnly = true;
            dgridEquipamiento.RowTemplate.Height = 25;
            dgridEquipamiento.Size = new Size(641, 616);
            dgridEquipamiento.TabIndex = 2;
            dgridEquipamiento.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txt_id
            // 
            txt_id.BackColor = Color.Crimson;
            txt_id.BorderStyle = BorderStyle.FixedSingle;
            txt_id.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_id.ForeColor = SystemColors.InactiveBorder;
            txt_id.Location = new Point(659, 145);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(389, 22);
            txt_id.TabIndex = 3;
            txt_id.Text = "ID DEL PRODUCTO";
            txt_id.TextAlign = HorizontalAlignment.Center;
            // 
            // txtnombre
            // 
            txtnombre.BackColor = Color.Crimson;
            txtnombre.BorderStyle = BorderStyle.FixedSingle;
            txtnombre.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtnombre.ForeColor = SystemColors.InactiveBorder;
            txtnombre.Location = new Point(659, 172);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(389, 22);
            txtnombre.TabIndex = 4;
            txtnombre.Text = "NOMBRE";
            txtnombre.TextAlign = HorizontalAlignment.Center;
            // 
            // txtprecio
            // 
            txtprecio.BackColor = Color.Crimson;
            txtprecio.BorderStyle = BorderStyle.FixedSingle;
            txtprecio.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtprecio.ForeColor = SystemColors.InactiveBorder;
            txtprecio.Location = new Point(659, 203);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(389, 22);
            txtprecio.TabIndex = 5;
            txtprecio.Text = "PRECIO";
            txtprecio.TextAlign = HorizontalAlignment.Center;
            // 
            // txtcodbarras
            // 
            txtcodbarras.BackColor = Color.Crimson;
            txtcodbarras.BorderStyle = BorderStyle.FixedSingle;
            txtcodbarras.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtcodbarras.ForeColor = SystemColors.InactiveBorder;
            txtcodbarras.Location = new Point(659, 234);
            txtcodbarras.Name = "txtcodbarras";
            txtcodbarras.Size = new Size(389, 22);
            txtcodbarras.TabIndex = 6;
            txtcodbarras.Text = "CÓDIGO DE BARRAS";
            txtcodbarras.TextAlign = HorizontalAlignment.Center;
            // 
            // txtimagen
            // 
            txtimagen.BackColor = Color.Crimson;
            txtimagen.BorderStyle = BorderStyle.FixedSingle;
            txtimagen.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtimagen.ForeColor = SystemColors.InactiveBorder;
            txtimagen.Location = new Point(659, 265);
            txtimagen.Name = "txtimagen";
            txtimagen.Size = new Size(389, 22);
            txtimagen.TabIndex = 7;
            txtimagen.Text = "IMAGEN";
            txtimagen.TextAlign = HorizontalAlignment.Center;
            // 
            // comboTipo
            // 
            comboTipo.BackColor = Color.Crimson;
            comboTipo.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboTipo.ForeColor = SystemColors.InactiveBorder;
            comboTipo.FormattingEnabled = true;
            comboTipo.Items.AddRange(new object[] { "ESPADA", "HACHA", "LANZA", "ESCUDO", "ARMADURA" });
            comboTipo.Location = new Point(659, 296);
            comboTipo.Name = "comboTipo";
            comboTipo.Size = new Size(389, 22);
            comboTipo.TabIndex = 8;
            comboTipo.Text = "TIPO DE PRODUCTO";
            comboTipo.SelectedIndexChanged += comboTipo_SelectedIndexChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(192, 255, 192);
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.FromArgb(255, 255, 128);
            btnGuardar.Location = new Point(666, 325);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 140);
            btnGuardar.TabIndex = 12;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += button1_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackgroundImage = (Image)resources.GetObject("btnBorrar.BackgroundImage");
            btnBorrar.Location = new Point(893, 562);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(140, 60);
            btnBorrar.TabIndex = 13;
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(192, 255, 192);
            btnModificar.BackgroundImage = (Image)resources.GetObject("btnModificar.BackgroundImage");
            btnModificar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.FromArgb(255, 255, 128);
            btnModificar.Location = new Point(812, 325);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(140, 140);
            btnModificar.TabIndex = 14;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnImagen
            // 
            btnImagen.BackgroundImage = (Image)resources.GetObject("btnImagen.BackgroundImage");
            btnImagen.Location = new Point(958, 325);
            btnImagen.Name = "btnImagen";
            btnImagen.Size = new Size(75, 140);
            btnImagen.TabIndex = 15;
            btnImagen.UseVisualStyleBackColor = true;
            btnImagen.Click += btnImagen_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBoxImagen
            // 
            pictureBoxImagen.BackColor = Color.Crimson;
            pictureBoxImagen.Location = new Point(666, 472);
            pictureBoxImagen.Name = "pictureBoxImagen";
            pictureBoxImagen.Size = new Size(150, 150);
            pictureBoxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagen.TabIndex = 16;
            pictureBoxImagen.TabStop = false;
            pictureBoxImagen.Click += pictureBoxImagen_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(725, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 145);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // colId
            // 
            colId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 43;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "NOMBRE";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "PRECIO";
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            // 
            // colCodBarras
            // 
            colCodBarras.HeaderText = "CÓDIGO DE BARRAS";
            colCodBarras.Name = "colCodBarras";
            colCodBarras.ReadOnly = true;
            // 
            // colTipo
            // 
            colTipo.HeaderText = "TIPO";
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            // 
            // colImagen
            // 
            colImagen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colImagen.HeaderText = "IMAGEN";
            colImagen.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colImagen.Name = "colImagen";
            colImagen.ReadOnly = true;
            colImagen.Resizable = DataGridViewTriState.False;
            colImagen.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // CRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1062, 637);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBoxImagen);
            Controls.Add(btnImagen);
            Controls.Add(btnModificar);
            Controls.Add(btnBorrar);
            Controls.Add(btnGuardar);
            Controls.Add(comboTipo);
            Controls.Add(txtimagen);
            Controls.Add(txtcodbarras);
            Controls.Add(txtprecio);
            Controls.Add(txtnombre);
            Controls.Add(txt_id);
            Controls.Add(dgridEquipamiento);
            Name = "CRUD";
            Text = "Caja";
            Load += CRUD_Load;
            ((System.ComponentModel.ISupportInitialize)dgridEquipamiento).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_armeria;
        private PictureBox pictureBox_npc_tienda;
        private DataGridView dgridEquipamiento;
        private TextBox txt_id;
        private TextBox txtnombre;
        private TextBox txtprecio;
        private TextBox txtcodbarras;
        private TextBox txtimagen;
        private ComboBox comboTipo;
        private Button btnGuardar;
        private Button btnBorrar;
        private Button btnModificar;
        private Button btnImagen;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBoxImagen;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colCodBarras;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewImageColumn colImagen;
    }
}