using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TLU_Web_API.models;

namespace TLU_Web_API.controller
{
    public class DiemDanhController : ApiController
    {

        [HttpGet]
        public Thongbao diemdanh(int idsinhvien,int idbuoihoc,string token)
        {
            DataDataContext db = new DataDataContext();


            if (!token.Equals(db.getToken(idbuoihoc)))
            {
                return new Thongbao(false, "Mã QR này đã hết hạn ! Xin mời quét lại !");
            }

            if ((bool)!db.Kiemtrathuoclop(idsinhvien, idbuoihoc))
            {
                return new Thongbao(false, "Bạn không thể điểm danh vì không thuộc lớp này !");
            };
            try
            { 
                DiemDanh obj = new DiemDanh();
                obj.IDBuoiHoc = idbuoihoc;
                obj.IDSinhVien = idsinhvien;
                obj.DenLop = true;
                db.DiemDanhs.InsertOnSubmit(obj);
                db.SubmitChanges();
                return new Thongbao(true, "Điểm danh thành công !");
            }
            catch{}


            return new Thongbao(false, "Điểm danh thất bại ! Vui lòng thử lại !");
        }
    }
}
