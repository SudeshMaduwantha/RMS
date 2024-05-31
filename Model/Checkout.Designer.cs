namespace RMS.Model
{
    partial class Checkout
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            txtBillAmount = new Guna.UI2.WinForms.Guna2TextBox();
            lblBillAmount = new Label();
            txtReceived = new Guna.UI2.WinForms.Guna2TextBox();
            lblPayment = new Label();
            txtChange = new Guna.UI2.WinForms.Guna2TextBox();
            lblChange = new Label();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            guna2Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(guna2ControlBox1);
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2Panel1.Size = new Size(601, 81);
            guna2Panel1.Controls.SetChildIndex(pictureBox1, 0);
            guna2Panel1.Controls.SetChildIndex(label1, 0);
            guna2Panel1.Controls.SetChildIndex(guna2ControlBox1, 0);
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Bill;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.None;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.Location = new Point(12, 14);
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges4;
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.None;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.Location = new Point(135, 14);
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges5;
            // 
            // guna2Panel2
            // 
            guna2Panel2.Location = new Point(0, 286);
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel2.Size = new Size(601, 70);
            // 
            // label1
            // 
            label1.Size = new Size(99, 25);
            label1.Text = "Check Out";
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.CustomizableEdges = customizableEdges1;
            guna2ControlBox1.FillColor = Color.FromArgb(139, 152, 166);
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(534, 25);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ControlBox1.Size = new Size(45, 29);
            guna2ControlBox1.TabIndex = 2;
            // 
            // txtBillAmount
            // 
            txtBillAmount.CustomizableEdges = customizableEdges7;
            txtBillAmount.DefaultText = "";
            txtBillAmount.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBillAmount.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBillAmount.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBillAmount.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBillAmount.Enabled = false;
            txtBillAmount.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBillAmount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBillAmount.ForeColor = Color.FromArgb(64, 64, 64);
            txtBillAmount.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBillAmount.Location = new Point(23, 124);
            txtBillAmount.Name = "txtBillAmount";
            txtBillAmount.PasswordChar = '\0';
            txtBillAmount.PlaceholderText = "";
            txtBillAmount.SelectedText = "";
            txtBillAmount.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtBillAmount.Size = new Size(258, 36);
            txtBillAmount.TabIndex = 4;
            // 
            // lblBillAmount
            // 
            lblBillAmount.AutoSize = true;
            lblBillAmount.Location = new Point(23, 106);
            lblBillAmount.Name = "lblBillAmount";
            lblBillAmount.Size = new Size(70, 15);
            lblBillAmount.TabIndex = 5;
            lblBillAmount.Text = "Bill Amount";
            // 
            // txtReceived
            // 
            txtReceived.CustomizableEdges = customizableEdges9;
            txtReceived.DefaultText = "";
            txtReceived.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtReceived.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtReceived.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtReceived.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtReceived.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtReceived.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtReceived.ForeColor = Color.FromArgb(64, 64, 64);
            txtReceived.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtReceived.Location = new Point(316, 124);
            txtReceived.Name = "txtReceived";
            txtReceived.PasswordChar = '\0';
            txtReceived.PlaceholderText = "";
            txtReceived.SelectedText = "";
            txtReceived.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtReceived.Size = new Size(258, 36);
            txtReceived.TabIndex = 6;
            txtReceived.TextChanged += txtReceived_TextChanged;
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Location = new Point(316, 106);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(104, 15);
            lblPayment.TabIndex = 7;
            lblPayment.Text = "Payment Recieved";
            // 
            // txtChange
            // 
            txtChange.CustomizableEdges = customizableEdges11;
            txtChange.DefaultText = "";
            txtChange.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtChange.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtChange.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtChange.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtChange.Enabled = false;
            txtChange.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtChange.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtChange.ForeColor = Color.FromArgb(64, 64, 64);
            txtChange.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtChange.Location = new Point(23, 207);
            txtChange.Name = "txtChange";
            txtChange.PasswordChar = '\0';
            txtChange.PlaceholderText = "";
            txtChange.SelectedText = "";
            txtChange.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtChange.Size = new Size(258, 36);
            txtChange.TabIndex = 8;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Location = new Point(23, 189);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(48, 15);
            lblChange.TabIndex = 9;
            lblChange.Text = "Change";
            // 
            // Checkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 356);
            Controls.Add(txtChange);
            Controls.Add(lblChange);
            Controls.Add(txtReceived);
            Controls.Add(lblPayment);
            Controls.Add(txtBillAmount);
            Controls.Add(lblBillAmount);
            Name = "Checkout";
            Text = "Checkout";
            Load += Checkout_Load;
            Controls.SetChildIndex(guna2Panel1, 0);
            Controls.SetChildIndex(guna2Panel2, 0);
            Controls.SetChildIndex(lblBillAmount, 0);
            Controls.SetChildIndex(txtBillAmount, 0);
            Controls.SetChildIndex(lblPayment, 0);
            Controls.SetChildIndex(txtReceived, 0);
            Controls.SetChildIndex(lblChange, 0);
            Controls.SetChildIndex(txtChange, 0);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            guna2Panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        public Guna.UI2.WinForms.Guna2TextBox txtBillAmount;
        private Label lblBillAmount;
        public Guna.UI2.WinForms.Guna2TextBox txtReceived;
        private Label lblPayment;
        public Guna.UI2.WinForms.Guna2TextBox txtChange;
        private Label lblChange;
    }
}