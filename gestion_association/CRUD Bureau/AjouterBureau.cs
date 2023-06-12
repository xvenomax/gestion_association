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

namespace gestion_association.CRUD_Bureau
{
    public partial class AjouterBureau : Form
    {
        public AjouterBureau()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source = LAPTOP-KDSQMFSH;Initial Catalog=GESTION_ASSOCIATION;Integrated Security = true";
        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void RetourModifier_Click(object sender, EventArgs e)
        {
            Bureau formulaire = new Bureau();

            // Affichez le formulaire
            formulaire.Show();

            this.Close();
        }

        private void btnAjouterEtudiant_Click(object sender, EventArgs e)
        {
            // Récupérer les données des TextBox
            string idTresorier = txtIDTresorier.Text;
            string idSecretaire = txtIDSecretaire.Text;
            string idPresident = txtIDPresident.Text;
            DateTime anneeBureau = dtpBureau.Value;
            


            // Requête INSERT INTO
            string insertQuery = "INSERT INTO BUREAU (IDETUDIANT, IDETUDIANT_ETRE_SECRETAIRE, IDETUDIANT_ETRE_PRESIDENT, ANNEEBUREAU) VALUES (@IDETUDIANT, @IDETUDIANT_ETRE_SECRETAIRE, @IDETUDIANT_ETRE_PRESIDENT, @ANNEEBUREAU)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(insertQuery, connection);

                // Ajouter les paramètres avec les valeurs des TextBox
                command.Parameters.AddWithValue("@IDETUDIANT", idTresorier);
                command.Parameters.AddWithValue("@IDETUDIANT_ETRE_SECRETAIRE", idSecretaire);
                command.Parameters.AddWithValue("@IDETUDIANT_ETRE_PRESIDENT", idPresident);
                command.Parameters.AddWithValue("@ANNEEBUREAU", anneeBureau);
                

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Le bureau a bien été ajouté");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'insertion : " + ex.Message);
                }

            }

            // Créez une instance du formulaire souhaité
            Bureau formulaire = new Bureau();

            // Affichez le formulaire
            formulaire.Show();

            this.Close();

        }
    }
}
