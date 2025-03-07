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
    public partial class MiniStatement: Form
    {
        public MiniStatement()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gunes\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        string Acc = Login.AccNumber;
        private void populate()
        {
            Con.Open();
            string query = "select * from TransactionTbl where AccNum='"+Acc+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            minidgv.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void MiniStatement_Load(object sender, EventArgs e)
        {
            populate();
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
    }
}
