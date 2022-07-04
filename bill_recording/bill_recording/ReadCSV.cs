using System.Linq;
using System.Data;
using Microsoft.VisualBasic.FileIO; // This namespace usage is important or else TextFieldParser method will lead to error
using System.IO;
using System;
using System.Text;

namespace bill_recording
{
    internal class ReadCSV
    {
        public DataTable readCSV;

        public ReadCSV(string fileName, bool firstRowContainsFieldNames = true)
        {
            readCSV = GenerateDataTable(fileName, firstRowContainsFieldNames);
            
        }

        public void saveObjectToCSV(List<Product> products, String name)
        {
            foreach(Product p in products)
            {
                if (p.Ten.ToString().Equals(name))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Ten,Gia,ChietKhau,SoLuong," + Environment.NewLine);
                    sb.Append(p.Ten.ToString());
                    sb.Append(",");
                    sb.Append(p.Gia.ToString());
                    sb.Append(",");
                    sb.Append(p.ChietKhau.ToString());
                    sb.Append(",");
                    sb.Append(p.SoLuong.ToString());
                    sb.Append(",");
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter("searchData.csv", false))
                    {
                        // Write the stringbuilder text to the the file.
                        sw.WriteLine(sb.ToString());
                    }
                }
            }
        }

        public void saveListToCSV(List<Product> products, String name)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Ten,Gia,ChietKhau,SoLuong," + Environment.NewLine);

            foreach (Product p in products)
            {
                    sb.Append(p.Ten.ToString());
                    sb.Append(",");
                    sb.Append(p.Gia.ToString());
                    sb.Append(",");
                    sb.Append(p.ChietKhau.ToString());
                    sb.Append(",");
                    sb.Append(p.SoLuong.ToString());
                    sb.Append("," + Environment.NewLine);
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(name, false))
                    {
                        // Write the stringbuilder text to the the file.
                        sw.WriteLine(sb.ToString());
                    }
            }
        }

        public void ExtractDataToCSV(DataGridView dgv)
        {

            // Don't save if no data is returned
            if (dgv.Rows.Count == 0)
            {
                return;
            }
            StringBuilder sb = new StringBuilder();
            // Column headers
            string columnsHeader = "";
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                columnsHeader += dgv.Columns[i].Name + ",";
            }
            sb.Append(columnsHeader + Environment.NewLine);
            // Go through each cell in the datagridview
            foreach (DataGridViewRow dgvRow in dgv.Rows)
            {
                // Make sure it's not an empty row.
                if (!dgvRow.IsNewRow)
                {
                    for (int c = 0; c < dgvRow.Cells.Count; c++)
                    {
                        // Append the cells data followed by a comma to delimit.

                        sb.Append(dgvRow.Cells[c].Value + ",");
                    }
                    // Add a new line in the text file.
                    sb.Append(Environment.NewLine);
                }
            }
            // Load up the save file dialog with the default option as saving as a .csv file.
            /*SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV files (*.csv)|*.csv";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {*/
                // If they've selected a save location...
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter("data.csv", false))
                {
                    // Write the stringbuilder text to the the file.
                    sw.WriteLine(sb.ToString());
                }
            //}
            // Confirm to the user it has been completed.
            MessageBox.Show("Đã lưu thông tin sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private static DataTable GenerateDataTable(string fileName, bool firstRowContainsFieldNames = true)
        {
            DataTable result = new DataTable();

            if (fileName == "")
            {
                return result;
            }

            string delimiters = ",";
            string extension = Path.GetExtension(fileName);

            if (extension.ToLower() == "txt")
                delimiters = "\t";
            else if (extension.ToLower() == "csv")
                delimiters = ",";

            using (TextFieldParser tfp = new TextFieldParser(fileName))
            {
                tfp.SetDelimiters(delimiters);

                // Get The Column Names
                if (!tfp.EndOfData)
                {
                    string[] fields = tfp.ReadFields();

                    for (int i = 0; i < fields.Count(); i++)
                    {
                        if (firstRowContainsFieldNames)
                            result.Columns.Add(fields[i]);
                        else
                            result.Columns.Add("Col" + i);
                    }

                    // If first line is data then add it
                    if (!firstRowContainsFieldNames)
                        result.Rows.Add(fields);
                }

                // Get Remaining Rows from the CSV
                while (!tfp.EndOfData)
                result.Rows.Add(tfp.ReadFields());
            }

            return result;
        }

        public List<Product> toList(String csv)
        {
            List<Product> values = File.ReadAllLines(csv)
                                           .Skip(1)
                                           .SkipLast(1)
                                           .Select(v => fromCsv(v))
                                           .ToList();
            return values; 
        }

        public static Product fromCsv(string csvLine)
        {
            
            string[] values = csvLine.Split(',');
            Product p = new Product();
            p.Ten = values[0];
            p.Gia = values[1];
            p.ChietKhau = Convert.ToDouble(values[2]);
            p.SoLuong = values[3];
           
            return p;
        }
    }
}
