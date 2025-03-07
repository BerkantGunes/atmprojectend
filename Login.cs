using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMproject
{
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.Show();
            this.Hide();
        }
        public static string AccNumber;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gunes\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        private void loginbtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AccountTbl where Accnum='"+accnumtxt.Text+"' and PIN = "+pintxt.Text+"", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                AccNumber = accnumtxt.Text;
                HOME home = new HOME();
                home.Show();
                this.Hide();
                Con.Close();
            } else
            {
                MessageBox.Show("Wrong Password Or PIN Code!");
            }
                Con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
