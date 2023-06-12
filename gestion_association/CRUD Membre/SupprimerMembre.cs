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

namespace gestion_association.CRUD_Membre
{
    public partial class SupprimerMembre : Form
    {
        public SupprimerMembre()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source = LAPTOP-KDSQMFSH;Initial Catalog=GESTION_ASSOCIATION;Integrated Security = true";

        private void btnSupprimerMembre_Click(object sender, EventArgs e)
        {
            string nomSupp = txtNomSupp.Text;

            string deleteQuery = "DELETE ETUDIANT WHERE NOM = @NOMSUPP";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(deleteQuery, connection);

                // Ajouter les paramètres avec les valeurs des TextBox
                command.Parameters.AddWithValue("@NOMSupp", nomSupp);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Le membre " + nomSupp + " a bien été supprimé");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de lla suppression : " + ex.Message);
                }

            }

            // Créez une instance du formulaire souhaité
            Membre formulaire = new Membre();

            // Affichez le formulaire
            formulaire.Show();

            this.Close();
        }

        private void RetourModifier_Click(object sender, EventArgs e)
        {
            Membre formulaire = new Membre();

            // Affichez le formulaire
            formulaire.Show();

            this.Close();
        }

        private void RetourModifier_Click_1(object sender, EventArgs e)
        {
            Membre formulaire = new Membre();

            // Affichez le formulaire
            formulaire.Show();

            this.Close();
        }
    }
}
