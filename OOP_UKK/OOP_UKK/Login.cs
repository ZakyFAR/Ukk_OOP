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
    public partial class Login : Form
    {
        // create connection with database
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Zaky3\UKK\OOP\Betamart.accdb");

        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select count(*) from Users where username='" + txt_username.Text + "' and password ='" + txt_password.Text + "' ", con);

            //create datatable
            DataTable dt = new DataTable();

            //fill datatble
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                Menu f2 = new Menu();
                f2.Show();
                this.Hide();



            }
            else
            {
                MessageBox.Show("Invalid username or Password");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_password.Text = "";
            txt_username.Text = "";
        }

        private void lbl_buatAkun_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register f2 = new Register();
            this.Hide();
            f2.Show();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
