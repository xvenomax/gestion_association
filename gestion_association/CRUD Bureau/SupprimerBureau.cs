using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_association.CRUD_Bureau
{
    public partial class SupprimerBureau : Form
    {
        public SupprimerBureau()
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
    }
}
