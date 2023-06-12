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
    public partial class ModifierBureau : Form
    {
        public ModifierBureau()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source = LAPTOP-KDSQMFSH;Initial Catalog=GESTION_ASSOCIATION;Integrated Security = true";
        private void RetourModifier_Click(object sender, EventArgs e)
        {
            Bureau formulaire = new Bureau();

            // Affichez le formulaire
            formulaire.Show();

            this.Close();
        }

        private void btnModifierBureau_Click(object sender, EventArgs e)
        {
            // Récupérer les données des TextBox
            string idTresorier = txtIDTresoriermodif.Text;
            string idSecretaire = txtIDSecretairemodif.Text;
            string idPresident = txtIDPresidentmodif.Text;
            DateTime anneeBureau = dtpBureaumodif.Value;
            string idBureauModif = txtidbureaumodif.Text;

            // Requête INSERT INTO
            string updateQuery = "UPDATE BUREAU SET " +
    "IDETUDIANT_ETRE_SECRETAIRE = @IDETUDIANT_ETRE_SECRETAIRE, " +
    "IDETUDIANT_ETRE_PRESIDENT = @IDETUDIANT_ETRE_PRESIDENT, " +
    "ANNEEBUREAU = @ANNEEBUREAU, " +
    "WHERE IDBUREAU = @IDBUREAUMODIF";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(updateQuery, connection);

                // Ajouter les paramètres avec les valeurs des TextBox
                command.Parameters.AddWithValue("@IDBUREAUMODIF", idBureauModif);
                command.Parameters.AddWithValue("@IDETUDIANT", idTresorier);
                command.Parameters.AddWithValue("@IDETUDIANT_ETRE_SECRETAIRE", idSecretaire);
                command.Parameters.AddWithValue("@IDETUDIANT_ETRE_PRESIDENT", idPresident);
                command.Parameters.AddWithValue("@ANNEEBUREAU", anneeBureau);
                


                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Le bureau a bien été modifié");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la modification : " + ex.Message);
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
