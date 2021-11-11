using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OOP_UKK
{
    public partial class Register : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Zaky3\UKK\OOP\Betamart.accdb");
        public Register()
        {
            InitializeComponent();
        }

        private void btn_buatAkun_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" || txt_password.Text == "")
            { 
                MessageBox.Show("Jangan dikosongkan");
            }
                    
                    
            else
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Users values('" + txt_username.Text + "','" + txt_password.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Akun berhasil dibuat");
                Close();

                Login f2 = new Login();
                this.Hide();
                f2.Show();
            }
        
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_password.Text = "";
            txt_username.Text = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Login f2 = new Login();
            this.Hide();
            f2.Show();
        }
    }
}
