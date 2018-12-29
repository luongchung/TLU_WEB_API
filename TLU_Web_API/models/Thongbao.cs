using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TLU_Web_API.models
{
    public class Thongbao
    {
        public bool ketqua;
        public string text;

        public Thongbao()
        {
        }

        public Thongbao(bool ketqua, string text)
        {
            this.ketqua = ketqua;
            this.text = text;
        }

    }
}