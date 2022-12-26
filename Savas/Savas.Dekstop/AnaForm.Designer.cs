namespace Savas.Dekstop
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.BilgiPanel = new System.Windows.Forms.Panel();
            this.UcakSavarPanel = new System.Windows.Forms.Panel();
            this.SavasAlaniPanel = new System.Windows.Forms.Panel();
            this.BilgiLabel = new System.Windows.Forms.Label();
            this.SureLabel = new System.Windows.Forms.Label();
            this.BilgiPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BilgiPanel
            // 
            this.BilgiPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BilgiPanel.Controls.Add(this.SureLabel);
            this.BilgiPanel.Controls.Add(this.BilgiLabel);
            this.BilgiPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BilgiPanel.Location = new System.Drawing.Point(0, 0);
            this.BilgiPanel.Name = "BilgiPanel";
            this.BilgiPanel.Size = new System.Drawing.Size(1119, 145);
            this.BilgiPanel.TabIndex = 0;
            // 
            // UcakSavarPanel
            // 
            this.UcakSavarPanel.BackColor = System.Drawing.SystemColors.Info;
            this.UcakSavarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UcakSavarPanel.Location = new System.Drawing.Point(0, 603);
            this.UcakSavarPanel.Name = "UcakSavarPanel";
            this.UcakSavarPanel.Size = new System.Drawing.Size(1119, 50);
            this.UcakSavarPanel.TabIndex = 1;
            // 
            // SavasAlaniPanel
            // 
            this.SavasAlaniPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SavasAlaniPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SavasAlaniPanel.Location = new System.Drawing.Point(0, 145);
            this.SavasAlaniPanel.Name = "SavasAlaniPanel";
            this.SavasAlaniPanel.Size = new System.Drawing.Size(1119, 458);
            this.SavasAlaniPanel.TabIndex = 2;
            // 
            // BilgiLabel
            // 
            this.BilgiLabel.AutoSize = true;
            this.BilgiLabel.Font = new System.Drawing.Font("Leelawadee", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BilgiLabel.Location = new System.Drawing.Point(12, 39);
            this.BilgiLabel.Name = "BilgiLabel";
            this.BilgiLabel.Size = new System.Drawing.Size(599, 75);
            this.BilgiLabel.TabIndex = 0;
            this.BilgiLabel.Text = "Oyunu başlatmak için ENTER tuşuna basınız.\r\nUçaksavarı hareket ettirmek için SAĞ/" +
    "SOL yön tuşlarına basınız.\r\nAteş etmek için BOŞLUK tuşuna basınız";
            // 
            // SureLabel
            // 
            this.SureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SureLabel.Location = new System.Drawing.Point(901, 39);
            this.SureLabel.Name = "SureLabel";
            this.SureLabel.Size = new System.Drawing.Size(206, 64);
            this.SureLabel.TabIndex = 1;
            this.SureLabel.Text = "0:00";
            this.SureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 653);
            this.Controls.Add(this.SavasAlaniPanel);
            this.Controls.Add(this.UcakSavarPanel);
            this.Controls.Add(this.BilgiPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaForm";
            this.Text = " Savas Oyunu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnaForm_KeyDown);
            this.BilgiPanel.ResumeLayout(false);
            this.BilgiPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BilgiPanel;
        private System.Windows.Forms.Label SureLabel;
        private System.Windows.Forms.Label BilgiLabel;
        private System.Windows.Forms.Panel UcakSavarPanel;
        private System.Windows.Forms.Panel SavasAlaniPanel;
    }
}

