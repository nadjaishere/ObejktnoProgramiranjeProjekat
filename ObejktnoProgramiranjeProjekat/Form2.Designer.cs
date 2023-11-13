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
            this.components = new System.ComponentModel.Container();
            this.btnNazad2 = new System.Windows.Forms.Button();
            this.pbxIgrac1 = new System.Windows.Forms.PictureBox();
            this.pbxIgrac2 = new System.Windows.Forms.PictureBox();
            this.tmrNmp = new System.Windows.Forms.Timer(this.components);
            this.tmrMetkovi = new System.Windows.Forms.Timer(this.components);
            this.pbxMetak1 = new System.Windows.Forms.PictureBox();
            this.btnIzlaz2 = new System.Windows.Forms.Button();
            this.tbxPoeni1 = new System.Windows.Forms.TextBox();
            this.tbxPoeni2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIgrac1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIgrac2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMetak1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNazad2
            // 
            this.btnNazad2.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad2.Location = new System.Drawing.Point(1097, 93);
            this.btnNazad2.Name = "btnNazad2";
            this.btnNazad2.Size = new System.Drawing.Size(75, 75);
            this.btnNazad2.TabIndex = 0;
            this.btnNazad2.Text = "<";
            this.btnNazad2.UseVisualStyleBackColor = true;
            this.btnNazad2.TabStopChanged += new System.EventHandler(this.pbxMetak2_Click);
            this.btnNazad2.Click += new System.EventHandler(this.button1_Click);
            this.btnNazad2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.btnNazad2_PreviewKeyDown);
            // 
            // pbxIgrac1
            // 
            this.pbxIgrac1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pbxIgrac1.Location = new System.Drawing.Point(78, 256);
            this.pbxIgrac1.Name = "pbxIgrac1";
            this.pbxIgrac1.Size = new System.Drawing.Size(69, 63);
            this.pbxIgrac1.TabIndex = 1;
            this.pbxIgrac1.TabStop = false;
            this.pbxIgrac1.Click += new System.EventHandler(this.pbxIgrac1_Click);
            this.pbxIgrac1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.pbxIgrac1_PreviewKeyDown);
            // 
            // pbxIgrac2
            // 
            this.pbxIgrac2.BackColor = System.Drawing.Color.Yellow;
            this.pbxIgrac2.Location = new System.Drawing.Point(974, 256);
            this.pbxIgrac2.Name = "pbxIgrac2";
            this.pbxIgrac2.Size = new System.Drawing.Size(69, 63);
            this.pbxIgrac2.TabIndex = 2;
            this.pbxIgrac2.TabStop = false;
            this.pbxIgrac2.Click += new System.EventHandler(this.pbxIgrac2_Click);
            this.pbxIgrac2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.pbxIgrac2_PreviewKeyDown);
            // 
            // tmrNmp
            // 
            this.tmrNmp.Enabled = true;
            this.tmrNmp.Interval = 20;
            this.tmrNmp.Tick += new System.EventHandler(this.tmrNmp_Tick);
            // 
            // tmrMetkovi
            // 
            this.tmrMetkovi.Enabled = true;
            this.tmrMetkovi.Interval = 50;
            this.tmrMetkovi.Tick += new System.EventHandler(this.tmrMetkovi_Tick);
            // 
            // pbxMetak1
            // 
            this.pbxMetak1.BackColor = System.Drawing.Color.White;
            this.pbxMetak1.Location = new System.Drawing.Point(132, 285);
            this.pbxMetak1.Name = "pbxMetak1";
            this.pbxMetak1.Size = new System.Drawing.Size(15, 15);
            this.pbxMetak1.TabIndex = 4;
            this.pbxMetak1.TabStop = false;
            this.pbxMetak1.Click += new System.EventHandler(this.pbxMetak2_Click);
            // 
            // btnIzlaz2
            // 
            this.btnIzlaz2.BackColor = System.Drawing.Color.Red;
            this.btnIzlaz2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzlaz2.ForeColor = System.Drawing.Color.White;
            this.btnIzlaz2.Location = new System.Drawing.Point(1097, 12);
            this.btnIzlaz2.Name = "btnIzlaz2";
            this.btnIzlaz2.Size = new System.Drawing.Size(75, 75);
            this.btnIzlaz2.TabIndex = 5;
            this.btnIzlaz2.Text = "X";
            this.btnIzlaz2.UseVisualStyleBackColor = false;
            this.btnIzlaz2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tbxPoeni1
            // 
            this.tbxPoeni1.Location = new System.Drawing.Point(453, 12);
            this.tbxPoeni1.Name = "tbxPoeni1";
            this.tbxPoeni1.ReadOnly = true;
            this.tbxPoeni1.Size = new System.Drawing.Size(107, 22);
            this.tbxPoeni1.TabIndex = 6;
            // 
            // tbxPoeni2
            // 
            this.tbxPoeni2.Location = new System.Drawing.Point(621, 12);
            this.tbxPoeni2.Name = "tbxPoeni2";
            this.tbxPoeni2.ReadOnly = true;
            this.tbxPoeni2.Size = new System.Drawing.Size(107, 22);
            this.tbxPoeni2.TabIndex = 7;
            // 
            // frmIgra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 678);
            this.Controls.Add(this.tbxPoeni2);
            this.Controls.Add(this.tbxPoeni1);
            this.Controls.Add(this.btnIzlaz2);
            this.Controls.Add(this.pbxMetak1);
            this.Controls.Add(this.pbxIgrac2);
            this.Controls.Add(this.pbxIgrac1);
            this.Controls.Add(this.btnNazad2);
            this.MaximumSize = new System.Drawing.Size(1202, 725);
            this.Name = "frmIgra";
            this.Load += new System.EventHandler(this.frmIgra_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmIgra_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmIgra_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbxIgrac1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIgrac2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMetak1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNazad2;
        private System.Windows.Forms.PictureBox pbxIgrac1;
        private System.Windows.Forms.PictureBox pbxIgrac2;
        private System.Windows.Forms.Timer tmrNmp;
        private System.Windows.Forms.Timer tmrMetkovi;
        private System.Windows.Forms.PictureBox pbxMetak1;
        private System.Windows.Forms.Button btnIzlaz2;
        private System.Windows.Forms.TextBox tbxPoeni1;
        private System.Windows.Forms.TextBox tbxPoeni2;
    }
}