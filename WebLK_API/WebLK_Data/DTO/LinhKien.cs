using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLK_Data.DTO
{
    public class LinhKien
    {
        public int malinhkien { get; set; }
        public string tenlinhkien { get; set; }
        public string thongsokithuat { get; set; }
        public string mota { get; set; }
        public float giaban { get; set; }
        public string thoigianbaohanh { get; set; }
        public int maloailinhkien { get; set; }
        public int manhacungcap { get; set; }
        public int maloaimay { get; set; }

        public LinhKien() 
        { 
        }

        public LinhKien(int malinhkien, string tenlinhkien, string thongsokithuat, string mota, float giaban, string thoigianbaohanh, int maloailinhkien, int manhacungcap, int maloaimay)
        {
            this.malinhkien = malinhkien;
            this.tenlinhkien = tenlinhkien;
            this.thongsokithuat = thongsokithuat;
            this.mota = mota;
            this.giaban = giaban;
            this.thoigianbaohanh = thoigianbaohanh;
            this.maloailinhkien = maloailinhkien;
            this.manhacungcap = manhacungcap;
            this.maloaimay = maloaimay;

        }

        public LinhKien(DataRow row)
        {
            this.malinhkien = int.Parse(row["maLinhKien"].ToString());
            this.tenlinhkien = row["tenLinhKien"].ToString();
            this.thongsokithuat = row["thongSoKiThuat"].ToString();
            this.mota = row["moTa"].ToString();
            this.giaban = float.Parse(row["maLinhKien"].ToString());
            this.thoigianbaohanh = row["thoiGianBaoHanh"].ToString();
            this.maloailinhkien = int.Parse(row["maLoaiLinhKien"].ToString());
            this.manhacungcap = int.Parse(row["maNhaCungCap"].ToString());
            this.maloaimay = int.Parse(row["maLoaiMay"].ToString());
        }


    }
}
