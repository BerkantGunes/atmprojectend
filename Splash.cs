﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMproject
{
    public partial class Splash: Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        int starting = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            starting += 1;
            myprogress.Value = starting;
            
            percantage.Text = "" + starting;
            if(myprogress.Value != 100)
            {
                myprogress.Value += 1;
                
            }
            else
            {
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
