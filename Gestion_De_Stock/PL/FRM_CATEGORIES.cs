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
    public partial class FRM_CATEGORIES : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Server = .\SQLEXPRESS; Database = Gestion_DB; Integrated Security = true");
        SqlDataAdapter da;//hada howa li kayjdna les information li kayna fbase de donne (khadim)
        DataTable dt = new DataTable();
        BindingManagerBase bmb;
        SqlCommandBuilder cmdb;
        public FRM_CATEGORIES()
        {
            InitializeComponent();
            da = new SqlDataAdapter("select ID_Cat as 'ID', Catégorie as 'Catégories' from [Catégories]", sqlcon);
            da.Fill(dt);
            dgList.DataSource = dt;
            txtID.DataBindings.Add("text", dt, "ID");
            txtDes.DataBindings.Add("text", dt, "Catégories");
            bmb = this.BindingContext[dt];
            lblPosition.Text = (bmb.Position + 1) + "  /  " + bmb.Count;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            int id;
            if (dt.Rows.Count == 0)
            {
                bmb.AddNew();
                btnNew.Enabled = false;
                btnAdd.Enabled = true;
                id = 1;
                txtID.Text = id.ToString();

                txtDes.Focus();
            }
            else
            {
                bmb.AddNew();
                btnNew.Enabled = false;
                btnAdd.Enabled = true;
                id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0]) + 1;
                txtID.Text = id.ToString();
                txtDes.Focus();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Ajouté avec succès", "Ajouté", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            lblPosition.Text = (bmb.Position + 1) + "  /  " + bmb.Count;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Attention: Si vous supprimez cette catégorie, les produits appartenant à cette catégorie seront " +
                    "supprimés.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    bmb.RemoveAt(bmb.Position);
                    bmb.EndCurrentEdit();
                    cmdb = new SqlCommandBuilder(da);
                    da.Update(dt);
                    MessageBox.Show("Deleted successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblPosition.Text = (bmb.Position + 1) + "  /  " + bmb.Count;
                }
                else
                {
                    MessageBox.Show("La catégorie n'a pas été supprimé", "Processus de suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }catch
            {
                MessageBox.Show("La Liste Vide", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Modifié avec succès", "Modifié", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblPosition.Text = (bmb.Position + 1) + "  /  " + bmb.Count;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            lblPosition.Text = (bmb.Position + 1) + "  /  " + bmb.Count;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            lblPosition.Text = (bmb.Position + 1) + "  /  " + bmb.Count;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            lblPosition.Text = (bmb.Position + 1) + "  /  " + bmb.Count;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            lblPosition.Text = (bmb.Position + 1) + "  /  " + bmb.Count;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrinAll_Click(object sender, EventArgs e)
        {
            RPT.rpt_all_categories rpt = new RPT.rpt_all_categories();
            RPT.FRM_RPT_PRO frm = new RPT.FRM_RPT_PRO();
            rpt.Refresh();
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }

        private void btnPrintCurrent_Click(object sender, EventArgs e)
        {
            RPT.rpt_single_category rpt = new RPT.rpt_single_category();
            RPT.FRM_RPT_PRO frm = new RPT.FRM_RPT_PRO();
            rpt.SetParameterValue("@id", Convert.ToInt32(txtID.Text));
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }

        private void exportToPdfAll_Click(object sender, EventArgs e)
        {
            RPT.rpt_all_categories myReport = new RPT.rpt_all_categories();

            //Create Export Options
            ExportOptions export = new ExportOptions();

            //Create Object For destination
            DiskFileDestinationOptions dfoptions = new DiskFileDestinationOptions();

            //Create Object For Excel Format
            PdfFormatOptions pdfformat = new PdfFormatOptions();

            //Set the path of destination
            dfoptions.DiskFileName = @"C:\Users\Mohamed L'HARRAK\Documents\New folder\catégorieAlllList.pdf";

            //Set Report Options to crystal export options
            export = myReport.ExportOptions;

            //Set Destination type
            export.ExportDestinationType = ExportDestinationType.DiskFile;

            //Set the type of document
            export.ExportFormatType = ExportFormatType.PortableDocFormat;

            //format the excel document
            export.ExportFormatOptions = pdfformat;

            //Set Destination option
            export.ExportDestinationOptions = dfoptions;

            myReport.Refresh();
            //Export the report
            myReport.Export();

            MessageBox.Show("Liste exportée avec succès!", "exportée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void ExportToPdfCurrent_Click(object sender, EventArgs e)
        {
            RPT.rpt_single_category myReport = new RPT.rpt_single_category();
            //creat export option
            ExportOptions export = new ExportOptions();
            //create object for destinaton
            DiskFileDestinationOptions dfoptions = new DiskFileDestinationOptions();
            PdfFormatOptions pdfFormat = new PdfFormatOptions();
            dfoptions.DiskFileName = @"C:\Users\Mohamed L'HARRAK\Documents\New folder\catégorieDetailList.pdf";
            export = myReport.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.PortableDocFormat;
            export.ExportFormatOptions = pdfFormat;
            export.ExportDestinationOptions = dfoptions;
            myReport.SetParameterValue("@id", Convert.ToInt32(txtID.Text));
            myReport.Export();
            MessageBox.Show("Liste exportée avec succès", "Exportée", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
