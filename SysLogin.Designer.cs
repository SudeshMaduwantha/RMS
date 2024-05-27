namespace RMS
{
    partial class SysLogin
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            btnexit = new Guna.UI2.WinForms.Guna2Button();
            btnlogin = new Guna.UI2.WinForms.Guna2Button();
            passwordtxt = new TextBox();
            label2 = new Label();
            usernametxt = new TextBox();
            label1 = new Label();
            guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(pictureBox1);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.FillColor = Color.FromArgb(50, 55, 89);
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(363, 224);
            guna2Panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.login_system;
            pictureBox1.Location = new Point(103, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 197);
            label3.Name = "label3";
            label3.Size = new Size(162, 15);
            label3.TabIndex = 8;
            label3.Text = "Please Enter User Information";
            // 
            // btnexit
            // 
            btnexit.AutoRoundedCorners = true;
            btnexit.BorderRadius = 21;
            btnexit.CustomizableEdges = customizableEdges3;
            btnexit.DisabledState.BorderColor = Color.DarkGray;
            btnexit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnexit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnexit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnexit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnexit.ForeColor = Color.White;
            btnexit.Location = new Point(200, 412);
            btnexit.Name = "btnexit";
            btnexit.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnexit.Size = new Size(123, 45);
            btnexit.TabIndex = 15;
            btnexit.Text = "EXIT";
            btnexit.Click += btnexit_Click;
            // 
            // btnlogin
            // 
            btnlogin.AutoRoundedCorners = true;
            btnlogin.BorderRadius = 21;
            btnlogin.CustomizableEdges = customizableEdges5;
            btnlogin.DisabledState.BorderColor = Color.DarkGray;
            btnlogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnlogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnlogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnlogin.FillColor = Color.FromArgb(241, 85, 126);
            btnlogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnlogin.ForeColor = Color.White;
            btnlogin.Location = new Point(52, 412);
            btnlogin.Name = "btnlogin";
            btnlogin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnlogin.Size = new Size(123, 45);
            btnlogin.TabIndex = 14;
            btnlogin.Text = "LOGIN";
            btnlogin.Click += btnlogin_Click;
            // 
            // passwordtxt
            // 
            passwordtxt.Location = new Point(52, 337);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(271, 23);
            passwordtxt.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 317);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 12;
            label2.Text = "Password";
            // 
            // usernametxt
            // 
            usernametxt.Location = new Point(52, 272);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(271, 23);
            usernametxt.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 252);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 10;
            label1.Text = "Username";
            // 
            // guna2MessageDialog1
            // 
            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            guna2MessageDialog1.Caption = "RMS";
            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            guna2MessageDialog1.Parent = this;
            guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            guna2MessageDialog1.Text = null;
            // 
            // SysLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 471);
            Controls.Add(btnexit);
            Controls.Add(guna2Panel1);
            Controls.Add(btnlogin);
            Controls.Add(usernametxt);
            Controls.Add(passwordtxt);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SysLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SysLogin";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private PictureBox pictureBox1;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button btnexit;
        private Guna.UI2.WinForms.Guna2Button btnlogin;
        private TextBox passwordtxt;
        private Label label2;
        private TextBox usernametxt;
        private Label label1;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
    }
}