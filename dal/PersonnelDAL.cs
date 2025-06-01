using System;
using System.Collections.Generic;
using MediaTek86.modele;
using MediaTek86.bddmanager;

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
        /// <returns>Liste des personnels.</returns>
        public static List<Personnel> GetAllPersonnels()
        {
            List<Personnel> personnels = new List<Personnel>();

            string reqSelect = "SELECT * FROM personnel";
            var rows = BddManager.GetData(reqSelect);

            foreach (var row in rows)
            {
                personnels.Add(new Personnel(
                    Convert.ToInt32(row["idpersonnel"]),
                    row["nom"].ToString(),
                    row["prenom"].ToString(),
                    row["tel"].ToString(),
                    row["mail"].ToString(),
                    Convert.ToInt32(row["idservice"])  
                ));
            }

            return personnels;
        }
    }
}




