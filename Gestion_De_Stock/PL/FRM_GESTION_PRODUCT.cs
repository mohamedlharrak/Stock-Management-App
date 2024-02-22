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
using CrystalDecisions.CrystalReports.EMFServerMessageFactory;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports;

namespace Gestion_De_Stock.PL
{
    public partial class FRM_GESTION_PRODUCT : Form
    {
        private static FRM_GESTION_PRODUCT frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FRM_GESTION_PRODUCT getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_GESTION_PRODUCT();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }

        BL.CLS_PRODUCT prd = new BL.CLS_PRODUCT();
        public FRM_GESTION_PRODUCT()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = prd.GET_ALL_PRODUCT();
            if (frm == null)
            {
                frm = this;
            }
        }

        private void FRM_GESTION_PRODUCT_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = prd.SearchProduct(txtSearch.Text);
            this.dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Pro frm = new Add_Pro();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Êtes-vous sûr du processus de suppression?", "Attention", MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                prd.DeleteProduct(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Produit supprimé", "Processus de suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = prd.GET_ALL_PRODUCT();
            }
            else
            {
                MessageBox.Show("Le produit n'a pas été supprimé", "Processus de suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Add_Pro frm = new Add_Pro();
                frm.txtCode.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.txtName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.cmbcat.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.cmbfour.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.dt.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                frm.txtPrix.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                frm.txtQte.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
                frm.txtemp.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                frm.txtDes.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
                frm.Text = "Modifier le Produit" + this.dataGridView1.CurrentRow.Cells[1].Value.ToString(); ;
                frm.btnAjouter.Text = "Modifier";
                frm.State = "Modifier";
                frm.txtCode.ReadOnly = true;
                byte[] image = (byte[])prd.GET_IMAGE_PRODUCT(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
                MemoryStream ms = new MemoryStream(image);
                frm.pbox.Image = Image.FromStream(ms);
                frm.ShowDialog();
            }catch
            {
                MessageBox.Show("Le Liste vide", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FRM_SHOW_IMAGE frm = new FRM_SHOW_IMAGE();
            byte[] image = (byte[])prd.GET_IMAGE_PRODUCT(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.pictureBox1.Image = Image.FromStream(ms);
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RPT.RPT_PRD_SINGEL myReport = new RPT.RPT_PRD_SINGEL();
            myReport.SetParameterValue("@ID", this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            RPT.FRM_RPT_PRO myForm = new RPT.FRM_RPT_PRO();
            myForm.crystalReportViewer1.ReportSource = myReport;
            myForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RPT.RPT_ALL_PRODUCT rpt = new RPT.RPT_ALL_PRODUCT();
            RPT.FRM_RPT_PRO frm = new RPT.FRM_RPT_PRO();
            rpt.Refresh();
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RPT.RPT_ALL_PRODUCT myReport = new RPT.RPT_ALL_PRODUCT();
            //creat export option
            ExportOptions export = new ExportOptions();
            //create object for destinaton
            DiskFileDestinationOptions dfoptions = new DiskFileDestinationOptions();
            ExcelFormatOptions excelFormat = new ExcelFormatOptions();
            dfoptions.DiskFileName = @"C:\Users\Mohamed L'HARRAK\Documents\New folder\pruductList.xls";
            export = myReport.ExportOptions;
            export.ExportDestinationType = ExportDestinationType.DiskFile;
            export.ExportFormatType = ExportFormatType.Excel;
            export.ExportFormatOptions = excelFormat;
            export.ExportDestinationOptions = dfoptions;
            myReport.Export();
            MessageBox.Show("Liste exportée avec succès","Exportée",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
