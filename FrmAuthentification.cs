using System;
using System.Windows.Forms;
using MediaTek86.modele;
using MediaTek86.dal;

namespace MediaTek86
{
    public partial class FrmAuthentification : Form
    {
        public FrmAuthentification()
        {
            InitializeComponent();
        }

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

            Utilisateur utilisateur = UtilisateurDAL.GetUtilisateur(login, password);

            if (utilisateur == null)
            {
                lblErreurAuth.Text = "Identifiant ou mot de passe incorrect.";
                lblErreurAuth.Visible = true;
            }
            else
            {
                FrmMediatek frmMediatek = new FrmMediatek(utilisateur);
                this.Hide();
                frmMediatek.ShowDialog();
                this.Close();
            }
        }
    }
}



