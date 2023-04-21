namespace WinForm_Armeria_PDV
{
    partial class CRUD_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD_Usuarios));
            dataGridView1 = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colPassword = new DataGridViewTextBoxColumn();
            colRol = new DataGridViewTextBoxColumn();
            txtIdUser = new TextBox();
            lblIdUser = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblContraseña = new Label();
            txtPassword = new TextBox();
            lblRol = new Label();
            comboRol = new ComboBox();
            btnGuardarUser = new Button();
            btnModificarUser = new Button();
            btnEliminarUser = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colPassword, colRol });
            dataGridView1.Location = new Point(346, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(442, 426);
            dataGridView1.TabIndex = 0;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.Name = "colId";
            // 
            // colNombre
            // 
            colNombre.HeaderText = "USUARIO";
            colNombre.Name = "colNombre";
            // 
            // colPassword
            // 
            colPassword.HeaderText = "CONTRASEÑA";
            colPassword.Name = "colPassword";
            // 
            // colRol
            // 
            colRol.HeaderText = "ROL";
            colRol.Name = "colRol";
            // 
            // txtIdUser
            // 
            txtIdUser.Location = new Point(12, 40);
            txtIdUser.Name = "txtIdUser";
            txtIdUser.Size = new Size(328, 23);
            txtIdUser.TabIndex = 1;
            // 
            // lblIdUser
            // 
            lblIdUser.AutoSize = true;
            lblIdUser.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdUser.ForeColor = SystemColors.ButtonFace;
            lblIdUser.Location = new Point(12, 12);
            lblIdUser.Name = "lblIdUser";
            lblIdUser.Size = new Size(32, 25);
            lblIdUser.TabIndex = 2;
            lblIdUser.Text = "ID";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.ForeColor = SystemColors.ButtonFace;
            lblUsuario.Location = new Point(12, 66);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(84, 25);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(12, 94);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(328, 23);
            txtUsuario.TabIndex = 3;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblContraseña.ForeColor = SystemColors.ButtonFace;
            lblContraseña.Location = new Point(12, 120);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(118, 25);
            lblContraseña.TabIndex = 6;
            lblContraseña.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(12, 148);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(328, 23);
            txtPassword.TabIndex = 5;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRol.ForeColor = SystemColors.ButtonFace;
            lblRol.Location = new Point(12, 174);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(42, 25);
            lblRol.TabIndex = 8;
            lblRol.Text = "Rol";
            // 
            // comboRol
            // 
            comboRol.FormattingEnabled = true;
            comboRol.Items.AddRange(new object[] { "ADMIN", "CAJERO" });
            comboRol.Location = new Point(12, 202);
            comboRol.Name = "comboRol";
            comboRol.Size = new Size(328, 23);
            comboRol.TabIndex = 9;
            // 
            // btnGuardarUser
            // 
            btnGuardarUser.Image = (Image)resources.GetObject("btnGuardarUser.Image");
            btnGuardarUser.Location = new Point(12, 231);
            btnGuardarUser.Name = "btnGuardarUser";
            btnGuardarUser.Size = new Size(125, 125);
            btnGuardarUser.TabIndex = 10;
            btnGuardarUser.UseVisualStyleBackColor = true;
            // 
            // btnModificarUser
            // 
            btnModificarUser.Image = (Image)resources.GetObject("btnModificarUser.Image");
            btnModificarUser.Location = new Point(215, 231);
            btnModificarUser.Name = "btnModificarUser";
            btnModificarUser.Size = new Size(125, 125);
            btnModificarUser.TabIndex = 11;
            btnModificarUser.UseVisualStyleBackColor = true;
            // 
            // btnEliminarUser
            // 
            btnEliminarUser.BackgroundImage = (Image)resources.GetObject("btnEliminarUser.BackgroundImage");
            btnEliminarUser.Location = new Point(99, 375);
            btnEliminarUser.Name = "btnEliminarUser";
            btnEliminarUser.Size = new Size(146, 63);
            btnEliminarUser.TabIndex = 12;
            btnEliminarUser.UseVisualStyleBackColor = true;
            // 
            // CRUD_Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminarUser);
            Controls.Add(btnModificarUser);
            Controls.Add(btnGuardarUser);
            Controls.Add(comboRol);
            Controls.Add(lblRol);
            Controls.Add(lblContraseña);
            Controls.Add(txtPassword);
            Controls.Add(lblUsuario);
            Controls.Add(txtUsuario);
            Controls.Add(lblIdUser);
            Controls.Add(txtIdUser);
            Controls.Add(dataGridView1);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CRUD_Usuarios";
            Text = "CRUD_Usuarios";
            Load += CRUD_Usuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colPassword;
        private DataGridViewTextBoxColumn colRol;
        private TextBox txtIdUser;
        private Label lblIdUser;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblContraseña;
        private TextBox txtPassword;
        private Label lblRol;
        private ComboBox comboRol;
        private Button btnGuardarUser;
        private Button btnModificarUser;
        private Button btnEliminarUser;
    }
}