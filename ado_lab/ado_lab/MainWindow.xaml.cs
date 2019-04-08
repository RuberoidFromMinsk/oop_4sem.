using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace ado_lab
{
    public partial class MainWindow : Window
    {
        private readonly DataTable _studTable = new DataTable();
        private readonly SqlConnection _newcon = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ConnectionString);

        public MainWindow()
        {
            InitializeComponent();
        }
//Student
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            int group;
            if (int.TryParse(GroupBox.Text, out group))
            { }
            else
                MessageBox.Show("You have entered a wrong data");


            if(GroupBox.Text == "" || StudentNameBox.Text == "" || HometownBox.Text == "")
            {
                MessageBox.Show("Fill in all data and continue");
            }
            else
            {
                string ConnectionString = @"Data Source=DESKTOP-R0R983R;Initial Catalog=ADO.NET;Integrated Security=True";
                using (SqlConnection cn = new SqlConnection(ConnectionString))
                {
                    cn.Open();
                    SqlTransaction transaction = cn.BeginTransaction();
                    SqlCommand command = cn.CreateCommand();
                    command.Transaction = transaction;
                    try
                    {
                        command.CommandText = $"INSERT INTO STUDENT (IDGROUP, NAME, HOMETOWN) VALUES ({group}, '{name}', '{hometown}');";
                        command.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Object has been added");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        transaction.Rollback();
                    }
                }

                GroupBox.Clear();
                StudentNameBox.Clear();
                HometownBox.Clear();
            }
        }

//Show
        private async void Show_Button_Click(object sender, RoutedEventArgs e)
        {
            _studTable.Clear();
            await _newcon.OpenAsync();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from STUDENT", _newcon);
            adapter.Fill(_studTable);
            User_Grid.DataContext = _studTable.DefaultView;
            _newcon.Close();
        }

//Update
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            int oldgroup;
            if (int.TryParse(NewGroupBox.Text, out oldgroup))
            { }
            else
                MessageBox.Show("You have entered a wrong data");

            string ConnectionString = @"Data Source=DESKTOP-R0R983R;Initial Catalog=ADO.NET;Integrated Security=True";
            string sqlExpression = $"UPDATE STUDENT SET IDGROUP = {oldgroup} WHERE NAME = '{nameupdate}';";

            using (SqlConnection cn = new SqlConnection(ConnectionString))
            {
                cn.Open();
                SqlCommand command = new SqlCommand(sqlExpression, cn);
                command.BeginExecuteNonQuery();
                MessageBox.Show("Object has been updated");
                cn.Close();
            }
            NewGroupBox.Clear();
            NameUpdate.Clear();
        }
//Delete
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            string ConnectionString = @"Data Source=DESKTOP-R0R983R;Initial Catalog=ADO.NET;Integrated Security=True";
            string sqlExpression = $"DELETE FROM STUDENT WHERE NAME = '{nameupdate}';";

            using (SqlConnection cn = new SqlConnection(ConnectionString))
            {
                cn.Open();
                SqlCommand command = new SqlCommand(sqlExpression, cn);
                command.BeginExecuteNonQuery();
                MessageBox.Show("Object has been deleted");
                cn.Close();
            }
        }
 //Sort

        private async void Sort_Click(object sender, RoutedEventArgs e)
        {
            _studTable.Clear();
            await _newcon.OpenAsync();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM STUDENT ORDER BY IDGROUP;", _newcon);
            adapter.Fill(_studTable);
            User_Grid.DataContext = _studTable.DefaultView;
            _newcon.Close();
        }

//Query
        private async void Query_Click(object sender, RoutedEventArgs e)
        {
            _studTable.Clear();
            if (QueryBox.Text == "")
                MessageBox.Show("Заполните поле");
            else
            {
                await _newcon.OpenAsync();
                SqlDataAdapter adapter = new SqlDataAdapter(QueryBox.Text, _newcon);
                adapter.Fill(_studTable);
                User_Grid.DataContext = _studTable.DefaultView;
                _newcon.Close();
            }

            QueryBox.Clear();
        }

        public static string name;
        private void StudentNameBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            name = StudentNameBox.Text;
        }

        public static string hometown;
        private void HometownBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            hometown = HometownBox.Text;
        }

        public static string nameupdate;
        private void NameUpdate_TextChanged(object sender, TextChangedEventArgs e)
        {
            nameupdate = NameUpdate.Text;
        }
    }
}
