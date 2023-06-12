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
    public partial class Promotions : Form
    {
        public Promotions()
        {
            InitializeComponent();
        }

        private void btnretourpromotions_Click(object sender, EventArgs e)
        {
            // Fermer le formulaire actuel
            this.Close();
        }
    }
}
