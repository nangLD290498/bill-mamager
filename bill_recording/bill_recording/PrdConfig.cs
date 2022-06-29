using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bill_recording
{
    public partial class PrdConfig : Form
    {

        public void loadFromCSV()
        {
            try
            {
                // display data
                ReadCSV csv = new ReadCSV("data.csv");

                try
                {
                    dgv_prd_table.DataSource = csv.readCSV;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public PrdConfig()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PrdConfig_Load(object sender, EventArgs e)
        {
            loadFromCSV();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ReadCSV csv = new ReadCSV("data.csv");
            csv.ExtractDataToCSV(dgv_prd_table);
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            loadFromCSV();
        }

        private int rowIndex = 0;
        private void xóaSPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.dgv_prd_table.Rows[this.rowIndex].IsNewRow)
            {
                this.dgv_prd_table.Rows.RemoveAt(this.rowIndex);
            }
        }

        private void dgv_prd_table_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dgv_prd_table.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dgv_prd_table.CurrentCell = this.dgv_prd_table.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(this.dgv_prd_table, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }
    }
}
