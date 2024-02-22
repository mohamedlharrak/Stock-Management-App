using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Gestion_De_Stock.BL
{
    class CLS_PRODUCT
    {
        //Bach n3amro combobox

        public DataTable GET_ALL_FOURNISSEUR()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_ALL_FOURNISSEUR", null);
            DAL.Close();
            return dt;
        }
        public DataTable GET_ALL_CAT()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
           
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_ALL_CAT", null);
            DAL.Close();
            return dt;
        }
        public void ADD_PRODUCT(string Code_Barre, string Name_Pro, int ID_Cat, int ID_fournisseurs,
           DateTime Date_Entrée,  string Prix,string QTE, string Emplacement, string Designation, byte[] Image)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[10];
            param[0] = new SqlParameter("@Code_Barre", SqlDbType.VarChar, 30);
            param[0].Value = Code_Barre;
            param[1] = new SqlParameter("@Name_Pro", SqlDbType.VarChar, 50);
            param[1].Value = Name_Pro;
            param[2] = new SqlParameter("@ID_Cat", SqlDbType.Int);
            param[2].Value = ID_Cat;
            param[3] = new SqlParameter("@ID_fournisseurs", SqlDbType.Int);
            param[3].Value = ID_fournisseurs;
            param[4] = new SqlParameter("@Date_Entrée", SqlDbType.Date);
            param[4].Value = Date_Entrée;
            param[5] = new SqlParameter("@Prix", SqlDbType.VarChar, 15);
            param[5].Value = Prix;
            param[6] = new SqlParameter("@QTE", SqlDbType.VarChar,10);
            param[6].Value = QTE;
            param[7] = new SqlParameter("@Emplacement", SqlDbType.VarChar, 50);
            param[7].Value = Emplacement;
            param[8] = new SqlParameter("@Designation", SqlDbType.VarChar, 100);
            param[8].Value = Designation;
            param[9] = new SqlParameter("@Image", SqlDbType.Image);
            param[9].Value = Image;
            DAL.ExecuteCommand("ADD_PRODUCT", param);
            DAL.Close();
        }
        public DataTable VerifyCodeBarre(string Code_Barre)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Code_Barre", SqlDbType.VarChar, 30);
            param[0].Value = Code_Barre;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("VerifyCodeBarre", param);
            DAL.Close();
            return dt;
        }
        public DataTable GET_ALL_PRODUCT()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_ALL_PRODUCT", null);
            DAL.Close();
            return dt;
        }
        public DataTable SearchProduct(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 30);
            param[0].Value = ID;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("SearchProduct", param);
            DAL.Close();
            return dt;
        }
        public void DeleteProduct(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
           
            DAL.ExecuteCommand("DeleteProduct", param);
            DAL.Close();
        }
        public DataTable GET_IMAGE_PRODUCT(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 30);
            param[0].Value = ID;

            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_IMAGE_PRODUCT", param);
            DAL.Close();
            return dt;
        }
        public void UPDATE_PRODUCTE(string Code_Barre, string Name_Pro, int ID_Cat, int ID_fournisseurs,
           DateTime Date_Entrée, string Prix, string QTE, string Emplacement, string Designation, byte[] Image)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[10];
            param[0] = new SqlParameter("@Code_Barre", SqlDbType.VarChar, 30);
            param[0].Value = Code_Barre;
            param[1] = new SqlParameter("@Name_Pro", SqlDbType.VarChar, 50);
            param[1].Value = Name_Pro;
            param[2] = new SqlParameter("@ID_Cat", SqlDbType.Int);
            param[2].Value = ID_Cat;
            param[3] = new SqlParameter("@ID_fournisseurs", SqlDbType.Int);
            param[3].Value = ID_fournisseurs;
            param[4] = new SqlParameter("@Date_Entrée", SqlDbType.Date);
            param[4].Value = Date_Entrée;
            param[5] = new SqlParameter("@Prix", SqlDbType.VarChar, 15);
            param[5].Value = Prix;
            param[6] = new SqlParameter("@QTE", SqlDbType.VarChar, 10);
            param[6].Value = QTE;
            param[7] = new SqlParameter("@Emplacement", SqlDbType.VarChar, 50);
            param[7].Value = Emplacement;
            param[8] = new SqlParameter("@Designation", SqlDbType.VarChar, 100);
            param[8].Value = Designation;
            param[9] = new SqlParameter("@Image", SqlDbType.Image);
            param[9].Value = Image;
            DAL.ExecuteCommand("UPDATE_PRODUCTE", param);
            DAL.Close();
        }
    }
}
