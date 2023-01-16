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
    public partial class Form3 : Form
    {
        public Form3()
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
            string query = "SELECT* FROM OkulYonetim";
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

            if (Equals(textBox1.Text, "") == true || Equals(textBox2.Text, "") == true || Equals(textBox3.Text, "") == true)
            {
            }
            else
            {
                string t1 = "Seçilmedi";
                if (radioButton1.Checked == true) {
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                     t1 = "11 İdare";
                }
                else if (radioButton2.Checked == true) {
                    radioButton1.Checked = false;
                    radioButton3.Checked = false;
                     t1 = "12 Öğretmen";
                }
                else if (radioButton3.Checked == true) {
                    radioButton2.Checked = false;
                    radioButton1.Checked = false;
                     t1 = "13 Öğrenci İşleri";
                }
                
                string query = string.Format("INSERT INTO OkulYonetim(ID,AdSoyad,Gorevi,YonetimTip) VALUES('{0}','{1}','{2}','{3}')", textBox1.Text.ToString(), textBox2.Text.ToString(), textBox3.Text.ToString(),t1);
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

                string query = string.Format("DELETE FROM OkulYonetim WHERE ID={0}", textBox7.Text.ToString());
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
            string query1 = string.Format("UPDATE OkulYonetim SET AdSoyad = '{0}' WHERE ID = {1}", textBox10.Text.ToString(), textBox8.Text.ToString()); ;
            Console.WriteLine(query1);
            SQLiteCommand command1 = new SQLiteCommand(query1, connection1);
            command1.ExecuteNonQuery();

            SQLiteConnection connection2 = new SQLiteConnection(@"data source=C:\Users\cemh\Desktop\INTERNET PROGRAMCILIGI\VIZE-MIDTERM ODEVI\Proje\Veritabanı\DataBase");
            connection2.Open();
            string query2 = string.Format("UPDATE OkulYonetim SET Görevi = '{0}' WHERE ID = {1}", textBox11.Text.ToString(), textBox8.Text.ToString()); ;
            Console.WriteLine(query2);
            SQLiteCommand command2 = new SQLiteCommand(query2, connection2);
            command2.ExecuteNonQuery();

            string t1 = "Seçilmedi";
            if (radioButton1.Checked == true)
            {
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                t1 = "11 İdare";
            }
            else if (radioButton2.Checked == true)
            {
                radioButton1.Checked = false;
                radioButton3.Checked = false;
                t1 = "12 Öğretmen";
            }
            else if (radioButton3.Checked == true)
            {
                radioButton2.Checked = false;
                radioButton1.Checked = false;
                t1 = "13 Öğrenci İşleri";
            }

            SQLiteConnection connection3 = new SQLiteConnection(@"data source=C:\Users\cemh\Desktop\INTERNET PROGRAMCILIGI\VIZE-MIDTERM ODEVI\Proje\Veritabanı\DataBase");
            connection3.Open();
            string query3 = string.Format("UPDATE OkulYonetim SET YonetimTip = '{0}' WHERE ID = {1}", t1, textBox8.Text.ToString()); ;
            Console.WriteLine(query3);
            SQLiteCommand command3 = new SQLiteCommand(query3, connection3);
            command3.ExecuteNonQuery();

            SQLiteConnection connection = new SQLiteConnection(@"data source=C:\Users\cemh\Desktop\INTERNET PROGRAMCILIGI\VIZE-MIDTERM ODEVI\Proje\Veritabanı\DataBase");
            connection.Open();
            string query = string.Format("UPDATE OkulYonetim SET ID = '{0}' WHERE ID = {1}", textBox9.Text.ToString(), textBox8.Text.ToString()); ;
            Console.WriteLine(query);
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            SQLiteDataAdapter adapter1 = new SQLiteDataAdapter(command1);
            SQLiteDataAdapter adapter2 = new SQLiteDataAdapter(command2);
          
            adapter.Fill(dt);
            adapter1.Fill(dt);
            adapter2.Fill(dt);
           
            dataGridView1.DataSource = dt;

        }


        private void button8_Click(object sender, EventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection(@"data source=C:\Users\cemh\Desktop\INTERNET PROGRAMCILIGI\VIZE-MIDTERM ODEVI\Proje\Veritabanı\DataBase");
            connection.Open();
            string query = string.Format("SELECT* FROM OkulYonetim WHERE ID={0}", textBox8.Text.ToString());
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
