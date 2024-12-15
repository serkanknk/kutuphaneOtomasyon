namespace kutuphane2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.girişButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PersonelŞifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PersonelAdi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(115, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // girişButton
            // 
            this.girişButton.BackColor = System.Drawing.Color.Lime;
            this.girişButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girişButton.Location = new System.Drawing.Point(115, 363);
            this.girişButton.Name = "girişButton";
            this.girişButton.Size = new System.Drawing.Size(185, 43);
            this.girişButton.TabIndex = 10;
            this.girişButton.Text = "Giriş";
            this.girişButton.UseVisualStyleBackColor = false;
            this.girişButton.Click += new System.EventHandler(this.girişButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(44, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Şifre:";
            // 
            // PersonelŞifre
            // 
            this.PersonelŞifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelŞifre.Location = new System.Drawing.Point(115, 309);
            this.PersonelŞifre.Multiline = true;
            this.PersonelŞifre.Name = "PersonelŞifre";
            this.PersonelŞifre.PasswordChar = '*';
            this.PersonelŞifre.Size = new System.Drawing.Size(185, 35);
            this.PersonelŞifre.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(57, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Adı:";
            // 
            // PersonelAdi
            // 
            this.PersonelAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelAdi.Location = new System.Drawing.Point(115, 249);
            this.PersonelAdi.Multiline = true;
            this.PersonelAdi.Name = "PersonelAdi";
            this.PersonelAdi.Size = new System.Drawing.Size(185, 35);
            this.PersonelAdi.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(412, 451);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.girişButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PersonelŞifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PersonelAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button girişButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PersonelŞifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PersonelAdi;
    }
}

