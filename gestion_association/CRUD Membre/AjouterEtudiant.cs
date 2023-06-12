using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_association
{
    public partial class AjouterEtudiant : Form
    {
        public AjouterEtudiant()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source = LAPTOP-KDSQMFSH;Initial Catalog=GESTION_ASSOCIATION;Integrated Security = true";

        private void AjouterEtudiant_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouterEtudiant_Click(object sender, EventArgs e)
        {
            // Récupérer les données des TextBox
            string ideEtudiant = txtIDEtudiant.Text;
            string idFormation = txtIDFormation.Text;
            string idIntervention = txtIDIntervention.Text;
            string idRencontre = txtIDRencontre.Text;
            string idSecteurActivite = txtIDSecteurActivite.Text;
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            string telephone = txtTelephone.Text;
            DateTime dateNaissance = dtpDateNaissance.Value;
            string lyceeOrigine = txtLyceeOrigine.Text;
            string baccalaureat = txtBaccalaureat.Text;
            string specialiteBac = txtSpecialiteBac.Text;
            DateTime anneeObtentionBac = dtpAnneeBac.Value;
            DateTime dateEntreeBTS = dtpDateEntreeBTS.Value;
            DateTime dateSortieBTS = dtpDateSortieBTS.Value;
            string specialiteBTS = txtSpecialiteBTS.Text;
            DateTime dateObtentionDiplome = dtpDateObtentionDiplome.Value;
            DateTime dateEntreeMondeProfessionnel = dtpDateEntreeMondeProfessionnel.Value;


            // Requête INSERT INTO
            string insertQuery = "INSERT INTO ETUDIANT (IDETUDIANT, IDFORMATION, IDINTERVENTION, IDRENCONTRE, IDSECTEURACTIVITE, NOM, PRENOM, TELEPHONE, DATENAISSANCE, LYCEEORIGINE, BACCALAUREAT, SPECIALITEBAC, ANNEEOBTENTIONBAC, DATEENTREEBTS, DATESORTIEBTS, SPECIALITEBTS, DATEOBTENTIONDIPLOME, DATEENTREEMONDEPROFESSIONNEL) VALUES (@IDETUDIANT, @IDFORMATION, @IDINTERVENTION, @IDRENCONTRE, @IDSECTEURACTIVITE, @NOM, @PRENOM, @TELEPHONE, @DATENAISSANCE, @LYCEEORIGINE, @BACCALAUREAT, @SPECIALITEBAC, @ANNEEOBTENTIONBAC, @DATEENTREEBTS, @DATESORTIEBTS, @SPECIALITEBTS, @DATEOBTENTIONDIPLOME, @DATEENTREEMONDEPROFESSIONNEL)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(insertQuery, connection);

                // Ajouter les paramètres avec les valeurs des TextBox
                command.Parameters.AddWithValue("@IDETUDIANT", ideEtudiant);
                command.Parameters.AddWithValue("@IDFORMATION", idFormation);
                command.Parameters.AddWithValue("@IDINTERVENTION", idIntervention);
                command.Parameters.AddWithValue("@IDRENCONTRE", idRencontre);
                command.Parameters.AddWithValue("@IDSECTEURACTIVITE", idSecteurActivite);
                command.Parameters.AddWithValue("@NOM", nom);
                command.Parameters.AddWithValue("@PRENOM", prenom);
                command.Parameters.AddWithValue("@TELEPHONE", telephone);
                command.Parameters.AddWithValue("@DATENAISSANCE", dateNaissance);
                command.Parameters.AddWithValue("@LYCEEORIGINE", lyceeOrigine);
                command.Parameters.AddWithValue("@BACCALAUREAT", baccalaureat);
                command.Parameters.AddWithValue("@SPECIALITEBAC", specialiteBac);
                command.Parameters.AddWithValue("@ANNEEOBTENTIONBAC", anneeObtentionBac);
                command.Parameters.AddWithValue("@DATEENTREEBTS", dateEntreeBTS);
                command.Parameters.AddWithValue("@DATESORTIEBTS", dateSortieBTS);
                command.Parameters.AddWithValue("@SPECIALITEBTS", specialiteBTS);
                command.Parameters.AddWithValue("@DATEOBTENTIONDIPLOME", dateObtentionDiplome);
                command.Parameters.AddWithValue("@DATEENTREEMONDEPROFESSIONNEL", dateEntreeMondeProfessionnel);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Le membre " + nom + " a bien été ajouté");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'insertion : " + ex.Message);
                }

            }

            // Créez une instance du formulaire souhaité
            Membre formulaire = new Membre();

            // Affichez le formulaire
            formulaire.Show();

            this.Close();


        }

        private void txtIDEtudiant_TextChanged(object sender, EventArgs e)
        {

        }

        private void RetourModifier_Click(object sender, EventArgs e)
        {
            Membre formulaire = new Membre();

            // Affichez le formulaire
            formulaire.Show();

            this.Close();
        }
    }
}
