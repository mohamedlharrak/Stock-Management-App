using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Gestion_De_Stock.BL
{
    class CLS_FOURNISSEUR
    {
        public void ADD_FURNISSEUR(int ID_fournisseurs, string Nom_de_fournisseurs, string Personne_a_contacter,
            string Prénom_de_la_personne, string Adresse, string Téléphone)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_fournisseurs", SqlDbType.VarChar, 30);
            param[0].Value = ID_fournisseurs;
            param[1] = new SqlParameter("@Nom_de_fournisseurs", SqlDbType.VarChar, 50);
            param[1].Value = Nom_de_fournisseurs;
            param[2] = new SqlParameter("@Personne_a_contacter", SqlDbType.Int);
            param[2].Value = Personne_a_contacter;
            param[3] = new SqlParameter("@Prénom_de_la_personne", SqlDbType.Int);
            param[3].Value = Prénom_de_la_personne;
            param[4] = new SqlParameter("@Adresse", SqlDbType.Date);
            param[4].Value = Adresse;
            param[5] = new SqlParameter("@Téléphone", SqlDbType.VarChar, 15);
            param[5].Value = Téléphone;
            DAL.ExecuteCommand("ADD_FURNISSEUR", param);
            DAL.Close();
        }
    }
}
