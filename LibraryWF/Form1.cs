using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.IO.Ports;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Drawing;

namespace LibraryWF
{
    public partial class Form1 : Form
    {
        private string nameDB;
        private SQLiteConnection connection;
        private SQLiteCommand command;
        public Form1()
        {
            InitializeComponent();
            command = new SQLiteCommand();
            nameDB = "Lybrary.sqlite";
            connection = new SQLiteConnection($"Data Source={nameDB};Version=3;");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(nameDB))
            {
                SQLiteConnection.CreateFile(nameDB);
            }

            try
            {
                connection.Open();
                this.Text = "Библиотека. Ссоединение с базой данных: УСТАНОВЛЕННО";
                command.Connection = connection;
                command.CommandText = "CREATE TABLE IF NOT EXISTS Catalog (id INTEGER PRIMARY KEY AUTOINCREMENT, PlaceNumber int, Author varchar(100), BookTitle varchar(100))";
                command.ExecuteNonQuery();
                command.CommandText = "SELECT * FROM Catalog";
                DataTable read = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(read);
                foreach (DataRow row in read.Rows)
                {
                    comboBoxListBooks.Items.Add($"\"{row.Field<string>("BookTitle")}\"    {row.Field<string>("Author")}    №{row.Field<int>("PlaceNumber")}");
                }
            }
            catch
            {
                this.Text = "Библиотека. Соединение с базой данных: ОТСУТСВУЕТ";
                MessageBox.Show("Не удалось подключится к базе данных!");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxNumber.Text == "" | textBoxAuthor.Text == "" | textBoxTitle.Text == "")
            {
                MessageBox.Show("Все поля обязательны к заполнению!");
            }
            else
            {
                try
                {
                    command.CommandText = $"INSERT INTO Catalog (PlaceNumber, Author, BookTitle) values ('{textBoxNumber.Text}', '{textBoxAuthor.Text}', '{textBoxTitle.Text}');";
                    command.ExecuteNonQuery();
                    textBoxAuthor.Clear();
                    textBoxNumber.Clear();
                    textBoxTitle.Clear();
                    MessageBox.Show("Произведение успешно добавлено");
                }
                catch
                {
                    MessageBox.Show("Сединение с базой данных отсутствует!");
                }
            }
        }

        private void textBoxAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) | e.KeyChar == '' | e.KeyChar == '-' | e.KeyChar == ' ')
            {
                return;
            }
            else
            {
                MessageBox.Show("В имени не может быть чисел и символов!");
                e.Handled = true;
            }
        }

        private void textBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | e.KeyChar == '')
            {
                return;
            }
            else
            {
                MessageBox.Show("Только числовой ввод!");
                e.Handled = true;
            }
        }

        private void comboBoxListBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                DialogResult dialogResult = MessageBox.Show($"Вы уверны, что хотите удалить это произведение:\n\n{comboBoxListBooks.Text}", "Предупреждение:", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Regex regex = new Regex("[№][0-9]+");
                    MatchCollection matches = regex.Matches(comboBoxListBooks.SelectedItem.ToString());
                    string _tmp = matches[0].Value.Remove(0, 1);
                    int _num = Convert.ToInt32(_tmp);
                    command.CommandText = $"DELETE  FROM Catalog WHERE PlaceNumber={_num}";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Удаление прошло успешно");
                    comboBoxListBooks.Text = "Выбрать призведение";
                }
            }
            else
            {
                MessageBox.Show("Сединение с базой данных отсутствует!");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void buttonNameDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            if (textBoxNameDelete.Text == "")
            {
                MessageBox.Show("Произведение не выбрано!");
            }
            else
            {
                dialogResult = MessageBox.Show($"Вы уверны, что хотите удалить это произведение:\n\n{textBoxNameDelete.Text}", "Предупреждение:", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    command.CommandText = $"DELETE  FROM Catalog WHERE BookTitle='{textBoxNameDelete.Text}'";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Удаление прошло успешно");
                    textBoxNameDelete.Text = "";
                }
            }
        }

        private void buttonOnOf_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                buttonOnOf.BackColor = Color.Red;
                labelAddToLibrary.Visible = false;
                labelAuthor.Visible = false;
                labelNumber.Visible = false;
                labelNameDelete.Visible = false;
                labelTitle.Visible = false;
                labelToDelete.Visible = false;
                textBoxAuthor.Visible = false;
                textBoxNumber.Visible = false;
                textBoxTitle.Visible = false;   
                textBoxNameDelete.Visible = false;
                comboBoxListBooks.Visible = false;
                buttonAdd.Visible = false;
                buttonUpdate.Visible = false;
                buttonNameDelete.Visible = false;
                this.Text = "Библиотека. Соединение с базой данных: ОТСУТСТВУЕТ";
            }
            else if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                buttonOnOf.BackColor = Color.ForestGreen;
                labelAddToLibrary.Visible = true;
                labelAuthor.Visible = true;
                labelNumber.Visible = true;
                labelNameDelete.Visible = true;
                labelTitle.Visible = true;
                labelToDelete.Visible = true;
                textBoxAuthor.Visible = true;
                textBoxNumber.Visible = true;
                textBoxTitle.Visible = true;
                textBoxNameDelete.Visible = true;
                comboBoxListBooks.Visible = true;
                buttonAdd.Visible = true;
                buttonUpdate.Visible = true;
                buttonNameDelete.Visible = true;
                this.Text = "Библиотека. Соединение с базой данных: УСТАНОВЛЕННО";
            }
        }
    }
}
