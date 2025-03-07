namespace ATMproject
{
    partial class Balance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.accnolbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.accnumlbl = new System.Windows.Forms.Label();
            this.balancelbl = new System.Windows.Forms.Label();
            this.backlbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.exitlbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 100);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // exitlbl
            // 
            this.exitlbl.AutoSize = true;
            this.exitlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exitlbl.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.exitlbl.Location = new System.Drawing.Point(725, 9);
            this.exitlbl.Name = "exitlbl";
            this.exitlbl.Size = new System.Drawing.Size(36, 36);
            this.exitlbl.TabIndex = 11;
            this.exitlbl.Text = "X";
            this.exitlbl.Click += new System.EventHandler(this.exitlbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(149, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // accnolbl
            // 
            this.accnolbl.AutoSize = true;
            this.accnolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.accnolbl.Location = new System.Drawing.Point(150, 227);
            this.accnolbl.Name = "accnolbl";
            this.accnolbl.Size = new System.Drawing.Size(197, 29);
            this.accnolbl.TabIndex = 5;
            this.accnolbl.Text = "Account Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(150, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Your Balance:";
            // 
            // accnumlbl
            // 
            this.accnumlbl.AutoSize = true;
            this.accnumlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.accnumlbl.Location = new System.Drawing.Point(370, 227);
            this.accnumlbl.Name = "accnumlbl";
            this.accnumlbl.Size = new System.Drawing.Size(103, 29);
            this.accnumlbl.TabIndex = 7;
            this.accnumlbl.Text = "AccNum";
            // 
            // balancelbl
            // 
            this.balancelbl.AutoSize = true;
            this.balancelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.balancelbl.Location = new System.Drawing.Point(370, 318);
            this.balancelbl.Name = "balancelbl";
            this.balancelbl.Size = new System.Drawing.Size(148, 29);
            this.balancelbl.TabIndex = 8;
            this.balancelbl.Text = "BalanceInTL";
            this.balancelbl.Click += new System.EventHandler(this.label5_Click);
            // 
            // backlbl
            // 
            this.backlbl.AutoSize = true;
            this.backlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backlbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.backlbl.Location = new System.Drawing.Point(313, 493);
            this.backlbl.Name = "backlbl";
            this.backlbl.Size = new System.Drawing.Size(68, 25);
            this.backlbl.TabIndex = 27;
            this.backlbl.Text = "BACK";
            this.backlbl.Click += new System.EventHandler(this.backlbl_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 544);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 16);
            this.panel2.TabIndex = 28;
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 560);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.backlbl);
            this.Controls.Add(this.balancelbl);
            this.Controls.Add(this.accnumlbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.accnolbl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Balance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balance";
            this.Load += new System.EventHandler(this.Balance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exitlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label accnolbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label accnumlbl;
        private System.Windows.Forms.Label balancelbl;
        private System.Windows.Forms.Label backlbl;
        private System.Windows.Forms.Panel panel2;
    }
}