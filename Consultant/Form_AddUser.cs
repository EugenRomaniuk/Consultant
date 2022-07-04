using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Consultant
{
    public partial class Form_AddUser : Form
    {
        string connectionString = @"Data Source=DESKTOP-1BNSHCE\SQLEXPRESS;Initial Catalog=Users;Integrated Security=True";

        public Form_AddUser()
        {
            InitializeComponent();
        }

        private void button_AddUser_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                string sqlQuery = $"INSERT INTO Users (Name, SecondName, Patronymic, Phone, Passport) VALUES (@Name, @SecondName, @Patronymic, @Phone, @Passport)";

                SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);

                command.Parameters.AddWithValue("Name", textBox_Name.Text);
                command.Parameters.AddWithValue("SecondName", textBox_SecondName.Text);
                command.Parameters.AddWithValue("Patronymic", textBox_Patronymic.Text);
                command.Parameters.AddWithValue("Phone", textBox_Phone.Text);
                command.Parameters.AddWithValue("Passport", textBox_Passport.Text);

                if(command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Пользователь добавлен");
                }
                else
                {
                    MessageBox.Show("Ошибка");
                }
            }
        }
    }
}
