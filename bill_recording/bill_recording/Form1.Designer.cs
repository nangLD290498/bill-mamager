﻿namespace bill_recording
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sc_main_frame = new System.Windows.Forms.SplitContainer();
            this.cbb_product_names = new System.Windows.Forms.ComboBox();
            this.dgr_product_list = new System.Windows.Forms.DataGridView();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ll_config_prd = new System.Windows.Forms.LinkLabel();
            this.btn_gen_bill = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_add_info = new System.Windows.Forms.Button();
            this.pnl_bill = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaSPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChietKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sc_main_frame)).BeginInit();
            this.sc_main_frame.Panel1.SuspendLayout();
            this.sc_main_frame.Panel2.SuspendLayout();
            this.sc_main_frame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_product_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.pnl_bill.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sc_main_frame
            // 
            this.sc_main_frame.BackColor = System.Drawing.SystemColors.Window;
            this.sc_main_frame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sc_main_frame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc_main_frame.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.sc_main_frame.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sc_main_frame.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sc_main_frame.IsSplitterFixed = true;
            this.sc_main_frame.Location = new System.Drawing.Point(0, 0);
            this.sc_main_frame.Name = "sc_main_frame";
            // 
            // sc_main_frame.Panel1
            // 
            this.sc_main_frame.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.sc_main_frame.Panel1.Controls.Add(this.cbb_product_names);
            this.sc_main_frame.Panel1.Controls.Add(this.dgr_product_list);
            this.sc_main_frame.Panel1.Controls.Add(this.ll_config_prd);
            this.sc_main_frame.Panel1.Controls.Add(this.btn_gen_bill);
            this.sc_main_frame.Panel1.Controls.Add(this.btn_search);
            // 
            // sc_main_frame.Panel2
            // 
            this.sc_main_frame.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.sc_main_frame.Panel2.Controls.Add(this.btn_add_info);
            this.sc_main_frame.Panel2.Controls.Add(this.pnl_bill);
            this.sc_main_frame.Size = new System.Drawing.Size(1063, 569);
            this.sc_main_frame.SplitterDistance = 199;
            this.sc_main_frame.TabIndex = 0;
            // 
            // cbb_product_names
            // 
            this.cbb_product_names.FormattingEnabled = true;
            this.cbb_product_names.Location = new System.Drawing.Point(6, 14);
            this.cbb_product_names.Name = "cbb_product_names";
            this.cbb_product_names.Size = new System.Drawing.Size(121, 23);
            this.cbb_product_names.TabIndex = 2;
            this.cbb_product_names.SelectedIndexChanged += new System.EventHandler(this.cbb_product_names_SelectedIndexChanged);
            this.cbb_product_names.Click += new System.EventHandler(this.cbb_product_names_Click);
            // 
            // dgr_product_list
            // 
            this.dgr_product_list.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgr_product_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgr_product_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_product_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ten,
            this.Gia,
            this.ChietKhau,
            this.SoLuong});
            this.dgr_product_list.DataSource = this.bindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgr_product_list.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgr_product_list.Location = new System.Drawing.Point(6, 61);
            this.dgr_product_list.Name = "dgr_product_list";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgr_product_list.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgr_product_list.RowTemplate.Height = 25;
            this.dgr_product_list.Size = new System.Drawing.Size(176, 474);
            this.dgr_product_list.TabIndex = 7;
            this.dgr_product_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgr_product_list.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgr_product_list_CellEndEdit);
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(bill_recording.Product);
            // 
            // ll_config_prd
            // 
            this.ll_config_prd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ll_config_prd.AutoSize = true;
            this.ll_config_prd.Location = new System.Drawing.Point(6, 545);
            this.ll_config_prd.Name = "ll_config_prd";
            this.ll_config_prd.Size = new System.Drawing.Size(26, 15);
            this.ll_config_prd.TabIndex = 5;
            this.ll_config_prd.TabStop = true;
            this.ll_config_prd.Text = "Sửa";
            this.ll_config_prd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_config_prd_LinkClicked);
            // 
            // btn_gen_bill
            // 
            this.btn_gen_bill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_gen_bill.Location = new System.Drawing.Point(81, 541);
            this.btn_gen_bill.Name = "btn_gen_bill";
            this.btn_gen_bill.Size = new System.Drawing.Size(101, 23);
            this.btn_gen_bill.TabIndex = 3;
            this.btn_gen_bill.Text = "Sinh Hóa Đơn ";
            this.btn_gen_bill.UseVisualStyleBackColor = true;
            this.btn_gen_bill.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(137, 14);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(45, 26);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Tìm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_add_info
            // 
            this.btn_add_info.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_add_info.Location = new System.Drawing.Point(585, 541);
            this.btn_add_info.Name = "btn_add_info";
            this.btn_add_info.Size = new System.Drawing.Size(116, 23);
            this.btn_add_info.TabIndex = 1;
            this.btn_add_info.Text = "Thêm thông tin";
            this.btn_add_info.UseVisualStyleBackColor = true;
            this.btn_add_info.Click += new System.EventHandler(this.btn_add_info_Click);
            // 
            // pnl_bill
            // 
            this.pnl_bill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnl_bill.BackColor = System.Drawing.Color.White;
            this.pnl_bill.Controls.Add(this.label4);
            this.pnl_bill.Controls.Add(this.label3);
            this.pnl_bill.Controls.Add(this.label2);
            this.pnl_bill.Controls.Add(this.label1);
            this.pnl_bill.Location = new System.Drawing.Point(159, 33);
            this.pnl_bill.Name = "pnl_bill";
            this.pnl_bill.Size = new System.Drawing.Size(542, 502);
            this.pnl_bill.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(139, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phiếu xuất kho kiêm đơn bán hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 66);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điện Thoại: 0373481062";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 47);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label2.Size = new System.Drawing.Size(231, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ: 44 Triều Khúc, Thanh Xuân, Hà Nội";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(198, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phương Sin Comestic";
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
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên";
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            this.Ten.Width = 50;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            this.Gia.Width = 50;
            // 
            // ChietKhau
            // 
            this.ChietKhau.DataPropertyName = "ChietKhau";
            this.ChietKhau.HeaderText = "Chiết Khấu";
            this.ChietKhau.Name = "ChietKhau";
            this.ChietKhau.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "SL";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 569);
            this.Controls.Add(this.sc_main_frame);
            this.Name = "Form1";
            this.Text = "BillCreator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sc_main_frame.Panel1.ResumeLayout(false);
            this.sc_main_frame.Panel1.PerformLayout();
            this.sc_main_frame.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc_main_frame)).EndInit();
            this.sc_main_frame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgr_product_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.pnl_bill.ResumeLayout(false);
            this.pnl_bill.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        public void setListProduct()
        {
            readCSV = new ReadCSV("data.csv");
            products = readCSV.toList("data.csv");
            foreach (Product p in products)
            {
                System.Diagnostics.Debug.WriteLine(p.Ten +"|"+p.Gia+"|"+p.ChietKhau+"|"+p.SoLuong);
            }
        }

        void setComboBoxItem()
        {
            setListProduct();
            foreach (Product p in products)
            {
                cbb_product_names.Items.Add(p.Ten);
            }
        }

        #endregion

        private SplitContainer sc_main_frame;
        private Button btn_search;
        private Button btn_gen_bill;
        private LinkLabel ll_config_prd;
        private Panel pnl_bill;
        private Label label2;
        List<Product> products;
        ReadCSV readCSV;
        private Label label1;
        private Label label3;
        private Button btn_add_info;
        BindingSource bindingSource;
        private Label label4;
        private DataGridView dgr_product_list;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem xóaSPToolStripMenuItem;
        private ComboBox cbb_product_names;
        private DataGridViewTextBoxColumn Ten;
        private DataGridViewTextBoxColumn Gia;
        private DataGridViewTextBoxColumn ChietKhau;
        private DataGridViewTextBoxColumn SoLuong;
    }
}