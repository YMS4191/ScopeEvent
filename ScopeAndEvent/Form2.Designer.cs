namespace ScopeAndEvent
{
    partial class Form2
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
            this.txtYaziAlani = new System.Windows.Forms.TextBox();
            this.lblYaziAlani = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtYaziAlani
            // 
            this.txtYaziAlani.Location = new System.Drawing.Point(28, 13);
            this.txtYaziAlani.Name = "txtYaziAlani";
            this.txtYaziAlani.Size = new System.Drawing.Size(378, 20);
            this.txtYaziAlani.TabIndex = 0;
            this.txtYaziAlani.TextChanged += new System.EventHandler(this.txtYaziAlani_TextChanged);
            // 
            // lblYaziAlani
            // 
            this.lblYaziAlani.Location = new System.Drawing.Point(25, 47);
            this.lblYaziAlani.Name = "lblYaziAlani";
            this.lblYaziAlani.Size = new System.Drawing.Size(381, 330);
            this.lblYaziAlani.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 402);
            this.Controls.Add(this.lblYaziAlani);
            this.Controls.Add(this.txtYaziAlani);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYaziAlani;
        private System.Windows.Forms.Label lblYaziAlani;
    }
}