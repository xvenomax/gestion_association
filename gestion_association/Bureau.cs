using gestion_association.CRUD_Bureau;
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
    public partial class Bureau : Form
    {
        public Bureau()
        {
            InitializeComponent();
        }

        private void btnretourbureau_Click(object sender, EventArgs e)
        {
            // Fermer le formulaire actuel
            this.Close();
        }

        private void btnajoutermembre_Click(object sender, EventArgs e)
        {
            // Créez une instance du formulaire souhaité
            AjouterBureau formulaire = new AjouterBureau();

            // Affichez le formulaire
            formulaire.Show();

            this.Close();
        }

        private void btnmodifiermembre_Click(object sender, EventArgs e)
        {
            // Créez une instance du formulaire souhaité
            ModifierBureau formulaire = new ModifierBureau();

            // Affichez le formulaire
            formulaire.Show();

            this.Close();
        }

        private void btnsuppmembre_Click(object sender, EventArgs e)
        {
            // Créez une instance du formulaire souhaité
            SupprimerBureau formulaire = new SupprimerBureau();

            // Affichez le formulaire
            formulaire.Show();

            this.Close();
        }

        private void Bureau_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gESTION_ASSOCIATIONDataSet2.BUREAU'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.bUREAUTableAdapter1.Fill(this.gESTION_ASSOCIATIONDataSet2.BUREAU);

        }
    }
}
