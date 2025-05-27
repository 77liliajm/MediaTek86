namespace MediaTek86.modele
{
    /// <summary>
    /// Classe métier représentant un utilisateur (login + mot de passe)
    /// </summary>
    public class Utilisateur
    {
        public string login { get; set; }
        public string pwd { get; set; }

        /// <summary>
        /// Constructeur de la classe Utilisateur
        /// </summary>
        /// <param name="login">Identifiant de l'utilisateur</param>
        /// <param name="pwd">Mot de passe de l'utilisateur</param>
        public Utilisateur(string login, string pwd)
        {
            this.login = login;
            this.pwd = pwd;
        }
    }
}
