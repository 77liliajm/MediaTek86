using MediaTek86.modele;
using MediaTek86.dal;
using MediaTek86; // pour le hash
using System;
using System.Windows.Forms;


namespace MediaTek86
{
    /// <summary>
    /// Formulaire d'authentification permettant la connexion.
    /// </summary>
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
        /// Gestion du clic sur le bouton Valider pour tenter la connexion.
        /// </summary>
        private void btnValider_Click(object sender, EventArgs e)
        {
            string login = txtIdentifiant.Text.Trim();
            string password = txtMotDePasse.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                lblErreurAuth.Text = "Veuillez remplir tous les champs.";
                lblErreurAuth.Visible = true;
                return;
            }

            // Hachage du mot de passe
            string passwordHash = SecurityHelper.ComputeSha256Hash(password);

            // Vérification dans la base
            Utilisateur utilisateur = UtilisateurDAL.GetUtilisateur(login, passwordHash);

            if (utilisateur == null)
            {
                lblErreurAuth.Text = "Identifiant ou mot de passe incorrect.";
                lblErreurAuth.Visible = true;
            }
            else
            {
                // Connexion OK → accès à FrmMediatek
                FrmMediatek frmMediatek = new FrmMediatek(utilisateur);
                this.Hide();
                frmMediatek.ShowDialog();
                this.Close();
            }
        }
    }
}




