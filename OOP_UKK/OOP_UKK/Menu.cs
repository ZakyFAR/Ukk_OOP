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
    public partial class Menu : Form
    {

        // create connection with database
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Zaky3\UKK\OOP\Betamart.accdb");
        int count = 0;
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "" || txt_nama.Text == "" || txt_stock.Text == "" || txt_harga.Text == "" || txt_kategori.Text == "" || txt_kode.Text == "")
            {
                MessageBox.Show("Jangan ada yang dikosongkan");
            }


            else
            {
                try
                {
                    if (txt_id.Text == "" || txt_nama.Text == "" || txt_stock.Text == "" || txt_harga.Text == "" || txt_kategori.Text == "" || txt_kode.Text == "")
                    {
                        MessageBox.Show("Jangan ada yang dikosongkan");
                    }


                    else
                    {
                        try
                        {
                            con.Open();
                            OleDbCommand cmd = con.CreateCommand();
                            String printah = "update Databarang set Nama='" + txt_nama.Text + "' ,Stock='" + txt_stock.Text + "' ,Harga='" + txt_harga.Text + "' ,Kategori='" + txt_kategori.Text + "',Kode='" + txt_kode.Text + "' where ID=" + txt_id.Text + "";
                            cmd.CommandText = printah;
                            cmd.ExecuteNonQuery();
                            con.Close();
                            txt_nama.Text = "";
                            txt_stock.Text = "";
                            txt_kode.Text = "";
                            txt_harga.Text = "";
                            txt_kategori.Text = "";
                            txt_id.Text = "";
                            MessageBox.Show("Barang berhasil diupdate");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            


        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            if (txt_nama.Text == "" || txt_stock.Text == "" || txt_harga.Text == "" || txt_kategori.Text == "" || txt_kode.Text == "")
            {
                MessageBox.Show("Hanya ID yang kosong");
            }


            else
            {
                try
                {
                    con.Open();
                    String printah = "INSERT INTO Databarang (Nama,Stock,Harga,Kategori,Kode) values ('" + txt_nama.Text + "', '" + txt_stock.Text + "',  '" + txt_harga.Text + "', '" + txt_kategori.Text + "','" + txt_kode.Text + "')";
                    OleDbCommand cmd = new OleDbCommand(printah, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    txt_nama.Text = "";
                    txt_stock.Text = "";
                    txt_kode.Text = "";
                    txt_harga.Text = "";
                    txt_kategori.Text = "";
                    txt_id.Text = "";
                    MessageBox.Show("Barang Baru telah di tambahkan");
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
                }
            }
            

        private void btn_tampil_Click(object sender, EventArgs e)
        {
            con.Open();
            string printah = "select * from Databarang ";
            OleDbDataAdapter da = new OleDbDataAdapter(printah, con);
            DataTable dt = new DataTable();
            //OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);

            Grid1.DataSource = dt;

            con.Close();
        }

        private void txt_harga_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_search.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_clear2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_id.Text = "";
            txt_nama.Text = "";
            txt_stock.Text = "";
            txt_kode.Text = "";
            txt_harga.Text = "";
            txt_kategori.Text = "";
        }

        private void btn__Click(object sender, EventArgs e)
        {
            con.Open();
            string printah = "select * from Databarang where Nama='" + txt_search.Text + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(printah, con);
            DataTable dt = new DataTable();
            //OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);

            Grid1.DataSource = dt;

            con.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            count = 0;
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Databarang where Nama ='" + txt_search.Text + "' or Kategori ='" + txt_search.Text + "' or Kode='" + txt_search.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            Grid1.DataSource = dt;
            con.Close();


            if (count == 0)
            {
                MessageBox.Show("Barang tidak ditemukan");
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            // create dataadabter
            OleDbDataAdapter da = new OleDbDataAdapter("select count(*) from Databarang where Nama='" + txt_nama.Text + "' or Kode='"+txt_kode.Text+"' ", con);

            //create datatable
            DataTable dt = new DataTable();

            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                con.Open();
                string printah = "DELETE FROM Databarang WHERE Nama='" + txt_nama.Text + "'or Kode='" + txt_kode.Text + "'";
                OleDbDataAdapter da2 = new OleDbDataAdapter(printah, con);
                DataTable dt2 = new DataTable();
                //OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da2.Fill(dt2);

                con.Close();
                txt_nama.Text = "";
                txt_stock.Text = "";
                txt_kode.Text = "";
                txt_harga.Text = "";
                txt_kategori.Text = "";
                txt_id.Text = "";
                MessageBox.Show("Barang telah dihapus");

            }
            else
            {
                MessageBox.Show("Salah Masukan Nama atau Kode");
            }
        }
    }
}
