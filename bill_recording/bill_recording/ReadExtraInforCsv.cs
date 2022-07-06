using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bill_recording
{
    internal class ReadExtraInforCsv
    {
        public void saveObjectToCSV(ExtraInfo p)
        {

                    StringBuilder sb = new StringBuilder();
                    sb.Append("TenKD,DienThoai,DiaChi,NhanVien,NgayThang,SoTien," + Environment.NewLine);
                    sb.Append(p.TenKD.ToString());
                    sb.Append(",");
                    sb.Append(p.DienThoai.ToString());
                    sb.Append(",");
                    sb.Append(p.DiaChi.ToString());
                    sb.Append(",");
                    sb.Append(p.NhanVien.ToString());
                    sb.Append(",");
                    sb.Append(p.NgayThang.ToString());
                    sb.Append(",");
                    sb.Append(p.SoTien.ToString());
                    sb.Append(",");
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter("additionalInfo.csv", false))
                    {
                        // Write the stringbuilder text to the the file.
                        sw.WriteLine(sb.ToString());
                    }

        }
        public ExtraInfo getfirstObject(String csv)
        {
            List<ExtraInfo> values = File.ReadAllLines(csv)
                                           .Skip(1)
                                           .Select(v => fromCsv(v))
                                           .ToList();
            if (values == null) return null;
            return values[0];
        }

        public static ExtraInfo fromCsv(string csvLine)
        {

            string[] values = csvLine.Split(',');
            ExtraInfo p = new ExtraInfo();
            p.TenKD = values[0];
            p.DienThoai = values[1];
            p.DiaChi = values[2];
            p.NhanVien = values[3];
            p.NgayThang = values[4];
            p.SoTien = values[5];

            return p;
        }

    }
}
