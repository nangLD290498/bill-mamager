namespace bill_recording
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sc_main_frame = new System.Windows.Forms.SplitContainer();
            this.cbb_product_names = new System.Windows.Forms.ComboBox();
            this.dgr_product_list = new System.Windows.Forms.DataGridView();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChietKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ll_config_prd = new System.Windows.Forms.LinkLabel();
            this.btn_gen_bill = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_add_info = new System.Windows.Forms.Button();
            this.pnl_bill = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tlq_product_bought = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaSPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sc_main_frame)).BeginInit();
            this.sc_main_frame.Panel1.SuspendLayout();
            this.sc_main_frame.Panel2.SuspendLayout();
            this.sc_main_frame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_product_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.pnl_bill.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlq_product_bought.SuspendLayout();
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
            this.sc_main_frame.Size = new System.Drawing.Size(1194, 647);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgr_product_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgr_product_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_product_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ten,
            this.Gia,
            this.ChietKhau,
            this.SoLuong});
            this.dgr_product_list.DataSource = this.bindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgr_product_list.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgr_product_list.Location = new System.Drawing.Point(6, 61);
            this.dgr_product_list.Name = "dgr_product_list";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgr_product_list.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgr_product_list.RowTemplate.Height = 25;
            this.dgr_product_list.Size = new System.Drawing.Size(176, 552);
            this.dgr_product_list.TabIndex = 7;
            this.dgr_product_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgr_product_list.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgr_product_list_CellEndEdit);
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
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(bill_recording.Product);
            // 
            // ll_config_prd
            // 
            this.ll_config_prd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ll_config_prd.AutoSize = true;
            this.ll_config_prd.Location = new System.Drawing.Point(6, 623);
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
            this.btn_gen_bill.Location = new System.Drawing.Point(81, 619);
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
            this.btn_add_info.Location = new System.Drawing.Point(720, 619);
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
            this.pnl_bill.Controls.Add(this.label17);
            this.pnl_bill.Controls.Add(this.label16);
            this.pnl_bill.Controls.Add(this.tableLayoutPanel1);
            this.pnl_bill.Controls.Add(this.tlq_product_bought);
            this.pnl_bill.Controls.Add(this.label15);
            this.pnl_bill.Controls.Add(this.label14);
            this.pnl_bill.Controls.Add(this.label13);
            this.pnl_bill.Controls.Add(this.label12);
            this.pnl_bill.Controls.Add(this.label11);
            this.pnl_bill.Controls.Add(this.label10);
            this.pnl_bill.Controls.Add(this.label9);
            this.pnl_bill.Controls.Add(this.label8);
            this.pnl_bill.Controls.Add(this.label7);
            this.pnl_bill.Controls.Add(this.label6);
            this.pnl_bill.Controls.Add(this.label5);
            this.pnl_bill.Controls.Add(this.label4);
            this.pnl_bill.Controls.Add(this.label3);
            this.pnl_bill.Controls.Add(this.label2);
            this.pnl_bill.Controls.Add(this.label1);
            this.pnl_bill.Location = new System.Drawing.Point(164, 33);
            this.pnl_bill.Name = "pnl_bill";
            this.pnl_bill.Size = new System.Drawing.Size(672, 580);
            this.pnl_bill.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(127, 461);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(146, 15);
            this.label17.TabIndex = 18;
            this.label17.Text = "Tám mươi chín đồng chẵn";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(44, 461);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 15);
            this.label16.TabIndex = 17;
            this.label16.Text = "Viết bằng chữ: ";
            this.label16.Click += new System.EventHandler(this.label16_Click_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.68942F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.31058F));
            this.tableLayoutPanel1.Controls.Add(this.label21, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label18, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label19, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label20, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(46, 401);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(587, 57);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(4, 7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(112, 15);
            this.label18.TabIndex = 0;
            this.label18.Text = "Số lượng mặt hàng";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(4, 35);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 15);
            this.label19.TabIndex = 1;
            this.label19.Text = "Tổng cộng";
            // 
            // tlq_product_bought
            // 
            this.tlq_product_bought.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlq_product_bought.ColumnCount = 7;
            this.tlq_product_bought.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.616257F));
            this.tlq_product_bought.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.00341F));
            this.tlq_product_bought.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.778157F));
            this.tlq_product_bought.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.726962F));
            this.tlq_product_bought.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.28669F));
            this.tlq_product_bought.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.5802F));
            this.tlq_product_bought.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.13993F));
            this.tlq_product_bought.Controls.Add(this.label35, 6, 1);
            this.tlq_product_bought.Controls.Add(this.label34, 5, 1);
            this.tlq_product_bought.Controls.Add(this.label33, 4, 1);
            this.tlq_product_bought.Controls.Add(this.label32, 3, 1);
            this.tlq_product_bought.Controls.Add(this.label31, 2, 1);
            this.tlq_product_bought.Controls.Add(this.label30, 1, 1);
            this.tlq_product_bought.Controls.Add(this.label28, 6, 0);
            this.tlq_product_bought.Controls.Add(this.label27, 5, 0);
            this.tlq_product_bought.Controls.Add(this.label26, 4, 0);
            this.tlq_product_bought.Controls.Add(this.label24, 2, 0);
            this.tlq_product_bought.Controls.Add(this.label23, 1, 0);
            this.tlq_product_bought.Controls.Add(this.label22, 0, 0);
            this.tlq_product_bought.Controls.Add(this.label25, 3, 0);
            this.tlq_product_bought.Controls.Add(this.label29, 0, 1);
            this.tlq_product_bought.Location = new System.Drawing.Point(46, 232);
            this.tlq_product_bought.Name = "tlq_product_bought";
            this.tlq_product_bought.RowCount = 2;
            this.tlq_product_bought.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlq_product_bought.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlq_product_bought.Size = new System.Drawing.Size(587, 169);
            this.tlq_product_bought.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(168, 204);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 15);
            this.label15.TabIndex = 14;
            this.label15.Text = "Nguyễn Văn A";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(46, 205);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 15);
            this.label14.TabIndex = 13;
            this.label14.Text = "Nhân viên bán hàng:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(98, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(195, 15);
            this.label13.TabIndex = 12;
            this.label13.Text = "Hoằng Cát, Hoằng Hóa, Thanh Hóa";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "Địa chỉ:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(464, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "0474381062";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(379, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Số điện thoại:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(115, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Si Xuân Thu - 213";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Khách hàng: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(480, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày 31 tháng 03 năm 2022";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(287, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "HD008658";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(206, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phiếu xuất kho kiêm đơn bán hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 66);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điện Thoại: 0373481062";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 47);
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
            this.label1.Location = new System.Drawing.Point(265, 28);
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
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(569, 7);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(14, 15);
            this.label20.TabIndex = 2;
            this.label20.Text = "2";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(538, 35);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 15);
            this.label21.TabIndex = 3;
            this.label21.Text = "80,000";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(6, 11);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(28, 15);
            this.label22.TabIndex = 0;
            this.label22.Text = "STT";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(135, 11);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(57, 15);
            this.label23.TabIndex = 1;
            this.label23.Text = "Tên hàng";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(292, 11);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(20, 15);
            this.label24.TabIndex = 2;
            this.label24.Text = "SL";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(320, 11);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(50, 15);
            this.label25.TabIndex = 3;
            this.label25.Text = "Đơn giá";
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label26.Location = new System.Drawing.Point(390, 3);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(39, 30);
            this.label26.TabIndex = 4;
            this.label26.Text = "Chiết khấu";
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label27.Location = new System.Drawing.Point(451, 3);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(50, 30);
            this.label27.TabIndex = 5;
            this.label27.Text = "Đơn giá\r\nsau CK";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label28.Location = new System.Drawing.Point(537, 11);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(20, 15);
            this.label28.TabIndex = 6;
            this.label28.Text = "SL";
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(13, 37);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(13, 15);
            this.label29.TabIndex = 7;
            this.label29.Text = "1";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(43, 37);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(96, 15);
            this.label30.TabIndex = 8;
            this.label30.Text = "Chi phí đóng gói";
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(296, 37);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(13, 15);
            this.label31.TabIndex = 9;
            this.label31.Text = "1";
            // 
            // label32
            // 
            this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(336, 37);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(34, 15);
            this.label32.TabIndex = 10;
            this.label32.Text = "5,000";
            // 
            // label33
            // 
            this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(398, 37);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(44, 15);
            this.label33.TabIndex = 11;
            this.label33.Text = "55.44%";
            // 
            // label34
            // 
            this.label34.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(470, 37);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(34, 15);
            this.label34.TabIndex = 12;
            this.label34.Text = "3,000";
            // 
            // label35
            // 
            this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(549, 37);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(34, 15);
            this.label35.TabIndex = 13;
            this.label35.Text = "3.000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 647);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tlq_product_bought.ResumeLayout(false);
            this.tlq_product_bought.PerformLayout();
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
        private Label label6;
        private Label label5;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TableLayoutPanel tlq_product_bought;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label17;
        private Label label16;
        private Label label18;
        private Label label19;
        private Label label21;
        private Label label20;
        private Label label35;
        private Label label34;
        private Label label33;
        private Label label32;
        private Label label31;
        private Label label30;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label25;
        private Label label29;
    }
}