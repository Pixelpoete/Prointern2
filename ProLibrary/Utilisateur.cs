using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProLibrary
{
    public class Utilisateur
    {
        public string Matricule { get; set; }
        public string CodeService { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string MotDePasse { get; set; }
        public byte StatutConnexion { get; set; }
        public byte StatutSystem { get; set; }
        public DateTime DateConnexion { get; set; }
        public DateTime HeureConnexion { get; set; }
        public string NomHost { get; set; }
        public string AIP { get; set; }
        public byte NumProfil { get; set; }
        DbConnexion db = new DbConnexion();
        public bool ExistUnOuDesUtilisateurs()
        {
            //SqlConnection cn = new SqlConnection(db._connectionString);
            using (SqlConnection cnx = db.RenvoiObjetConnnexion())
            {
                cnx.Open();
                SqlCommand cmd = new SqlCommand("select * from utilisateur", cnx);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    return true;
                else
                    return false;
            }
        }
    }
}
