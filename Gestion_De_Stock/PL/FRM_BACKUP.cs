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

namespace Gestion_De_Stock.PL
{
    public partial class FRM_BACKUP : Form
    {
        SqlConnection con = new SqlConnection(@"Server = .\SQLEXPRESS; Database = Gestion_DB; Integrated Security = true");
        SqlCommand cmd;
        public FRM_BACKUP()
        {
            InitializeComponent();
        }

        private void FRM_BACKUP_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Back Up (*.Bak) | *.Bak";
            if(sf.ShowDialog() == DialogResult.OK)
            {
                cmd = new SqlCommand("Backup Database Gestion_DB to Disk='" + sf.FileName+"'" , con); ;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
          
           
        }
    }
}
