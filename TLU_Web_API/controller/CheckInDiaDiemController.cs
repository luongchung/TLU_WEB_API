using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TLU_Web_API.controller
{
    public class CheckInDiaDiemController : ApiController
    {
        [HttpGet]
        public IHttpActionResult laydanhsachnhanvien(int id)
        {
            DataDataContext db = new DataDataContext();
            var a = db.GetLopMonHocTheoDiaDiem(id).ToList();
            return Ok(a);
        }
    }
}
