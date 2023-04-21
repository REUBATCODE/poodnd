namespace WinForm_Armeria_PDV
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            txtUserLogin = new TextBox();
            lblPasswordLogin = new Label();
            lblUserLogin = new Label();
            txtPasswordLogin = new TextBox();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(131, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(264, 145);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtUserLogin
            // 
            txtUserLogin.Location = new Point(131, 194);
            txtUserLogin.Name = "txtUserLogin";
            txtUserLogin.Size = new Size(264, 23);
            txtUserLogin.TabIndex = 1;
            // 
            // lblPasswordLogin
            // 
            lblPasswordLogin.AutoSize = true;
            lblPasswordLogin.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPasswordLogin.ForeColor = SystemColors.ButtonFace;
            lblPasswordLogin.Location = new Point(131, 220);
            lblPasswordLogin.Name = "lblPasswordLogin";
            lblPasswordLogin.Size = new Size(118, 25);
            lblPasswordLogin.TabIndex = 8;
            lblPasswordLogin.Text = "Contraseña";
            // 
            // lblUserLogin
            // 
            lblUserLogin.AutoSize = true;
            lblUserLogin.BackColor = SystemColors.ActiveCaptionText;
            lblUserLogin.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserLogin.ForeColor = SystemColors.ButtonFace;
            lblUserLogin.Location = new Point(131, 166);
            lblUserLogin.Name = "lblUserLogin";
            lblUserLogin.Size = new Size(84, 25);
            lblUserLogin.TabIndex = 7;
            lblUserLogin.Text = "Usuario";
            // 
            // txtPasswordLogin
            // 
            txtPasswordLogin.Location = new Point(131, 248);
            txtPasswordLogin.Name = "txtPasswordLogin";
            txtPasswordLogin.Size = new Size(264, 23);
            txtPasswordLogin.TabIndex = 9;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Crimson;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(131, 292);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(264, 23);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(534, 361);
            Controls.Add(btnLogin);
            Controls.Add(txtPasswordLogin);
            Controls.Add(lblPasswordLogin);
            Controls.Add(lblUserLogin);
            Controls.Add(txtUserLogin);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtUserLogin;
        private Label lblPasswordLogin;
        private Label lblUserLogin;
        private TextBox txtPasswordLogin;
        private Button btnLogin;
    }
}