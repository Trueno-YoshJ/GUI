using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using MySqlX.XDevAPI;
using NImal_furniture.Models;


namespace NImal_furniture.Repository
{
    public class clients_repo
    {
        private readonly string connectionString = "Data Source=TRON\\TEW_SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True;Trust Server Certificate=True";
        public List<Clients> GetClients()
        {
            var clients = new List<Clients>();
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
                                Clients client = new Clients();
                                client.id = reader.GetInt32(0);
                                client.name = reader.GetString(1);
                                client.type = reader.GetString(2);
                                client.quantity = reader.GetInt32(3);
                                client.price = reader.GetInt32(4);
                                client.Add(client);
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exeption : " + ex.Message);
            }
            return clients;
        }
        public Clients? GetClients(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "SELECT * FROM clients WHERE id =@id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                            if (reader.Read())
                            {
                                Clients client = new Clients();
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
                Console.WriteLine("Exeption : " + ex.Message);
            }
            return null;
        }
        public void CreateClients(Clients clients)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO clients" +
                            "(name,type,quantity,price)" +
                            "(@name,@type,@quantity,@price)";
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
        public void UpdateClients(Clients clients)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE clients" +
                            "SET name = @name, type = @type" +
                            "quantity = @quntity,price = @price" +
                            "WHERE id=@id";
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
