
namespace ZarAtmaOyunuV1
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
            this.TextBoxSkor = new System.Windows.Forms.TextBox();
            this.pictureBox_Oyuncu1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Oyuncu2 = new System.Windows.Forms.PictureBox();
            this.buttonOyuncu1 = new System.Windows.Forms.Button();
            this.buttonOyuncu2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelOyuncu1Skor = new System.Windows.Forms.Label();
            this.labelOyuncu2Skor = new System.Windows.Forms.Label();
            this.buttonTekrar = new System.Windows.Forms.Button();
            this.buttonBaşla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Oyuncu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Oyuncu2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(96, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kazanma Skorunu Belirleyiniz.";
            // 
            // TextBoxSkor
            // 
            this.TextBoxSkor.Location = new System.Drawing.Point(354, 21);
            this.TextBoxSkor.Name = "TextBoxSkor";
            this.TextBoxSkor.Size = new System.Drawing.Size(108, 20);
            this.TextBoxSkor.TabIndex = 1;
            // 
            // pictureBox_Oyuncu1
            // 
            this.pictureBox_Oyuncu1.Location = new System.Drawing.Point(44, 105);
            this.pictureBox_Oyuncu1.Name = "pictureBox_Oyuncu1";
            this.pictureBox_Oyuncu1.Size = new System.Drawing.Size(159, 134);
            this.pictureBox_Oyuncu1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Oyuncu1.TabIndex = 2;
            this.pictureBox_Oyuncu1.TabStop = false;
            this.pictureBox_Oyuncu1.Visible = false;
            // 
            // pictureBox_Oyuncu2
            // 
            this.pictureBox_Oyuncu2.Location = new System.Drawing.Point(325, 105);
            this.pictureBox_Oyuncu2.Name = "pictureBox_Oyuncu2";
            this.pictureBox_Oyuncu2.Size = new System.Drawing.Size(156, 134);
            this.pictureBox_Oyuncu2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Oyuncu2.TabIndex = 3;
            this.pictureBox_Oyuncu2.TabStop = false;
            this.pictureBox_Oyuncu2.Visible = false;
            // 
            // buttonOyuncu1
            // 
            this.buttonOyuncu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOyuncu1.Location = new System.Drawing.Point(44, 276);
            this.buttonOyuncu1.Name = "buttonOyuncu1";
            this.buttonOyuncu1.Size = new System.Drawing.Size(159, 40);
            this.buttonOyuncu1.TabIndex = 4;
            this.buttonOyuncu1.Text = "Oyuncu 1";
            this.buttonOyuncu1.UseVisualStyleBackColor = true;
            this.buttonOyuncu1.Visible = false;
            this.buttonOyuncu1.Click += new System.EventHandler(this.buttonOyuncu1_Click);
            // 
            // buttonOyuncu2
            // 
            this.buttonOyuncu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOyuncu2.Location = new System.Drawing.Point(325, 276);
            this.buttonOyuncu2.Name = "buttonOyuncu2";
            this.buttonOyuncu2.Size = new System.Drawing.Size(159, 40);
            this.buttonOyuncu2.TabIndex = 5;
            this.buttonOyuncu2.Text = "Oyuncu 2";
            this.buttonOyuncu2.UseVisualStyleBackColor = true;
            this.buttonOyuncu2.Visible = false;
            this.buttonOyuncu2.Click += new System.EventHandler(this.buttonOyuncu2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(40, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Skor:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(321, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Skor:";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelOyuncu1Skor
            // 
            this.labelOyuncu1Skor.AutoSize = true;
            this.labelOyuncu1Skor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOyuncu1Skor.Location = new System.Drawing.Point(96, 253);
            this.labelOyuncu1Skor.Name = "labelOyuncu1Skor";
            this.labelOyuncu1Skor.Size = new System.Drawing.Size(19, 20);
            this.labelOyuncu1Skor.TabIndex = 8;
            this.labelOyuncu1Skor.Text = "0";
            this.labelOyuncu1Skor.Visible = false;
            // 
            // labelOyuncu2Skor
            // 
            this.labelOyuncu2Skor.AutoSize = true;
            this.labelOyuncu2Skor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOyuncu2Skor.Location = new System.Drawing.Point(378, 253);
            this.labelOyuncu2Skor.Name = "labelOyuncu2Skor";
            this.labelOyuncu2Skor.Size = new System.Drawing.Size(19, 20);
            this.labelOyuncu2Skor.TabIndex = 9;
            this.labelOyuncu2Skor.Text = "0";
            this.labelOyuncu2Skor.Visible = false;
            // 
            // buttonTekrar
            // 
            this.buttonTekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTekrar.Location = new System.Drawing.Point(181, 378);
            this.buttonTekrar.Name = "buttonTekrar";
            this.buttonTekrar.Size = new System.Drawing.Size(216, 42);
            this.buttonTekrar.TabIndex = 10;
            this.buttonTekrar.Text = "Tekrar Başlat";
            this.buttonTekrar.UseVisualStyleBackColor = true;
            this.buttonTekrar.Visible = false;
            this.buttonTekrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBaşla
            // 
            this.buttonBaşla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBaşla.Location = new System.Drawing.Point(169, 47);
            this.buttonBaşla.Name = "buttonBaşla";
            this.buttonBaşla.Size = new System.Drawing.Size(215, 36);
            this.buttonBaşla.TabIndex = 11;
            this.buttonBaşla.Text = "Oyuna Başla";
            this.buttonBaşla.UseVisualStyleBackColor = true;
            this.buttonBaşla.Click += new System.EventHandler(this.buttonBaşla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 423);
            this.Controls.Add(this.buttonBaşla);
            this.Controls.Add(this.buttonTekrar);
            this.Controls.Add(this.labelOyuncu2Skor);
            this.Controls.Add(this.labelOyuncu1Skor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonOyuncu2);
            this.Controls.Add(this.buttonOyuncu1);
            this.Controls.Add(this.pictureBox_Oyuncu2);
            this.Controls.Add(this.pictureBox_Oyuncu1);
            this.Controls.Add(this.TextBoxSkor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Oyuncu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Oyuncu2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxSkor;
        private System.Windows.Forms.PictureBox pictureBox_Oyuncu1;
        private System.Windows.Forms.PictureBox pictureBox_Oyuncu2;
        private System.Windows.Forms.Button buttonOyuncu1;
        private System.Windows.Forms.Button buttonOyuncu2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelOyuncu1Skor;
        private System.Windows.Forms.Label labelOyuncu2Skor;
        private System.Windows.Forms.Button buttonTekrar;
        private System.Windows.Forms.Button buttonBaşla;
    }
}

