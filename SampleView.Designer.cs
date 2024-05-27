namespace RMS
{
    partial class SampleView
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
            SearchTxt = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            btnAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            label2 = new Label();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            SuspendLayout();
            // 
            // SearchTxt
            // 
            SearchTxt.CustomizableEdges = customizableEdges1;
            SearchTxt.DefaultText = "";
            SearchTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            SearchTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            SearchTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            SearchTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            SearchTxt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            SearchTxt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SearchTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            SearchTxt.IconLeft = Properties.Resources.search;
            SearchTxt.Location = new Point(496, 82);
            SearchTxt.Name = "SearchTxt";
            SearchTxt.PasswordChar = '\0';
            SearchTxt.PlaceholderText = "Search Here";
            SearchTxt.SelectedText = "";
            SearchTxt.ShadowDecoration.CustomizableEdges = customizableEdges2;
            SearchTxt.Size = new Size(266, 36);
            SearchTxt.TabIndex = 0;
            SearchTxt.TextChanged += SearchTxt_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(496, 64);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Search";
            // 
            // btnAdd
            // 
            btnAdd.CheckedState.ImageSize = new Size(64, 64);
            btnAdd.HoverState.ImageSize = new Size(64, 64);
            btnAdd.Image = Properties.Resources.plus;
            btnAdd.ImageOffset = new Point(0, 0);
            btnAdd.ImageRotate = 0F;
            btnAdd.Location = new Point(34, 64);
            btnAdd.Name = "btnAdd";
            btnAdd.PressedState.ImageSize = new Size(64, 64);
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnAdd.Size = new Size(55, 54);
            btnAdd.TabIndex = 2;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 24);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 3;
            label2.Text = "Header Text";
            // 
            // guna2Separator1
            // 
            guna2Separator1.Location = new Point(34, 134);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(728, 10);
            guna2Separator1.TabIndex = 4;
            // 
            // SampleView
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(800, 513);
            Controls.Add(guna2Separator1);
            Controls.Add(label2);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(SearchTxt);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SampleView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SampleView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        public Guna.UI2.WinForms.Guna2TextBox SearchTxt;
        public Guna.UI2.WinForms.Guna2ImageButton btnAdd;
        public Label label2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        public Label label1;
    }
}