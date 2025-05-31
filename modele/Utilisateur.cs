namespace MediaTek86.modele
{
    /// <summary>
    /// Représente un utilisateur avec login et mot de passe.
    /// </summary>
    public class Utilisateur
    {
        /// <summary>
        /// Obtient l'identifiant du personnel associé à l'utilisateur.
        /// </summary>
        public int IdPersonnel { get; }

        /// <summary>
        /// Obtient le login de l'utilisateur.
        /// </summary>
        public string Login { get; }

        /// <summary>
        /// Obtient le mot de passe de l'utilisateur.
        /// </summary>
        public string Password { get; }

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Utilisateur"/>.
        /// </summary>
        /// <param name="idPersonnel">Identifiant du personnel.</param>
        /// <param name="login">Login de l'utilisateur.</param>
        /// <param name="password">Mot de passe de l'utilisateur.</param>
        public Utilisateur(int idPersonnel, string login, string password)
        {
            IdPersonnel = idPersonnel;
            Login = login;
            Password = password;
        }
    }
}




