using System;
using MediaTek86.modele;
using mediatek86.bddmanager;
using System.Collections.Generic;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe permettant l'accès aux données des utilisateurs.
    /// </summary>
    public class UtilisateurDAL
    {
        /// <summary>
        /// Récupère un utilisateur à partir de son login.
        /// </summary>
        /// <param name="login">Le nom d'utilisateur (login) à rechercher.</param>
        /// <returns>Un objet <see cref="Utilisateur"/> si l'utilisateur est trouvé, sinon <c>null</c>.</returns>
        public static Utilisateur GetUtilisateur(string login)
        {
            string reqSelect = "SELECT * FROM utilisateur WHERE login = @login";
            var parameters = new Dictionary<string, object> { { "@login", login } };
            var rows = BddManager.GetData(reqSelect, parameters);

            if (rows.Count > 0)
            {
                var row = rows[0];
                int idpersonnel = Convert.ToInt32(row["idpersonnel"]);
                string password = row["pwd"].ToString();

                return new Utilisateur(idpersonnel, login, password);
            }
            else
            {
                return null;
            }
        }
    }
}


