using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using AutoService.Models;

namespace AutoService.Data
{
    public class CarRepository
    {
        public List<Car> GetAll()
        {
            var list = new List<Car>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "SELECT a.ID_автомобиля, a.Марка, a.Модель, a.Год_выпуска, a.Гос_номер, " +
                    "       a.ID_клиента, k.Фамилия + ' ' + k.Имя AS КлиентФИО " +
                    "FROM Автомобили a " +
                    "INNER JOIN Клиенты k ON a.ID_клиента = k.ID_клиента " +
                    "ORDER BY a.Марка, a.Модель",
                    conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Car
                        {
                            Id           = reader.GetInt32(0),
                            Brand        = reader.GetString(1),
                            Model        = reader.GetString(2),
                            Year         = reader.GetInt32(3),
                            LicensePlate = reader.GetString(4),
                            ClientId     = reader.GetInt32(5),
                            ClientName   = reader.GetString(6)
                        });
                    }
                }
            }
            return list;
        }

        public List<Car> Search(string searchText)
        {
            var list = new List<Car>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "SELECT a.ID_автомобиля, a.Марка, a.Модель, a.Год_выпуска, a.Гос_номер, " +
                    "       a.ID_клиента, k.Фамилия + ' ' + k.Имя AS КлиентФИО " +
                    "FROM Автомобили a " +
                    "INNER JOIN Клиенты k ON a.ID_клиента = k.ID_клиента " +
                    "WHERE a.Марка LIKE @Search OR a.Гос_номер LIKE @Search " +
                    "ORDER BY a.Марка, a.Модель",
                    conn);
                cmd.Parameters.AddWithValue("@Search", "%" + searchText + "%");
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Car
                        {
                            Id           = reader.GetInt32(0),
                            Brand        = reader.GetString(1),
                            Model        = reader.GetString(2),
                            Year         = reader.GetInt32(3),
                            LicensePlate = reader.GetString(4),
                            ClientId     = reader.GetInt32(5),
                            ClientName   = reader.GetString(6)
                        });
                    }
                }
            }
            return list;
        }

        public void Add(Car car)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "INSERT INTO Автомобили (Марка, Модель, Год_выпуска, Гос_номер, ID_клиента) " +
                    "VALUES (@Brand, @Model, @Year, @LicensePlate, @ClientId)",
                    conn);
                cmd.Parameters.AddWithValue("@Brand",        car.Brand);
                cmd.Parameters.AddWithValue("@Model",        car.Model);
                cmd.Parameters.AddWithValue("@Year",         car.Year);
                cmd.Parameters.AddWithValue("@LicensePlate", car.LicensePlate);
                cmd.Parameters.AddWithValue("@ClientId",     car.ClientId);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Car car)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "UPDATE Автомобили " +
                    "SET Марка=@Brand, Модель=@Model, Год_выпуска=@Year, " +
                    "    Гос_номер=@LicensePlate, ID_клиента=@ClientId " +
                    "WHERE ID_автомобиля=@Id",
                    conn);
                cmd.Parameters.AddWithValue("@Brand",        car.Brand);
                cmd.Parameters.AddWithValue("@Model",        car.Model);
                cmd.Parameters.AddWithValue("@Year",         car.Year);
                cmd.Parameters.AddWithValue("@LicensePlate", car.LicensePlate);
                cmd.Parameters.AddWithValue("@ClientId",     car.ClientId);
                cmd.Parameters.AddWithValue("@Id",           car.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "DELETE FROM Автомобили WHERE ID_автомобиля=@Id",
                    conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Car> GetReport()
        {
            var list = new List<Car>();
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "SELECT k.Фамилия + ' ' + k.Имя AS Клиент, k.Телефон, " +
                    "       a.Марка, a.Модель, a.Год_выпуска, a.Гос_номер " +
                    "FROM Клиенты k " +
                    "LEFT JOIN Автомобили a ON k.ID_клиента = a.ID_клиента " +
                    "ORDER BY k.Фамилия, k.Имя, a.Марка",
                    conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Car
                        {
                            ClientName   = reader.GetString(0),
                            Brand        = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                            Model        = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                            Year         = reader.IsDBNull(4) ? 0 : reader.GetInt32(4),
                            LicensePlate = reader.IsDBNull(5) ? string.Empty : reader.GetString(5)
                        });
                    }
                }
            }
            return list;
        }
    }
}
