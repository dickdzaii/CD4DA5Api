﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class SanPhamModel
    {
        public string MaSanPham {get;set;}
      public string MaLoai2 {get;set;}
      public string TenSanPham {get;set;}
      public string MoTa {get;set;}
      public string GhiChu {get;set;}
      public string Link {get;set;}
      public string Removed {get;set;}
      public string Displayed {get;set;}
      public int giahientai { get; set; }
      public List<GiaBanModel> dsgiaban { get; set; }
    }
}
