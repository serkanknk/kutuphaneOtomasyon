namespace kutuphane2.kayitlarForm
{
    partial class kaynakOduncForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.uyeAraText = new System.Windows.Forms.TextBox();
            this.uyeAraButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.kitapAdArama = new System.Windows.Forms.TextBox();
            this.öduncVer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 349);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1513, 579);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Üye Tc. No=";
            // 
            // uyeAraText
            // 
            this.uyeAraText.Location = new System.Drawing.Point(147, 35);
            this.uyeAraText.Multiline = true;
            this.uyeAraText.Name = "uyeAraText";
            this.uyeAraText.Size = new System.Drawing.Size(303, 35);
            this.uyeAraText.TabIndex = 2;
            this.uyeAraText.TextChanged += new System.EventHandler(this.uyeAraText_TextChanged);
            // 
            // uyeAraButton
            // 
            this.uyeAraButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyeAraButton.Location = new System.Drawing.Point(456, 35);
            this.uyeAraButton.Name = "uyeAraButton";
            this.uyeAraButton.Size = new System.Drawing.Size(98, 36);
            this.uyeAraButton.TabIndex = 3;
            this.uyeAraButton.Text = "Ara";
            this.uyeAraButton.UseVisualStyleBackColor = true;
            this.uyeAraButton.Click += new System.EventHandler(this.uyeAraButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(142, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(581, 45);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(923, 275);
            this.dataGridView2.TabIndex = 5;
            // 
            // kitapAdArama
            // 
            this.kitapAdArama.BackColor = System.Drawing.Color.White;
            this.kitapAdArama.Location = new System.Drawing.Point(581, 4);
            this.kitapAdArama.Multiline = true;
            this.kitapAdArama.Name = "kitapAdArama";
            this.kitapAdArama.Size = new System.Drawing.Size(424, 35);
            this.kitapAdArama.TabIndex = 6;
            this.kitapAdArama.TextChanged += new System.EventHandler(this.kitapAdArama_TextChanged);
            // 
            // öduncVer
            // 
            this.öduncVer.BackColor = System.Drawing.Color.Lime;
            this.öduncVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.öduncVer.Location = new System.Drawing.Point(381, 263);
            this.öduncVer.Name = "öduncVer";
            this.öduncVer.Size = new System.Drawing.Size(173, 57);
            this.öduncVer.TabIndex = 7;
            this.öduncVer.Text = "Ödünç Ver";
            this.öduncVer.UseVisualStyleBackColor = false;
            this.öduncVer.Click += new System.EventHandler(this.öduncVer_Click);
            // 
            // kaynakOduncForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1436, 919);
            this.Controls.Add(this.öduncVer);
            this.Controls.Add(this.kitapAdArama);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uyeAraButton);
            this.Controls.Add(this.uyeAraText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "kaynakOduncForm";
            this.Text = "kaynakOduncForm";
            this.Load += new System.EventHandler(this.kaynakOduncForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uyeAraText;
        private System.Windows.Forms.Button uyeAraButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox kitapAdArama;
        private System.Windows.Forms.Button öduncVer;
    }
}