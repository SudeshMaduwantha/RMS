namespace RMS.Model
{
    partial class ucProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblName = new Label();
            txtImage = new PictureBox();
            guna2ShadowPanel1.SuspendLayout();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtImage).BeginInit();
            SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(guna2Separator1);
            guna2ShadowPanel1.Controls.Add(guna2Panel1);
            guna2ShadowPanel1.Controls.Add(txtImage);
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(3, 3);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(144, 144);
            guna2ShadowPanel1.TabIndex = 0;
            // 
            // guna2Separator1
            // 
            guna2Separator1.Location = new Point(3, 94);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(138, 10);
            guna2Separator1.TabIndex = 2;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(lblName);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Dock = DockStyle.Bottom;
            guna2Panel1.Location = new Point(0, 102);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(144, 42);
            guna2Panel1.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(9, 4);
            lblName.Name = "lblName";
            lblName.Size = new Size(132, 23);
            lblName.TabIndex = 0;
            lblName.Text = "Product Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtImage
            // 
            txtImage.Image = Properties.Resources.burger;
            txtImage.Location = new Point(26, 5);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(97, 91);
            txtImage.SizeMode = PictureBoxSizeMode.Zoom;
            txtImage.TabIndex = 0;
            txtImage.TabStop = false;
            txtImage.Click += txtImage_Click;
            // 
            // ucProduct
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(guna2ShadowPanel1);
            Name = "ucProduct";
            guna2ShadowPanel1.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lblName;
        private PictureBox txtImage;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}
