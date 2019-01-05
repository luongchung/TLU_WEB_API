using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TLU_Web_API.controller
{
    public class LopMonHocController : ApiController
    {
        DataDataContext db = new DataDataContext();
        [HttpGet]
        public List<LopMonHoc> getDSLopMonHoc(string id/* id sinhvien*/)
        {
            List<LopMonHoc> dssv = (from a in db.LopMonHocs
            where db.SinhVien_LopMonHocs
            .Where(p=>p.IDSinhVien.ToString().Equals(id) && p.IDLopMonHoc ==a.ID).Count()>0  &&  a.IsKT==false
                       select a).ToList();
            return dssv;
        }
    }
}
