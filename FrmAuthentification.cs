using System;
using System.Windows.Forms;
using MediaTek86.modele;
using MediaTek86.dal;

namespace MediaTek86
{
    public partial class FrmAuthentification : Form
    {
        /// <summary>
        /// Initialise une nouvelle instance du formulaire d'authentification.
        /// </summary>
        public FrmAuthentification()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gère la tentative de connexion lorsqu'on clique sur le bouton Valider.
        /// </summary>
        private void btnValider_Click(object sender, EventArgs e)
        {
            string login = txtIdentifiant.Text.Trim();
            string password = txtMotDePasse.Text;

            // Vérification des champs vides
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                lblErreurAuth.Text = "Veuillez remplir tous les champs.";
                lblErreurAuth.Visible = true;
                return;
            }

            // Vérifie les identifiants dans la base de données
            Utilisateur utilisateur = UtilisateurDAL.GetUtilisateur(login, password);

            if (utilisateur == null)
            {
                lblErreurAuth.Text = "Identifiant ou mot de passe incorrect.";
                lblErreurAuth.Visible = true;
            }
            else
            {
                // Connexion réussie → ouverture de la fenêtre principale
                FrmMediatek frmMediatek = new FrmMediatek(utilisateur);
                this.Hide();
                frmMediatek.ShowDialog();
                this.Close();
            }
        }
    }
}


