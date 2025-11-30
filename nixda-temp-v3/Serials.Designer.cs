namespace nixdatempv3
{
    partial class Serials
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Serials));
            this.BorderControl = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeText = new Guna.UI.WinForms.GunaTextBox();
            this.SerialsBox = new Guna.UI.WinForms.GunaTextBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SuspendLayout();
            // 
            // BorderControl
            // 
            this.BorderControl.BorderRadius = 10;
            this.BorderControl.ContainerControl = this;
            this.BorderControl.DockIndicatorTransparencyValue = 0.6D;
            this.BorderControl.ResizeForm = false;
            this.BorderControl.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.BorderControl.TransparentWhileDrag = true;
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(33, 52);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(230, 10);
            this.gunaSeparator1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(104, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "SERIALS";
            // 
            // TimeText
            // 
            this.TimeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(20)))));
            this.TimeText.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.TimeText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.TimeText.BorderSize = 0;
            this.TimeText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TimeText.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.TimeText.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.TimeText.FocusedForeColor = System.Drawing.Color.White;
            this.TimeText.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.TimeText.ForeColor = System.Drawing.Color.White;
            this.TimeText.Location = new System.Drawing.Point(23, 359);
            this.TimeText.Name = "TimeText";
            this.TimeText.PasswordChar = '\0';
            this.TimeText.ReadOnly = true;
            this.TimeText.SelectedText = "";
            this.TimeText.Size = new System.Drawing.Size(251, 30);
            this.TimeText.TabIndex = 7;
            this.TimeText.Text = "Time: HH:MM | DD/MM/JJJJ";
            this.TimeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SerialsBox
            // 
            this.SerialsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(20)))));
            this.SerialsBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.SerialsBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.SerialsBox.BorderSize = 0;
            this.SerialsBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SerialsBox.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.SerialsBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.SerialsBox.FocusedForeColor = System.Drawing.Color.White;
            this.SerialsBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SerialsBox.ForeColor = System.Drawing.Color.White;
            this.SerialsBox.Location = new System.Drawing.Point(23, 68);
            this.SerialsBox.Multiline = true;
            this.SerialsBox.Name = "SerialsBox";
            this.SerialsBox.PasswordChar = '\0';
            this.SerialsBox.ReadOnly = true;
            this.SerialsBox.SelectedText = "";
            this.SerialsBox.Size = new System.Drawing.Size(251, 291);
            this.SerialsBox.TabIndex = 8;
            this.SerialsBox.Text = resources.GetString("SerialsBox.Text");
            this.SerialsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(248, 4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.PressedColor = System.Drawing.Color.White;
            this.guna2ControlBox1.PressedDepth = 0;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 17;
            // 
            // Serials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(296, 392);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.SerialsBox);
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Serials";
            this.Text = "Serials";
            this.Load += new System.EventHandler(this.Serials_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderControl;
        private Guna.UI.WinForms.GunaTextBox SerialsBox;
        private Guna.UI.WinForms.GunaTextBox TimeText;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}