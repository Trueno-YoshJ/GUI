using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using MySqlX.XDevAPI;
using Nimal_furniture.Models;


namespace Nimal_furniture.Repository
{
    public class Stock_repo
    {
        private readonly string connectionString = "Data Source=TRON\\TEW_SQLEXPRESS;Initial Catalog=Myinventory;Integrated Security=True;Trust Server Certificate=True";
        public List<stocks> GetClients()
        {
            var clients = new List<stocks>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM clients ORDER BY id DESC";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                            while (reader.Read())
                            {
                                stocks client = new stocks();
                                client.id = reader.GetInt32(0);
                                client.name = reader.GetString(1);
                                client.type = reader.GetString(2);
                                client.quantity = reader.GetInt32(3);
                                client.price = reader.GetInt32(4);
                               
                                clients.Add(client);
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception : " + ex.Message);
            }
            return clients;
        }
        public stocks? GetClients(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM clients WHERE id =@id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                            if (reader.Read())
                            {
                                stocks client = new stocks();
                                client.id = reader.GetInt32(0);
                                client.name = reader.GetString(1);
                                client.type = reader.GetString(2);
                                client.quantity = reader.GetInt32(3);
                                client.price = reader.GetInt32(4);
                                return client;
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception : " + ex.Message);
            }
            return null;
        }
        public void CreateClients(stocks clients)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO clients (pname, ptype, qty, price) VALUES (@name, @type, @quantity, @price)";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@name", clients.name);
                        command.Parameters.AddWithValue("@type", clients.type);
                        command.Parameters.AddWithValue("@quantity", clients.quantity);
                        command.Parameters.AddWithValue("@price", clients.price);
                        command.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        public void UpdateClients(stocks clients)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE clients SET pname = @name, ptype = @type, qty = @quantity, price = @price WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@name", clients.name);
                        command.Parameters.AddWithValue("@type", clients.type);
                        command.Parameters.AddWithValue("@quantity", clients.quantity);
                        command.Parameters.AddWithValue("@price", clients.price);

                        command.Parameters.AddWithValue("@id", clients.id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DeleteClient(int id)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM clients WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception" + ex.Message);

            }
        }
    }
}
