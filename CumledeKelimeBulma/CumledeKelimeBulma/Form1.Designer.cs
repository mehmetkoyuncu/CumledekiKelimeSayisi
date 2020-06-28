namespace CumledeKelimeBulma
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSearchedWord = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.RichTextBox();
            this.lblWordCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblArananSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSearchedWord
            // 
            this.txtSearchedWord.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchedWord.Location = new System.Drawing.Point(454, 36);
            this.txtSearchedWord.Multiline = true;
            this.txtSearchedWord.Name = "txtSearchedWord";
            this.txtSearchedWord.Size = new System.Drawing.Size(468, 54);
            this.txtSearchedWord.TabIndex = 0;
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(740, 96);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(182, 50);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // txtText
            // 
            this.txtText.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtText.Location = new System.Drawing.Point(33, 23);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(397, 267);
            this.txtText.TabIndex = 2;
            this.txtText.Text = "";
            // 
            // lblWordCount
            // 
            this.lblWordCount.AutoSize = true;
            this.lblWordCount.BackColor = System.Drawing.Color.Lime;
            this.lblWordCount.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWordCount.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblWordCount.Location = new System.Drawing.Point(656, 180);
            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Size = new System.Drawing.Size(70, 39);
            this.lblWordCount.TabIndex = 3;
            this.lblWordCount.Text = "label";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(484, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kelime Sayısı : ";
            // 
            // lblArananSonuc
            // 
            this.lblArananSonuc.AutoSize = true;
            this.lblArananSonuc.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblArananSonuc.Location = new System.Drawing.Point(761, 237);
            this.lblArananSonuc.Name = "lblArananSonuc";
            this.lblArananSonuc.Size = new System.Drawing.Size(0, 39);
            this.lblArananSonuc.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(934, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblArananSonuc);
            this.Controls.Add(this.lblWordCount);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtSearchedWord);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchedWord;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.RichTextBox txtText;
        private System.Windows.Forms.Label lblWordCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblArananSonuc;
    }
}

