using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetaMart
{
    public partial class Form1 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\XIIRPL\UKK\PBO\betaMart.accdb");
        public Form1()
        {
            InitializeComponent();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Insert into barang (kodeBrg,namaBrg,satuan,hargaPokok,hargaJual) Values ('"+kodeBarang.Text+ "','" + namaBarang.Text + "', '" + satuanBarang.Text + "','" + hargaPokok.Text + "','" + HargaJual.Text + "')",con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data barang berhasil ditambah");
            clearText();
            fillgrid();
        }

        void fillgrid()
        {
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from barang order by ID", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            clearText();
            con.Close();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Update barang set kodeBrg='"+kodeBarang.Text+"',namaBrg='"+namaBarang.Text+"',satuan='"+satuanBarang.Text+"',hargaPokok='" + hargaPokok.Text + "',hargaJual='"+HargaJual.Text+"' where ID="+idtxt.Text+" ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Berhasil diupdate");
            clearText();
            fillgrid();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Delete from barang where ID="+idtxt.Text+" ",con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Berhasil dihapus");
            fillgrid();
        }

        void clearText()
        {
            kodeBarang.Text = "";
            namaBarang.Text = "";
            satuanBarang.Text = "";
            hargaPokok.Text = "";
            HargaJual.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillgrid();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();

            this.Hide();
        }
    }
}
