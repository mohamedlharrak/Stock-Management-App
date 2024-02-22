using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_De_Stock.PL
{
    public partial class FRM_LOGIN2 : Form
    {
        BL.CLS_LOGIN log = new BL.CLS_LOGIN();//add new object from cls_login
        public FRM_LOGIN2()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            DataTable dt = log.LOGIN(txtID.Text, txtPWD.Text);
            if(dt.Rows.Count>0)
            {
                FRM_main.getMainForm.produitsToolStripMenuItem.Enabled = true;
                FRM_main.getMainForm.catégoriesToolStripMenuItem.Enabled = true;
                FRM_main.getMainForm.fournisseurToolStripMenuItem.Enabled = true;
                FRM_main.getMainForm.utilisateursToolStripMenuItem.Enabled = true;
                FRM_main.getMainForm.créerUneSauvegardeToolStripMenuItem.Enabled = true;
                FRM_main.getMainForm.restaurerUneSauvegardeToolStripMenuItem.Enabled = true;
                FRM_main.getMainForm.connexionToolStripMenuItem.Enabled = false;
                FRM_main.getMainForm.déconnexionToolStripMenuItem.Enabled = true;
                FRM_main.getMainForm.panel1.Enabled = true;
                FRM_main.getMainForm.btnCréer.Enabled = true;
                FRM_main.getMainForm.btnRestaurer.Enabled = true;
                FRM_main.getMainForm.btnDconx.Enabled = true;
                FRM_main.getMainForm.btnConx.Enabled = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe invalide", "Erreur", MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void txtPWD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPWD_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
