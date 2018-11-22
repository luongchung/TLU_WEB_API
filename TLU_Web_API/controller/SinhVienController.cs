using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Linq;

namespace TLU_Web_API.controller
{
    public class SinhVienController : ApiController
    {
        DataDataContext db = new DataDataContext();
        [HttpGet]
        public List<SinhVien> laydanhsachsinhvien()
        {
            
            List<SinhVien> arr = (from a in db.SinhViens select a).ToList(); ;
            return arr;
        }
        public InforSinhVien getThongTinSinhVien(string id)
        {
            var sv = (from a in db.InforSinhViens where a.MSV.Equals(id) select a).FirstOrDefault();     
            return sv;
        }
    }
}
