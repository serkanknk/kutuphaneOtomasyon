namespace kutuphane2.kaynakİslemleri
{
    partial class kaynakGuncelleForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kaynakGuncelleTarih = new System.Windows.Forms.DateTimePicker();
            this.kaynakGuncelleSayfa = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.kaynakGuncelleButton = new System.Windows.Forms.Button();
            this.kaynakGuncelleYayınevi = new System.Windows.Forms.TextBox();
            this.kaynakGuncelleYazar = new System.Windows.Forms.TextBox();
            this.kaynakGuncelleAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakGuncelleSayfa)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(407, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1120, 859);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // kaynakGuncelleTarih
            // 
            this.kaynakGuncelleTarih.Location = new System.Drawing.Point(187, 347);
            this.kaynakGuncelleTarih.Name = "kaynakGuncelleTarih";
            this.kaynakGuncelleTarih.Size = new System.Drawing.Size(181, 22);
            this.kaynakGuncelleTarih.TabIndex = 55;
            // 
            // kaynakGuncelleSayfa
            // 
            this.kaynakGuncelleSayfa.Location = new System.Drawing.Point(187, 303);
            this.kaynakGuncelleSayfa.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.kaynakGuncelleSayfa.Name = "kaynakGuncelleSayfa";
            this.kaynakGuncelleSayfa.Size = new System.Drawing.Size(181, 22);
            this.kaynakGuncelleSayfa.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(63, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 53;
            this.label5.Text = "Tarih:";
            // 
            // kaynakGuncelleButton
            // 
            this.kaynakGuncelleButton.BackColor = System.Drawing.Color.Blue;
            this.kaynakGuncelleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaynakGuncelleButton.Location = new System.Drawing.Point(194, 386);
            this.kaynakGuncelleButton.Name = "kaynakGuncelleButton";
            this.kaynakGuncelleButton.Size = new System.Drawing.Size(174, 57);
            this.kaynakGuncelleButton.TabIndex = 52;
            this.kaynakGuncelleButton.Text = "Güncelle";
            this.kaynakGuncelleButton.UseVisualStyleBackColor = false;
            this.kaynakGuncelleButton.Click += new System.EventHandler(this.kaynakGuncelleButton_Click);
            // 
            // kaynakGuncelleYayınevi
            // 
            this.kaynakGuncelleYayınevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaynakGuncelleYayınevi.Location = new System.Drawing.Point(187, 243);
            this.kaynakGuncelleYayınevi.Multiline = true;
            this.kaynakGuncelleYayınevi.Name = "kaynakGuncelleYayınevi";
            this.kaynakGuncelleYayınevi.Size = new System.Drawing.Size(181, 34);
            this.kaynakGuncelleYayınevi.TabIndex = 51;
            // 
            // kaynakGuncelleYazar
            // 
            this.kaynakGuncelleYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaynakGuncelleYazar.Location = new System.Drawing.Point(187, 180);
            this.kaynakGuncelleYazar.Multiline = true;
            this.kaynakGuncelleYazar.Name = "kaynakGuncelleYazar";
            this.kaynakGuncelleYazar.Size = new System.Drawing.Size(181, 34);
            this.kaynakGuncelleYazar.TabIndex = 50;
            // 
            // kaynakGuncelleAd
            // 
            this.kaynakGuncelleAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaynakGuncelleAd.Location = new System.Drawing.Point(187, 120);
            this.kaynakGuncelleAd.Multiline = true;
            this.kaynakGuncelleAd.Name = "kaynakGuncelleAd";
            this.kaynakGuncelleAd.Size = new System.Drawing.Size(181, 34);
            this.kaynakGuncelleAd.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(-2, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 48;
            this.label4.Text = "Sayfa Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(37, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "Yayınevi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(63, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Yazar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(92, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 45;
            this.label1.Text = "Ad:";
            // 
            // kaynakGuncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1520, 924);
            this.Controls.Add(this.kaynakGuncelleTarih);
            this.Controls.Add(this.kaynakGuncelleSayfa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kaynakGuncelleButton);
            this.Controls.Add(this.kaynakGuncelleYayınevi);
            this.Controls.Add(this.kaynakGuncelleYazar);
            this.Controls.Add(this.kaynakGuncelleAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "kaynakGuncelleForm";
            this.Text = "kaynakGuncelleForm";
            this.Load += new System.EventHandler(this.kaynakGuncelleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakGuncelleSayfa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker kaynakGuncelleTarih;
        private System.Windows.Forms.NumericUpDown kaynakGuncelleSayfa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button kaynakGuncelleButton;
        private System.Windows.Forms.TextBox kaynakGuncelleYayınevi;
        private System.Windows.Forms.TextBox kaynakGuncelleYazar;
        private System.Windows.Forms.TextBox kaynakGuncelleAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}