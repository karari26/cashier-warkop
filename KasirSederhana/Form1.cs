using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace KasirSederhana
{
    public partial class Form1 : Form
    {
        private MySqlConnection conn;
        private string connStr = "server=localhost;user=root;database=kasir;port=3306;password=";


        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection(connStr);
            cmbProduk.Items.Clear();
            dataGridKeranjang.CellContentClick += dataGridKeranjang_CellContentClick;
            LoadProduk(); // Ambil data produk dari database
        }

        private void InitializeComponents()
        {
            this.Text = "Aplikasi Kasir Sederhana";
            this.Size = new Size(600, 500);

            cmbProduk = new ComboBox() { Left = 20, Top = 20, Width = 150 };
            numQty = new NumericUpDown() { Left = 180, Top = 20, Width = 60, Minimum = 1, Value = 1 };
            btnTambah = new Button() { Left = 250, Top = 20, Width = 80, Text = "Tambah" };
            btnTambah.Click += btnTambah_Click;

            dataGridKeranjang = new DataGridView()
            {
                Left = 20,
                Top = 60,
                Width = 540,
                Height = 300,
                AllowUserToAddRows = false,
                ReadOnly = true
            };

            // Tambahkan kolom-kolom yang diperlukan
            dataGridKeranjang.Columns.Add("Produk", "Produk");
            dataGridKeranjang.Columns.Add("Qty", "Qty");
            dataGridKeranjang.Columns.Add("Harga", "Harga");
            dataGridKeranjang.Columns.Add("Subtotal", "Subtotal");

            lblTotal = new Label() { Left = 20, Top = 370, Width = 300, Text = "Total: Rp 0" };
            btnBayar = new Button() { Left = 400, Top = 370, Width = 80, Text = "Bayar" };
            btnBayar.Click += btnBayar_Click;

            this.Controls.Add(cmbProduk);
            this.Controls.Add(numQty);
            this.Controls.Add(btnTambah);
            this.Controls.Add(dataGridKeranjang);
            this.Controls.Add(lblTotal);
            this.Controls.Add(btnBayar);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbProduk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numQty_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            string namaProduk = cmbProduk.Text;
            int qty = (int)numQty.Value;

            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT harga FROM produk WHERE nama=@nama", conn);
            cmd.Parameters.AddWithValue("@nama", namaProduk);
            var result = cmd.ExecuteScalar();
            conn.Close();

            if (result == null)
            {
                MessageBox.Show("Produk tidak ditemukan di database.");
                return;
            }

            if (dataGridKeranjang.Columns.Count == 0)
            {
                dataGridKeranjang.Columns.Add("Produk", "Produk");
                dataGridKeranjang.Columns.Add("Qty", "Qty");
                dataGridKeranjang.Columns.Add("Harga", "Harga");
                dataGridKeranjang.Columns.Add("Subtotal", "Subtotal");
            }

            // Tambahkan tombol Edit dan Hapus
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.Name = "Edit";
            btnEdit.HeaderText = "Edit";
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;
            dataGridKeranjang.Columns.Add(btnEdit);

            DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
            btnHapus.Name = "Hapus";
            btnHapus.HeaderText = "Hapus";
            btnHapus.Text = "Hapus";
            btnHapus.UseColumnTextForButtonValue = true;
            dataGridKeranjang.Columns.Add(btnHapus);

            decimal harga = Convert.ToDecimal(result);
            decimal subtotal = harga * qty;
            dataGridKeranjang.Rows.Add(namaProduk, qty, harga, subtotal);

            HitungTotal();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void dataGridKeranjang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dataGridKeranjang.Rows[e.RowIndex].IsNewRow)
                return; // ⛔ Jangan hapus baris baru yang belum dikomit

            string columnName = dataGridKeranjang.Columns[e.ColumnIndex].Name;

            if (columnName == "Edit")
            {
                string produk = dataGridKeranjang.Rows[e.RowIndex].Cells["Produk"].Value.ToString();
                int qty = Convert.ToInt32(dataGridKeranjang.Rows[e.RowIndex].Cells["Qty"].Value);

                cmbProduk.SelectedItem = produk;
                numQty.Value = qty;

                dataGridKeranjang.Rows.RemoveAt(e.RowIndex);
                HitungTotal();
            }
            else if (columnName == "Hapus")
            {
                dataGridKeranjang.Rows.RemoveAt(e.RowIndex);
                HitungTotal();
            }
        }

        private void LoadProduk()
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT nama FROM produk", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbProduk.Items.Add(reader["nama"].ToString());
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load produk: " + ex.Message);
            }
        }

        private void HitungTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridKeranjang.Rows)
            {
                total += Convert.ToDecimal(row.Cells[3].Value);
            }
            lblTotal.Text = $"Total: Rp {total:N0}";
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            if (dataGridKeranjang.Rows.Count == 0)
            {
                MessageBox.Show("Keranjang kosong!");
                return;
            }

            decimal total = 0;
            foreach (DataGridViewRow row in dataGridKeranjang.Rows)
                total += Convert.ToDecimal(row.Cells[3].Value);

            try
            {
                conn.Open();

                MySqlCommand cmdTrans = new MySqlCommand("INSERT INTO transaksi (tanggal, total) VALUES (NOW(), @total)", conn);
                cmdTrans.Parameters.AddWithValue("@total", total);
                cmdTrans.ExecuteNonQuery();

                long transaksiId = cmdTrans.LastInsertedId;

                foreach (DataGridViewRow row in dataGridKeranjang.Rows)
                {
                    if (row.IsNewRow || row.Cells[0].Value == null) continue;

                    string nama = row.Cells[0].Value?.ToString() ?? "";
                    int qty = row.Cells[1].Value != null ? Convert.ToInt32(row.Cells[1].Value) : 0;
                    decimal subtotal = row.Cells[3].Value != null ? Convert.ToDecimal(row.Cells[3].Value) : 0;

                    MySqlCommand cmdDetail = new MySqlCommand(
                        "INSERT INTO detail_transaksi (transaksi_id, produk_id, qty, subtotal) " +
                        "VALUES (@tid, (SELECT id FROM produk WHERE nama=@nama LIMIT 1), @qty, @subtotal)", conn);
                    cmdDetail.Parameters.AddWithValue("@tid", transaksiId);
                    cmdDetail.Parameters.AddWithValue("@nama", nama);
                    cmdDetail.Parameters.AddWithValue("@qty", qty);
                    cmdDetail.Parameters.AddWithValue("@subtotal", subtotal);
                    cmdDetail.ExecuteNonQuery();
                }

                conn.Close();

                MessageBox.Show("Transaksi berhasil disimpan!");
                dataGridKeranjang.Rows.Clear();
                HitungTotal();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Gagal menyimpan transaksi: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
