namespace GeometrikHesapMakinesi
{
    partial class GeoCalculatorForm
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
            this.bAlan = new System.Windows.Forms.Button();
            this.Bcevre = new System.Windows.Forms.Button();
            this.rtbSonuc = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBEU = new System.Windows.Forms.CheckBox();
            this.cbDU = new System.Windows.Forms.CheckBox();
            this.cbKare = new System.Windows.Forms.CheckBox();
            this.cbDikdörtgen = new System.Windows.Forms.CheckBox();
            this.cbDaire = new System.Windows.Forms.CheckBox();
            this.gbEU = new System.Windows.Forms.GroupBox();
            this.tbTabanKenar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbDikUcgen = new System.Windows.Forms.GroupBox();
            this.tbYukseklik = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDUtaban = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbDikdörtgen = new System.Windows.Forms.GroupBox();
            this.tbKısaKenar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUzunKenar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbKare = new System.Windows.Forms.GroupBox();
            this.tbUzunKenarK = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbDaire = new System.Windows.Forms.GroupBox();
            this.tbYarıcap = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gbSekiller = new System.Windows.Forms.GroupBox();
            this.gbEU.SuspendLayout();
            this.gbDikUcgen.SuspendLayout();
            this.gbDikdörtgen.SuspendLayout();
            this.gbKare.SuspendLayout();
            this.gbDaire.SuspendLayout();
            this.gbSekiller.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAlan
            // 
            this.bAlan.Location = new System.Drawing.Point(8, 195);
            this.bAlan.Name = "bAlan";
            this.bAlan.Size = new System.Drawing.Size(174, 47);
            this.bAlan.TabIndex = 0;
            this.bAlan.Text = "Alan Hesapla";
            this.bAlan.UseVisualStyleBackColor = true;
            this.bAlan.Click += new System.EventHandler(this.bAlan_Click);
            // 
            // Bcevre
            // 
            this.Bcevre.Location = new System.Drawing.Point(188, 195);
            this.Bcevre.Name = "Bcevre";
            this.Bcevre.Size = new System.Drawing.Size(174, 47);
            this.Bcevre.TabIndex = 1;
            this.Bcevre.Text = "Çevre Hesapla";
            this.Bcevre.UseVisualStyleBackColor = true;
            this.Bcevre.Click += new System.EventHandler(this.Bcevre_Click);
            // 
            // rtbSonuc
            // 
            this.rtbSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtbSonuc.Location = new System.Drawing.Point(115, 248);
            this.rtbSonuc.Name = "rtbSonuc";
            this.rtbSonuc.Size = new System.Drawing.Size(452, 77);
            this.rtbSonuc.TabIndex = 2;
            this.rtbSonuc.Text = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(3, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 74);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sonuç :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(5, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lütfen hesap yapmak istediğiniz şekli seçin:";
            // 
            // CBEU
            // 
            this.CBEU.AutoSize = true;
            this.CBEU.Location = new System.Drawing.Point(6, 21);
            this.CBEU.Name = "CBEU";
            this.CBEU.Size = new System.Drawing.Size(127, 21);
            this.CBEU.TabIndex = 6;
            this.CBEU.Text = "Eşkenar Üçgen";
            this.CBEU.UseVisualStyleBackColor = true;
            this.CBEU.CheckedChanged += new System.EventHandler(this.CBEU_CheckedChanged);
            // 
            // cbDU
            // 
            this.cbDU.AutoSize = true;
            this.cbDU.Location = new System.Drawing.Point(6, 44);
            this.cbDU.Name = "cbDU";
            this.cbDU.Size = new System.Drawing.Size(95, 21);
            this.cbDU.TabIndex = 7;
            this.cbDU.Text = "Dik Üçgen";
            this.cbDU.UseVisualStyleBackColor = true;
            this.cbDU.CheckedChanged += new System.EventHandler(this.cbDU_CheckedChanged);
            // 
            // cbKare
            // 
            this.cbKare.AutoSize = true;
            this.cbKare.Location = new System.Drawing.Point(6, 70);
            this.cbKare.Name = "cbKare";
            this.cbKare.Size = new System.Drawing.Size(60, 21);
            this.cbKare.TabIndex = 8;
            this.cbKare.Text = "Kare";
            this.cbKare.UseVisualStyleBackColor = true;
            this.cbKare.CheckedChanged += new System.EventHandler(this.cbKare_CheckedChanged);
            // 
            // cbDikdörtgen
            // 
            this.cbDikdörtgen.AutoSize = true;
            this.cbDikdörtgen.Location = new System.Drawing.Point(6, 97);
            this.cbDikdörtgen.Name = "cbDikdörtgen";
            this.cbDikdörtgen.Size = new System.Drawing.Size(99, 21);
            this.cbDikdörtgen.TabIndex = 9;
            this.cbDikdörtgen.Text = "Dikdörtgen";
            this.cbDikdörtgen.UseVisualStyleBackColor = true;
            this.cbDikdörtgen.CheckedChanged += new System.EventHandler(this.cbDikdörtgen_CheckedChanged);
            // 
            // cbDaire
            // 
            this.cbDaire.AutoSize = true;
            this.cbDaire.Location = new System.Drawing.Point(6, 124);
            this.cbDaire.Name = "cbDaire";
            this.cbDaire.Size = new System.Drawing.Size(64, 21);
            this.cbDaire.TabIndex = 10;
            this.cbDaire.Text = "Daire";
            this.cbDaire.UseVisualStyleBackColor = true;
            this.cbDaire.CheckedChanged += new System.EventHandler(this.cbDaire_CheckedChanged);
            // 
            // gbEU
            // 
            this.gbEU.Controls.Add(this.tbTabanKenar);
            this.gbEU.Controls.Add(this.label3);
            this.gbEU.Location = new System.Drawing.Point(296, 30);
            this.gbEU.Name = "gbEU";
            this.gbEU.Size = new System.Drawing.Size(324, 106);
            this.gbEU.TabIndex = 11;
            this.gbEU.TabStop = false;
            this.gbEU.Text = "Eşkenar Üçgen";
            this.gbEU.Visible = false;
            // 
            // tbTabanKenar
            // 
            this.tbTabanKenar.Location = new System.Drawing.Point(213, 19);
            this.tbTabanKenar.Name = "tbTabanKenar";
            this.tbTabanKenar.Size = new System.Drawing.Size(100, 22);
            this.tbTabanKenar.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Taban kenarı değerini giriniz : ";
            // 
            // gbDikUcgen
            // 
            this.gbDikUcgen.Controls.Add(this.tbYukseklik);
            this.gbDikUcgen.Controls.Add(this.label5);
            this.gbDikUcgen.Controls.Add(this.tbDUtaban);
            this.gbDikUcgen.Controls.Add(this.label4);
            this.gbDikUcgen.Location = new System.Drawing.Point(296, 29);
            this.gbDikUcgen.Name = "gbDikUcgen";
            this.gbDikUcgen.Size = new System.Drawing.Size(324, 106);
            this.gbDikUcgen.TabIndex = 12;
            this.gbDikUcgen.TabStop = false;
            this.gbDikUcgen.Text = "Dik Üçgen";
            this.gbDikUcgen.Visible = false;
            // 
            // tbYukseklik
            // 
            this.tbYukseklik.Location = new System.Drawing.Point(213, 44);
            this.tbYukseklik.Name = "tbYukseklik";
            this.tbYukseklik.Size = new System.Drawing.Size(100, 22);
            this.tbYukseklik.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Yükseklik değerini giriniz : ";
            // 
            // tbDUtaban
            // 
            this.tbDUtaban.Location = new System.Drawing.Point(213, 19);
            this.tbDUtaban.Name = "tbDUtaban";
            this.tbDUtaban.Size = new System.Drawing.Size(100, 22);
            this.tbDUtaban.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Taban kenarı değerini giriniz : ";
            // 
            // gbDikdörtgen
            // 
            this.gbDikdörtgen.Controls.Add(this.tbKısaKenar);
            this.gbDikdörtgen.Controls.Add(this.label6);
            this.gbDikdörtgen.Controls.Add(this.tbUzunKenar);
            this.gbDikdörtgen.Controls.Add(this.label7);
            this.gbDikdörtgen.Location = new System.Drawing.Point(296, 30);
            this.gbDikdörtgen.Name = "gbDikdörtgen";
            this.gbDikdörtgen.Size = new System.Drawing.Size(324, 106);
            this.gbDikdörtgen.TabIndex = 13;
            this.gbDikdörtgen.TabStop = false;
            this.gbDikdörtgen.Text = "Dikdörtgen";
            this.gbDikdörtgen.Visible = false;
            // 
            // tbKısaKenar
            // 
            this.tbKısaKenar.Location = new System.Drawing.Point(213, 44);
            this.tbKısaKenar.Name = "tbKısaKenar";
            this.tbKısaKenar.Size = new System.Drawing.Size(100, 22);
            this.tbKısaKenar.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Kısa kenar değerini giriniz : ";
            // 
            // tbUzunKenar
            // 
            this.tbUzunKenar.Location = new System.Drawing.Point(213, 19);
            this.tbUzunKenar.Name = "tbUzunKenar";
            this.tbUzunKenar.Size = new System.Drawing.Size(100, 22);
            this.tbUzunKenar.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Uzun kenar değerini giriniz : ";
            // 
            // gbKare
            // 
            this.gbKare.Controls.Add(this.tbUzunKenarK);
            this.gbKare.Controls.Add(this.label8);
            this.gbKare.Location = new System.Drawing.Point(296, 30);
            this.gbKare.Name = "gbKare";
            this.gbKare.Size = new System.Drawing.Size(324, 106);
            this.gbKare.TabIndex = 12;
            this.gbKare.TabStop = false;
            this.gbKare.Text = "Kare";
            this.gbKare.Visible = false;
            // 
            // tbUzunKenarK
            // 
            this.tbUzunKenarK.Location = new System.Drawing.Point(213, 19);
            this.tbUzunKenarK.Name = "tbUzunKenarK";
            this.tbUzunKenarK.Size = new System.Drawing.Size(100, 22);
            this.tbUzunKenarK.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Uzun kenar değerini giriniz : ";
            // 
            // gbDaire
            // 
            this.gbDaire.Controls.Add(this.tbYarıcap);
            this.gbDaire.Controls.Add(this.label9);
            this.gbDaire.Location = new System.Drawing.Point(296, 29);
            this.gbDaire.Name = "gbDaire";
            this.gbDaire.Size = new System.Drawing.Size(324, 106);
            this.gbDaire.TabIndex = 12;
            this.gbDaire.TabStop = false;
            this.gbDaire.Text = "Daire";
            this.gbDaire.Visible = false;
            // 
            // tbYarıcap
            // 
            this.tbYarıcap.Location = new System.Drawing.Point(213, 19);
            this.tbYarıcap.Name = "tbYarıcap";
            this.tbYarıcap.Size = new System.Drawing.Size(100, 22);
            this.tbYarıcap.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Yarıçap değerini giriniz : ";
            // 
            // gbSekiller
            // 
            this.gbSekiller.Controls.Add(this.CBEU);
            this.gbSekiller.Controls.Add(this.cbDU);
            this.gbSekiller.Controls.Add(this.cbKare);
            this.gbSekiller.Controls.Add(this.cbDikdörtgen);
            this.gbSekiller.Controls.Add(this.cbDaire);
            this.gbSekiller.Location = new System.Drawing.Point(12, 30);
            this.gbSekiller.Name = "gbSekiller";
            this.gbSekiller.Size = new System.Drawing.Size(193, 149);
            this.gbSekiller.TabIndex = 14;
            this.gbSekiller.TabStop = false;
            this.gbSekiller.Text = "Şekiller";
            // 
            // GeoCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 348);
            this.Controls.Add(this.gbSekiller);
            this.Controls.Add(this.gbDikUcgen);
            this.Controls.Add(this.gbDaire);
            this.Controls.Add(this.gbDikdörtgen);
            this.Controls.Add(this.gbKare);
            this.Controls.Add(this.gbEU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbSonuc);
            this.Controls.Add(this.Bcevre);
            this.Controls.Add(this.bAlan);
            this.Name = "GeoCalculatorForm";
            this.Text = "GeoCalculator";
            this.gbEU.ResumeLayout(false);
            this.gbEU.PerformLayout();
            this.gbDikUcgen.ResumeLayout(false);
            this.gbDikUcgen.PerformLayout();
            this.gbDikdörtgen.ResumeLayout(false);
            this.gbDikdörtgen.PerformLayout();
            this.gbKare.ResumeLayout(false);
            this.gbKare.PerformLayout();
            this.gbDaire.ResumeLayout(false);
            this.gbDaire.PerformLayout();
            this.gbSekiller.ResumeLayout(false);
            this.gbSekiller.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAlan;
        private System.Windows.Forms.Button Bcevre;
        private System.Windows.Forms.RichTextBox rtbSonuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CBEU;
        private System.Windows.Forms.CheckBox cbDU;
        private System.Windows.Forms.CheckBox cbKare;
        private System.Windows.Forms.CheckBox cbDikdörtgen;
        private System.Windows.Forms.CheckBox cbDaire;
        private System.Windows.Forms.GroupBox gbEU;
        private System.Windows.Forms.TextBox tbTabanKenar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbDikUcgen;
        private System.Windows.Forms.TextBox tbYukseklik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDUtaban;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbDikdörtgen;
        private System.Windows.Forms.TextBox tbKısaKenar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUzunKenar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbKare;
        private System.Windows.Forms.TextBox tbUzunKenarK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbDaire;
        private System.Windows.Forms.TextBox tbYarıcap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbSekiller;
    }
}

