namespace Harjoitus3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LukuYksiTB = new System.Windows.Forms.TextBox();
            this.LukuKaksiTB = new System.Windows.Forms.TextBox();
            this.LaskutoimituksetCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.LaskeBT = new System.Windows.Forms.Button();
            this.ErrorLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LukuYksiTB
            // 
            this.LukuYksiTB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LukuYksiTB.Location = new System.Drawing.Point(27, 37);
            this.LukuYksiTB.Name = "LukuYksiTB";
            this.LukuYksiTB.Size = new System.Drawing.Size(100, 36);
            this.LukuYksiTB.TabIndex = 0;
            // 
            // LukuKaksiTB
            // 
            this.LukuKaksiTB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LukuKaksiTB.Location = new System.Drawing.Point(215, 37);
            this.LukuKaksiTB.Name = "LukuKaksiTB";
            this.LukuKaksiTB.Size = new System.Drawing.Size(100, 36);
            this.LukuKaksiTB.TabIndex = 1;
            this.LukuKaksiTB.TextChanged += new System.EventHandler(this.LukuKaksiTB_TextChanged);
            // 
            // LaskutoimituksetCB
            // 
            this.LaskutoimituksetCB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LaskutoimituksetCB.FormattingEnabled = true;
            this.LaskutoimituksetCB.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.LaskutoimituksetCB.Location = new System.Drawing.Point(148, 35);
            this.LaskutoimituksetCB.Name = "LaskutoimituksetCB";
            this.LaskutoimituksetCB.Size = new System.Drawing.Size(47, 38);
            this.LaskutoimituksetCB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(321, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VastausLB.Location = new System.Drawing.Point(355, 43);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(26, 30);
            this.VastausLB.TabIndex = 4;
            this.VastausLB.Text = "X";
            this.VastausLB.Visible = false;
            // 
            // LaskeBT
            // 
            this.LaskeBT.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LaskeBT.Location = new System.Drawing.Point(451, 35);
            this.LaskeBT.Name = "LaskeBT";
            this.LaskeBT.Size = new System.Drawing.Size(77, 41);
            this.LaskeBT.TabIndex = 5;
            this.LaskeBT.Text = "Laske";
            this.LaskeBT.UseVisualStyleBackColor = true;
            this.LaskeBT.Click += new System.EventHandler(this.button1_Click);
            // 
            // ErrorLB
            // 
            this.ErrorLB.AutoSize = true;
            this.ErrorLB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ErrorLB.Location = new System.Drawing.Point(27, 97);
            this.ErrorLB.Name = "ErrorLB";
            this.ErrorLB.Size = new System.Drawing.Size(201, 30);
            this.ErrorLB.TabIndex = 6;
            this.ErrorLB.Text = "Virhe! Tarkista luvut";
            this.ErrorLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ErrorLB);
            this.Controls.Add(this.LaskeBT);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LaskutoimituksetCB);
            this.Controls.Add(this.LukuKaksiTB);
            this.Controls.Add(this.LukuYksiTB);
            this.Name = "Form1";
            this.Text = "Yksinkertainen nelilaskin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox LukuYksiTB;
        private TextBox LukuKaksiTB;
        private ComboBox LaskutoimituksetCB;
        private Label label1;
        private Label VastausLB;
        private Button LaskeBT;
        private Label ErrorLB;
    }
}