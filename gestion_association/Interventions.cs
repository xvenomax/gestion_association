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
    public partial class Interventions : Form
    {
        public Interventions()
        {
            InitializeComponent();
        }

        private void btnretourinterventions_Click(object sender, EventArgs e)
        {
            // Fermer le formulaire actuel
            this.Close();
        }
    }
}
