using System;
using System.Collections.Generic;
using MediaTek86.modele;
using MediaTek86.bddmanager;
using MySql.Data.MySqlClient;

namespace MediaTek86.dal
{
    public class UtilisateurDAL
    {
        private static string connectionString = "server=localhost;database=mediatek86;uid=root;pwd=Okboomer93100!!;";

        /// <summary>
        /// Récupère un utilisateur à partir du login et du mot de passe en clair.
        /// Le mot de passe est hashé en SHA-256 avant la requête.
        /// </summary>
        public static Utilisateur GetUtilisateur(string login, string password)
        {
            string pwdHash = SecurityHelper.ComputeSha256Hash(password);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT login FROM responsable WHERE login = @login AND pwd = @pwdHash LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@pwdHash", pwdHash);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Crée et retourne un utilisateur avec le login récupéré
                            return new Utilisateur(reader.GetString("login"));
                        }
                    }
                }
            }

            // Utilisateur non trouvé
            return null;
        }
    }
}






