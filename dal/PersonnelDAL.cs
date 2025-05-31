using System;
using System.Collections.Generic;
using MediaTek86.modele;
using mediatek86.bddmanager;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe de gestion des accès aux données pour les personnels.
    /// </summary>
    public class PersonnelDAL
    {
        /// <summary>
        /// Récupère la liste de tous les personnels depuis la base de données.
        /// </summary>
        /// <returns>Liste d'objets <see cref="Personnel"/> représentant les personnels.</returns>
        public static List<Personnel> GetAllPersonnels()
        {
            List<Personnel> personnels = new List<Personnel>();

            string reqSelect = "SELECT * FROM personnel";
            var rows = BddManager.GetData(reqSelect);

            foreach (var row in rows)
            {
                int id = Convert.ToInt32(row["idpersonnel"]);
                string nom = row["nom"].ToString();
                string prenom = row["prenom"].ToString();
                string tel = row["tel"].ToString();
                string mail = row["mail"].ToString();
                string idservice = row["idservice"].ToString();

                personnels.Add(new Personnel(id, nom, prenom, tel, mail, idservice));
            }

            return personnels;
        }
    }
}



