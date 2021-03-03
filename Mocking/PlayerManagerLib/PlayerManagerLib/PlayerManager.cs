﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PlayerManagerLib
{
    public interface IPlayerMapper

    {

        bool IsPlayerNameExistsInDb(string name);

        void AddNewPlayerIntoDb(string name);

    }
    public class PlayerManager
    {
    }

    public class PlayerMapper : IPlayerMapper

    {

        private readonly string _connectionString =

        "Data Source=(local);Initial Catalog=GameDB;Integrated Security=True";

        public bool IsPlayerNameExistsInDb(string name)

        {

            using (SqlConnection connection = new SqlConnection(_connectionString))

            {

                connection.Open();

                using (SqlCommand command = connection.CreateCommand())

                {

                    command.CommandText = "SELECT count(*) FROM Player WHERE 'Name' = @name";

                    command.Parameters.AddWithValue("@name", name);

                    // Get the number of player with this name

                    var existingPlayersCount = (int)command.ExecuteScalar();

                    // Result is 0, if no player exists, or 1, if a player already exists

                    return existingPlayersCount > 0;

                }

            }

        }

        public void AddNewPlayerIntoDb(string name)

        {

            using (SqlConnection connection = new SqlConnection(_connectionString))

            {

                connection.Open();

                using (SqlCommand command = connection.CreateCommand())

                {

                    command.CommandText = "INSERT INTO Player ([Name]) VALUES (@name)";

                    command.Parameters.AddWithValue("@name", name);

                    command.ExecuteNonQuery();

                }

            }

        }

    }

    public class Player

    {

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Country { get; private set; }

        public int NoOfMatches { get; private set; }

        public Player(string name, int age, string country, int noOfMatches)

        {

            Name = name;

            Age = age;

            Country = country;

            NoOfMatches = noOfMatches;

        }

        public static Player RegisterNewPlayer(string name, IPlayerMapper playerMapper = null)

        {

            // If a PlayerMapper was not passed in, use a real one.

            // This allows us to pass in a "mock" PlayerMapper (for testing),

            // but use a real PlayerMapper, when running the program.

            if (playerMapper == null)

            {

                playerMapper = new PlayerMapper();

            }

            if (string.IsNullOrWhiteSpace(name))

            {

                throw new ArgumentException("Player name can’t be empty.");

            }

            // Throw an exception if there is already a player with this name in the database.

            if (playerMapper.IsPlayerNameExistsInDb(name))

            {

                throw new ArgumentException("Player name already exists.");

            }

            // Add the player to the database.

            playerMapper.AddNewPlayerIntoDb(name);

            return new Player(name, 23, "India", 30);

        }

    }
}
