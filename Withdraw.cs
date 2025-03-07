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
    public partial class Withdraw: Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gunes\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        string Acc = Login.AccNumber;
        int bal;
        private void getBalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where AccNum='" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            balancelbl.Text = dt.Rows[0][0].ToString() + " TL";
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }
        private void addtransaction()
        {
            string trType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "','" + trType + "','" + amounttxt.Text + "','" + DateTime.Now.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void Withdraw_Load(object sender, EventArgs e)
        {
            getBalance();
        }

        int newbalance;

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (amounttxt.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else if (Convert.ToInt32(amounttxt.Text) <= 0)
            {
                MessageBox.Show("Enter a Valid Amount!");
            }
            else if (Convert.ToInt32(amounttxt.Text) > bal)
            {
                MessageBox.Show("Insufficient Balance!");
            }
            else
            {
                newbalance = bal - Convert.ToInt32(amounttxt.Text);
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance =" + newbalance + " where AccNum = '" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(amounttxt.Text + "TL Success Withdrawn From Your Account!");
                    Con.Close();
                    addtransaction();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                } 
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void balancelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
