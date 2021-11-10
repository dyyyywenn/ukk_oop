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
    public partial class Form2 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\XIIRPL\UKK\PBO\betaMart.accdb");
        public Form2()
        {
            InitializeComponent();
        }

        private void gobackBtn_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();

            this.Hide();
        }

        OleDbCommand cmd;
        private void registerBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string text = "Insert Into [user] (UserName,Pass) values ('" + username.Text + "','" + password.Text + "')";
            cmd = new OleDbCommand(text, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Register success");
            con.Close();
            clearText();
        }

        void clearText()
        {
            username.Text = "";
            password.Text = "";
        }
    }
}
