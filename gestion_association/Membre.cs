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
using gestion_association.CRUD_Membre;
using MySql.Data.MySqlClient;


namespace gestion_association
{
    public partial class Membre : Form
    {
        public Membre()
        {
            InitializeComponent();
        }



        private void Membre_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gESTION_ASSOCIATIONDataSet.ETUDIANT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.eTUDIANTTableAdapter.Fill(this.gESTION_ASSOCIATIONDataSet.ETUDIANT);
            string connectionString = "Data Source = LAPTOP-KDSQMFSH;Initial Catalog=GESTION_ASSOCIATION;Integrated Security = true";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "Select * from ETUDIANT";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            
        }


        private void btnretourmembre_Click(object sender, EventArgs e)
        {
            // Fermer le formulaire actuel
            this.Close();
        }

        private void dataMembre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnajouteretudiant_Click(object sender, EventArgs e)
        {
            // Créez une instance du formulaire souhaité
            AjouterEtudiant formulaire = new AjouterEtudiant();

            // Affichez le formulaire
            formulaire.Show();
            
            this.Close();
        }

       

        private void btnmodifieretudiant_Click(object sender, EventArgs e)
        {
            // Créez une instance du formulaire souhaité
            ModifierEtudiant formulaire = new ModifierEtudiant();

            // Affichez le formulaire
            formulaire.Show();

            this.Close();
        }

        private void btnsuppetudiant_Click(object sender, EventArgs e)
        {
            // Créez une instance du formulaire souhaité
            SupprimerMembre formulaire = new SupprimerMembre();

            // Affichez le formulaire
            formulaire.Show();

            this.Close();
        }
    }

} 

