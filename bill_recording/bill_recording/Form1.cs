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
      
                if(cbb_product_names.SelectedItem != null)
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
            PrdConfig prConfig= new PrdConfig();
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
                if(p.Ten.Equals(prd.Ten) && p.Gia.Equals(prd.Gia) && p.ChietKhau.Equals(prd.ChietKhau))
                {
                    newList.Add(prd);
                }
                else
                {
                    newList.Add(p);
                }
            }
            readCSV.saveListToCSV(newList);
            //filter and save all with SL>0 to csv of selected ones 
            //load csv of selected ones
            isSearching = false;
        }
    }
}