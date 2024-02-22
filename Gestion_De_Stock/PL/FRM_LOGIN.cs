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
    public partial class FRM_LOGIN : Form
    {
        BL.CLS_LOGIN log = new BL.CLS_LOGIN();
        public FRM_LOGIN()
        {
            InitializeComponent();

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FRM_LOGIN1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "Nom d'utilisateur")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtPWD_Enter(object sender, EventArgs e)
        {
            if (txtPWD.Text == "Mot de Passe")
            {
                txtPWD.Text = "";
                txtPWD.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                txtID.Text = "Nom d'utilisateur";
                txtID.ForeColor = Color.Silver;
            }
        }

        private void txtPWD_Leave(object sender, EventArgs e)
        {
            if (txtPWD.Text == "")
            {
                txtPWD.Text = "Mot de Passe";
                txtPWD.ForeColor = Color.Silver;
            }
        }

        private void txtPWD_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = log.LOGIN(txtID.Text, txtPWD.Text);
            if (dt.Rows.Count > 0)
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
                MessageBox.Show("Nom d'utilisateur ou mot de passe invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
