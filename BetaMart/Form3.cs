using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BetaMart
{
    public partial class Form3 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\XIIRPL\UKK\PBO\betaMart.accdb");
        public Form3()
        {
            InitializeComponent();
        }

        OleDbDataAdapter da;
        DataTable dt = new DataTable();
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string text = "Select * from [user] Where [UserName] ='" + username.Text + "' AND [Pass]='" + password.Text + "'";
            da = new OleDbDataAdapter(text, con);
            da.Fill(dt);
            if (username.Text == "" || password.Text == "")
                MessageBox.Show("username dan password tidak boleh kosong");
            else
                if (dt.Rows.Count > 0)
                {
                    Form1 form = new Form1();
                    form.Show();

                this.Hide();
                }
                else
                {
                MessageBox.Show("Username dan password salah","Alert",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

        }

        private void goToBtn_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();

            this.Hide();
        }
    }
}
