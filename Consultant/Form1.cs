using System.Data;
using System.Data.SqlClient;
namespace Consultant
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=DESKTOP-1BNSHCE\SQLEXPRESS;Initial Catalog=Users;Integrated Security=True";

        int selectedRow;

        SqlCommand sqlCommand;

        SqlDataReader reader;

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Name", "Имя");
            dataGridView1.Columns.Add("SecondName", "Фамилия");
            dataGridView1.Columns.Add("Patronymic", "Отчество");
            dataGridView1.Columns.Add("Phone", "Номер телефона");
            dataGridView1.Columns.Add("Passport", "Серия и номер пасспорта");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dataGridView, IDataRecord record)
        {
            dataGridView.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dataGridView)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                dataGridView.Rows.Clear();

                string sqlQuery = $"SELECT * FROM Users";

                sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

                reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    ReadSingleRow(dataGridView, reader);
                }
                reader.Close();
            }
        }

        public void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == String.Empty)
            {
                dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted;
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var name = textBox_Name.Text;
            var secondName = textBox_SecondName.Text;
            var patronymic = textBox_Patronymic.Text;
            var phone = textBox_Phone.Text;
            var passport = textBox_Passport.Text;

            dataGridView1.Rows[selectedRowIndex].SetValues(name, secondName, patronymic, phone, passport);
            dataGridView1.Rows[selectedRowIndex].Cells[6].Value = RowState.Modified;
        }
        public void Update()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                for(int index = 0; index < dataGridView1.Rows.Count; index++)
                {
                    var rowState = (RowState)dataGridView1.Rows[index].Cells[6].Value;

                    if (rowState == RowState.Existed)
                    {
                        continue;
                    }
                    if (rowState == RowState.Deleted)
                    {
                        int id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                        string sqlQuery = $"DELETE FROM Users WHERE Id = {id}";

                        sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    }

                    if(rowState == RowState.Modified)
                {

                    var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var secondName = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var patronymic = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var phone = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var passport = dataGridView1.Rows[index].Cells[5].Value.ToString();

                    string changeQuery = $"UPDATE Users SET Name = '{name}', SecondName = '{secondName}', Patronymic = '{patronymic}', Phone = '{phone}', Passport = '{passport}'";

                    var command = new SqlCommand(changeQuery, sqlConnection);
                    command.ExecuteNonQuery();

                }
                }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox_Name.Text = row.Cells[1].Value.ToString();
                textBox_SecondName.Text = row.Cells[2].Value.ToString();
                textBox_Patronymic.Text = row.Cells[3].Value.ToString();
                textBox_Phone.Text = row.Cells[4].Value.ToString();
                textBox_Passport.Text = row.Cells[5].Value.ToString();
            }
        }

        private void button_AddUser_Click(object sender, EventArgs e)
        {
            Form_AddUser form_AddUser = new Form_AddUser();
            form_AddUser.Show();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void button_DeleteUser_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void button_ChangeUser_Click(object sender, EventArgs e)
        {
            Change();
        }
    }
}