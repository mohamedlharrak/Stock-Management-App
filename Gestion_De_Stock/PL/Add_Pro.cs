using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Gestion_De_Stock.PL
{
    public partial class Add_Pro : Form
    {
        public string State = "Add";
        BL.CLS_PRODUCT prd = new BL.CLS_PRODUCT();//Objecti jdid Bax n3aro combobox 
        BL.CLS_PRODUCT fnr = new BL.CLS_PRODUCT();//Objecti jdid Bax n3aro combobox 
        public Add_Pro()//hada constractou bax mli nfetho form iban had xi flowel
        {
            InitializeComponent();
            cmbcat.DataSource = prd.GET_ALL_CAT();//combobox dyal catégorie kaystab9bel bayant mn dala GET..
            cmbcat.DisplayMember = "Catégorie";//hada li ghadi iban f cmbbox
            cmbcat.ValueMember = "ID_Cat";
            cmbfour.DataSource = fnr.GET_ALL_FOURNISSEUR(); //combobox dyal Fournisseur kaystab9bel bayant mn dala GET..
            cmbfour.DisplayMember = "Nom_de_fournisseurs";//hada li ghadi iban f cmbbox
            cmbfour.ValueMember = "ID_fournisseurs";
            pbox.Image = Image.FromFile(@"C:\Users\Mohamed L'HARRAK\Documents\New folder\Pas_d'Image.gif");//image
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Fichiers d'image | *.JPG; *.PNG; *.GIF; *.BMP";
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                pbox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            

            
            if(State=="Add")
            {
                if(txtCode.Text.Length>0)
                {
                    MemoryStream ms = new MemoryStream();
                    pbox.Image.Save(ms, pbox.Image.RawFormat);
                    byte[] byteImage = ms.ToArray();
                    prd.ADD_PRODUCT(txtCode.Text, txtName.Text, Convert.ToInt32(cmbcat.SelectedValue),
                        Convert.ToInt32(cmbfour.SelectedValue), dt.Value, txtPrix.Text, txtQte.Text,
                        txtemp.Text, txtDes.Text, byteImage);
                    MessageBox.Show("Produit ajouté avec succès", "Ajouter un produit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                else
                {
                    MessageBox.Show("SVP entrée le code barre","Attantion",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                
              
                
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                pbox.Image.Save(ms, pbox.Image.RawFormat);
                byte[] byteImage = ms.ToArray();
                prd.UPDATE_PRODUCTE(txtCode.Text, txtName.Text, Convert.ToInt32(cmbcat.SelectedValue),
                    Convert.ToInt32(cmbfour.SelectedValue), dt.Value, txtPrix.Text, txtQte.Text,
                    txtemp.Text, txtDes.Text, byteImage);
                MessageBox.Show("Produit Modifier avec succès", "Modifier un produit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            FRM_GESTION_PRODUCT.getMainForm.dataGridView1.DataSource = prd.GET_ALL_PRODUCT();
           

        }

        private void txtCode_Validated(object sender, EventArgs e)
        {
            if (State=="Add")
            {
                DataTable dt = new DataTable();
                dt = prd.VerifyCodeBarre(txtCode.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Ce Code Barre existe déjà", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCode.Focus();
                    txtCode.SelectionStart = 0;
                    txtCode.SelectionLength = txtCode.TextLength;
                }
                
            }
           
        }
        public void clear()
        {
            txtCode.Clear();
            txtName.Clear();
            txtPrix.Clear();
            txtQte.Clear();
            txtemp.Clear();
            cmbfour.ResetText();
            cmbcat.ResetText();
            dt.ResetText();
            pbox.Image = Image.FromFile(@"C:\Users\Mohamed L'HARRAK\Documents\New folder\Pas_d'Image.gif");


            txtDes.Clear();
       
        }

        private void cmbfour_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pbox_Click(object sender, EventArgs e)
        {
            
        }

        private void Add_Pro_Load(object sender, EventArgs e)
        {

        }
    }
}
