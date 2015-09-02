namespace RentCar
{
    partial class frmKullanaci
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
            this.pnl = new System.Windows.Forms.Panel();
            this.btnArac = new System.Windows.Forms.Button();
            this.btnKullanici = new System.Windows.Forms.Button();
            this.btnKirala = new System.Windows.Forms.Button();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.btnKirala);
            this.pnl.Controls.Add(this.btnArac);
            this.pnl.Controls.Add(this.btnKullanici);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl.Location = new System.Drawing.Point(0, 0);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(754, 74);
            this.pnl.TabIndex = 0;
            // 
            // btnArac
            // 
            this.btnArac.Location = new System.Drawing.Point(210, 23);
            this.btnArac.Name = "btnArac";
            this.btnArac.Size = new System.Drawing.Size(173, 23);
            this.btnArac.TabIndex = 1;
            this.btnArac.Text = "Araclar";
            this.btnArac.UseVisualStyleBackColor = true;
            this.btnArac.Click += new System.EventHandler(this.btnArac_Click);
            // 
            // btnKullanici
            // 
            this.btnKullanici.Location = new System.Drawing.Point(13, 23);
            this.btnKullanici.Name = "btnKullanici";
            this.btnKullanici.Size = new System.Drawing.Size(145, 23);
            this.btnKullanici.TabIndex = 0;
            this.btnKullanici.Text = "Kullanıcı İşlemleri";
            this.btnKullanici.UseVisualStyleBackColor = true;
            this.btnKullanici.Click += new System.EventHandler(this.btnKullanici_Click);
            // 
            // btnKirala
            // 
            this.btnKirala.Location = new System.Drawing.Point(478, 22);
            this.btnKirala.Name = "btnKirala";
            this.btnKirala.Size = new System.Drawing.Size(167, 23);
            this.btnKirala.TabIndex = 2;
            this.btnKirala.Text = "Kirala";
            this.btnKirala.UseVisualStyleBackColor = true;
            this.btnKirala.Click += new System.EventHandler(this.btnKirala_Click);
            // 
            // frmKullanaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 375);
            this.Controls.Add(this.pnl);
            this.IsMdiContainer = true;
            this.Name = "frmKullanaci";
            this.Text = "frmKullanaci";
            this.pnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Button btnKullanici;
        private System.Windows.Forms.Button btnArac;
        private System.Windows.Forms.Button btnKirala;
    }
}