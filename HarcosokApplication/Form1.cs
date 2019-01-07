using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarcosokApplication
{
    public partial class Form1 : Form
    {



        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=harcosdb;Uid=root;Password=;");



        public Form1()
        {
            InitializeComponent();
            try
            {

                conn.Open();
              /*  var letrehozDB = conn.CreateCommand();
                letrehozDB.CommandText = @"CREATE DATABASE IF NOT EXISTS harcosdb";
                letrehozDB.ExecuteNonQuery();
*/
                

                var kapcsolodas1 = conn.CreateCommand();
                kapcsolodas1.CommandText = @"CREATE TABLE IF NOT EXISTS harcostable
                                            (id INTEGER AUTO_INCREMENT PRIMARY KEY,
                                            nev VARCHAR(64) NOT NULL UNIQUE,
                                            datum DATE NOT NULL
                                            )";
                kapcsolodas1.ExecuteNonQuery();

                var kapcsolodas2 = conn.CreateCommand();
                kapcsolodas2.CommandText = @"CREATE TABLE IF NOT EXISTS tulajdonsagok
                                        (id INTEGER AUTO_INCREMENT PRIMARY KEY, 
                                        nev VARCHAR(30) NOT NULL,
                                        leiras VARCHAR(70) NOT NULL,
                                        id_harcos INTEGER NOT NULL,
                                        FOREIGN KEY (id_harcos) REFERENCES harcostable(id)
                                        )";
                kapcsolodas2.ExecuteNonQuery();

                
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Kapcsolódási hiba: " + e);

            }
            conn.Close();
            
        }

        private void letrehozButton_Click_1(object sender, EventArgs e)
            {
                string nev = nevTextBox.Text;
                DateTime datum = DateTime.Now;

                /*  var ellenorzes = conn.CreateCommand();
                  ellenorzes.CommandText = "SELECT COUNT(*) FROM harcostable WHERE nev = @nev";
                  ellenorzes.Parameters.AddWithValue("@nev", nev);
                  var darab = (long)ellenorzes.ExecuteScalar();
                  if (darab != 0)
                  {
                      MessageBox.Show("A felhasználónév már létezik");

                  }*/

                var command = conn.CreateCommand();
                command.Parameters.AddWithValue("@nev", nev);
                command.Parameters.AddWithValue("@datum", datum);
                command.CommandText = "INSERT INTO harcosdb.harcostable (nev,datum) VALUES ('@nev','@datum')";
               
                conn.Close();


            }
       
    }
}
