using System;
using System.Collections.Generic;
using MediaTek86.modele;
using MediaTek86.bddmanager;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe permettant l'accès aux données des utilisateurs.
    /// </summary>
    public class UtilisateurDAL
    {
        /// <summary>
        /// Récupère un utilisateur à partir de son login et mot de passe.
        /// </summary>
        /// <param name="login">Le login de l'utilisateur.</param>
        /// <param name="pwd">Le mot de passe de l'utilisateur.</param>
        /// <returns>Un objet Utilisateur si trouvé, sinon null.</returns>
        public static Utilisateur GetUtilisateur(string login, string pwd)
        {
            string query = "SELECT * FROM utilisateur WHERE login = @login AND pwd = @pwd";
            var parameters = new Dictionary<string, object>
            {
                { "@login", login },
                { "@pwd", pwd }
            };

            var result = BddManager.GetData(query, parameters);

            if (result.Count > 0)
            {
                var row = result[0];
                return new Utilisateur(
                    Convert.ToInt32(row["idpersonnel"]),
                    row["login"].ToString(),
                    row["pwd"].ToString()
                );
            }

            return null;
        }
    }
}




