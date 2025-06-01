using MediaTek86.modele;
using MySql.Data.MySqlClient;

namespace MediaTek86.dal
{
    /// <summary>
    /// Fournit des méthodes d'accès aux données de l'utilisateur.
    /// </summary>
    public static class UtilisateurDAL
    {
        private static string connectionString = "server=localhost;database=mediatek86;uid=root;pwd=Okboomer93100!!;";

        /// <summary>
        /// Récupère un utilisateur depuis la base avec login et mot de passe hashé.
        /// </summary>
        /// <param name="login">Le login de l'utilisateur</param>
        /// <param name="passwordHash">Le mot de passe hashé</param>
        /// <returns>Un objet Utilisateur ou null si non trouvé</returns>
        public static Utilisateur GetUtilisateur(string login, string passwordHash)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT login, pwd FROM responsable WHERE login = @login AND pwd = @pwdHash LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@pwdHash", passwordHash);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string userLogin = reader.GetString("login");
                            string pwd = reader.GetString("pwd");

                            return new Utilisateur(userLogin, pwd); // adapte selon le constructeur disponible
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
    }
}








