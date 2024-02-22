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
    public partial class FRM_main : Form
    {
        private static FRM_main frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FRM_main getMainForm
        {
            get
            {
                if(frm==null)
                {
                    frm = new FRM_main();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public FRM_main()
        {
            InitializeComponent();
            pnlParametre.Visible = false;
            panel1.Size = new Size(223, 537);
            if (frm == null)
            {
                frm = this;
            }
            this.produitsToolStripMenuItem.Enabled = false;
            this.catégoriesToolStripMenuItem.Enabled = false;
            this.fournisseurToolStripMenuItem.Enabled = false;
            this.utilisateursToolStripMenuItem.Enabled = false;
            this.créerUneSauvegardeToolStripMenuItem.Enabled = false;
            this.restaurerUneSauvegardeToolStripMenuItem.Enabled = false;
            this.déconnexionToolStripMenuItem.Enabled = false;
            this.panel1.Enabled = false;
            this.btnCréer.Enabled = false;
            this.btnRestaurer.Enabled = false;
            this.btnDconx.Enabled = false;

        }

        private void fournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void connexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_LOGIN frm = new FRM_LOGIN();
            frm.ShowDialog();
        }

        private void ajouterUnNouveauProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Pro frm = new Add_Pro();
            frm.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        private void FRM_main_Load(object sender, EventArgs e)
        {

        }   

        private void déconnexionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.produitsToolStripMenuItem.Enabled = false;
            this.catégoriesToolStripMenuItem.Enabled = false;
            this.fournisseurToolStripMenuItem.Enabled = false;
            this.utilisateursToolStripMenuItem.Enabled = false;
            this.créerUneSauvegardeToolStripMenuItem.Enabled = false;
            this.restaurerUneSauvegardeToolStripMenuItem.Enabled = false;
            this.connexionToolStripMenuItem.Enabled = true;

            this.déconnexionToolStripMenuItem.Enabled = false;
            this.panel1.Enabled = false;
            this.btnCréer.Enabled = false;
            this.btnRestaurer.Enabled = false;
            this.btnDconx.Enabled = false;
            this.btnConx.Enabled = true;
        }

        private void modifierUneCatégorieToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionDeProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_GESTION_PRODUCT frm = new FRM_GESTION_PRODUCT();
            frm.ShowDialog();
        }

        private void FRM_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous vraiment quitter", "Attantion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void ajouterUnNouveauCatégoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ajouterUnNouveauCatégoriesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRM_ADD_FOURNISSEUR frm = new FRM_ADD_FOURNISSEUR();
            frm.ShowDialog();
        }

        private void gestionDeFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_FOURNISSEUR frm = new FRM_ADD_FOURNISSEUR();
            frm.ShowDialog();
        }

        private void gestionDeCatégorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CATEGORIES frm = new FRM_CATEGORIES();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(panel1.Width == 223)
            {
                panel1.Size = new Size(75, 537);
            }else
            {
                panel1.Size = new Size(223, 537);
            }
        }

        private void pnlBut_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnCatMenu_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnCatMenu.Top;
            FRM_CATEGORIES frm = new FRM_CATEGORIES();
            frm.ShowDialog();
        }

        private void btnFourMenu_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnFourMenu.Top;
            FRM_ADD_FOURNISSEUR frm = new FRM_ADD_FOURNISSEUR();
            frm.ShowDialog();
        }

        private void btnUserMenu_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnUserMenu.Top;
        }

        private void btnProduitMenu_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnProduitMenu.Top;
            FRM_GESTION_PRODUCT frm = new FRM_GESTION_PRODUCT();
            frm.ShowDialog(); pnlBut.Top = btnProduitMenu.Top;
        }

        private void btnParametre_Click(object sender, EventArgs e)
        {
            pnlParametre.Size = new Size(312, 175);
            pnlParametre.Visible = !pnlParametre.Visible;
        }

        private void btnConx_Click(object sender, EventArgs e)
        {
            FRM_LOGIN frm = new FRM_LOGIN();
            frm.ShowDialog();
        }

        private void btnDconx_Click(object sender, EventArgs e)
        {
            this.produitsToolStripMenuItem.Enabled = false;
            this.catégoriesToolStripMenuItem.Enabled = false;
            this.fournisseurToolStripMenuItem.Enabled = false;
            this.utilisateursToolStripMenuItem.Enabled = false;
            this.créerUneSauvegardeToolStripMenuItem.Enabled = false;
            this.restaurerUneSauvegardeToolStripMenuItem.Enabled = false;
            this.connexionToolStripMenuItem.Enabled = true;

            this.déconnexionToolStripMenuItem.Enabled = false;
            this.panel1.Enabled = false;
            this.btnCréer.Enabled = false;
            this.btnRestaurer.Enabled = false;
            this.btnDconx.Enabled = false;
            this.btnConx.Enabled = true;
        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnCréer_Click(object sender, EventArgs e)
        {
            FRM_BACKUP frm = new FRM_BACKUP();
            frm.ShowDialog();
        }

        private void créerUneSauvegardeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_BACKUP frm = new FRM_BACKUP();
            frm.ShowDialog();
        }
    }
}
