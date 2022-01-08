using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop_App.Models;
using MySql.Data.MySqlClient;

namespace Desktop_App.Repository
{
    class ScheduleRepository
    {

        private Database Database;

        public ScheduleRepository (Database Database)
        {
            this.Database = Database;
        }

        public List<Schedule> FindAll ()
        {
            List<Schedule> schedule = new List<Schedule>();
            Database.ConnectToDatabase();
            string query = "SELECT orar.id, firstname, lastname, phone, adresa, data " +
                "FROM orar " +
                "LEFT JOIN antrenor " +
                "ON orar.id_antrenor = antrenor.id " +
                "LEFT JOIN locatie " +
                "ON orar.id_locatie = locatie.id";
            MySqlDataReader reader;
            try
            {
                using (MySqlCommand command = new MySqlCommand(query, Database.GetConnection()))
                {
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Schedule appointment = new Schedule(reader.GetInt32(0) ,new Antrenor(reader.GetString(1), 
                                reader.GetString(2), reader.GetString(3)), new Locatie(reader.GetString(4)), 
                                reader.GetDateTime(5).Date);
                            schedule.Add(appointment);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Database.disconnectFromDatabase();
            return schedule;
        }

        public bool updateDate (DateTime date, int Id)
        {
            Database.ConnectToDatabase();
            string query = "UPDATE orar SET orar.data=@date WHERE orar.id=@id";
            try
            {
                using (MySqlCommand command = new MySqlCommand(query, Database.GetConnection()))
                {
                    var caca = date.Year + "-" + date.Month + "-" + date.Day;
                    command.Parameters.Add("@date", MySqlDbType.Date).Value = date.Year + "-" + date.Month + "-" + date.Day;
                    command.Parameters.Add("@id", MySqlDbType.Int32).Value = Id;
                    command.ExecuteNonQuery();
                }
                Database.disconnectFromDatabase();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool deleteDate (int Id)
        {
            Database.ConnectToDatabase();
            string query = "DELETE FROM orar WHERE id=@id";
            try
            {
                using (MySqlCommand command = new MySqlCommand(query, Database.GetConnection()))
                {
                    command.Parameters.Add("@id", MySqlDbType.Int32).Value = Id;
                    command.ExecuteNonQuery();
                }
                Database.disconnectFromDatabase();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}
