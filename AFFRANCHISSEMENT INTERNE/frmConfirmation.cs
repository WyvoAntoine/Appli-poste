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
    public partial class frmAffichage : Form
    {
        public frmAffichage()
        {
            InitializeComponent();
        }

        private void frmAffichage_Load(object sender, EventArgs e)
        {
            ///<summary>
            ///S'effectue au chargement la page
            ///</summary>
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblPrix.Text = Program.prix;
            timerFermeture.Start();



        }
        private void timerFermeture_Tick(object sender, EventArgs a)
        {
            ///<summary>
            ///Lance un timer qui se ferme au bout de 5 secondes
            /// </summary>
            this.Dispose();
        }
    }
}

