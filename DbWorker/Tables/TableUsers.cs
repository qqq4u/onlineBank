using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DBEntities;
using DbWorker.Tools;
using ExceptionEntities;

namespace DbWorker.Tables
{
    public class TableUsers
    {
        public User GetUserByLoginPassword(string login, string password)
        {
            try
            {
                User user = null;

                using (MySqlConnection mySqlConnection = DbConnection.GetConnection())
                {
                    mySqlConnection.Open();
                    using (MySqlCommand mySqlCommand = mySqlConnection.CreateCommand())
                    {
                        mySqlCommand.CommandText = $"SELECT * FROM `users` WHERE `login`='{login}' AND `password`='{password}'";
                        using (MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader())
                        {
                            if (mySqlDataReader.HasRows == true)
                            {
                                mySqlDataReader.Read();

                                user = new User()
                                {
                                    Id = mySqlDataReader.GetInt32("id"),
                                    Name = mySqlDataReader.GetString("name"),
                                    Login = mySqlDataReader.GetString("login"),
                                    Password = mySqlDataReader.GetString("password")
                                };
                            }
                            else
                            {
                                throw new WrongLoginPasswordException();
                            }
                        }
                    }
                }

                return user;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private bool IsLoginExists(string login)
        {
            try
            {

                using (MySqlConnection mySqlConnection = DbConnection.GetConnection())
                {
                    mySqlConnection.Open();
                    using (MySqlCommand mySqlCommand = mySqlConnection.CreateCommand())
                    {
                        mySqlCommand.CommandText = $"SELECT * FROM `users` WHERE `login`='{login}'";
                        using (MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader())
                        {
                            if (mySqlDataReader.HasRows == true)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }s
                        }
                    }
                }

              
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public User RegisterNewUser(string name, string login, string password)
        {
            try
            {
                User registeredUser = null;

                using (MySqlConnection mySqlConnection = DbConnection.GetConnection())
                {
                    mySqlConnection.Open();
                    using (MySqlCommand mySqlCommand = mySqlConnection.CreateCommand())
                    {
                        if (!IsLoginExists(login))
                        {
                            mySqlCommand.CommandText = $"INSERT `users` (name,login,password) VALUES ('{name}','{login}','{password}')";
                            mySqlCommand.ExecuteNonQuery();

                            mySqlCommand.CommandText = "SELECT * FROM `users` ORDER BY id DESC LIMIT 1;";
                            using (MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader())
                            {
                                mySqlDataReader.Read();
                                registeredUser = new User()
                                {
                                    Id = mySqlDataReader.GetInt32("id"),
                                    Name = mySqlDataReader.GetString("name"),
                                    Login = mySqlDataReader.GetString("login"),
                                    Password = mySqlDataReader.GetString("password")
                                };
                            }

                        }
                        else
                        {
                            throw new LoginIsAlreadyUsedException();
                        }

                    }
                }

                return registeredUser;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
