using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using AutoService.Models;

namespace AutoService.Data
{
    public class ClientRepository
    {
        public List<Client> GetAll()
        {
            var list = new List<Client>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "SELECT ID_клиента, Фамилия, Имя, Телефон, Адрес " +
                    "FROM Клиенты " +
                    "ORDER BY Фамилия, Имя",
                    conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Client
                        {
                            Id        = reader.GetInt32(0),
                            LastName  = reader.GetString(1),
                            FirstName = reader.GetString(2),
                            Phone     = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                            Address   = reader.IsDBNull(4) ? string.Empty : reader.GetString(4)
                        });
                    }
                }
            }
            return list;
        }

        public void Add(Client client)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "INSERT INTO Клиенты (Фамилия, Имя, Телефон, Адрес) " +
                    "VALUES (@LastName, @FirstName, @Phone, @Address)",
                    conn);
                cmd.Parameters.AddWithValue("@LastName",  client.LastName);
                cmd.Parameters.AddWithValue("@FirstName", client.FirstName);
                cmd.Parameters.AddWithValue("@Phone",   string.IsNullOrEmpty(client.Phone)   ? (object)DBNull.Value : client.Phone);
                cmd.Parameters.AddWithValue("@Address", string.IsNullOrEmpty(client.Address) ? (object)DBNull.Value : client.Address);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Client client)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "UPDATE Клиенты " +
                    "SET Фамилия=@LastName, Имя=@FirstName, Телефон=@Phone, Адрес=@Address " +
                    "WHERE ID_клиента=@Id",
                    conn);
                cmd.Parameters.AddWithValue("@LastName",  client.LastName);
                cmd.Parameters.AddWithValue("@FirstName", client.FirstName);
                cmd.Parameters.AddWithValue("@Phone",   string.IsNullOrEmpty(client.Phone)   ? (object)DBNull.Value : client.Phone);
                cmd.Parameters.AddWithValue("@Address", string.IsNullOrEmpty(client.Address) ? (object)DBNull.Value : client.Address);
                cmd.Parameters.AddWithValue("@Id", client.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "DELETE FROM Клиенты WHERE ID_клиента=@Id",
                    conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
