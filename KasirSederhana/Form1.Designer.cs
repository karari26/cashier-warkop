
namespace KasirSederhana
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.cmbProduk = new System.Windows.Forms.ComboBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.dataGridKeranjang = new System.Windows.Forms.DataGridView();
            this.btnBayar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKeranjang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Warkop";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numQty
            // 
            this.numQty.BackColor = System.Drawing.Color.White;
            this.numQty.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQty.Location = new System.Drawing.Point(476, 49);
            this.numQty.Margin = new System.Windows.Forms.Padding(2);
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(76, 25);
            this.numQty.TabIndex = 1;
            this.numQty.ValueChanged += new System.EventHandler(this.numQty_ValueChanged);
            // 
            // cmbProduk
            // 
            this.cmbProduk.BackColor = System.Drawing.Color.White;
            this.cmbProduk.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduk.FormattingEnabled = true;
            this.cmbProduk.Location = new System.Drawing.Point(194, 49);
            this.cmbProduk.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProduk.Name = "cmbProduk";
            this.cmbProduk.Size = new System.Drawing.Size(191, 27);
            this.cmbProduk.TabIndex = 2;
            this.cmbProduk.SelectedIndexChanged += new System.EventHandler(this.cmbProduk_SelectedIndexChanged);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.Crimson;
            this.btnTambah.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnTambah.Location = new System.Drawing.Point(684, 49);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(2);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(105, 28);
            this.btnTambah.TabIndex = 3;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // dataGridKeranjang
            // 
            this.dataGridKeranjang.BackgroundColor = System.Drawing.Color.White;
            this.dataGridKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKeranjang.GridColor = System.Drawing.Color.Turquoise;
            this.dataGridKeranjang.Location = new System.Drawing.Point(135, 103);
            this.dataGridKeranjang.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridKeranjang.Name = "dataGridKeranjang";
            this.dataGridKeranjang.RowHeadersWidth = 51;
            this.dataGridKeranjang.RowTemplate.Height = 24;
            this.dataGridKeranjang.Size = new System.Drawing.Size(654, 258);
            this.dataGridKeranjang.TabIndex = 4;
            this.dataGridKeranjang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridKeranjang_CellContentClick);
            // 
            // btnBayar
            // 
            this.btnBayar.BackColor = System.Drawing.Color.Crimson;
            this.btnBayar.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBayar.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnBayar.Location = new System.Drawing.Point(684, 377);
            this.btnBayar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(105, 41);
            this.btnBayar.TabIndex = 5;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.UseVisualStyleBackColor = false;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Crimson;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotal.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(231, 377);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(64, 25);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total : 0";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 44);
            this.label2.TabIndex = 7;
            this.label2.Text = "Gen Z";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "2-02.jpg");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Cornsilk;
            this.button1.Location = new System.Drawing.Point(447, 377);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Keluar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::KasirSederhana.Properties.Resources.op80;
            this.ClientSize = new System.Drawing.Size(848, 479);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.numQty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridKeranjang);
            this.Controls.Add(this.cmbProduk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKeranjang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.ComboBox cmbProduk;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.DataGridView dataGridKeranjang;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
    }
}

