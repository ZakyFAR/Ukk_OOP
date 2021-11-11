namespace OOP_UKK
{
    partial class Menu
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
            this.Grid1 = new System.Windows.Forms.DataGridView();
            this.btn_tampil = new System.Windows.Forms.Button();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_kode = new System.Windows.Forms.TextBox();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.txt_harga = new System.Windows.Forms.TextBox();
            this.txt_kategori = new System.Windows.Forms.TextBox();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_clear1 = new System.Windows.Forms.LinkLabel();
            this.lbl_clear2 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid1
            // 
            this.Grid1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid1.Location = new System.Drawing.Point(12, 80);
            this.Grid1.Name = "Grid1";
            this.Grid1.RowHeadersVisible = false;
            this.Grid1.Size = new System.Drawing.Size(520, 102);
            this.Grid1.TabIndex = 37;
            // 
            // btn_tampil
            // 
            this.btn_tampil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(85)))), ((int)(((byte)(158)))));
            this.btn_tampil.FlatAppearance.BorderSize = 0;
            this.btn_tampil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tampil.ForeColor = System.Drawing.Color.White;
            this.btn_tampil.Location = new System.Drawing.Point(457, 49);
            this.btn_tampil.Name = "btn_tampil";
            this.btn_tampil.Size = new System.Drawing.Size(75, 23);
            this.btn_tampil.TabIndex = 39;
            this.btn_tampil.Text = "Tampilkan Data";
            this.btn_tampil.UseVisualStyleBackColor = false;
            this.btn_tampil.Click += new System.EventHandler(this.btn_tampil_Click);
            // 
            // btn_tambah
            // 
            this.btn_tambah.FlatAppearance.BorderSize = 0;
            this.btn_tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tambah.Location = new System.Drawing.Point(422, 278);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(85, 39);
            this.btn_tambah.TabIndex = 0;
            this.btn_tambah.Text = "Tambah";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Location = new System.Drawing.Point(422, 338);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(85, 39);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Update";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(109, 338);
            this.txt_stock.Multiline = true;
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(269, 23);
            this.txt_stock.TabIndex = 7;
            // 
            // txt_kode
            // 
            this.txt_kode.Location = new System.Drawing.Point(109, 430);
            this.txt_kode.Multiline = true;
            this.txt_kode.Name = "txt_kode";
            this.txt_kode.Size = new System.Drawing.Size(269, 23);
            this.txt_kode.TabIndex = 8;
            // 
            // txt_nama
            // 
            this.txt_nama.Location = new System.Drawing.Point(109, 307);
            this.txt_nama.Multiline = true;
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(269, 23);
            this.txt_nama.TabIndex = 9;
            // 
            // txt_harga
            // 
            this.txt_harga.Location = new System.Drawing.Point(109, 369);
            this.txt_harga.Multiline = true;
            this.txt_harga.Name = "txt_harga";
            this.txt_harga.Size = new System.Drawing.Size(269, 23);
            this.txt_harga.TabIndex = 12;
            this.txt_harga.TextChanged += new System.EventHandler(this.txt_harga_TextChanged);
            // 
            // txt_kategori
            // 
            this.txt_kategori.Location = new System.Drawing.Point(109, 400);
            this.txt_kategori.Multiline = true;
            this.txt_kategori.Name = "txt_kategori";
            this.txt_kategori.Size = new System.Drawing.Size(269, 23);
            this.txt_kategori.TabIndex = 13;
            // 
            // btn_hapus
            // 
            this.btn_hapus.FlatAppearance.BorderSize = 0;
            this.btn_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hapus.Location = new System.Drawing.Point(422, 398);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(85, 39);
            this.btn_hapus.TabIndex = 4;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // txt_search
            // 
            this.txt_search.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(115)))), ((int)(((byte)(173)))));
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Font = new System.Drawing.Font("Airbnb Cereal App Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_search.ForeColor = System.Drawing.Color.White;
            this.txt_search.Location = new System.Drawing.Point(33, 195);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(372, 30);
            this.txt_search.TabIndex = 41;
            // 
            // lbl_clear1
            // 
            this.lbl_clear1.ActiveLinkColor = System.Drawing.Color.Blue;
            this.lbl_clear1.AutoSize = true;
            this.lbl_clear1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_clear1.Font = new System.Drawing.Font("Airbnb Cereal App", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_clear1.LinkColor = System.Drawing.Color.Black;
            this.lbl_clear1.Location = new System.Drawing.Point(477, 224);
            this.lbl_clear1.Name = "lbl_clear1";
            this.lbl_clear1.Size = new System.Drawing.Size(61, 25);
            this.lbl_clear1.TabIndex = 42;
            this.lbl_clear1.TabStop = true;
            this.lbl_clear1.Text = "Clear";
            this.lbl_clear1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbl_clear2
            // 
            this.lbl_clear2.ActiveLinkColor = System.Drawing.Color.Black;
            this.lbl_clear2.AutoSize = true;
            this.lbl_clear2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(85)))), ((int)(((byte)(158)))));
            this.lbl_clear2.Font = new System.Drawing.Font("Airbnb Cereal App", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_clear2.LinkColor = System.Drawing.Color.White;
            this.lbl_clear2.Location = new System.Drawing.Point(317, 466);
            this.lbl_clear2.Name = "lbl_clear2";
            this.lbl_clear2.Size = new System.Drawing.Size(61, 25);
            this.lbl_clear2.TabIndex = 43;
            this.lbl_clear2.TabStop = true;
            this.lbl_clear2.Text = "Clear";
            this.lbl_clear2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_clear2_LinkClicked);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(85)))), ((int)(((byte)(158)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(462, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 28);
            this.button2.TabIndex = 45;
            this.button2.Text = "Cari";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(109, 278);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(269, 23);
            this.txt_id.TabIndex = 47;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OOP_UKK.Properties.Resources.silang;
            this.pictureBox2.Location = new System.Drawing.Point(518, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::OOP_UKK.Properties.Resources.Frame_1__8_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 500);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_clear2);
            this.Controls.Add(this.lbl_clear1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.txt_kategori);
            this.Controls.Add(this.btn_tampil);
            this.Controls.Add(this.txt_harga);
            this.Controls.Add(this.Grid1);
            this.Controls.Add(this.txt_nama);
            this.Controls.Add(this.txt_kode);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.txt_stock);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Grid1;
        private System.Windows.Forms.Button btn_tampil;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.TextBox txt_kode;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.TextBox txt_harga;
        private System.Windows.Forms.TextBox txt_kategori;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.LinkLabel lbl_clear1;
        private System.Windows.Forms.LinkLabel lbl_clear2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_id;
    }
}

