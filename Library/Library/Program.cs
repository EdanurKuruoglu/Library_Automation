using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library
{
    public static class Program
    {
        public static MySqlConnection connection = null; // Global baðlantý nesnesi

        [STAThread]
        public static bool Injection(string input)
        {
            // SQL enjeksiyonu için yasaklý kelimeler
            string[] yasakli_kelime = { "UNION", "DROP", "DELETE", "INSERT", "UPDATE", "ALTER", "TRUNCATE", "SELECT", "FROM", "WHERE", "OR ", "\"OR\"=", "OR 1=1" };

            // SQL enjeksiyonu için yasaklý karakterler
            char[] yasak_karakter = { ';', '-', '*', '+', '=', '>', '<', '(', ')', '[', ']', '{', '}', '/', '\\', '\'', '\"' };


            // SQL enjeksiyonu için yasaklý kelimelerin kontrolü
            foreach (string keyword in yasakli_kelime)
            {
                if (input.ToUpper().Contains(keyword))
                {
                    return false;
                }
            }

            // SQL enjeksiyonu için yasaklý karakterlerin kontrolü
            foreach (char character in yasak_karakter)
            {
                if (input.Contains(character))
                {
                    return false;
                }
            }


            return true;
        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string connectionString = "Server=localhost;Database=library_1;Uid=root;Pwd=00000";
            connection = new MySqlConnection(connectionString);
            Application.Run(new FrmLogin()); 
        }
    }
}
