using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_association
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }



        private void btnmembre_Click(object sender, EventArgs e)
        {
            // Créez une instance du formulaire souhaité
            Membre formulaire = new Membre();

            // Affichez le formulaire
            formulaire.Show();

            this.Close();

        }

        private void btnbureau_Click(object sender, EventArgs e)
        {
            // Créez une instance du formulaire souhaité
            Bureau formulaire = new Bureau();

            // Affichez le formulaire
            formulaire.Show();
        }

        private void btnfermer_Click(object sender, EventArgs e)
        {
            
            // Créez une instance du formulaire souhaité
            Connexion formulaire = new Connexion();

            // Affichez le formulaire
            formulaire.Show();

            // Fermer le formulaire actuel
            this.Close();


        }

        private void btnpromotion_Click(object sender, EventArgs e)
        {
            // Créez une instance du formulaire souhaité
            Promotions formulaire = new Promotions();

            // Affichez le formulaire
            formulaire.Show();
        }

        private void btnintervention_Click(object sender, EventArgs e)
        {
            // Créez une instance du formulaire souhaité
            Interventions formulaire = new Interventions();

            // Affichez le formulaire
            formulaire.Show();
        }

    }
}
