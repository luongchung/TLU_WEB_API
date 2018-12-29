using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TLU_Web_API;

namespace HocReftful.controller
{
    public class NhanVienController : ApiController
    {
        [HttpGet]
        public List<NhanVien> laydanhsachnhanvien()
        {
            DataDataContext db = new DataDataContext();
            List<NhanVien> arr = (from a in db.NhanViens
                                  select a).ToList();
            return arr;
        }

    }
}
