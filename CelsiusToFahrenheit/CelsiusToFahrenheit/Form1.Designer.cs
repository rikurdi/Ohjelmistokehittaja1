namespace CelsiusToFahrenheit
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.ekaTB = new System.Windows.Forms.TextBox();
            this.tokaTB = new System.Windows.Forms.TextBox();
            this.errorLB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "=";
            // 
            // ekaTB
            // 
            this.ekaTB.Location = new System.Drawing.Point(107, 65);
            this.ekaTB.Name = "ekaTB";
            this.ekaTB.Size = new System.Drawing.Size(100, 20);
            this.ekaTB.TabIndex = 3;
            this.ekaTB.TextChanged += new System.EventHandler(this.ekaTB_TextChanged);
            // 
            // tokaTB
            // 
            this.tokaTB.Location = new System.Drawing.Point(259, 65);
            this.tokaTB.Name = "tokaTB";
            this.tokaTB.Size = new System.Drawing.Size(100, 20);
            this.tokaTB.TabIndex = 4;
            this.tokaTB.TextChanged += new System.EventHandler(this.tokaTB_TextChanged);
            // 
            // errorLB
            // 
            this.errorLB.AutoSize = true;
            this.errorLB.Location = new System.Drawing.Point(207, 140);
            this.errorLB.Name = "errorLB";
            this.errorLB.Size = new System.Drawing.Size(54, 13);
            this.errorLB.TabIndex = 5;
            this.errorLB.Text = "virheviesti";
            this.errorLB.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Celsius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fahrenheit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 183);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.errorLB);
            this.Controls.Add(this.tokaTB);
            this.Controls.Add(this.ekaTB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ekaTB;
        private System.Windows.Forms.TextBox tokaTB;
        private System.Windows.Forms.Label errorLB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

