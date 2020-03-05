namespace FreeandPremium
{
    partial class MainForm
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
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.ggb = new Guna.UI.WinForms.GunaButton();
            this.fbb = new Guna.UI.WinForms.GunaButton();
            this.twb = new Guna.UI.WinForms.GunaButton();
            this.wab = new Guna.UI.WinForms.GunaButton();
            this.igb = new Guna.UI.WinForms.GunaButton();
            this.ytb = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(191, 1);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 3;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(12, 9);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(35, 15);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "Form";
            // 
            // ggb
            // 
            this.ggb.AnimationHoverSpeed = 0.07F;
            this.ggb.AnimationSpeed = 0.03F;
            this.ggb.BaseColor = System.Drawing.Color.Black;
            this.ggb.BorderColor = System.Drawing.Color.Silver;
            this.ggb.BorderSize = 1;
            this.ggb.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ggb.FocusedColor = System.Drawing.Color.Empty;
            this.ggb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ggb.ForeColor = System.Drawing.Color.White;
            this.ggb.Image = null;
            this.ggb.ImageSize = new System.Drawing.Size(20, 20);
            this.ggb.Location = new System.Drawing.Point(28, 43);
            this.ggb.Name = "ggb";
            this.ggb.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ggb.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ggb.OnHoverForeColor = System.Drawing.Color.White;
            this.ggb.OnHoverImage = null;
            this.ggb.OnPressedColor = System.Drawing.Color.Black;
            this.ggb.Size = new System.Drawing.Size(160, 42);
            this.ggb.TabIndex = 5;
            this.ggb.Text = "Google";
            this.ggb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ggb.Click += new System.EventHandler(this.ggb_Click);
            // 
            // fbb
            // 
            this.fbb.AnimationHoverSpeed = 0.07F;
            this.fbb.AnimationSpeed = 0.03F;
            this.fbb.BaseColor = System.Drawing.Color.Black;
            this.fbb.BorderColor = System.Drawing.Color.Silver;
            this.fbb.BorderSize = 1;
            this.fbb.DialogResult = System.Windows.Forms.DialogResult.None;
            this.fbb.FocusedColor = System.Drawing.Color.Empty;
            this.fbb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fbb.ForeColor = System.Drawing.Color.White;
            this.fbb.Image = null;
            this.fbb.ImageSize = new System.Drawing.Size(20, 20);
            this.fbb.Location = new System.Drawing.Point(28, 91);
            this.fbb.Name = "fbb";
            this.fbb.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.fbb.OnHoverBorderColor = System.Drawing.Color.Black;
            this.fbb.OnHoverForeColor = System.Drawing.Color.White;
            this.fbb.OnHoverImage = null;
            this.fbb.OnPressedColor = System.Drawing.Color.Black;
            this.fbb.Size = new System.Drawing.Size(160, 42);
            this.fbb.TabIndex = 6;
            this.fbb.Text = "Facebook";
            this.fbb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fbb.Click += new System.EventHandler(this.fbb_Click);
            // 
            // twb
            // 
            this.twb.AnimationHoverSpeed = 0.07F;
            this.twb.AnimationSpeed = 0.03F;
            this.twb.BaseColor = System.Drawing.Color.Black;
            this.twb.BorderColor = System.Drawing.Color.Silver;
            this.twb.BorderSize = 1;
            this.twb.DialogResult = System.Windows.Forms.DialogResult.None;
            this.twb.FocusedColor = System.Drawing.Color.Empty;
            this.twb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.twb.ForeColor = System.Drawing.Color.White;
            this.twb.Image = null;
            this.twb.ImageSize = new System.Drawing.Size(20, 20);
            this.twb.Location = new System.Drawing.Point(28, 187);
            this.twb.Name = "twb";
            this.twb.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.twb.OnHoverBorderColor = System.Drawing.Color.Black;
            this.twb.OnHoverForeColor = System.Drawing.Color.White;
            this.twb.OnHoverImage = null;
            this.twb.OnPressedColor = System.Drawing.Color.Black;
            this.twb.Size = new System.Drawing.Size(160, 42);
            this.twb.TabIndex = 8;
            this.twb.Text = "Twitter";
            this.twb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.twb.Click += new System.EventHandler(this.twb_Click);
            // 
            // wab
            // 
            this.wab.AnimationHoverSpeed = 0.07F;
            this.wab.AnimationSpeed = 0.03F;
            this.wab.BaseColor = System.Drawing.Color.Black;
            this.wab.BorderColor = System.Drawing.Color.Silver;
            this.wab.BorderSize = 1;
            this.wab.DialogResult = System.Windows.Forms.DialogResult.None;
            this.wab.FocusedColor = System.Drawing.Color.Empty;
            this.wab.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.wab.ForeColor = System.Drawing.Color.White;
            this.wab.Image = null;
            this.wab.ImageSize = new System.Drawing.Size(20, 20);
            this.wab.Location = new System.Drawing.Point(28, 139);
            this.wab.Name = "wab";
            this.wab.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.wab.OnHoverBorderColor = System.Drawing.Color.Black;
            this.wab.OnHoverForeColor = System.Drawing.Color.White;
            this.wab.OnHoverImage = null;
            this.wab.OnPressedColor = System.Drawing.Color.Black;
            this.wab.Size = new System.Drawing.Size(160, 42);
            this.wab.TabIndex = 7;
            this.wab.Text = "Whatsapp";
            this.wab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.wab.Click += new System.EventHandler(this.wab_Click);
            // 
            // igb
            // 
            this.igb.AnimationHoverSpeed = 0.07F;
            this.igb.AnimationSpeed = 0.03F;
            this.igb.BaseColor = System.Drawing.Color.Black;
            this.igb.BorderColor = System.Drawing.Color.Silver;
            this.igb.BorderSize = 1;
            this.igb.DialogResult = System.Windows.Forms.DialogResult.None;
            this.igb.FocusedColor = System.Drawing.Color.Empty;
            this.igb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.igb.ForeColor = System.Drawing.Color.White;
            this.igb.Image = null;
            this.igb.ImageSize = new System.Drawing.Size(20, 20);
            this.igb.Location = new System.Drawing.Point(28, 283);
            this.igb.Name = "igb";
            this.igb.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.igb.OnHoverBorderColor = System.Drawing.Color.Black;
            this.igb.OnHoverForeColor = System.Drawing.Color.White;
            this.igb.OnHoverImage = null;
            this.igb.OnPressedColor = System.Drawing.Color.Black;
            this.igb.Size = new System.Drawing.Size(160, 42);
            this.igb.TabIndex = 10;
            this.igb.Text = "Instargram";
            this.igb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.igb.Click += new System.EventHandler(this.igb_Click);
            // 
            // ytb
            // 
            this.ytb.AnimationHoverSpeed = 0.07F;
            this.ytb.AnimationSpeed = 0.03F;
            this.ytb.BaseColor = System.Drawing.Color.Black;
            this.ytb.BorderColor = System.Drawing.Color.Silver;
            this.ytb.BorderSize = 1;
            this.ytb.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ytb.FocusedColor = System.Drawing.Color.Empty;
            this.ytb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ytb.ForeColor = System.Drawing.Color.White;
            this.ytb.Image = null;
            this.ytb.ImageSize = new System.Drawing.Size(20, 20);
            this.ytb.Location = new System.Drawing.Point(28, 235);
            this.ytb.Name = "ytb";
            this.ytb.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ytb.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ytb.OnHoverForeColor = System.Drawing.Color.White;
            this.ytb.OnHoverImage = null;
            this.ytb.OnPressedColor = System.Drawing.Color.Black;
            this.ytb.Size = new System.Drawing.Size(160, 42);
            this.ytb.TabIndex = 9;
            this.ytb.Text = "Youtube";
            this.ytb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ytb.Click += new System.EventHandler(this.ytb_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(236, 350);
            this.Controls.Add(this.igb);
            this.Controls.Add(this.ytb);
            this.Controls.Add(this.twb);
            this.Controls.Add(this.wab);
            this.Controls.Add(this.fbb);
            this.Controls.Add(this.ggb);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaControlBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDragControl DragControl;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaButton ggb;
        private Guna.UI.WinForms.GunaButton igb;
        private Guna.UI.WinForms.GunaButton ytb;
        private Guna.UI.WinForms.GunaButton twb;
        private Guna.UI.WinForms.GunaButton wab;
        private Guna.UI.WinForms.GunaButton fbb;
    }
}