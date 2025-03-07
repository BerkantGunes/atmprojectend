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
    public partial class Deposit: Form
    {
        public Deposit()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gunes\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        string Acc = Login.AccNumber;
        private void addtransaction()
        {
            string trType = "Deposit";
            try
            {
                Con.Open();
                string query = "insert into TransactionTbl values('"+Acc+"','"+trType+"','"+depoamttxt.Text+"','"+DateTime.Now.ToString()+"')";
                SqlCommand cmd = new SqlCommand(query,Con);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void loginbtn_Click(object sender, EventArgs e)
        {
            if(depoamttxt.Text == "" || Convert.ToInt32(depoamttxt.Text) <= 0)
            {
                MessageBox.Show("Enter the Amount to Deposit!");
            }
            else
            {
                
                newbalance = oldbalance + Convert.ToInt32(depoamttxt.Text);
                try
                {
                    Con.Open();
                    string query = "update AccountTbl set Balance="+ newbalance +" where AccNum='"+Acc+"'";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(depoamttxt.Text + "TL Successfully Deposit!");
                    Con.Close();
                    addtransaction();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }
        int oldbalance,newbalance;
        private void getBalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTbl where AccNum='" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            oldbalance = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            getBalance();
        }
    }
}
