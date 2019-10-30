namespace ScopeAndEvent
{
    partial class Form3
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
            this.txtMetinAlani = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKalanKarakterSayisi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMetinAlani
            // 
            this.txtMetinAlani.Location = new System.Drawing.Point(13, 13);
            this.txtMetinAlani.Multiline = true;
            this.txtMetinAlani.Name = "txtMetinAlani";
            this.txtMetinAlani.Size = new System.Drawing.Size(476, 156);
            this.txtMetinAlani.TabIndex = 0;
            this.txtMetinAlani.TextChanged += new System.EventHandler(this.txtMetinAlani_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kalan Karakter Sayısı : ";
            // 
            // lblKalanKarakterSayisi
            // 
            this.lblKalanKarakterSayisi.AutoSize = true;
            this.lblKalanKarakterSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKalanKarakterSayisi.Location = new System.Drawing.Point(188, 188);
            this.lblKalanKarakterSayisi.Name = "lblKalanKarakterSayisi";
            this.lblKalanKarakterSayisi.Size = new System.Drawing.Size(36, 20);
            this.lblKalanKarakterSayisi.TabIndex = 2;
            this.lblKalanKarakterSayisi.Text = "500";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 233);
            this.Controls.Add(this.lblKalanKarakterSayisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMetinAlani);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMetinAlani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKalanKarakterSayisi;
    }
}