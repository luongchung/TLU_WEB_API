using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TLU_Web_API.controller
{
    public class TraCuuDiemDanhController : ApiController
    {
        DataDataContext db = new DataDataContext();
        [HttpGet]
        public IHttpActionResult getTTDiemDanh(string idsv/* id sinhvien*/,string idlmh)
        {
            var dssv = (from a in db.getTTDiemDanh(idsv,idlmh) select a).ToList();
            return Ok(dssv);
        }
    }
}
