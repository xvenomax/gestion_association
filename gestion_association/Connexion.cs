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
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source = LAPTOP-KDSQMFSH;Initial Catalog=GESTION_ASSOCIATION;Integrated Security = true";

        private void btnconnexion_Click(object sender, EventArgs e)
        {
            string nomUtilisateur = txtNomUtilisateur.Text;
            string motDePasse = txtMotDePasse.Text;

            // Requête SQL pour vérifier les informations d'identification
            string query = "SELECT DroitAcces FROM UTILISATEUR WHERE NomUtilisateur = @NomUtilisateur AND MotDePasse = @MotDePasse";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NomUtilisateur", nomUtilisateur);
                command.Parameters.AddWithValue("@MotDePasse", motDePasse);

                connection.Open();
                object droitAcces = command.ExecuteScalar();
                connection.Close();

                if (droitAcces != null)
                {
                    // Créez une instance du formulaire souhaité
                    Accueil formulaire = new Accueil();

                    // Affichez le formulaire
                    formulaire.Show();

                    this.Visible = false;

                }
                else
                {
                    MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect ");
                }
            }
        }
    }
}
