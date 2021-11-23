namespace OpiskelijaRekisteri
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
            this.puhelinTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.opiskelijaNroTB = new System.Windows.Forms.TextBox();
            this.sNimiTB = new System.Windows.Forms.TextBox();
            this.nimiTB = new System.Windows.Forms.TextBox();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.puhelinLB = new System.Windows.Forms.Label();
            this.tyhjennaBT = new System.Windows.Forms.Button();
            this.tallennaBT = new System.Windows.Forms.Button();
            this.poistaBT = new System.Windows.Forms.Button();
            this.paivitaBT = new System.Windows.Forms.Button();
            this.TietotauluDG = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TietotauluDG)).BeginInit();
            this.SuspendLayout();
            // 
            // puhelinTB
            // 
            this.puhelinTB.Location = new System.Drawing.Point(450, 26);
            this.puhelinTB.Name = "puhelinTB";
            this.puhelinTB.Size = new System.Drawing.Size(150, 20);
            this.puhelinTB.TabIndex = 3;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(450, 59);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(150, 20);
            this.emailTB.TabIndex = 4;
            // 
            // opiskelijaNroTB
            // 
            this.opiskelijaNroTB.Location = new System.Drawing.Point(450, 90);
            this.opiskelijaNroTB.Name = "opiskelijaNroTB";
            this.opiskelijaNroTB.Size = new System.Drawing.Size(150, 20);
            this.opiskelijaNroTB.TabIndex = 5;
            // 
            // sNimiTB
            // 
            this.sNimiTB.Location = new System.Drawing.Point(105, 90);
            this.sNimiTB.Name = "sNimiTB";
            this.sNimiTB.Size = new System.Drawing.Size(150, 20);
            this.sNimiTB.TabIndex = 8;
            // 
            // nimiTB
            // 
            this.nimiTB.Location = new System.Drawing.Point(105, 58);
            this.nimiTB.Name = "nimiTB";
            this.nimiTB.Size = new System.Drawing.Size(150, 20);
            this.nimiTB.TabIndex = 7;
            // 
            // IdTB
            // 
            this.IdTB.Location = new System.Drawing.Point(105, 26);
            this.IdTB.Name = "IdTB";
            this.IdTB.Size = new System.Drawing.Size(150, 20);
            this.IdTB.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Etunimi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sukunimi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(342, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Opiskelijanro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(342, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sähköposti:";
            // 
            // puhelinLB
            // 
            this.puhelinLB.AutoSize = true;
            this.puhelinLB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puhelinLB.Location = new System.Drawing.Point(342, 29);
            this.puhelinLB.Name = "puhelinLB";
            this.puhelinLB.Size = new System.Drawing.Size(80, 17);
            this.puhelinLB.TabIndex = 12;
            this.puhelinLB.Text = "Puhelinnro:";
            // 
            // tyhjennaBT
            // 
            this.tyhjennaBT.Location = new System.Drawing.Point(63, 133);
            this.tyhjennaBT.Name = "tyhjennaBT";
            this.tyhjennaBT.Size = new System.Drawing.Size(93, 35);
            this.tyhjennaBT.TabIndex = 15;
            this.tyhjennaBT.Text = "TYHJENNÄ";
            this.tyhjennaBT.UseVisualStyleBackColor = true;
            this.tyhjennaBT.Click += new System.EventHandler(this.tyhjennaBT_Click);
            // 
            // tallennaBT
            // 
            this.tallennaBT.Location = new System.Drawing.Point(197, 133);
            this.tallennaBT.Name = "tallennaBT";
            this.tallennaBT.Size = new System.Drawing.Size(93, 35);
            this.tallennaBT.TabIndex = 16;
            this.tallennaBT.Text = "TALLENNA";
            this.tallennaBT.UseVisualStyleBackColor = true;
            this.tallennaBT.Click += new System.EventHandler(this.tallennaBT_Click);
            // 
            // poistaBT
            // 
            this.poistaBT.Location = new System.Drawing.Point(463, 133);
            this.poistaBT.Name = "poistaBT";
            this.poistaBT.Size = new System.Drawing.Size(93, 35);
            this.poistaBT.TabIndex = 18;
            this.poistaBT.Text = "POISTA";
            this.poistaBT.UseVisualStyleBackColor = true;
            this.poistaBT.Click += new System.EventHandler(this.poistaBT_Click);
            // 
            // paivitaBT
            // 
            this.paivitaBT.Location = new System.Drawing.Point(329, 133);
            this.paivitaBT.Name = "paivitaBT";
            this.paivitaBT.Size = new System.Drawing.Size(93, 35);
            this.paivitaBT.TabIndex = 17;
            this.paivitaBT.Text = "PÄIVITÄ";
            this.paivitaBT.UseVisualStyleBackColor = true;
            this.paivitaBT.Click += new System.EventHandler(this.paivitaBT_Click);
            // 
            // TietotauluDG
            // 
            this.TietotauluDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TietotauluDG.Location = new System.Drawing.Point(28, 198);
            this.TietotauluDG.Name = "TietotauluDG";
            this.TietotauluDG.Size = new System.Drawing.Size(746, 240);
            this.TietotauluDG.TabIndex = 19;
            this.TietotauluDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TietotauluDG_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TietotauluDG);
            this.Controls.Add(this.poistaBT);
            this.Controls.Add(this.paivitaBT);
            this.Controls.Add(this.tallennaBT);
            this.Controls.Add(this.tyhjennaBT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.puhelinLB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sNimiTB);
            this.Controls.Add(this.nimiTB);
            this.Controls.Add(this.IdTB);
            this.Controls.Add(this.opiskelijaNroTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.puhelinTB);
            this.Name = "Form1";
            this.Text = "Opiskelijarekisterin ylläpito";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TietotauluDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox puhelinTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox opiskelijaNroTB;
        private System.Windows.Forms.TextBox sNimiTB;
        private System.Windows.Forms.TextBox nimiTB;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label puhelinLB;
        private System.Windows.Forms.Button tyhjennaBT;
        private System.Windows.Forms.Button tallennaBT;
        private System.Windows.Forms.Button poistaBT;
        private System.Windows.Forms.Button paivitaBT;
        private System.Windows.Forms.DataGridView TietotauluDG;
    }
}

