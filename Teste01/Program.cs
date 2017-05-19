using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace Teste01
{
    class Program
    {
        static void Main(string[] args)
        {
            //MySQL
            //string myConnectionString = "server=127.0.0.1;uid=root;pwd=;database=holerite;";
            //MySqlConnection conn = new MySqlConnection(myConnectionString);
            //try
            //{
            //    var query = conn.CreateCommand();
            //    conn.Open();
            //    query.CommandText = "SELECT * FROM users";
            //    using (MySqlDataReader DR = query.ExecuteReader())
            //    {
            //        //while (DR.Read())
            //        //{
            //        //    long matricula = Convert.ToInt64(DR.GetValue(0));
            //        //    long cpf = Convert.ToInt64(DR.GetValue(1));
            //        //    string nome = Convert.ToString(DR.GetValue(2));
            //        //    Console.WriteLine(@"{0} {1:###\.###\.###-##} {2}", matricula, cpf, nome);
            //        //}
            //    }
            //}
            //catch (MySqlException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    if (conn.State == ConnectionState.Open)
            //        conn.Close();
            //}
            //Console.ReadLine();

            //string connetionString = "Data Source=ssavrd055,1433;Initial Catalog=DBpadroesTeste;User ID=sa;Password=foa2014";
            //SqlConnection conn = new SqlConnection(connetionString); ;
            //SqlCommand command;
            //SqlDataReader dataReader;
            //string sql = "SELECT * FROM Funcionario";
            //try
            //{
            //    conn.Open();
            //    Console.WriteLine("Connection Open!");
            //    command = new SqlCommand(sql, conn);
            //    dataReader = command.ExecuteReader();
            //    while (dataReader.Read())
            //    {
            //       Console.WriteLine(dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + " - " + dataReader.GetValue(2));
            //    }
            //    dataReader.Close();
            //    command.Dispose();
            //    conn.Close();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Can not open connection! " + ex);
            //}
            //Console.ReadLine();
            //ArrayList teste = new ArrayList();
            //teste.Add(0);
            //teste.Add(1);
            //teste.Add(2);
            //teste.Add(50);
            //teste.Add("ashdfjkl");
            //foreach (string i in teste) {
            //    Console.WriteLine(i);
            //}
            List<string> teste = new List<string>();
            string strTexto;
            do
            {
                strTexto = Console.ReadLine();
                teste.Add(strTexto);
            } while (!strTexto.Equals("Sair"));

            foreach (string texto in teste)
            {
                Console.Write(texto + " - ");
            }
            Console.ReadLine();
        }
    }
}