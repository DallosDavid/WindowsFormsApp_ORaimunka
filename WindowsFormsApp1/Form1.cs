using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=ajandek; Uid=root; Pwd=;");
            conn.Open();

            this.FormClosed += (sender, args) =>
            {
                if (conn != null)
                {
                    conn.Close();
                }

            };
            
            AdatBetoltes();



        }

        

        private void AdatBetoltes()
        {
            string sql = @"
SELECT id,nev,uzlet
from ajandek
ORDER BY nev
";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            using (var reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string nev = reader.GetString("nev");
                    string uzlet;
                    try
                    {
                        uzlet= reader.GetString("uzlet");
                    }
                    catch (SqlNullValueException ex)
                    {
                        uzlet = null;                        
                    }
                    var ajandek = new Ajandek(id, nev, uzlet);
                    listBox1.Items.Add(ajandek);
                }
            }

                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxnev.Visible = true;
            textBoxuzlet.Visible = true;
            labelnev.Visible = true;
            labeluzlet.Visible = true;
            button2.Visible = true;
          



        }

        private void button2_Click(object sender, EventArgs e)
        {

            var nev = textBoxnev.Text;
            var uzlet = textBoxuzlet.Text;
            var felvesz = conn.CreateCommand();
            var id = listBox1.Items.Count + 1;
            var ajandek = new Ajandek(id,nev,uzlet);
            felvesz.CommandText = @"INSERT INTO ajandek (nev,uzlet) VALUES (@nev,@uzlet)";
            felvesz.Parameters.AddWithValue("@nev", nev);
            felvesz.Parameters.AddWithValue("@uzlet", uzlet);
            int sorok = felvesz.ExecuteNonQuery();
            listBox1.Items.Add(ajandek);
            listBox1.Update();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Update();
            var delet = conn.CreateCommand();
            delet.CommandText = @"DELETE FROM `ajandek` WHERE `ajandek`.`id` = @id";
            Ajandek p = (Ajandek)listBox1.SelectedItem;
            int id = p.Id;
            delet.Parameters.AddWithValue("@id", id);
            int erint = delet.ExecuteNonQuery();
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            



        }
    }
}
