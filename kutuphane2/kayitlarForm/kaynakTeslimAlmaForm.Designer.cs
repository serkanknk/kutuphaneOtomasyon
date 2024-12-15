namespace kutuphane2.kayitlarForm
{
    partial class kaynakTeslimAlmaForm
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
            this.teslimAlButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1519, 705);
            this.dataGridView1.TabIndex = 0;
            // 
            // teslimAlButton
            // 
            this.teslimAlButton.BackColor = System.Drawing.Color.Lime;
            this.teslimAlButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teslimAlButton.Location = new System.Drawing.Point(21, 98);
            this.teslimAlButton.Name = "teslimAlButton";
            this.teslimAlButton.Size = new System.Drawing.Size(208, 53);
            this.teslimAlButton.TabIndex = 1;
            this.teslimAlButton.Text = "Teslim Al";
            this.teslimAlButton.UseVisualStyleBackColor = false;
            this.teslimAlButton.Click += new System.EventHandler(this.teslimAlButton_Click);
            // 
            // kaynakTeslimAlmaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1521, 921);
            this.Controls.Add(this.teslimAlButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "kaynakTeslimAlmaForm";
            this.Text = "kaynakTeslimAlmaForm";
            this.Load += new System.EventHandler(this.kaynakTeslimAlmaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button teslimAlButton;
    }
}