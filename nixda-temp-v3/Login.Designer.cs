namespace nixdatempv3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.BorderControl = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LicenseBox = new Siticone.UI.WinForms.SiticoneTextBox();
            this.LoginBTN = new Guna.UI.WinForms.GunaGradientTileButton();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SuspendLayout();
            // 
            // BorderControl
            // 
            this.BorderControl.AnimateWindow = true;
            this.BorderControl.BorderRadius = 10;
            this.BorderControl.ContainerControl = this;
            this.BorderControl.DockIndicatorTransparencyValue = 0.6D;
            this.BorderControl.ResizeForm = false;
            this.BorderControl.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.BorderControl.TransparentWhileDrag = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(108, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIXDA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(100, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "TEMP SPOOFER";
            // 
            // LicenseBox
            // 
            this.LicenseBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            this.LicenseBox.BorderRadius = 5;
            this.LicenseBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LicenseBox.DefaultText = "";
            this.LicenseBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LicenseBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LicenseBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LicenseBox.DisabledState.Parent = this.LicenseBox;
            this.LicenseBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LicenseBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            this.LicenseBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LicenseBox.FocusedState.Parent = this.LicenseBox;
            this.LicenseBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LicenseBox.HoveredState.Parent = this.LicenseBox;
            this.LicenseBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("LicenseBox.IconLeft")));
            this.LicenseBox.Location = new System.Drawing.Point(49, 198);
            this.LicenseBox.Name = "LicenseBox";
            this.LicenseBox.PasswordChar = '\0';
            this.LicenseBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.LicenseBox.PlaceholderText = "License Key";
            this.LicenseBox.SelectedText = "";
            this.LicenseBox.ShadowDecoration.Parent = this.LicenseBox;
            this.LicenseBox.Size = new System.Drawing.Size(264, 45);
            this.LicenseBox.TabIndex = 2;
            this.LicenseBox.TextOffset = new System.Drawing.Point(7, 0);
            // 
            // LoginBTN
            // 
            this.LoginBTN.Animated = true;
            this.LoginBTN.AnimationHoverSpeed = 0.1F;
            this.LoginBTN.AnimationSpeed = 0.07F;
            this.LoginBTN.BackColor = System.Drawing.Color.Transparent;
            this.LoginBTN.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LoginBTN.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.LoginBTN.BorderColor = System.Drawing.Color.Black;
            this.LoginBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBTN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LoginBTN.FocusedColor = System.Drawing.Color.Empty;
            this.LoginBTN.Font = new System.Drawing.Font("Segoe UI", 13.75F, System.Drawing.FontStyle.Bold);
            this.LoginBTN.ForeColor = System.Drawing.Color.White;
            this.LoginBTN.Image = null;
            this.LoginBTN.ImageSize = new System.Drawing.Size(52, 52);
            this.LoginBTN.Location = new System.Drawing.Point(49, 252);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.LoginBTN.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LoginBTN.OnHoverBorderColor = System.Drawing.Color.Black;
            this.LoginBTN.OnHoverForeColor = System.Drawing.Color.White;
            this.LoginBTN.OnHoverImage = null;
            this.LoginBTN.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.LoginBTN.Radius = 5;
            this.LoginBTN.Size = new System.Drawing.Size(264, 46);
            this.LoginBTN.TabIndex = 3;
            this.LoginBTN.Text = "LOGIN";
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(149, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Build V1.0";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(315, 4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.PressedColor = System.Drawing.Color.White;
            this.guna2ControlBox1.PressedDepth = 0;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 16;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(362, 496);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LoginBTN);
            this.Controls.Add(this.LicenseBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BLIGHT | LOGIN";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Siticone.UI.WinForms.SiticoneTextBox LicenseBox;
        private Guna.UI.WinForms.GunaGradientTileButton LoginBTN;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}

