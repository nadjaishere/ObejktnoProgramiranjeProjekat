namespace ObejktnoProgramiranjeProjekat
{
    partial class frmIgra
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
            this.btnNazad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNazad
            // 
            this.btnNazad.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.ForeColor = System.Drawing.Color.Black;
            this.btnNazad.Location = new System.Drawing.Point(24, 12);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(75, 75);
            this.btnNazad.TabIndex = 6;
            this.btnNazad.Text = "<";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // frmIgra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 678);
            this.Controls.Add(this.btnNazad);
            this.MinimumSize = new System.Drawing.Size(1202, 725);
            this.Name = "frmIgra";
            this.Load += new System.EventHandler(this.frmIgra_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNazad;
    }
}