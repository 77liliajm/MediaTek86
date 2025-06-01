using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MediaTek86.modele;
using MediaTek86.Repository;  // Important : pour accéder à PersonnelRepository

namespace MediaTek86
{
    /// <summary>
    /// Formulaire pour la gestion et l'affichage du personnel.
    /// </summary>
    public partial class FrmPersonnel : Form
    {
        /// <summary>
        /// Initialise une nouvelle instance du formulaire.
        /// </summary>
        public FrmPersonnel()
        {
            InitializeComponent();
            LoadPersonnelData();
        }

        /// <summary>
        /// Charge les données du personnel et les affiche dans le DataGridView.
        /// </summary>
        private void LoadPersonnelData()
        {
            try
            {
                // Récupération de la liste du personnel depuis la base de données
                List<Personnel> listePersonnel = PersonnelRepository.GetAllPersonnel();

                // Assigner la liste comme source de données du DataGridView
                dgvPersonnel.DataSource = null;
                dgvPersonnel.DataSource = listePersonnel;

                // Personnalisation des en-têtes des colonnes
                dgvPersonnel.Columns["Nom"].HeaderText = "Nom";
                dgvPersonnel.Columns["Prenom"].HeaderText = "Prénom";
                dgvPersonnel.Columns["Tel"].HeaderText = "Téléphone";
                dgvPersonnel.Columns["Mail"].HeaderText = "Email";
                dgvPersonnel.Columns["IdService"].HeaderText = "Service";
            }
            catch (Exception ex)
            {
                // Affiche un message d'erreur en cas d'échec de chargement des données
                MessageBox.Show("Erreur lors du chargement des données du personnel : " + ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


