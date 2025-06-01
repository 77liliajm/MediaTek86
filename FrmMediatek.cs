using System;
using System.Windows.Forms;
using MediaTek86.modele; // Pour que "Utilisateur" soit reconnu

namespace MediaTek86
{
    /// <summary>
    /// Formulaire principal de l’application MediaTek.
    /// </summary>
    public partial class FrmMediatek : Form
    {
        private Utilisateur utilisateur;

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="FrmMediatek"/> avec un utilisateur connecté.
        /// </summary>
        /// <param name="utilisateur">L'utilisateur connecté.</param>
        public FrmMediatek(Utilisateur utilisateur)
        {
            InitializeComponent();
            this.utilisateur = utilisateur;
        }
    }
}



