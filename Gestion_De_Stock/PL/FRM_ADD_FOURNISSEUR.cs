using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.EMFServerMessageFactory;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports;
namespace Gestion_De_Stock.PL
{
    public partial class FRM_ADD_FOURNISSEUR : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Server = .\SQLEXPRESS; Database = Gestion_DB; Integrated Security = true");
        SqlDataAdapter da;//hada howa li kayjdna les information li kayna fbase de donne (khadim)
        DataTable dt = new DataTable();
        BindingManagerBase bmb;
        SqlCommandBuilder cmdb;
        public FRM_ADD_FOURNISSEUR()
        {
            InitializeComponent();
            //da mxa jab lina lho9ol mn table
            da = new SqlDataAdapter("select ID_fournisseurs as 'ID', Nom_de_fournisseurs as 'Fournisseurs'," +
                " Personne_a_contacter as  'Personne a contacter', Prénom_de_la_personne as 'Prénom de la personne'," +
                " Adresse as Adresse,Téléphone as Téléphone from Fournisseurs", sqlcon);
            da.Fill(dt);//dik xi li jab da 3mlnah f dt
            dgListe.DataSource = dt;
            txtID.DataBindings.Add("text", dt, "ID");
            txtNomFour.DataBindings.Add("text", dt, "Fournisseurs");
            txtPC.DataBindings.Add("text", dt, "Personne a contacter");
            txtPP.DataBindings.Add("text", dt, "Prénom de la personne");
            txtA.DataBindings.Add("text", dt, "Adresse");
            txtT.DataBindings.Add("text", dt, "Téléphone");
            bmb = this.BindingContext[dt];
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FRM_ADD_FOURNISSEUR_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Ajouté avec succès", "Ajouté", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnAdd.Enabled =false;
            btnNew.Enabled =true;
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(bmb.Position +1==bmb.Count)
            {
                bmb.Position = 0;
                lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
            }
            else
            {
                bmb.Position += 1;
                lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
            }
           
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            int ID;
            if (dt.Rows.Count==0)
            {
                bmb.AddNew();
                btnNew.Enabled = false;
                btnAdd.Enabled = true;
                ID = 1;
                txtID.Text = ID.ToString();

                txtNomFour.Focus();
            }
            else
            {
                bmb.AddNew();
                btnNew.Enabled = false;
                btnAdd.Enabled = true;
                ID = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0]) + 1;
                txtID.Text = ID.ToString();
                txtNomFour.Focus();
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Attention: Si vous supprimez cette fournisseur, les produits appartenant à cette fournisseur seront " +
                    "supprimés.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    bmb.RemoveAt(bmb.Position);
                    bmb.EndCurrentEdit();
                    cmdb = new SqlCommandBuilder(da);
                    da.Update(dt);
                    MessageBox.Show("");
                    lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
                }
                else
                {
                    MessageBox.Show("Le fournisseur n'a pas été supprimé", "Processus de suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }catch
            {
                MessageBox.Show("La liste est vide","vide",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Modifié avec succès", "Modifié", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lblPosition.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            RPT.RPT_ALL_FOURNISSEUR rpt = new RPT.RPT_ALL_FOURNISSEUR();
            RPT.FRM_RPT_PRO frm = new RPT.FRM_RPT_PRO();
            rpt.Refresh();
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }

        private void btnPrintSingel_Click(object sender, EventArgs e)
        {
            RPT.RPT_SINGLE_FOURNISSEUR rpt = new RPT.RPT_SINGLE_FOURNISSEUR();
            RPT.FRM_RPT_PRO frm = new RPT.FRM_RPT_PRO();
            rpt.SetParameterValue("@ID",Convert.ToInt32(txtID.Text));
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }

        private void exportToPdfAll_Click(object sender, EventArgs e)
        {
            RPT.RPT_ALL_FOURNISSEUR myReport = new RPT.RPT_ALL_FOURNISSEUR();
            //creat export option
            ExportOptions export = new ExportOptions();
            //create object for destinaton
            DiskFileDestinationOptions dfoptions = new DiskFileDestinationOptions();
            PdfFormatOptions pdfFormat = new PdfFormatOptions();
            dfoptions.DiskFileName = @"C:\Users\Mohamed L'HARRAK\Documents\New folder\fournisseurList.pdf";
            export = myReport.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.PortableDocFormat;
            export.ExportFormatOptions = pdfFormat;
            export.ExportDestinationOptions = dfoptions;
            myReport.Refresh();
            myReport.Export();
            MessageBox.Show("Liste exportée avec succès", "Exportée", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void eportToPdfSingle_Click(object sender, EventArgs e)
        {
            RPT.RPT_SINGLE_FOURNISSEUR myReport = new RPT.RPT_SINGLE_FOURNISSEUR();
            //creat export option
            ExportOptions export = new ExportOptions();
            //create object for destinaton
            DiskFileDestinationOptions dfoptions = new DiskFileDestinationOptions();
            PdfFormatOptions pdfFormat = new PdfFormatOptions();
            dfoptions.DiskFileName = @"C:\Users\Mohamed L'HARRAK\Documents\New folder\fournisseurDetailList.pdf";
            export = myReport.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.PortableDocFormat;
            export.ExportFormatOptions = pdfFormat;
            export.ExportDestinationOptions = dfoptions;
            myReport.SetParameterValue("@id", Convert.ToInt32(txtID.Text));
            myReport.Export();
            MessageBox.Show("Liste exportée avec succès", "Exportée", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblPosition_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
