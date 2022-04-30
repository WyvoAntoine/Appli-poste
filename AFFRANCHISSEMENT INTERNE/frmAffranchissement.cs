using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFFRANCHISSEMENT_INTERNE
{

    public partial class frmAffranchissement : Form
    {
        public frmAffranchissement()
        {
            InitializeComponent();

        }
        ///<summary>
        ///S'effectue au chargement de la page
        ///</summary>
        private void frmAffranchissement_Load(object sender, EventArgs e)
        {

            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            grbCourrielOuPas.Visible = false;
            lblNom.Visible = false;
            lblPrenom.Visible = false;
            txtNom.Visible = false;
            txtPrenom.Visible = false;

        }
        ///<summary>
        ///S'effectue lorsque le bouton radio Recommande change d'état
        ///</summary>
        private void rdbRecommande_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbRecommande.Checked == true)
                grbRecommande.Visible = true;
            else
                grbRecommande.Visible = false;
            ///<summary>
            ///Test si le bouton Recommande et R1 sont cochés et  appelle la fonction en conséquence
            ///</summary>
            if (rdbRecommande.Checked == true && rdbR1.Checked == true)

            {
                ///<summary>
                ///le try catch viens gérer l'expetion du poids quand la case est vide
                ///</summary>
                try

                {
                    double prix = prixRecommandeR1(rdbRecommande.Checked, rdbR1.Checked,int.Parse(txtPoids.Text));
                    

                    txtTarif.Text = prix.ToString();
                }
                catch
                {
                    if (txtPoids.Text == "")
                        txtPoids.Focus();
                }
            }
            ///<summary>
            ///Test si le bouton Recommande et R2 sont cochés et  appelle la fonction en conséquence
            ///</summary>
            if (rdbRecommande.Checked == true && rdbR2.Checked == true)

            {
                try
                {
                    
                    txtTarif.Text = prix.ToString();
                }
                catch
                {
                    if (txtPoids.Text == "")
                        txtPoids.Focus();
                }
            }
            ///<summary>
            ///Test si le bouton Recommande et R3 sont cochés et  appelle la fonction en conséquence
            ///</summary>
            if (rdbRecommande.Checked == true && rdbR3.Checked == true)

            {
                try
                {
                     
                    txtTarif.Text = prix.ToString();
                }
                catch
                {
                    if (txtPoids.Text == "")
                        txtPoids.Focus();
                }
            }
        }

        private void chkAvisReception_CheckedChanged(object sender, EventArgs e)
        {
            ///<summary>
            ///S'effectue lorsque la checkbox Avis de recéption change d'etat
            ///</summary>
            if (chkAvisReception.Checked == false)
            {

                pnlCourrierNon.Visible = false;
                pnlCourrierOui.Visible = false;

            }
            try
            {
                ///<summary>
                ///Test si la check box est coché et donc agit en conséquence
                ///</summary>
                if (chkAvisReception.Checked == true)

                {
                    ///<summary>
                    ///Test si le bouton R1 et coché et appelle la fonction en conséquence plus le supplément pour avis de réception
                    ///</summary>
                    ///<value>poids compris entre 1 et 3000 inclus</value>
                    if (rdbR1.Checked == true)

                    {
                        double prix = prixRecommandeR1(rdbRecommande.Checked, rdbR1.Checked, int.Parse(txtPoids.Text)) + 1.15;
                        txtTarif.Text = prix.ToString();
                    }
                    else
                    {
                        ///<summary>
                        ///Test si le bouton R2 et coché et appelle la fonction en conséquence plus le supplément pour avis de réception
                        ///</summary>
                        ///<value>poids compris entre 1 et 3000 inclus</value>
                        if (rdbR2.Checked == true)

                        {
                            double prix = prixRecommandeR2(rdbRecommande.Checked, rdbR2.Checked, int.Parse(txtPoids.Text)) + 1.15;
                            txtTarif.Text = prix.ToString();
                        }
                        else
                        {
                            ///<summary>
                            ///Test si le bouton R3 et coché et appelle la fonction en conséquence plus le supplément pour avis de réception
                            ///</summary>
                            ///<value>poids compris entre 1 et 3000 inclus</value>
                            if (rdbR3.Checked == true)

                            {
                                double prix = prixRecommandeR3(rdbRecommande.Checked, rdbR3.Checked, int.Parse(txtPoids.Text)) + 1.15;
                                txtTarif.Text = prix.ToString();
                            }
                        }
                    }
                    

                    
                }
                ///<summary>
                ///Si la checkbox n'est pas coché il effectue le même processus que avant mais moins les 1,15 de supplémént
                ///</summary>
                ///<value>poids compris entre 1 et 3000 inclus</value>
                else

                {
                    if (rdbR1.Checked == true)
                    {
                        double prix = prixRecommandeR1(rdbRecommande.Checked, rdbR1.Checked, int.Parse(txtPoids.Text));
                        txtTarif.Text = prix.ToString();
                    }
                    else
                    {
                        if (rdbR2.Checked == true)
                        {
                            double prix = prixRecommandeR2(rdbRecommande.Checked, rdbR2.Checked, int.Parse(txtPoids.Text));
                            txtTarif.Text = prix.ToString();
                        }
                        else
                        {
                            if (rdbR3.Checked == true)
                            {
                                double prix = prixRecommandeR3(rdbRecommande.Checked, rdbR3.Checked, int.Parse(txtPoids.Text));
                                txtTarif.Text = prix.ToString();
                            }
                        }
                    }

                }
            }
            catch
            {
                if (txtPoids.Text == "")
                    txtPoids.Focus();
            }


            if (chkAvisReception.Checked == true)
            {
                grbCourrielOuPas.Visible = true;
                lblNom.Visible = true;
                lblPrenom.Visible = true;
                txtNom.Visible = true;
                txtPrenom.Visible = true;
                pnlCourrierOui.Visible = true;
            }
            else
            {
                grbCourrielOuPas.Visible = false;
                lblNom.Visible = false;
                lblPrenom.Visible = false;
                txtNom.Visible = false;
                txtPrenom.Visible = false;
            }

        }
        ///<summary>
        ///Lorsque l'on clique remet tous les composants énoncé ci-dessous à l'état d'ouverture
        ///</summary>
        private void btnNouveauCourriel_Click(object sender, EventArgs e)
        {

            rdbLettre.Checked = true;
            rdbR1.Checked = true;
            chkAvisReception.Checked = false;
            rdbOui.Checked = true;
            txtPoids.Text = String.Empty;
            txtNom.Text = String.Empty;
            txtPrenom.Text = String.Empty;
            txtMelPart1.Text = String.Empty;
            txtMelPart2.Text = String.Empty;
            txtMelPart3.Text = String.Empty;
            txtCodePostal.Text = String.Empty;
            txtAdresse.Text = String.Empty;
            txtVille.Text = String.Empty;
            pnlCourrierOui.Visible = false;
            txtTarif.Text = String.Empty;
        }
        ///<summary>
        ///S'efectue lorsque le bouton OUI change d'état
        ///</summary>
        private void rdbOui_CheckedChanged(object sender, EventArgs e)
        {
            ///<summary>
            ///Test si le bouton est coché et fait donc appraître les panels en conséquence
            ///</summary>
            if (rdbOui.Checked == true)

                pnlCourrierOui.Visible = true;
            pnlCourrierNon.Visible = false;


        }
        ///<summary>
        ///S'effectue lorsque le bouton NON change d'état
        ///</summary>
        private void rdbNon_CheckedChanged(object sender, EventArgs e)
        {

            ///<summary>
            ///Test si le bouton est coché et fait donc appraître les panels en conséquence
            ///</summary>
            if (rdbNon.Checked == true)

                pnlCourrierNon.Visible = true;
            pnlCourrierOui.Visible = false;

        }
        double prix;
        ///<summary>
        ///S'execute lorsque le bouton lettre change d'état
        ///</summary>
        private void rdbLettre_CheckedChanged(object sender, EventArgs e)
        {

            ///<summary>
            ///le try catch gère l'exeption lorsque le poids dépasse les 3kg
            ///</summary>
            ///<value>poids supérieur à 3000grammes</value>
            try

            {
                if (int.Parse(txtPoids.Text) <= 3000)
                {
                    double prix = prixLettre(int.Parse(txtPoids.Text));
                    txtTarif.Text = prix.ToString();
                }
                else
                {
                    prix = prixLettre(int.Parse(txtPoids.Text));
                    txtTarif.Text = "";
                    txtPoids.Text = "";
                }
            }
            catch
            {
                if (txtPoids.Text == "")
                    txtPoids.Focus();
            }


        }
        ///<summary>
        ///Fonction qui calcul le tarif pour une lettre en fonction du poids
        ///</summary>
        ///<value>Poids compris entre 1 et 3000 grammes inclus</value>
        ///<param name="poids">Poids de la lettre</param>
        ///<returns>Renvoie le tarif d'une lettre</returns>
        ///<exception cref="txtPoids.Text=String.Empty"></exception>
        public static double prixLettre(int poids)
        {
            double tarif = 0;
            {
                if (poids < 20)
                {
                    tarif = 1.28;


                }
                else
                {
                    if (poids < 100)
                    {
                        tarif = 2.56;

                    }
                    else
                    {
                        if (poids < 250)
                        {
                            tarif = 4.71;

                        }
                        else
                        {
                            if (poids < 500)
                            {
                                tarif = 7.06;

                            }
                            else
                            {
                                if (poids <= 3000)
                                {
                                    tarif = 10.24;

                                }
                                else
                                {
                                    if (poids > 3000)
                                    {
                                        MessageBox.Show("Poids trop élevé, Veuillez recommencer");

                                    }
                                }

                            }
                        }
                    }
                }
            }


            return tarif;
        }
        ///<summary>
        ///Fonction qui calcul le tarif a payé en fonction du poids
        ///</summary>
        ///<value>Poids compris entre 1 et 250 grammes inclus</value>
        ///<param name="poids">Poids de l'écopli</param>
        ///<returns>Renvoie le tarif de ecopli</returns>
        ///<exception cref="txtPoids.Text=String.Empty"></exception>
        public static double prixEcopli(int poids)
        {

            double tarif = 0;
            if (poids < 20)
            {
                tarif = 1.06;


            }
            else
            {
                if (poids < 100)
                {
                    tarif = 2.12;

                }
                else
                {
                    if (poids <= 250)
                    {
                        tarif = 3.86;

                    }
                    else
                    {
                        if(poids > 250)
                        {
                            MessageBox.Show("Poids trop élevé !");
                            
                        }
                    }


                    
                }
            }
            return tarif;
        }
        ///<summary>
        ///Calcul le tarif à payer pour un lettre recommandé avec l'option R1
        ///</summary>
        ///<value>Poids compris entre 1e et 3000grammes inclus</value>
        ///<param name="poids">Poids du recommande</param>
        ///<param name="Checked">Défini si recommande est checké ou pas</param>
        ///<param name="R1">Défini si R1 est checké ou pas</param>
        ///<returns>Renvoie le tarif de recommande pour R1</returns>
        ///<exception cref="txtPoids.Text=String.Empty"></exception>
        public static double prixRecommandeR1(bool Checked, bool R1,int poids)
        {

            double tarif1 = 0;

            if (Checked == true && R1 == true)
                tarif1 = prixLettre(poids) + 3.12;
            return tarif1;

        }
        ///<summary>
        ///Calcul le tarif à payer pour un lettre recommandé avec l'option R1
        ///</summary>
        ///<value>Poids compris entre 1e et 3000grammes inclus</value>
        ///<param name="poids">Poids du recommande</param>
        ///<param name="Checked">Défini si recommande est checké ou pas</param>
        ///<param name="R1">Défini si R2 est checké ou pas</param>
        ///<returns>Renvoie le tarif de recommande pour R2</returns>
        ///<exception cref="txtPoids.Text=String.Empty"></exception>
        public static double prixRecommandeR2(bool Checked, bool R2,int poids)
        {

            double tarif = 0;
            if (Checked == true && R2 == true)
                tarif = prixLettre(poids) + 3.92;
            return tarif;


        }
        ///<summary>
        ///Calcul le tarif à payer pour un lettre recommandé avec l'option R1
        ///</summary>
        ///<value>Poids compris entre 1e et 3000grammes inclus</value>
        ///<param name="poids">Poids du recommande</param>
        ///<param name="Checked">Défini si recommande est checké ou pas</param>
        ///<param name="R1">Défini si R3 est checké ou pas</param>
        ///<returns>Renvoie le tarif de recommande pour R3</returns>
        ///<exception cref="txtPoids.Text=String.Empty"></exception>
        public static double prixRecommandeR3(bool Checked, bool R3,int poids)
        {

            double tarif = 0;
            if (Checked == true && R3 == true)
                tarif = prixLettre(poids) + 5.12;
            return tarif;
        }

        ///<summary>
        ///S'effectue lorsque la zone de saisie du textbox change
        ///</summary>
        private void TxtPoids_TextChanged(object sender, EventArgs e)
        {

            ///<summary>
            ///Test si le bouton lettre est coché et appele la fonction lettre en conséquence
            ///</summary>
            if (rdbLettre.Checked == true)

            {                ///<summary>
                             ///Try catch qui gère l'exeption en cas de poids trop élevé
                             ///</summary>
                             ///<value>poids compris entre 1 et 3000 grammes inclus </value>
                try

                {

                    if (int.Parse(txtPoids.Text) <= 3000)
                    {
                        double prix = prixLettre(int.Parse(txtPoids.Text));
                        txtTarif.Text = prix.ToString();
                    }
                    else
                    {
                        prix = prixLettre(int.Parse(txtPoids.Text));
                        txtTarif.Text = "";
                        txtPoids.Text = "";
                    }
                }
                catch
                {
                    if (txtPoids.Text == "")
                        txtPoids.Focus();
                }
            }
            else
            {
                ///<summary>
                ///Test si le bouton ecopli est coché et appele la fonction lettre en conséquence
                ///</summary>
                if (rdbEcopli.Checked == true)

                {
                    ///<summary>
                    ///Try catch qui gère l'exeption en cas de poids trop élevé
                    ///</summary>
                    ///<value>poids compris entre 1 et 250 grammes inclus </value>
                    try

                    {
                        if (int.Parse(txtPoids.Text) <= 250)
                        {
                            double prix = prixEcopli(int.Parse(txtPoids.Text));
                            txtTarif.Text = prix.ToString();
                        }
                        else
                        {
                            prix = prixEcopli(int.Parse(txtPoids.Text));
                            txtPoids.Text = "";
                            txtTarif.Text = "";
                        }
                    }
                    catch
                    {
                        if (txtPoids.Text == "")
                            txtPoids.Focus();
                    }
                }
                else
                {
                    ///<summary>
                    ///Test si le bouton recommande et R1 sont cochés et appele la fonction lettre en conséquence
                    ///</summary>
                    ///<value>poids compris entre 1 et 3000 grammes inclus </value>
                    if (rdbRecommande.Checked == true && rdbR1.Checked == true)

                    {
                        try
                        {
                            if (int.Parse(txtPoids.Text) <= 3000)
                            {
                                double prix = prixRecommandeR1(rdbRecommande.Checked, rdbR1.Checked, int.Parse(txtPoids.Text));
                                txtTarif.Text = prix.ToString();
                            }
                            else
                            {
                                prix = prixRecommandeR1(rdbRecommande.Checked, rdbR1.Checked, int.Parse(txtPoids.Text));
                                txtTarif.Text = "";
                                txtPoids.Text = "";
                            }
                            
                            
                        }
                        catch
                        {
                            if (txtPoids.Text == "")
                                txtPoids.Focus();
                        }
                    }
                    else
                    {
                        ///<summary>
                        ///Test si le bouton recommande et R2 sont cochés et appele la fonction lettre en conséquence
                        ///</summary>
                        ///<value>poids compris entre 1 et 3000 grammes inclus </value>
                        if (rdbRecommande.Checked == true && rdbR2.Checked == true)

                        {
                            try
                            {
                                if (int.Parse(txtPoids.Text) <= 3000)
                                {
                                    double prix = prixRecommandeR2(rdbRecommande.Checked, rdbR2.Checked, int.Parse(txtPoids.Text));
                                    txtTarif.Text = prix.ToString();
                                }
                                else
                                {
                                    prix = prixRecommandeR2(rdbRecommande.Checked, rdbR2.Checked, int.Parse(txtPoids.Text));
                                    txtTarif.Text = "";
                                    txtPoids.Text = "";
                                }
                            }
                            catch
                            {
                                if (txtPoids.Text == "")
                                    txtPoids.Focus();
                            }
                        }
                        else
                        {
                            ///<summary>
                            ///Test si le bouton recommande et R2 sont cochés et appele la fonction lettre en conséquence
                            ///</summary>
                            ///<value>poids compris entre 1 et 3000 grammes inclus </value>
                            if (rdbRecommande.Checked == true && rdbR3.Checked == true)

                            {
                                try
                                {
                                    if (int.Parse(txtPoids.Text) <= 3000)
                                    {
                                        double prix = prixRecommandeR3(rdbRecommande.Checked, rdbR3.Checked, int.Parse(txtPoids.Text));
                                        txtTarif.Text = prix.ToString();
                                    }
                                    else
                                    {
                                        prix = prixRecommandeR3(rdbRecommande.Checked, rdbR3.Checked, int.Parse(txtPoids.Text));
                                        txtTarif.Text = "";
                                        txtPoids.Text = "";
                                    }
                                }
                                catch
                                {
                                    if (txtPoids.Text == "")
                                        txtPoids.Focus();
                                }

                            }
                        }
                    }
                }
            }
        }
        ///<summary>
        ///S'effectue lorsque le bouton ecopli change d'état et permet d'actualiser le prix
        ///</summary>
        ///<value>poids compris entre 1 et 250 grammes inclus</value>
        private void RdbEcopli_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                if (int.Parse(txtPoids.Text) <= 250)
                {
                    double prix = prixEcopli(int.Parse(txtPoids.Text));
                    txtTarif.Text = prix.ToString();
                }
                else
                {
                    prix = prixEcopli(int.Parse(txtPoids.Text));
                    txtPoids.Text = "";
                    txtTarif.Text = "";
                }
            }
            catch
            {
                if (txtPoids.Text == "")
                    txtPoids.Focus();

            }
        }

        ///<summary>
        ///S'effectue lorsque le bouton R1 change d'état et permet d'actualiser le prix
        ///</summary>
        ///<value>poids compris entre 1 et 3000 grammes inclus</value>
        private void rdbR1_CheckedChanged(object sender, EventArgs e)
        {
  
            if (rdbRecommande.Checked == true && rdbR1.Checked == true)
            {
                try
                {
                    if (int.Parse(txtPoids.Text) <= 3000)
                    {
                        double prix = prixRecommandeR1(rdbRecommande.Checked, rdbR1.Checked, int.Parse(txtPoids.Text));
                        txtTarif.Text = prix.ToString();
                    }
                    else
                    {
                        prix = prixRecommandeR1(rdbRecommande.Checked, rdbR1.Checked, int.Parse(txtPoids.Text));
                        txtTarif.Text = "";
                        txtPoids.Text = "";
                    }
                }
                catch
                {
                    if (txtPoids.Text == "")
                        txtPoids.Focus();
                }
            }
        }
        ///<summary>
        ///S'effectue lorsque le bouton R2 change d'état et permet d'actualiser le prix
        ///</summary>
        ///<value>poids compris entre 1 et 3000 grammes inclus</value>
        private void rdbR2_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbRecommande.Checked == true && rdbR2.Checked == true)
            {
                try
                {
                    if (int.Parse(txtPoids.Text) <= 3000)
                    {
                        double prix = prixRecommandeR2(rdbRecommande.Checked, rdbR2.Checked, int.Parse(txtPoids.Text));
                        txtTarif.Text = prix.ToString();
                    }
                    else
                    {
                        prix = prixRecommandeR2(rdbRecommande.Checked, rdbR2.Checked, int.Parse(txtPoids.Text));
                        txtTarif.Text = "";
                        txtPoids.Text = "";
                    }
                }
                catch
                {
                    if (txtPoids.Text == "")
                        txtPoids.Focus();
                }
            }
        }
        ///<summary>
        ///S'effectue lorsque le bouton R3 change d'état et permet d'actualiser le prix
        ///</summary>
        ///<value>poids compris entre 1 et 3000 grammes inclus</value>
        private void rdbR3_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbRecommande.Checked == true && rdbR3.Checked == true)
            {
                try
                {
                    if (int.Parse(txtPoids.Text) <= 3000)
                    {
                        double prix = prixRecommandeR3(rdbRecommande.Checked, rdbR3.Checked, int.Parse(txtPoids.Text));
                        txtTarif.Text = prix.ToString();
                    }
                    else
                    {
                        prix = prixRecommandeR3(rdbRecommande.Checked, rdbR3.Checked, int.Parse(txtPoids.Text));
                        txtTarif.Text = "";
                        txtPoids.Text = "";
                    }
                }
                catch
                {
                    if (txtPoids.Text == "")
                        txtPoids.Focus();
                }
            }
        }
        ///<summary>
        ///Permet d'effectuer un controle de saisie afin d'autoriser que les chiffres
        ///</summary>
        private void txtPoids_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Seul les chiffres sont acceptés");
            }
            
        }
        ///<summary>
        ///Ouvre une nouvelle fenêtre lorsque l'on clique sur le bouton valider
        ///</summary>
        private void btnValiderTarif_Click(object sender, EventArgs e)
        {

            frmAffichage frmLogo = new frmAffichage();
            Program.prix = txtTarif.Text;
            if (txtPoids.Text != "")

                frmLogo.ShowDialog();
            else
                MessageBox.Show("Veuillez remplir tous les champs !");
            
            
        }

    }
}
   

 

