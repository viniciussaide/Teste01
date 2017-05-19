using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace Teste01
{
    class Program
    {
        static void Main(string[] args)
        {
            string myConnectionString = "server=127.0.0.1;uid=root;pwd=;database=holerite;";
            MySqlConnection conn = new MySqlConnection(myConnectionString);

            try
            {
                var query = conn.CreateCommand();
                conn.Open();
                query.CommandText = "SELECT * FROM users";
                //query.ExecuteNonQuery();
                using (MySqlDataReader DR = query.ExecuteReader())
                {
                    while (DR.Read())
                    {
                        long matricula = Convert.ToInt64(DR.GetValue(0));
                        long cpf = Convert.ToInt64(DR.GetValue(1));
                        string nome = Convert.ToString(DR.GetValue(2));
                        Console.WriteLine(@"{0} {1:###\.###\.###-##} {2}", matricula, cpf, nome);
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            Console.ReadLine();
        }
    }
}