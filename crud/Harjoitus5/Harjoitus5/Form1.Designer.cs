﻿namespace Harjoitus5
{
    partial class LukujenJarjestys
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
            this.label1 = new System.Windows.Forms.Label();
            this.uusiLukuTB = new System.Windows.Forms.TextBox();
            this.VastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna luku (-999 lopetus):";
            // 
            // uusiLukuTB
            // 
            this.uusiLukuTB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uusiLukuTB.Location = new System.Drawing.Point(304, 31);
            this.uusiLukuTB.Name = "uusiLukuTB";
            this.uusiLukuTB.Size = new System.Drawing.Size(239, 32);
            this.uusiLukuTB.TabIndex = 1;
            this.uusiLukuTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uusiLukuTB_KeyPress);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(39, 97);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(46, 15);
            this.VastausLB.TabIndex = 2;
            this.VastausLB.Text = "vastaus";
            this.VastausLB.Visible = false;
            // 
            // LukujenJarjestys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.uusiLukuTB);
            this.Controls.Add(this.label1);
            this.Name = "LukujenJarjestys";
            this.Text = "Lukujen järjestys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox uusiLukuTB;
        private Label VastausLB;
    }
}