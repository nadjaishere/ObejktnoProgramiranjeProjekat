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
            this.pbxMetak2 = new System.Windows.Forms.PictureBox();
            this.pbxMetak1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIgrac1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIgrac2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMetak2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMetak1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNazad2
            // 
            this.btnNazad2.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad2.Location = new System.Drawing.Point(1097, 12);
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
            // pbxMetak2
            // 
            this.pbxMetak2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pbxMetak2.Location = new System.Drawing.Point(974, 285);
            this.pbxMetak2.Name = "pbxMetak2";
            this.pbxMetak2.Size = new System.Drawing.Size(15, 15);
            this.pbxMetak2.TabIndex = 3;
            this.pbxMetak2.TabStop = false;
            // 
            // pbxMetak1
            // 
            this.pbxMetak1.BackColor = System.Drawing.Color.Red;
            this.pbxMetak1.Location = new System.Drawing.Point(132, 285);
            this.pbxMetak1.Name = "pbxMetak1";
            this.pbxMetak1.Size = new System.Drawing.Size(15, 15);
            this.pbxMetak1.TabIndex = 4;
            this.pbxMetak1.TabStop = false;
            this.pbxMetak1.Click += new System.EventHandler(this.pbxMetak2_Click);
            // 
            // frmIgra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 678);
            this.Controls.Add(this.pbxMetak1);
            this.Controls.Add(this.pbxMetak2);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbxMetak2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMetak1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNazad2;
        private System.Windows.Forms.PictureBox pbxIgrac1;
        private System.Windows.Forms.PictureBox pbxIgrac2;
        private System.Windows.Forms.Timer tmrNmp;
        private System.Windows.Forms.Timer tmrMetkovi;
        private System.Windows.Forms.PictureBox pbxMetak2;
        private System.Windows.Forms.PictureBox pbxMetak1;
    }
}