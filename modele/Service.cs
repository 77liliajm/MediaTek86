using System;

namespace MediaTek86.modele
{
    /// <summary>
    /// Représente un service ou département dans l'organisation.
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Obtient l'identifiant unique du service.
        /// </summary>
        public string IdService { get; }

        /// <summary>
        /// Obtient le nom du service.
        /// </summary>
        public string NomService { get; }

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Service"/>.
        /// </summary>
        /// <param name="idService">L'identifiant unique du service.</param>
        /// <param name="nomService">Le nom du service.</param>
        public Service(string idService, string nomService)
        {
            IdService = idService;
            NomService = nomService;
        }
    }
}

