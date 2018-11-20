using Dapper;
using System.Data.SQLite;


namespace MyOpenCommerce
{
    public partial class formLogin : Form
    {
        private SQLiteConnection sqlConnection = new SQLiteConnection("Data Source=database.db;Version=3;");
        public formLogin()
        {
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
                InitializeComponent();
            else
                MessageBox.Show("Error on connect to Database.");

            this.Load += delegate
            {
                this.CenterToScreen();
            };
            
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            var Person = sqlConnection.Query("SELECT * FROM LOGIN WHERE username=@user AND password=@pass", new { user=textBox_Username.Text,pass=textBox_Password.Text }).FirstOrDefault();
            if(Person != null)
            {
                MessageBox.Show($"Welcome {Person.username}!","Login");
            }
            else { MessageBox.Show("Error on login with these credentials.","Login"); }
        }
    }
}
