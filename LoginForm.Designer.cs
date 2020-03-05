namespace FreeandPremium
{
    partial class LoginForm
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
            this.DragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.Exit = new Guna.UI.WinForms.GunaControlBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.hwidtextbox = new Guna.UI.WinForms.GunaTextBox();
            this.FreeLoginBtn = new Guna.UI.WinForms.GunaButton();
            this.PremiumLoginBtn = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this;
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.AnimationHoverSpeed = 0.07F;
            this.Exit.AnimationSpeed = 0.03F;
            this.Exit.IconColor = System.Drawing.Color.White;
            this.Exit.IconSize = 15F;
            this.Exit.Location = new System.Drawing.Point(326, 0);
            this.Exit.Name = "Exit";
            this.Exit.OnHoverBackColor = System.Drawing.Color.Red;
            this.Exit.OnHoverIconColor = System.Drawing.Color.White;
            this.Exit.OnPressedColor = System.Drawing.Color.Black;
            this.Exit.Size = new System.Drawing.Size(40, 30);
            this.Exit.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(12, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(90, 21);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Login Form";
            // 
            // hwidtextbox
            // 
            this.hwidtextbox.BaseColor = System.Drawing.Color.Black;
            this.hwidtextbox.BorderColor = System.Drawing.Color.Silver;
            this.hwidtextbox.BorderSize = 1;
            this.hwidtextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hwidtextbox.FocusedBaseColor = System.Drawing.Color.White;
            this.hwidtextbox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.hwidtextbox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.hwidtextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hwidtextbox.Location = new System.Drawing.Point(16, 62);
            this.hwidtextbox.Name = "hwidtextbox";
            this.hwidtextbox.PasswordChar = '\0';
            this.hwidtextbox.Size = new System.Drawing.Size(337, 30);
            this.hwidtextbox.TabIndex = 2;
            // 
            // FreeLoginBtn
            // 
            this.FreeLoginBtn.AnimationHoverSpeed = 0.07F;
            this.FreeLoginBtn.AnimationSpeed = 0.03F;
            this.FreeLoginBtn.BaseColor = System.Drawing.Color.Black;
            this.FreeLoginBtn.BorderColor = System.Drawing.Color.Silver;
            this.FreeLoginBtn.BorderSize = 1;
            this.FreeLoginBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.FreeLoginBtn.FocusedColor = System.Drawing.Color.Empty;
            this.FreeLoginBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FreeLoginBtn.ForeColor = System.Drawing.Color.White;
            this.FreeLoginBtn.Image = null;
            this.FreeLoginBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.FreeLoginBtn.Location = new System.Drawing.Point(16, 98);
            this.FreeLoginBtn.Name = "FreeLoginBtn";
            this.FreeLoginBtn.OnHoverBaseColor = System.Drawing.Color.Red;
            this.FreeLoginBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.FreeLoginBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.FreeLoginBtn.OnHoverImage = null;
            this.FreeLoginBtn.OnPressedColor = System.Drawing.Color.Black;
            this.FreeLoginBtn.Size = new System.Drawing.Size(160, 45);
            this.FreeLoginBtn.TabIndex = 3;
            this.FreeLoginBtn.Text = "Free Login";
            this.FreeLoginBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FreeLoginBtn.Click += new System.EventHandler(this.FreeLoginBtn_Click);
            // 
            // PremiumLoginBtn
            // 
            this.PremiumLoginBtn.AnimationHoverSpeed = 0.07F;
            this.PremiumLoginBtn.AnimationSpeed = 0.03F;
            this.PremiumLoginBtn.BaseColor = System.Drawing.Color.Black;
            this.PremiumLoginBtn.BorderColor = System.Drawing.Color.Silver;
            this.PremiumLoginBtn.BorderSize = 1;
            this.PremiumLoginBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.PremiumLoginBtn.FocusedColor = System.Drawing.Color.Empty;
            this.PremiumLoginBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PremiumLoginBtn.ForeColor = System.Drawing.Color.White;
            this.PremiumLoginBtn.Image = null;
            this.PremiumLoginBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.PremiumLoginBtn.Location = new System.Drawing.Point(193, 98);
            this.PremiumLoginBtn.Name = "PremiumLoginBtn";
            this.PremiumLoginBtn.OnHoverBaseColor = System.Drawing.Color.Red;
            this.PremiumLoginBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.PremiumLoginBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.PremiumLoginBtn.OnHoverImage = null;
            this.PremiumLoginBtn.OnPressedColor = System.Drawing.Color.Black;
            this.PremiumLoginBtn.Size = new System.Drawing.Size(160, 45);
            this.PremiumLoginBtn.TabIndex = 4;
            this.PremiumLoginBtn.Text = "Premium Login";
            this.PremiumLoginBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PremiumLoginBtn.Click += new System.EventHandler(this.PremiumLoginBtn_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(14, 37);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(94, 15);
            this.gunaLabel2.TabIndex = 5;
            this.gunaLabel2.Text = "Copy your hwid ";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(365, 166);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.PremiumLoginBtn);
            this.Controls.Add(this.FreeLoginBtn);
            this.Controls.Add(this.hwidtextbox);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.Exit);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDragControl DragControl;
        private Guna.UI.WinForms.GunaButton PremiumLoginBtn;
        private Guna.UI.WinForms.GunaButton FreeLoginBtn;
        private Guna.UI.WinForms.GunaTextBox hwidtextbox;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaControlBox Exit;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}

