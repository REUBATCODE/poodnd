namespace WinForm_Armeria_PDV
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            menuStrip1 = new MenuStrip();
            cRUDToolStripMenuItem = new ToolStripMenuItem();
            accederACRUDToolStripMenuItem = new ToolStripMenuItem();
            cAJADEVENTAToolStripMenuItem = new ToolStripMenuItem();
            accederACajaVentaToolStripMenuItem = new ToolStripMenuItem();
            cRUDDEUSUARIOSToolStripMenuItem = new ToolStripMenuItem();
            aCCEDERALCRUDDEUSUARIOSToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Crimson;
            menuStrip1.Items.AddRange(new ToolStripItem[] { cRUDToolStripMenuItem, cAJADEVENTAToolStripMenuItem, cRUDDEUSUARIOSToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(453, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // cRUDToolStripMenuItem
            // 
            cRUDToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { accederACRUDToolStripMenuItem });
            cRUDToolStripMenuItem.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cRUDToolStripMenuItem.Name = "cRUDToolStripMenuItem";
            cRUDToolStripMenuItem.Size = new Size(57, 20);
            cRUDToolStripMenuItem.Text = "CRUD";
            // 
            // accederACRUDToolStripMenuItem
            // 
            accederACRUDToolStripMenuItem.BackColor = Color.PaleVioletRed;
            accederACRUDToolStripMenuItem.Name = "accederACRUDToolStripMenuItem";
            accederACRUDToolStripMenuItem.Size = new Size(181, 22);
            accederACRUDToolStripMenuItem.Text = "Acceder a CRUD";
            accederACRUDToolStripMenuItem.Click += accederACRUDToolStripMenuItem_Click;
            // 
            // cAJADEVENTAToolStripMenuItem
            // 
            cAJADEVENTAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { accederACajaVentaToolStripMenuItem });
            cAJADEVENTAToolStripMenuItem.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cAJADEVENTAToolStripMenuItem.Name = "cAJADEVENTAToolStripMenuItem";
            cAJADEVENTAToolStripMenuItem.Size = new Size(123, 20);
            cAJADEVENTAToolStripMenuItem.Text = "CAJA DE VENTA";
            // 
            // accederACajaVentaToolStripMenuItem
            // 
            accederACajaVentaToolStripMenuItem.BackColor = Color.PaleVioletRed;
            accederACajaVentaToolStripMenuItem.Name = "accederACajaVentaToolStripMenuItem";
            accederACajaVentaToolStripMenuItem.Size = new Size(215, 22);
            accederACajaVentaToolStripMenuItem.Text = "Acceder a Caja Venta";
            accederACajaVentaToolStripMenuItem.Click += accederACajaVentaToolStripMenuItem_Click;
            // 
            // cRUDDEUSUARIOSToolStripMenuItem
            // 
            cRUDDEUSUARIOSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aCCEDERALCRUDDEUSUARIOSToolStripMenuItem });
            cRUDDEUSUARIOSToolStripMenuItem.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cRUDDEUSUARIOSToolStripMenuItem.Name = "cRUDDEUSUARIOSToolStripMenuItem";
            cRUDDEUSUARIOSToolStripMenuItem.Size = new Size(156, 20);
            cRUDDEUSUARIOSToolStripMenuItem.Text = "CRUD DE USUARIOS";
            cRUDDEUSUARIOSToolStripMenuItem.Click += cRUDDEUSUARIOSToolStripMenuItem_Click;
            // 
            // aCCEDERALCRUDDEUSUARIOSToolStripMenuItem
            // 
            aCCEDERALCRUDDEUSUARIOSToolStripMenuItem.BackColor = Color.PaleVioletRed;
            aCCEDERALCRUDDEUSUARIOSToolStripMenuItem.Name = "aCCEDERALCRUDDEUSUARIOSToolStripMenuItem";
            aCCEDERALCRUDDEUSUARIOSToolStripMenuItem.Size = new Size(267, 22);
            aCCEDERALCRUDDEUSUARIOSToolStripMenuItem.Text = "Acceder el CRUD de Usuarios";
            aCCEDERALCRUDDEUSUARIOSToolStripMenuItem.Click += aCCEDERALCRUDDEUSUARIOSToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(94, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 145);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(453, 215);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cRUDToolStripMenuItem;
        private ToolStripMenuItem accederACRUDToolStripMenuItem;
        private ToolStripMenuItem cAJADEVENTAToolStripMenuItem;
        private ToolStripMenuItem accederACajaVentaToolStripMenuItem;
        private ToolStripMenuItem cRUDDEUSUARIOSToolStripMenuItem;
        private ToolStripMenuItem aCCEDERALCRUDDEUSUARIOSToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}