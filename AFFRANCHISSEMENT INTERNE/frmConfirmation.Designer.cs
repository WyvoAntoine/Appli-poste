
namespace AFFRANCHISSEMENT_INTERNE
{
    partial class frmAffichage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAffichage));
            this.lblDate = new System.Windows.Forms.Label();
            this.lblLieu = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.ImageList(this.components);
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.timerFermeture = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(282, 101);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 15);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "label1";
            // 
            // lblLieu
            // 
            this.lblLieu.AutoSize = true;
            this.lblLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLieu.Location = new System.Drawing.Point(228, 142);
            this.lblLieu.Name = "lblLieu";
            this.lblLieu.Size = new System.Drawing.Size(183, 17);
            this.lblLieu.TabIndex = 1;
            this.lblLieu.Text = "Béthune - Pas de Calais";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrix.Location = new System.Drawing.Point(456, 96);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(57, 20);
            this.lblPrix.TabIndex = 2;
            this.lblPrix.Text = "label1";
            // 
            // imgLogo
            // 
            this.imgLogo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLogo.ImageStream")));
            this.imgLogo.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLogo.Images.SetKeyName(0, "th.jpg");
            this.imgLogo.Images.SetKeyName(1, "th.jpg");
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::AFFRANCHISSEMENT_INTERNE.Properties.Resources.Sans_titre__3_;
            this.pctLogo.Location = new System.Drawing.Point(25, 43);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(172, 140);
            this.pctLogo.TabIndex = 3;
            this.pctLogo.TabStop = false;
            // 
            // timerFermeture
            // 
            this.timerFermeture.Interval = 5000;
            this.timerFermeture.Tick += new System.EventHandler(this.timerFermeture_Tick);
            // 
            // frmAffichage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 212);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.lblLieu);
            this.Controls.Add(this.lblDate);
            this.Name = "frmAffichage";
            this.Text = "Confirmation";
            this.Load += new System.EventHandler(this.frmAffichage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblLieu;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.ImageList imgLogo;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Timer timerFermeture;
    }
}