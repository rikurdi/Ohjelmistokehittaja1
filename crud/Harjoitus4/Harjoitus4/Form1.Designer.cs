namespace Harjoitus4
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
            this.DTPicker = new System.Windows.Forms.DateTimePicker();
            this.DTButton = new System.Windows.Forms.Button();
            this.VuodetLB = new System.Windows.Forms.Label();
            this.TunnitLB = new System.Windows.Forms.Label();
            this.KuukaudetLB = new System.Windows.Forms.Label();
            this.MinuutitLB = new System.Windows.Forms.Label();
            this.PaivatLB = new System.Windows.Forms.Label();
            this.SekunnitLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DTPicker
            // 
            this.DTPicker.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DTPicker.Location = new System.Drawing.Point(37, 18);
            this.DTPicker.Name = "DTPicker";
            this.DTPicker.Size = new System.Drawing.Size(318, 32);
            this.DTPicker.TabIndex = 0;
            // 
            // DTButton
            // 
            this.DTButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DTButton.Location = new System.Drawing.Point(426, 12);
            this.DTButton.Name = "DTButton";
            this.DTButton.Size = new System.Drawing.Size(88, 46);
            this.DTButton.TabIndex = 1;
            this.DTButton.Text = "Laske";
            this.DTButton.UseVisualStyleBackColor = true;
            this.DTButton.Click += new System.EventHandler(this.DTButton_Click);
            // 
            // VuodetLB
            // 
            this.VuodetLB.AutoSize = true;
            this.VuodetLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VuodetLB.Location = new System.Drawing.Point(63, 96);
            this.VuodetLB.Name = "VuodetLB";
            this.VuodetLB.Size = new System.Drawing.Size(60, 21);
            this.VuodetLB.TabIndex = 3;
            this.VuodetLB.Text = "Vuodet";
            this.VuodetLB.Visible = false;
            // 
            // TunnitLB
            // 
            this.TunnitLB.AutoSize = true;
            this.TunnitLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TunnitLB.Location = new System.Drawing.Point(456, 103);
            this.TunnitLB.Name = "TunnitLB";
            this.TunnitLB.Size = new System.Drawing.Size(51, 21);
            this.TunnitLB.TabIndex = 4;
            this.TunnitLB.Text = "tunnit";
            this.TunnitLB.Visible = false;
            this.TunnitLB.Click += new System.EventHandler(this.label3_Click);
            // 
            // KuukaudetLB
            // 
            this.KuukaudetLB.AutoSize = true;
            this.KuukaudetLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KuukaudetLB.Location = new System.Drawing.Point(63, 163);
            this.KuukaudetLB.Name = "KuukaudetLB";
            this.KuukaudetLB.Size = new System.Drawing.Size(83, 21);
            this.KuukaudetLB.TabIndex = 5;
            this.KuukaudetLB.Text = "kuukaudet";
            this.KuukaudetLB.Visible = false;
            // 
            // MinuutitLB
            // 
            this.MinuutitLB.AutoSize = true;
            this.MinuutitLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinuutitLB.Location = new System.Drawing.Point(456, 163);
            this.MinuutitLB.Name = "MinuutitLB";
            this.MinuutitLB.Size = new System.Drawing.Size(69, 21);
            this.MinuutitLB.TabIndex = 6;
            this.MinuutitLB.Text = "minuutit";
            this.MinuutitLB.Visible = false;
            // 
            // PaivatLB
            // 
            this.PaivatLB.AutoSize = true;
            this.PaivatLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PaivatLB.Location = new System.Drawing.Point(63, 237);
            this.PaivatLB.Name = "PaivatLB";
            this.PaivatLB.Size = new System.Drawing.Size(52, 21);
            this.PaivatLB.TabIndex = 7;
            this.PaivatLB.Text = "päivät";
            this.PaivatLB.Visible = false;
            // 
            // SekunnitLB
            // 
            this.SekunnitLB.AutoSize = true;
            this.SekunnitLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SekunnitLB.Location = new System.Drawing.Point(456, 237);
            this.SekunnitLB.Name = "SekunnitLB";
            this.SekunnitLB.Size = new System.Drawing.Size(69, 21);
            this.SekunnitLB.TabIndex = 8;
            this.SekunnitLB.Text = "sekunnit";
            this.SekunnitLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SekunnitLB);
            this.Controls.Add(this.PaivatLB);
            this.Controls.Add(this.MinuutitLB);
            this.Controls.Add(this.KuukaudetLB);
            this.Controls.Add(this.TunnitLB);
            this.Controls.Add(this.VuodetLB);
            this.Controls.Add(this.DTButton);
            this.Controls.Add(this.DTPicker);
            this.Name = "Form1";
            this.Text = "Ikälaskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker DTPicker;
        private Button DTButton;
        private Label VuodetLB;
        private Label TunnitLB;
        private Label KuukaudetLB;
        private Label MinuutitLB;
        private Label PaivatLB;
        private Label SekunnitLB;
    }
}