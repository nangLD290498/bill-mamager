namespace bill_recording
{
    partial class PrdConfig
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
            this.dgv_prd_table = new System.Windows.Forms.DataGridView();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaSPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChietKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prd_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_prd_table
            // 
            this.dgv_prd_table.AutoGenerateColumns = false;
            this.dgv_prd_table.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgv_prd_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_prd_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ten,
            this.Gia,
            this.ChietKhau,
            this.SoLuong});
            this.dgv_prd_table.DataSource = this.bindingSource;
            this.dgv_prd_table.Location = new System.Drawing.Point(25, 22);
            this.dgv_prd_table.Name = "dgv_prd_table";
            this.dgv_prd_table.RowTemplate.Height = 25;
            this.dgv_prd_table.Size = new System.Drawing.Size(637, 355);
            this.dgv_prd_table.TabIndex = 2;
            this.dgv_prd_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgv_prd_table.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_prd_table_CellMouseUp);
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(bill_recording.Product);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(587, 385);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(506, 385);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 4;
            this.btn_load.Text = "Tải lại";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaSPToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 26);
            // 
            // xóaSPToolStripMenuItem
            // 
            this.xóaSPToolStripMenuItem.Name = "xóaSPToolStripMenuItem";
            this.xóaSPToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.xóaSPToolStripMenuItem.Text = "Xóa SP";
            this.xóaSPToolStripMenuItem.Click += new System.EventHandler(this.xóaSPToolStripMenuItem_Click);
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên";
            this.Ten.Name = "Ten";
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            // 
            // ChietKhau
            // 
            this.ChietKhau.DataPropertyName = "ChietKhau";
            this.ChietKhau.HeaderText = "Chiết Khấu";
            this.ChietKhau.Name = "ChietKhau";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "SL";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = false;
            // 
            // PrdConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(681, 420);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dgv_prd_table);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(697, 459);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(697, 459);
            this.Name = "PrdConfig";
            this.Text = "PrdConfig";
            this.Load += new System.EventHandler(this.PrdConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prd_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox tb_search;
        private Button btn_search;
        private DataGridView dgv_prd_table;
        private DataGridViewTextBoxColumn col_prd;
        private DataGridViewTextBoxColumn col_price;
        private DataGridViewTextBoxColumn col_operation;
        BindingSource bindingSource;
        private Button btn_save;
        private Button btn_load;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem xóaSPToolStripMenuItem;
        private DataGridViewTextBoxColumn Ten;
        private DataGridViewTextBoxColumn Gia;
        private DataGridViewTextBoxColumn ChietKhau;
        private DataGridViewTextBoxColumn SoLuong;
    }
}