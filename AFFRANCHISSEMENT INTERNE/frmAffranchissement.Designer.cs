
namespace AFFRANCHISSEMENT_INTERNE
{
    partial class frmAffranchissement
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPoids = new System.Windows.Forms.Label();
            this.txtPoids = new System.Windows.Forms.TextBox();
            this.lblIndicationPoids = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbChoixCourrier = new System.Windows.Forms.GroupBox();
            this.rdbRecommande = new System.Windows.Forms.RadioButton();
            this.rdbEcopli = new System.Windows.Forms.RadioButton();
            this.rdbLettre = new System.Windows.Forms.RadioButton();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.grbRecommande = new System.Windows.Forms.GroupBox();
            this.pnlCourrierNon = new System.Windows.Forms.Panel();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.txtCodePostal = new System.Windows.Forms.TextBox();
            this.lblCodePostal = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.pnlCourrierOui = new System.Windows.Forms.Panel();
            this.txtMelPart3 = new System.Windows.Forms.TextBox();
            this.lblAdresseMail = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            this.txtMelPart1 = new System.Windows.Forms.TextBox();
            this.txtMelPart2 = new System.Windows.Forms.TextBox();
            this.lblArobase = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.grbCourrielOuPas = new System.Windows.Forms.GroupBox();
            this.rdbNon = new System.Windows.Forms.RadioButton();
            this.rdbOui = new System.Windows.Forms.RadioButton();
            this.chkAvisReception = new System.Windows.Forms.CheckBox();
            this.grbTaux = new System.Windows.Forms.GroupBox();
            this.rdbR3 = new System.Windows.Forms.RadioButton();
            this.rdbR2 = new System.Windows.Forms.RadioButton();
            this.rdbR1 = new System.Windows.Forms.RadioButton();
            this.btnNouveauCourriel = new System.Windows.Forms.Button();
            this.lblTarif = new System.Windows.Forms.Label();
            this.txtTarif = new System.Windows.Forms.TextBox();
            this.btnValiderTarif = new System.Windows.Forms.Button();
            this.grbChoixCourrier.SuspendLayout();
            this.grbRecommande.SuspendLayout();
            this.pnlCourrierNon.SuspendLayout();
            this.pnlCourrierOui.SuspendLayout();
            this.grbCourrielOuPas.SuspendLayout();
            this.grbTaux.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPoids
            // 
            this.lblPoids.AutoSize = true;
            this.lblPoids.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoids.Location = new System.Drawing.Point(36, 95);
            this.lblPoids.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoids.Name = "lblPoids";
            this.lblPoids.Size = new System.Drawing.Size(188, 25);
            this.lblPoids.TabIndex = 0;
            this.lblPoids.Text = "Poids du courrier :";
            // 
            // txtPoids
            // 
            this.txtPoids.Location = new System.Drawing.Point(274, 95);
            this.txtPoids.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPoids.MaxLength = 4;
            this.txtPoids.Name = "txtPoids";
            this.txtPoids.Size = new System.Drawing.Size(109, 26);
            this.txtPoids.TabIndex = 1;
            this.txtPoids.TextChanged += new System.EventHandler(this.TxtPoids_TextChanged);
            this.txtPoids.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPoids_KeyPress_1);
            // 
            // lblIndicationPoids
            // 
            this.lblIndicationPoids.AutoSize = true;
            this.lblIndicationPoids.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicationPoids.Location = new System.Drawing.Point(447, 95);
            this.lblIndicationPoids.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndicationPoids.Name = "lblIndicationPoids";
            this.lblIndicationPoids.Size = new System.Drawing.Size(144, 22);
            this.lblIndicationPoids.TabIndex = 2;
            this.lblIndicationPoids.Text = "( en grammes )";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(754, 78);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(51, 20);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "label1";
            // 
            // grbChoixCourrier
            // 
            this.grbChoixCourrier.Controls.Add(this.rdbRecommande);
            this.grbChoixCourrier.Controls.Add(this.rdbEcopli);
            this.grbChoixCourrier.Controls.Add(this.rdbLettre);
            this.grbChoixCourrier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChoixCourrier.Location = new System.Drawing.Point(40, 183);
            this.grbChoixCourrier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbChoixCourrier.Name = "grbChoixCourrier";
            this.grbChoixCourrier.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbChoixCourrier.Size = new System.Drawing.Size(231, 166);
            this.grbChoixCourrier.TabIndex = 4;
            this.grbChoixCourrier.TabStop = false;
            this.grbChoixCourrier.Text = "Type de courrier";
            // 
            // rdbRecommande
            // 
            this.rdbRecommande.AutoSize = true;
            this.rdbRecommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRecommande.Location = new System.Drawing.Point(9, 111);
            this.rdbRecommande.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbRecommande.Name = "rdbRecommande";
            this.rdbRecommande.Size = new System.Drawing.Size(137, 24);
            this.rdbRecommande.TabIndex = 2;
            this.rdbRecommande.Text = "Recommandé";
            this.rdbRecommande.UseVisualStyleBackColor = true;
            this.rdbRecommande.CheckedChanged += new System.EventHandler(this.rdbRecommande_CheckedChanged);
            // 
            // rdbEcopli
            // 
            this.rdbEcopli.AutoSize = true;
            this.rdbEcopli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEcopli.Location = new System.Drawing.Point(9, 75);
            this.rdbEcopli.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbEcopli.Name = "rdbEcopli";
            this.rdbEcopli.Size = new System.Drawing.Size(80, 24);
            this.rdbEcopli.TabIndex = 1;
            this.rdbEcopli.Text = "Écopli";
            this.rdbEcopli.UseVisualStyleBackColor = true;
            this.rdbEcopli.CheckedChanged += new System.EventHandler(this.RdbEcopli_CheckedChanged);
            // 
            // rdbLettre
            // 
            this.rdbLettre.AutoSize = true;
            this.rdbLettre.Checked = true;
            this.rdbLettre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLettre.Location = new System.Drawing.Point(9, 40);
            this.rdbLettre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbLettre.Name = "rdbLettre";
            this.rdbLettre.Size = new System.Drawing.Size(78, 24);
            this.rdbLettre.TabIndex = 0;
            this.rdbLettre.TabStop = true;
            this.rdbLettre.Text = "Lettre";
            this.rdbLettre.UseVisualStyleBackColor = true;
            this.rdbLettre.CheckedChanged += new System.EventHandler(this.rdbLettre_CheckedChanged);
            // 
            // grbRecommande
            // 
            this.grbRecommande.Controls.Add(this.pnlCourrierNon);
            this.grbRecommande.Controls.Add(this.pnlCourrierOui);
            this.grbRecommande.Controls.Add(this.txtPrenom);
            this.grbRecommande.Controls.Add(this.lblPrenom);
            this.grbRecommande.Controls.Add(this.txtNom);
            this.grbRecommande.Controls.Add(this.lblNom);
            this.grbRecommande.Controls.Add(this.grbCourrielOuPas);
            this.grbRecommande.Controls.Add(this.chkAvisReception);
            this.grbRecommande.Controls.Add(this.grbTaux);
            this.grbRecommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRecommande.Location = new System.Drawing.Point(465, 138);
            this.grbRecommande.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbRecommande.Name = "grbRecommande";
            this.grbRecommande.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbRecommande.Size = new System.Drawing.Size(736, 542);
            this.grbRecommande.TabIndex = 5;
            this.grbRecommande.TabStop = false;
            this.grbRecommande.Text = "Courrier recommandé";
            this.grbRecommande.Visible = false;
            // 
            // pnlCourrierNon
            // 
            this.pnlCourrierNon.Controls.Add(this.txtVille);
            this.pnlCourrierNon.Controls.Add(this.lblVille);
            this.pnlCourrierNon.Controls.Add(this.txtCodePostal);
            this.pnlCourrierNon.Controls.Add(this.lblCodePostal);
            this.pnlCourrierNon.Controls.Add(this.txtAdresse);
            this.pnlCourrierNon.Controls.Add(this.lblAdresse);
            this.pnlCourrierNon.Location = new System.Drawing.Point(22, 363);
            this.pnlCourrierNon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCourrierNon.Name = "pnlCourrierNon";
            this.pnlCourrierNon.Size = new System.Drawing.Size(673, 178);
            this.pnlCourrierNon.TabIndex = 15;
            this.pnlCourrierNon.Visible = false;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(180, 132);
            this.txtVille.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(306, 28);
            this.txtVille.TabIndex = 5;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(98, 137);
            this.lblVille.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(61, 22);
            this.lblVille.TabIndex = 4;
            this.lblVille.Text = "Ville :";
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.Location = new System.Drawing.Point(180, 78);
            this.txtCodePostal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.Size = new System.Drawing.Size(127, 28);
            this.txtCodePostal.TabIndex = 3;
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.AutoSize = true;
            this.lblCodePostal.Location = new System.Drawing.Point(24, 83);
            this.lblCodePostal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodePostal.Name = "lblCodePostal";
            this.lblCodePostal.Size = new System.Drawing.Size(131, 22);
            this.lblCodePostal.TabIndex = 2;
            this.lblCodePostal.Text = "Code Postal :";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(180, 23);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(388, 28);
            this.txtAdresse.TabIndex = 1;
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(63, 29);
            this.lblAdresse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(95, 22);
            this.lblAdresse.TabIndex = 0;
            this.lblAdresse.Text = "Adresse :";
            // 
            // pnlCourrierOui
            // 
            this.pnlCourrierOui.Controls.Add(this.txtMelPart3);
            this.pnlCourrierOui.Controls.Add(this.lblAdresseMail);
            this.pnlCourrierOui.Controls.Add(this.lblPoint);
            this.pnlCourrierOui.Controls.Add(this.txtMelPart1);
            this.pnlCourrierOui.Controls.Add(this.txtMelPart2);
            this.pnlCourrierOui.Controls.Add(this.lblArobase);
            this.pnlCourrierOui.Location = new System.Drawing.Point(22, 363);
            this.pnlCourrierOui.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCourrierOui.Name = "pnlCourrierOui";
            this.pnlCourrierOui.Size = new System.Drawing.Size(673, 65);
            this.pnlCourrierOui.TabIndex = 14;
            this.pnlCourrierOui.Visible = false;
            // 
            // txtMelPart3
            // 
            this.txtMelPart3.Location = new System.Drawing.Point(576, 28);
            this.txtMelPart3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMelPart3.Name = "txtMelPart3";
            this.txtMelPart3.Size = new System.Drawing.Size(58, 28);
            this.txtMelPart3.TabIndex = 12;
            // 
            // lblAdresseMail
            // 
            this.lblAdresseMail.AutoSize = true;
            this.lblAdresseMail.Location = new System.Drawing.Point(4, 37);
            this.lblAdresseMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdresseMail.Name = "lblAdresseMail";
            this.lblAdresseMail.Size = new System.Drawing.Size(132, 22);
            this.lblAdresseMail.TabIndex = 7;
            this.lblAdresseMail.Text = "Adresse Mel :";
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Location = new System.Drawing.Point(529, 31);
            this.lblPoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(16, 22);
            this.lblPoint.TabIndex = 11;
            this.lblPoint.Text = ".";
            // 
            // txtMelPart1
            // 
            this.txtMelPart1.Location = new System.Drawing.Point(146, 28);
            this.txtMelPart1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMelPart1.Name = "txtMelPart1";
            this.txtMelPart1.Size = new System.Drawing.Size(228, 28);
            this.txtMelPart1.TabIndex = 8;
            // 
            // txtMelPart2
            // 
            this.txtMelPart2.Location = new System.Drawing.Point(418, 28);
            this.txtMelPart2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMelPart2.Name = "txtMelPart2";
            this.txtMelPart2.Size = new System.Drawing.Size(103, 28);
            this.txtMelPart2.TabIndex = 10;
            // 
            // lblArobase
            // 
            this.lblArobase.AutoSize = true;
            this.lblArobase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArobase.Location = new System.Drawing.Point(382, 31);
            this.lblArobase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArobase.Name = "lblArobase";
            this.lblArobase.Size = new System.Drawing.Size(28, 22);
            this.lblArobase.TabIndex = 9;
            this.lblArobase.Text = "@";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(360, 322);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(148, 28);
            this.txtPrenom.TabIndex = 6;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(252, 322);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(90, 22);
            this.lblPrenom.TabIndex = 5;
            this.lblPrenom.Text = "Prénom :";
            // 
            // txtNom
            // 
            this.txtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNom.Location = new System.Drawing.Point(360, 262);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(148, 28);
            this.txtNom.TabIndex = 4;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(282, 262);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(62, 22);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Nom :";
            // 
            // grbCourrielOuPas
            // 
            this.grbCourrielOuPas.Controls.Add(this.rdbNon);
            this.grbCourrielOuPas.Controls.Add(this.rdbOui);
            this.grbCourrielOuPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCourrielOuPas.Location = new System.Drawing.Point(286, 157);
            this.grbCourrielOuPas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbCourrielOuPas.Name = "grbCourrielOuPas";
            this.grbCourrielOuPas.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbCourrielOuPas.Size = new System.Drawing.Size(178, 66);
            this.grbCourrielOuPas.TabIndex = 2;
            this.grbCourrielOuPas.TabStop = false;
            this.grbCourrielOuPas.Text = "Par courriel";
            // 
            // rdbNon
            // 
            this.rdbNon.AutoSize = true;
            this.rdbNon.Location = new System.Drawing.Point(80, 29);
            this.rdbNon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbNon.Name = "rdbNon";
            this.rdbNon.Size = new System.Drawing.Size(63, 24);
            this.rdbNon.TabIndex = 1;
            this.rdbNon.Text = "Non";
            this.rdbNon.UseVisualStyleBackColor = true;
            this.rdbNon.CheckedChanged += new System.EventHandler(this.rdbNon_CheckedChanged);
            // 
            // rdbOui
            // 
            this.rdbOui.AutoSize = true;
            this.rdbOui.Checked = true;
            this.rdbOui.Location = new System.Drawing.Point(9, 29);
            this.rdbOui.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbOui.Name = "rdbOui";
            this.rdbOui.Size = new System.Drawing.Size(58, 24);
            this.rdbOui.TabIndex = 0;
            this.rdbOui.TabStop = true;
            this.rdbOui.Text = "Oui";
            this.rdbOui.UseVisualStyleBackColor = true;
            this.rdbOui.CheckedChanged += new System.EventHandler(this.rdbOui_CheckedChanged);
            // 
            // chkAvisReception
            // 
            this.chkAvisReception.AutoSize = true;
            this.chkAvisReception.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAvisReception.Location = new System.Drawing.Point(206, 75);
            this.chkAvisReception.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkAvisReception.Name = "chkAvisReception";
            this.chkAvisReception.Size = new System.Drawing.Size(174, 26);
            this.chkAvisReception.TabIndex = 1;
            this.chkAvisReception.Text = "Avis de réception";
            this.chkAvisReception.UseVisualStyleBackColor = true;
            this.chkAvisReception.CheckedChanged += new System.EventHandler(this.chkAvisReception_CheckedChanged);
            // 
            // grbTaux
            // 
            this.grbTaux.Controls.Add(this.rdbR3);
            this.grbTaux.Controls.Add(this.rdbR2);
            this.grbTaux.Controls.Add(this.rdbR1);
            this.grbTaux.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTaux.Location = new System.Drawing.Point(22, 55);
            this.grbTaux.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbTaux.Name = "grbTaux";
            this.grbTaux.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbTaux.Size = new System.Drawing.Size(112, 148);
            this.grbTaux.TabIndex = 0;
            this.grbTaux.TabStop = false;
            this.grbTaux.Text = "Taux";
            // 
            // rdbR3
            // 
            this.rdbR3.AutoSize = true;
            this.rdbR3.Location = new System.Drawing.Point(30, 102);
            this.rdbR3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbR3.Name = "rdbR3";
            this.rdbR3.Size = new System.Drawing.Size(55, 24);
            this.rdbR3.TabIndex = 2;
            this.rdbR3.Text = "R3";
            this.rdbR3.UseVisualStyleBackColor = true;
            this.rdbR3.CheckedChanged += new System.EventHandler(this.rdbR3_CheckedChanged);
            // 
            // rdbR2
            // 
            this.rdbR2.AutoSize = true;
            this.rdbR2.Location = new System.Drawing.Point(30, 65);
            this.rdbR2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbR2.Name = "rdbR2";
            this.rdbR2.Size = new System.Drawing.Size(55, 24);
            this.rdbR2.TabIndex = 1;
            this.rdbR2.Text = "R2";
            this.rdbR2.UseVisualStyleBackColor = true;
            this.rdbR2.CheckedChanged += new System.EventHandler(this.rdbR2_CheckedChanged);
            // 
            // rdbR1
            // 
            this.rdbR1.AutoSize = true;
            this.rdbR1.Checked = true;
            this.rdbR1.Location = new System.Drawing.Point(30, 29);
            this.rdbR1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbR1.Name = "rdbR1";
            this.rdbR1.Size = new System.Drawing.Size(55, 24);
            this.rdbR1.TabIndex = 0;
            this.rdbR1.TabStop = true;
            this.rdbR1.Text = "R1";
            this.rdbR1.UseVisualStyleBackColor = true;
            this.rdbR1.CheckedChanged += new System.EventHandler(this.rdbR1_CheckedChanged);
            // 
            // btnNouveauCourriel
            // 
            this.btnNouveauCourriel.Location = new System.Drawing.Point(40, 369);
            this.btnNouveauCourriel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNouveauCourriel.Name = "btnNouveauCourriel";
            this.btnNouveauCourriel.Size = new System.Drawing.Size(177, 58);
            this.btnNouveauCourriel.TabIndex = 6;
            this.btnNouveauCourriel.Text = "Nouveau Courrier";
            this.btnNouveauCourriel.UseVisualStyleBackColor = true;
            this.btnNouveauCourriel.Click += new System.EventHandler(this.btnNouveauCourriel_Click);
            // 
            // lblTarif
            // 
            this.lblTarif.AutoSize = true;
            this.lblTarif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarif.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTarif.Location = new System.Drawing.Point(18, 508);
            this.lblTarif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarif.Name = "lblTarif";
            this.lblTarif.Size = new System.Drawing.Size(147, 25);
            this.lblTarif.TabIndex = 7;
            this.lblTarif.Text = "Tarif à payer :";
            // 
            // txtTarif
            // 
            this.txtTarif.Enabled = false;
            this.txtTarif.Location = new System.Drawing.Point(196, 506);
            this.txtTarif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTarif.Name = "txtTarif";
            this.txtTarif.Size = new System.Drawing.Size(148, 26);
            this.txtTarif.TabIndex = 8;
            // 
            // btnValiderTarif
            // 
            this.btnValiderTarif.Location = new System.Drawing.Point(158, 589);
            this.btnValiderTarif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnValiderTarif.Name = "btnValiderTarif";
            this.btnValiderTarif.Size = new System.Drawing.Size(189, 71);
            this.btnValiderTarif.TabIndex = 9;
            this.btnValiderTarif.Text = "Valider le tarif";
            this.btnValiderTarif.UseVisualStyleBackColor = true;
            this.btnValiderTarif.Click += new System.EventHandler(this.btnValiderTarif_Click);
            // 
            // frmAffranchissement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 698);
            this.Controls.Add(this.btnValiderTarif);
            this.Controls.Add(this.txtTarif);
            this.Controls.Add(this.lblTarif);
            this.Controls.Add(this.btnNouveauCourriel);
            this.Controls.Add(this.grbRecommande);
            this.Controls.Add(this.grbChoixCourrier);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblIndicationPoids);
            this.Controls.Add(this.txtPoids);
            this.Controls.Add(this.lblPoids);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAffranchissement";
            this.Text = "Calcul des tarifs pour les courriers en France Métropolitaine";
            this.Load += new System.EventHandler(this.frmAffranchissement_Load);
            this.grbChoixCourrier.ResumeLayout(false);
            this.grbChoixCourrier.PerformLayout();
            this.grbRecommande.ResumeLayout(false);
            this.grbRecommande.PerformLayout();
            this.pnlCourrierNon.ResumeLayout(false);
            this.pnlCourrierNon.PerformLayout();
            this.pnlCourrierOui.ResumeLayout(false);
            this.pnlCourrierOui.PerformLayout();
            this.grbCourrielOuPas.ResumeLayout(false);
            this.grbCourrielOuPas.PerformLayout();
            this.grbTaux.ResumeLayout(false);
            this.grbTaux.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPoids;
        private System.Windows.Forms.TextBox txtPoids;
        private System.Windows.Forms.Label lblIndicationPoids;
        private System.Windows.Forms.Label lblDate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grbChoixCourrier;
        private System.Windows.Forms.RadioButton rdbRecommande;
        private System.Windows.Forms.RadioButton rdbEcopli;
        private System.Windows.Forms.RadioButton rdbLettre;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox grbRecommande;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.GroupBox grbCourrielOuPas;
        private System.Windows.Forms.RadioButton rdbNon;
        private System.Windows.Forms.RadioButton rdbOui;
        private System.Windows.Forms.CheckBox chkAvisReception;
        private System.Windows.Forms.GroupBox grbTaux;
        private System.Windows.Forms.RadioButton rdbR3;
        private System.Windows.Forms.RadioButton rdbR2;
        private System.Windows.Forms.RadioButton rdbR1;
        private System.Windows.Forms.Button btnNouveauCourriel;
        private System.Windows.Forms.Label lblAdresseMail;
        private System.Windows.Forms.TextBox txtMelPart3;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.TextBox txtMelPart2;
        private System.Windows.Forms.Label lblArobase;
        private System.Windows.Forms.TextBox txtMelPart1;
        private System.Windows.Forms.Panel pnlCourrierNon;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Panel pnlCourrierOui;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.TextBox txtCodePostal;
        private System.Windows.Forms.Label lblCodePostal;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label lblTarif;
        private System.Windows.Forms.TextBox txtTarif;
        private System.Windows.Forms.Button btnValiderTarif;
    }
}

