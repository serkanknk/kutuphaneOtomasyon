namespace kutuphane2.kaynakİslemleri
{
    partial class kaynakEkleForm
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
            this.kaynakEkleButton = new System.Windows.Forms.Button();
            this.kaynakEkleYayınevi = new System.Windows.Forms.TextBox();
            this.kaynakEkleYazar = new System.Windows.Forms.TextBox();
            this.kaynakEkleAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kaynakEkleSayfa = new System.Windows.Forms.NumericUpDown();
            this.kaynakEkleTarih = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakEkleSayfa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kaynakEkleButton
            // 
            this.kaynakEkleButton.BackColor = System.Drawing.Color.Lime;
            this.kaynakEkleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaynakEkleButton.Location = new System.Drawing.Point(207, 484);
            this.kaynakEkleButton.Name = "kaynakEkleButton";
            this.kaynakEkleButton.Size = new System.Drawing.Size(174, 57);
            this.kaynakEkleButton.TabIndex = 41;
            this.kaynakEkleButton.Text = "Kaydet";
            this.kaynakEkleButton.UseVisualStyleBackColor = false;
            this.kaynakEkleButton.Click += new System.EventHandler(this.kaynakEkleButton_Click);
            // 
            // kaynakEkleYayınevi
            // 
            this.kaynakEkleYayınevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaynakEkleYayınevi.Location = new System.Drawing.Point(200, 332);
            this.kaynakEkleYayınevi.Multiline = true;
            this.kaynakEkleYayınevi.Name = "kaynakEkleYayınevi";
            this.kaynakEkleYayınevi.Size = new System.Drawing.Size(181, 34);
            this.kaynakEkleYayınevi.TabIndex = 37;
            // 
            // kaynakEkleYazar
            // 
            this.kaynakEkleYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaynakEkleYazar.Location = new System.Drawing.Point(200, 269);
            this.kaynakEkleYazar.Multiline = true;
            this.kaynakEkleYazar.Name = "kaynakEkleYazar";
            this.kaynakEkleYazar.Size = new System.Drawing.Size(181, 34);
            this.kaynakEkleYazar.TabIndex = 36;
            // 
            // kaynakEkleAd
            // 
            this.kaynakEkleAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaynakEkleAd.Location = new System.Drawing.Point(200, 209);
            this.kaynakEkleAd.Multiline = true;
            this.kaynakEkleAd.Name = "kaynakEkleAd";
            this.kaynakEkleAd.Size = new System.Drawing.Size(181, 34);
            this.kaynakEkleAd.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Sayfa Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(50, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Yayınevi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(76, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Yazar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(105, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Ad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(76, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "Tarih:";
            // 
            // kaynakEkleSayfa
            // 
            this.kaynakEkleSayfa.Location = new System.Drawing.Point(200, 392);
            this.kaynakEkleSayfa.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.kaynakEkleSayfa.Name = "kaynakEkleSayfa";
            this.kaynakEkleSayfa.Size = new System.Drawing.Size(181, 22);
            this.kaynakEkleSayfa.TabIndex = 43;
            // 
            // kaynakEkleTarih
            // 
            this.kaynakEkleTarih.Location = new System.Drawing.Point(200, 436);
            this.kaynakEkleTarih.Name = "kaynakEkleTarih";
            this.kaynakEkleTarih.Size = new System.Drawing.Size(181, 22);
            this.kaynakEkleTarih.TabIndex = 44;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(412, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1114, 819);
            this.dataGridView1.TabIndex = 45;
            // 
            // kaynakEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1442, 886);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kaynakEkleTarih);
            this.Controls.Add(this.kaynakEkleSayfa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kaynakEkleButton);
            this.Controls.Add(this.kaynakEkleYayınevi);
            this.Controls.Add(this.kaynakEkleYazar);
            this.Controls.Add(this.kaynakEkleAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "kaynakEkleForm";
            this.Text = "kaynakEkleForm";
            this.Load += new System.EventHandler(this.kaynakEkleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kaynakEkleSayfa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button kaynakEkleButton;
        private System.Windows.Forms.TextBox kaynakEkleYayınevi;
        private System.Windows.Forms.TextBox kaynakEkleYazar;
        private System.Windows.Forms.TextBox kaynakEkleAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown kaynakEkleSayfa;
        private System.Windows.Forms.DateTimePicker kaynakEkleTarih;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}