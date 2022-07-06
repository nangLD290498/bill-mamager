using CsvHelper;

namespace bill_recording
{
    public partial class Form1 : Form
    {
        bool isSearching = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            if (cbb_product_names.SelectedItem != null)
            {
                setListProduct();
                readCSV.saveObjectToCSV(products, cbb_product_names.Text);
                ReadCSV searchCSV = new ReadCSV("searchData.csv");
                dgr_product_list.DataSource = searchCSV.readCSV;
                isSearching = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ll_config_prd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PrdConfig prConfig = new PrdConfig();
            prConfig.ShowDialog();
        }

        private void ll_reload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


        }

        private void btn_add_info_Click(object sender, EventArgs e)
        {
            InformationInput informationInput = new InformationInput();
            informationInput.ShowDialog();
        }

        private void dgv_list_prd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ReadCSV searchCSV = new ReadCSV("selectedItems.csv");
            dgr_product_list.DataSource = searchCSV.readCSV;

            ReadExtraInforCsv readExtraInforCsv = new ReadExtraInforCsv();
            ExtraInfo extraInfo = readExtraInforCsv.getfirstObject("additionalInfo.csv");
            Form1 f = (Form1)Application.OpenForms["Form1"];
            f.lb_cus_name.Text = extraInfo.TenKD;
            f.lb_sdt.Text = extraInfo.DienThoai;
            f.lb_address.Text = extraInfo.DiaChi;
            f.lb_khachhang.Text = extraInfo.NhanVien;
            f.lb_ngaythang.Text = extraInfo.NgayThang;
            f.lb_sotien.Text = extraInfo.SoTien;
        }

        private void cbb_product_names_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbb_product_names_Click(object sender, EventArgs e)
        {
            cbb_product_names.Items.Clear();
            cbb_product_names.ResetText();
            setComboBoxItem();
        }

        private void dgr_product_list_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //update in root file
            setListProduct();
            DataGridViewRow row = dgr_product_list.Rows[e.RowIndex];
            Product prd = new Product();
            prd.Ten = row.Cells["Ten"].Value.ToString();
            prd.Gia = row.Cells["Gia"].Value.ToString();
            prd.SoLuong = row.Cells["SoLuong"].Value.ToString();
            prd.ChietKhau = Convert.ToDouble(row.Cells["ChietKhau"].Value.ToString());
            List<Product> newList = new List<Product>();
            System.Diagnostics.Debug.WriteLine(prd.Ten + "|" + prd.Gia + "|" + prd.ChietKhau + "|" + prd.SoLuong);
            foreach (Product p in products)
            {
                if (p.Ten.Equals(prd.Ten) && p.Gia.Equals(prd.Gia) && p.ChietKhau.Equals(prd.ChietKhau))
                {
                    newList.Add(prd);
                }
                else
                {
                    newList.Add(p);
                }
            }
            readCSV.saveListToCSV(newList, "data.csv");
            //filter and save all with SL>0 to csv of selected ones 
            List<Product> selectedList = new List<Product>();
            foreach (Product p in newList)
            {
                try
                {
                    int SLInt = int.Parse(p.SoLuong);
                    if (SLInt != null && SLInt > 0)
                    {
                        selectedList.Add(p);
                    }
                }
                catch (Exception)
                {
                }
            }
            readCSV.saveListToCSV(selectedList, "selectedItems.csv");
            //load csv of selected ones
            ReadCSV searchCSV = new ReadCSV("selectedItems.csv");
            dgr_product_list.DataSource = searchCSV.readCSV;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

    

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click_1(object sender, EventArgs e)
        {

        }
    }
}