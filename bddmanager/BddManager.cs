using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace MediaTek86.bddmanager
{
    /// <summary>
    /// Classe statique de gestion des connexions et requêtes SQL avec MySQL.
    /// Fournit des méthodes pour ouvrir/fermer la connexion et exécuter des requêtes SQL.
    /// </summary>
    public class BddManager
    {
        private static MySqlConnection connection;

        // À adapter selon tes identifiants
        private const string connectionString = "server=localhost;user id=root;password=Okboomer93100!!;database=mediatek86;SslMode=none";

        /// <summary>
        /// Ouvre la connexion à la base de données si elle n'est pas déjà ouverte.
        /// </summary>
        public static void OpenConnection()
        {
            if (connection == null)
            {
                connection = new MySqlConnection(connectionString);
            }

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        /// <summary>
        /// Ferme la connexion à la base de données si elle est ouverte.
        /// </summary>
        public static void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Exécute une requête SELECT et retourne les résultats dans une liste de dictionnaires.
        /// </summary>
        /// <param name="query">Requête SQL à exécuter.</param>
        /// <param name="parameters">Paramètres de la requête (facultatif).</param>
        /// <returns>Liste de dictionnaires représentant les lignes retournées par la requête.</returns>
        public static List<Dictionary<string, object>> GetData(string query, Dictionary<string, object> parameters = null)
        {
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();
            try
            {
                OpenConnection();
                using (var command = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var row = new Dictionary<string, object>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row.Add(reader.GetName(i), reader.GetValue(i));
                            }
                            result.Add(row);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur SQL : " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return result;
        }

        /// <summary>
        /// Exécute une requête INSERT, UPDATE ou DELETE.
        /// </summary>
        /// <param name="query">Requête SQL à exécuter.</param>
        /// <param name="parameters">Paramètres de la requête (facultatif).</param>
        public static void ExecuteQuery(string query, Dictionary<string, object> parameters = null)
        {
            try
            {
                OpenConnection();
                using (var command = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur SQL : " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}


