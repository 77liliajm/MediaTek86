using System;

namespace MediaTek86.modele
{
    /// <summary>
    /// Représente une absence d’un personnel avec motif et dates.
    /// </summary>
    public class Absence
    {
        /// <summary>
        /// Obtient l'identifiant du personnel.
        /// </summary>
        public int IdPersonnel { get; }

        /// <summary>
        /// Obtient l'identifiant du motif d'absence.
        /// </summary>
        public int IdMotif { get; }

        /// <summary>
        /// Obtient la date de début de l'absence.
        /// </summary>
        public DateTime DateDebut { get; }

        /// <summary>
        /// Obtient la date de fin de l'absence.
        /// </summary>
        public DateTime DateFin { get; }

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Absence"/>.
        /// </summary>
        /// <param name="idPersonnel">L'identifiant du personnel.</param>
        /// <param name="idMotif">L'identifiant du motif d'absence.</param>
        /// <param name="dateDebut">La date de début de l'absence.</param>
        /// <param name="dateFin">La date de fin de l'absence.</param>
        public Absence(int idPersonnel, int idMotif, DateTime dateDebut, DateTime dateFin)
        {
            IdPersonnel = idPersonnel;
            IdMotif = idMotif;
            DateDebut = dateDebut;
            DateFin = dateFin;
        }
    }
}


