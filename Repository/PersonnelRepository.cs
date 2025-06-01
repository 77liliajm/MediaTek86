using MediaTek86.modele;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace MediaTek86.Repository
{
    /// <summary>
    /// Fournit les méthodes pour accéder aux données du personnel dans la base de données.
    /// </summary>
    public static class PersonnelRepository
    {
        // Chaîne de connexion vers la base de données MySQL
        private static string connectionString = "server=localhost;database=mediatek86;uid=root;pwd=Okboomer93100!!;";

        /// <summary>
        /// Récupère la liste complète du personnel depuis la base de données.
        /// </summary>
        /// <returns>Liste d'objets Personnel</returns>
        public static List<Personnel> GetAllPersonnel()
        {
            List<Personnel> liste = new List<Personnel>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Requête SQL pour récupérer les informations du personnel
                string query = "SELECT idpersonnel, nom, prenom, tel, mail, idservice FROM personnel ORDER BY nom, prenom";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Parcours des résultats de la requête
                        while (reader.Read())
                        {
                            int idPersonnel = reader.GetInt32("idpersonnel");
                            string nom = reader.IsDBNull(reader.GetOrdinal("nom")) ? "" : reader.GetString("nom");
                            string prenom = reader.IsDBNull(reader.GetOrdinal("prenom")) ? "" : reader.GetString("prenom");
                            string tel = reader.IsDBNull(reader.GetOrdinal("tel")) ? "" : reader.GetString("tel");
                            string mail = reader.IsDBNull(reader.GetOrdinal("mail")) ? "" : reader.GetString("mail");
                            int idService = reader.IsDBNull(reader.GetOrdinal("idservice")) ? 0 : reader.GetInt32("idservice");

                            // Création d'un objet Personnel avec les données récupérées
                            Personnel p = new Personnel(idPersonnel, nom, prenom, tel, mail, idService);
                            liste.Add(p);
                        }
                    }
                }
            }

            return liste;
        }
    }
}


