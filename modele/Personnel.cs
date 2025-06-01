using System;

namespace MediaTek86.modele
{
    /// <summary>
    /// Représente un employé (personnel) avec ses informations de contact et service.
    /// </summary>
    public class Personnel
    {
        /// <summary>
        /// Obtient l'identifiant unique du personnel.
        /// </summary>
        public int IdPersonnel { get; }

        /// <summary>
        /// Obtient le nom de famille du personnel.
        /// </summary>
        public string Nom { get; }

        /// <summary>
        /// Obtient le prénom du personnel.
        /// </summary>
        public string Prenom { get; }

        /// <summary>
        /// Obtient le numéro de téléphone du personnel.
        /// </summary>
        public string Tel { get; }

        /// <summary>
        /// Obtient l'adresse email du personnel.
        /// </summary>
        public string Mail { get; }

        /// <summary>
        /// Obtient l'identifiant du service auquel le personnel est rattaché.
        /// </summary>
        public int IdService { get; }

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Personnel"/>.
        /// </summary>
        /// <param name="idPersonnel">L'identifiant unique du personnel.</param>
        /// <param name="nom">Le nom de famille.</param>
        /// <param name="prenom">Le prénom.</param>
        /// <param name="tel">Le numéro de téléphone.</param>
        /// <param name="mail">L'adresse email.</param>
        /// <param name="idService">L'identifiant du service.</param>
        public Personnel(int idPersonnel, string nom, string prenom, string tel, string mail, int idService)
        {
            IdPersonnel = idPersonnel;
            Nom = nom;
            Prenom = prenom;
            Tel = tel;
            Mail = mail;
            IdService = idService;
        }
    }
}



