
namespace BetaMart
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kodeBarang = new System.Windows.Forms.TextBox();
            this.namaBarang = new System.Windows.Forms.TextBox();
            this.satuanBarang = new System.Windows.Forms.TextBox();
            this.hargaPokok = new System.Windows.Forms.TextBox();
            this.HargaJual = new System.Windows.Forms.TextBox();
            this.insertBtn = new System.Windows.Forms.Button();
            this.labelKodeBrg = new System.Windows.Forms.Label();
            this.labelNamaBrg = new System.Windows.Forms.Label();
            this.labelSatuan = new System.Windows.Forms.Label();
            this.labelHargaPokok = new System.Windows.Forms.Label();
            this.labelHargaJual = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kodeBarang
            // 
            this.kodeBarang.Location = new System.Drawing.Point(518, 89);
            this.kodeBarang.Name = "kodeBarang";
            this.kodeBarang.Size = new System.Drawing.Size(261, 23);
            this.kodeBarang.TabIndex = 0;
            // 
            // namaBarang
            // 
            this.namaBarang.Location = new System.Drawing.Point(517, 133);
            this.namaBarang.Name = "namaBarang";
            this.namaBarang.Size = new System.Drawing.Size(261, 23);
            this.namaBarang.TabIndex = 1;
            // 
            // satuanBarang
            // 
            this.satuanBarang.Location = new System.Drawing.Point(517, 182);
            this.satuanBarang.Name = "satuanBarang";
            this.satuanBarang.Size = new System.Drawing.Size(261, 23);
            this.satuanBarang.TabIndex = 2;
            // 
            // hargaPokok
            // 
            this.hargaPokok.Location = new System.Drawing.Point(518, 226);
            this.hargaPokok.Name = "hargaPokok";
            this.hargaPokok.Size = new System.Drawing.Size(260, 23);
            this.hargaPokok.TabIndex = 3;
            // 
            // HargaJual
            // 
            this.HargaJual.Location = new System.Drawing.Point(518, 270);
            this.HargaJual.Name = "HargaJual";
            this.HargaJual.Size = new System.Drawing.Size(261, 23);
            this.HargaJual.TabIndex = 4;
            // 
            // insertBtn
            // 
            this.insertBtn.BackColor = System.Drawing.Color.Gold;
            this.insertBtn.Location = new System.Drawing.Point(538, 318);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(97, 41);
            this.insertBtn.TabIndex = 5;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = false;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // labelKodeBrg
            // 
            this.labelKodeBrg.AutoSize = true;
            this.labelKodeBrg.Location = new System.Drawing.Point(518, 71);
            this.labelKodeBrg.Name = "labelKodeBrg";
            this.labelKodeBrg.Size = new System.Drawing.Size(74, 15);
            this.labelKodeBrg.TabIndex = 6;
            this.labelKodeBrg.Text = "Kode Barang";
            // 
            // labelNamaBrg
            // 
            this.labelNamaBrg.AutoSize = true;
            this.labelNamaBrg.Location = new System.Drawing.Point(517, 115);
            this.labelNamaBrg.Name = "labelNamaBrg";
            this.labelNamaBrg.Size = new System.Drawing.Size(79, 15);
            this.labelNamaBrg.TabIndex = 7;
            this.labelNamaBrg.Text = "Nama Barang";
            // 
            // labelSatuan
            // 
            this.labelSatuan.AutoSize = true;
            this.labelSatuan.Location = new System.Drawing.Point(518, 164);
            this.labelSatuan.Name = "labelSatuan";
            this.labelSatuan.Size = new System.Drawing.Size(43, 15);
            this.labelSatuan.TabIndex = 8;
            this.labelSatuan.Text = "Satuan";
            // 
            // labelHargaPokok
            // 
            this.labelHargaPokok.AutoSize = true;
            this.labelHargaPokok.Location = new System.Drawing.Point(517, 208);
            this.labelHargaPokok.Name = "labelHargaPokok";
            this.labelHargaPokok.Size = new System.Drawing.Size(75, 15);
            this.labelHargaPokok.TabIndex = 9;
            this.labelHargaPokok.Text = "Harga Pokok";
            // 
            // labelHargaJual
            // 
            this.labelHargaJual.AutoSize = true;
            this.labelHargaJual.Location = new System.Drawing.Point(518, 252);
            this.labelHargaJual.Name = "labelHargaJual";
            this.labelHargaJual.Size = new System.Drawing.Size(101, 15);
            this.labelHargaJual.TabIndex = 10;
            this.labelHargaJual.Text = "Harga Jual Satuan";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(488, 364);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Gold;
            this.editBtn.Location = new System.Drawing.Point(664, 318);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(97, 41);
            this.editBtn.TabIndex = 12;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Gold;
            this.deleteBtn.Location = new System.Drawing.Point(598, 368);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(97, 41);
            this.deleteBtn.TabIndex = 13;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(518, 45);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(260, 23);
            this.idtxt.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Gold;
            this.exitBtn.Location = new System.Drawing.Point(12, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 16;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelHargaJual);
            this.Controls.Add(this.labelHargaPokok);
            this.Controls.Add(this.labelSatuan);
            this.Controls.Add(this.labelNamaBrg);
            this.Controls.Add(this.labelKodeBrg);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.HargaJual);
            this.Controls.Add(this.hargaPokok);
            this.Controls.Add(this.satuanBarang);
            this.Controls.Add(this.namaBarang);
            this.Controls.Add(this.kodeBarang);
            this.Name = "Form1";
            this.Text = "BetaMart";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kodeBarang;
        private System.Windows.Forms.TextBox namaBarang;
        private System.Windows.Forms.TextBox satuanBarang;
        private System.Windows.Forms.TextBox hargaPokok;
        private System.Windows.Forms.TextBox HargaJual;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Label labelKodeBrg;
        private System.Windows.Forms.Label labelNamaBrg;
        private System.Windows.Forms.Label labelSatuan;
        private System.Windows.Forms.Label labelHargaPokok;
        private System.Windows.Forms.Label labelHargaJual;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitBtn;
    }
}

