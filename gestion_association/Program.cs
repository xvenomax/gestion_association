using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gestion_association
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Connexion à la base de données
            string connectionString = "Data Source=LAPTOP-KDSQMFSH;Initial Catalog=GESTION_ASSOCIATION;User ID=;Password=";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                Console.WriteLine("Connexion réussie.");

                // Vous pouvez effectuer vos opérations sur la base de données ici

                connection.Close();
                Console.WriteLine("Connexion fermée.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur de connexion : " + ex.Message);
            }

            // Démarrage de l'application Windows Forms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Connexion());
        }
    }
}