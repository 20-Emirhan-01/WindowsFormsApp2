using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection(@"data source=C:\Users\cemh\Desktop\INTERNET PROGRAMCILIGI\VIZE-MIDTERM ODEVI\Proje\Veritabanı\DataBase");
            connection.Open();
            string query = "SELECT* FROM Ogrenci";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            SQLiteConnection connection = new SQLiteConnection(@"data source=C:\Users\cemh\Desktop\INTERNET PROGRAMCILIGI\VIZE-MIDTERM ODEVI\Proje\Veritabanı\DataBase");
            connection.Open();

            if (Equals(textBox1.Text, "") == true || Equals(textBox2.Text, "") == true || Equals(textBox3.Text, "") == true || Equals(textBox4.Text, "") == true || Equals(textBox5.Text, "") == true || Equals(textBox6.Text, "") == true)
            {
            }
            else {

                string query = string.Format("INSERT INTO Ogrenci(ID,AdSoyad,KayitTarihi,OgrenciNo,DTarih,Bolum) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", textBox1.Text.ToString(), textBox2.Text.ToString(), textBox3.Text.ToString(), textBox4.Text.ToString(), textBox5.Text.ToString(), textBox6.Text.ToString());
                Console.WriteLine(query);
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection(@"data source=C:\Users\cemh\Desktop\INTERNET PROGRAMCILIGI\VIZE-MIDTERM ODEVI\Proje\Veritabanı\DataBase");
            connection.Open();

            if (Equals(textBox7.Text, "") == true)
            {

            }
            else
            {

                string query = string.Format("DELETE FROM Ogrenci WHERE ID={0}", textBox7.Text.ToString());
                Console.WriteLine(query);
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {


            SQLiteConnection connection1 = new SQLiteConnection(@"data source=C:\Users\cemh\Desktop\INTERNET PROGRAMCILIGI\VIZE-MIDTERM ODEVI\Proje\Veritabanı\DataBase");
            connection1.Open();
            string query1 = string.Format("UPDATE Ogrenci SET AdSoyad = '{0}' WHERE ID = {1}", textBox10.Text.ToString(), textBox8.Text.ToString()); ;
            Console.WriteLine(query1);
            SQLiteCommand command1 = new SQLiteCommand(query1, connection1);
            command1.ExecuteNonQuery();

            SQLiteConnection connection2 = new SQLiteConnection(@"data source=C:\Users\cemh\Desktop\INTERNET PROGRAMCILIGI\VIZE-MIDTERM ODEVI\Proje\Veritabanı\DataBase");
            connection2.Open();
            string query2 = string.Format("UPDATE Ogrenci SET KayitTarihi = '{0}' WHERE ID = {1}", textBox11.Text.ToString(), textBox8.Text.ToString()); ;
            Console.WriteLine(query2);
            SQLiteCommand command2 = new SQLiteCommand(query2, connection2);
            command2.ExecuteNonQuery();

            SQLiteConnection connection3 = new SQLiteConnection(@"data source=C:\Users\cemh\Desktop\INTERNET PROGRAMCILIGI\VIZE-MIDTERM ODEVI\Proje\Veritabanı\DataBase");
            connection3.Open();
            string query3 = string.Format("UPDATE Ogrenci SET OgrenciNo = '{0}' WHERE ID = {1}", textBox12.Text.ToString(), textBox8.Text.ToString()); ;
            Console.WriteLine(query3);
            SQLiteCommand command3 = new SQLiteCommand(query3, connection3);
            command3.ExecuteNonQuery();

            SQLiteConnection connection4 = new SQLiteConnection(@"data source=C:\Users\cemh\Desktop\INTERNET PROGRAMCILIGI\VIZE-MIDTERM ODEVI\Proje\Veritabanı\DataBase");
            connection4.Open();
            string query4 = string.Format("UPDATE Ogrenci SET DTarih = '{0}' WHERE ID = {1}", textBox13.Text.ToString(), textBox8.Text.ToString()); ;
            Console.WriteLine(query4);
            SQLiteCommand command4 = new SQLiteCommand(query4, connection4);
            command4.ExecuteNonQuery();

            SQLiteConnection connection5 = new SQLiteConnection(@"data source=C:\Users\cemh\Desktop\INTERNET PROGRAMCILIGI\VIZE-MIDTERM ODEVI\Proje\Veritabanı\DataBase");
            connection5.Open();
            string query5 = string.Format("UPDATE Ogrenci SET Bolum = '{0}' WHERE ID = {1}", textBox14.Text.ToString(), textBox8.Text.ToString()); ;
            Console.WriteLine(query5);
            SQLiteCommand command5 = new SQLiteCommand(query5, connection5);
            command5.ExecuteNonQuery();

            SQLiteConnection connection = new SQLiteConnection(@"data source=C:\Users\cemh\Desktop\INTERNET PROGRAMCILIGI\VIZE-MIDTERM ODEVI\Proje\Veritabanı\DataBase");
            connection.Open();
            string query = string.Format("UPDATE Ogrenci SET ID = '{0}' WHERE ID = {1}", textBox9.Text.ToString(), textBox8.Text.ToString()); ;
            Console.WriteLine(query);
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            SQLiteDataAdapter adapter1 = new SQLiteDataAdapter(command1);
            SQLiteDataAdapter adapter2 = new SQLiteDataAdapter(command2);
            SQLiteDataAdapter adapter3 = new SQLiteDataAdapter(command3);
            SQLiteDataAdapter adapter4 = new SQLiteDataAdapter(command4);
            SQLiteDataAdapter adapter5 = new SQLiteDataAdapter(command5);
            adapter.Fill(dt);
            adapter1.Fill(dt);
            adapter2.Fill(dt);
            adapter3.Fill(dt);
            adapter4.Fill(dt);
            adapter5.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    

        private void button8_Click(object sender, EventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection(@"data source=C:\Users\cemh\Desktop\INTERNET PROGRAMCILIGI\VIZE-MIDTERM ODEVI\Proje\Veritabanı\DataBase");
            connection.Open();
            string query = string.Format("SELECT* FROM Ogrenci WHERE ID={0}", textBox8.Text.ToString());
            Console.WriteLine(query);
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

    }
}
