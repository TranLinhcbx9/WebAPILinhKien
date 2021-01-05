using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebLK_Data.DTO;

namespace WebLK_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        public string baseAddress = "https://localhost:44333";

        List<LinhKien> listLinhKien = null;

        public void LoadData()
        {
            listLinhKien = LoadSanPham();
            if (listLinhKien != null)
                dtgDisplaySanPham.DataSource = listLinhKien;
            //listLoaiSP = LoadLoaiSP();
            //if (listLoaiSP != null)
            //    dtgdisplayLoaiSP.DataSource = listLoaiSP;
        }

        private List<LinhKien> LoadSanPham()
        {
            List<LinhKien> listSanPham = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("listlinhkien");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<LinhKien>>();
                    readTask.Wait();

                    listSanPham = readTask.Result;

                }
                else //web api sent error response 
                {
                    //log response status here..    

                }
            }
            return listSanPham;
        }
    }
}
