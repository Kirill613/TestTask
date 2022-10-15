using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask
{
    public class Db
    {
        public static string connectionString { get; private set; }

        public static void CreateDbAndTable()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                try
                {
                    SqlCommand command1 = sqlConnection.CreateCommand();
                    command1.CommandText = "CREATE DATABASE employees";
                    command1.ExecuteNonQuery();
                }
                catch
                {
                }

                try
                {
                    SqlCommand command = sqlConnection.CreateCommand();
                    command.CommandText = "CREATE TABLE employees (id INT PRIMARY KEY IDENTITY, " +
                                                                  "name varchar(max) NOT NULL," +
                                                                  "surname varchar(max) NOT NULL," +
                                                                  "position varchar(max) NOT NULL," +
                                                                  "year_of_birthday INT NOT NULL," +
                                                                  "salary INT NOT NULL)";
                    command.ExecuteNonQuery();

                    AddRecord("Vasya1", "Vasilev1", "junior developer", 1990, 2342);
                    AddRecord("Vasya2", "Vasilev2", "junior developer", 2002, 123);
                    AddRecord("Vasya3", "Vasilev3", "middle developer", 2002, 3456);
                    AddRecord("Vasya4", "Vasilev4", "middle developer", 2005, 46564);
                    AddRecord("Vasya5", "Vasilev5", "middle developer", 2002, 4566);
                    AddRecord("Vasya6", "Vasilev6", "senior developer", 1980, 456);
                    AddRecord("Vasya7", "Vasilev7", "senior developer", 1999, 6780);
                    AddRecord("Vasya8", "Vasilev8", "senior developer", 1995, 33454);
                    AddRecord("Vasya9", "Vasilev9", "senior developer", 1970, 23443);
                    AddRecord("Vasya10", "Vasilev10", "tester", 1999, 345);
                    AddRecord("Vasya11", "Vasilev11", "tester", 1995, 654);
                    AddRecord("Vasya12", "Vasilev12", "tester", 2002, 2344);
                }
                catch
                {
                }
            }
        }

        public static bool ChangeConnectionString(string serverName)
        {
            string connection = "Server=" + serverName + ";Database=master;Trusted_Connection=True";

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connection);
            builder.ConnectTimeout = 2;

            using (SqlConnection sqlConnection = new SqlConnection(builder.ToString()))
            {
                try
                {
                    sqlConnection.Open();
                    MessageBox.Show("Connection success.", "All good", MessageBoxButtons.YesNo);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Connection failed, try again. "+ e.Message, "Error", MessageBoxButtons.YesNo);
                    return false;
                }              
            }
            connectionString = connection;
            return true;
        }

        public static List<string[]> GetTableData(string[] positions)
        {
            if (positions.Count() == 0)
                return new List<string[]>();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                SqlCommand command5 = sqlConnection.CreateCommand();

                var parameters = new string[positions.Length];
                for (int i = 0; i < positions.Length; i++)
                {
                    parameters[i] = string.Format("@pos{0}", i);
                    command5.Parameters.AddWithValue(parameters[i], positions[i]);
                }

                command5.CommandText = String.Format("SELECT id, name, surname, position, year_of_birthday, salary " +
                                     "FROM employees " +
                                     "WHERE position IN ({0})", string.Join(", ", parameters));

                SqlDataReader reader = command5.ExecuteReader();

                var data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[6]);

                    for (int i = 0; i < 6; i++)
                        data[data.Count - 1][i] = reader[i].ToString();
                }
                return data;
            }
        }

        public static string[] GetPositions()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                string query = "SELECT DISTINCT position FROM employees";

                SqlCommand command5 = sqlConnection.CreateCommand();

                command5.CommandText = query;

                SqlDataReader reader = command5.ExecuteReader();

                var data = new List<string>();

                while (reader.Read())
                {
                    data.Add(reader[0].ToString());
                }
                return data.ToArray();
            }
        }
        public static DataTable GetDataForReport()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                string query = "SELECT position, salary FROM employees";

                SqlCommand command5 = sqlConnection.CreateCommand();

                command5.CommandText = query;

                DataTable dataTable = new DataTable();

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command5))
                {
                    dataAdapter.Fill(dataTable);
                }

                return dataTable;
            }
        }
        public static void DeleteRecord(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                SqlCommand command3 = sqlConnection.CreateCommand();
                command3.CommandText = "DELETE FROM employees " +
                                       "WHERE id = @id";

                command3.Parameters.AddWithValue("@id", id);
                command3.ExecuteNonQuery();
            }
        }
        public static void AddRecord(string name, string surname, string position, int yearOfBirthday, int salary)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                SqlCommand command2 = sqlConnection.CreateCommand();

                command2.CommandText = "INSERT INTO employees (name, surname, position, year_of_birthday, salary) " +
                                                      "VALUES (@name, @surname, @position, @year_of_birthday, @salary)";

                command2.Parameters.AddWithValue("@name", name);
                command2.Parameters.AddWithValue("@surname", surname);
                command2.Parameters.AddWithValue("@position", position);
                command2.Parameters.AddWithValue("@year_of_birthday", yearOfBirthday);
                command2.Parameters.AddWithValue("@salary", salary);

                command2.ExecuteNonQuery();
            }
        }

    }

}