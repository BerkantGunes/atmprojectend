using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMproject
{
    public partial class FastCash: Form
    {
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

        public FastCash()
        {
            InitializeComponent();
        }


        private void backbtn_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }

        private void FastCash_Load(object sender, EventArgs e)
        {
            getBalance();
        }

        private void addtransaction1()
        {
            string trType = "Deposit";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "','" + trType + "','" + 200 + "','" + DateTime.Now.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void addtransaction2()
        {
            string trType = "Deposit";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "','" + trType + "','" + 500 + "','" + DateTime.Now.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void addtransaction3()
        {
            string trType = "Deposit";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "','" + trType + "','" + 1000 + "','" + DateTime.Now.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void addtransaction4()
        {
            string trType = "Deposit";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "','" + trType + "','" + 5000 + "','" + DateTime.Now.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void addtransaction5()
        {
            string trType = "Deposit";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "','" + trType + "','" + 10000 + "','" + DateTime.Now.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void addtransaction6()
        {
            string trType = "Deposit";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values('" + Acc + "','" + trType + "','" + 20000 + "','" + DateTime.Now.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void twohundredbtn_Click(object sender, EventArgs e)
        {
            if(bal<200)
            {
                MessageBox.Show("Insufficient Balance!");
            }
            else
            {
                int newbalance = bal - 200;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance =" + newbalance + " where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("200 TL Succesfully Withdrawn From Your Account!");
                    Con.Close();
                    addtransaction1();
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

        private void fivehundredbtn_Click(object sender, EventArgs e)
        {
            if (bal < 500)
            {
                MessageBox.Show("Insufficient Balance!");
            }
            else
            {
                int newbalance = bal - 500;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance =" + newbalance + " where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("500 TL Succesfully Withdrawn From Your Account!");
                    Con.Close();
                    addtransaction2();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void onethousandbtn_Click(object sender, EventArgs e)
        {
            if (bal < 1000)
            {
                MessageBox.Show("Insufficient Balance!");
            }
            else
            {
                int newbalance = bal - 1000;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance =" + newbalance + " where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("1000 TL Succesfully Withdrawn From Your Account!");
                    Con.Close();
                    addtransaction3();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void fivethousandbtn_Click(object sender, EventArgs e)
        {
            if (bal < 5000)
            {
                MessageBox.Show("Insufficient Balance!");
            }
            else
            {
                int newbalance = bal - 5000;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance =" + newbalance + " where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("5000 TL Succesfully Withdrawn From Your Account!");
                    Con.Close();
                    addtransaction4();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void tenthousandbtn_Click(object sender, EventArgs e)
        {
            if (bal < 10000)
            {
                MessageBox.Show("Insufficient Balance!");
            }
            else
            {
                int newbalance = bal - 10000;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance =" + newbalance + " where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("10000 TL Succesfully Withdrawn From Your Account!");
                    Con.Close();
                    addtransaction5();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void twentythousandbtn_Click(object sender, EventArgs e)
        {
            if (bal < 20000)
            {
                MessageBox.Show("Insufficient Balance!");
            }
            else
            {
                int newbalance = bal - 20000;
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance =" + newbalance + " where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("20000 TL Succesfully Withdrawn From Your Account!");
                    Con.Close();
                    addtransaction6();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
