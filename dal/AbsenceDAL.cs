using System;
using System.Collections.Generic;
using MediaTek86.modele;
using mediatek86.bddmanager;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe permettant l'accès aux données des absences.
    /// </summary>
    public class AbsenceDAL
    {
        /// <summary>
        /// Récupère la liste des absences pour un personnel donné.
        /// </summary>
        /// <param name="idpersonnel">L'identifiant du personnel.</param>
        /// <returns>Une liste d'objets <see cref="Absence"/> correspondant aux absences du personnel.</returns>
        public static List<Absence> GetAbsencesByPersonnel(int idpersonnel)
        {
            List<Absence> absences = new List<Absence>();

            string reqSelect = "SELECT * FROM absence WHERE idpersonnel = @idpersonnel";
            var parameters = new Dictionary<string, object> { { "@idpersonnel", idpersonnel } };
            var rows = BddManager.GetData(reqSelect, parameters);

            foreach (var row in rows)
            {
                int idmotif = Convert.ToInt32(row["idmotif"]);
                DateTime datedebut = Convert.ToDateTime(row["datedebut"]);
                DateTime datefin = Convert.ToDateTime(row["datefin"]);

                absences.Add(new Absence(idpersonnel, idmotif, datedebut, datefin));
            }

            return absences;
        }
    }
}


