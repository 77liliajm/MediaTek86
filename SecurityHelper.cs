using System.Security.Cryptography;
using System.Text;

namespace MediaTek86
{
    /// <summary>
    /// Classe utilitaire pour les fonctions de sécurité comme le hashage SHA-256.
    /// </summary>
    public static class SecurityHelper
    {
        /// <summary>
        /// Calcule le hash SHA-256 d'une chaîne de caractères.
        /// </summary>
        /// <param name="rawData">La chaîne de caractères à hasher.</param>
        /// <returns>Le hash SHA-256 sous forme de chaîne hexadécimale.</returns>
        public static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }
    }
}



