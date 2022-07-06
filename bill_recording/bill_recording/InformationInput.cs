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
    public partial class InformationInput : Form
    {
        public InformationInput()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            ReadExtraInforCsv readExtraInforCsv = new ReadExtraInforCsv();
            //store info to csv
            ExtraInfo info = new ExtraInfo();
            info.TenKD = tb_cus_name.Text;
            info.DienThoai = tb_phone.Text;
            info.DiaChi = tb_address.Text;
            info.NhanVien = tb_employee.Text;
            //date todo
            string date = "Ngày " + dtp_date.Value.Day.ToString() + " tháng " + dtp_date.Value.Month.ToString() + " năm " + dtp_date.Value.Year.ToString();
            System.Diagnostics.Debug.WriteLine(dtp_date.Value.Day.ToString() + "||" + dtp_date.Value.Month.ToString() + "||" + dtp_date.Value.Year.ToString() + "||");
            info.NgayThang = date;
            info.SoTien = tb_money_amount.Text;
            readExtraInforCsv.saveObjectToCSV(info);

            // load to bill
            
            ExtraInfo extraInfo = readExtraInforCsv.getfirstObject("additionalInfo.csv");
            Form1 f = (Form1)Application.OpenForms["Form1"];
            f.lb_cus_name.Text = extraInfo.TenKD;
            f.lb_sdt.Text = extraInfo.DienThoai;
            f.lb_address.Text = extraInfo.DiaChi;
            f.lb_khachhang.Text = extraInfo.NhanVien;
            f.lb_ngaythang.Text = extraInfo.NgayThang;
            f.lb_sotien.Text = extraInfo.SoTien;
            this.Close();
        }

        private void InformationInput_Load(object sender, EventArgs e)
        {
            ReadExtraInforCsv readExtraInforCsv = new ReadExtraInforCsv();
            ExtraInfo extraInfo = readExtraInforCsv.getfirstObject("additionalInfo.csv");
            tb_cus_name.Text = extraInfo.TenKD;
            tb_phone.Text = extraInfo.DienThoai;
            tb_address.Text = extraInfo.DiaChi;
            tb_employee.Text = extraInfo.NhanVien;
            tb_money_amount.Text = extraInfo.SoTien;
        }
    }
}
