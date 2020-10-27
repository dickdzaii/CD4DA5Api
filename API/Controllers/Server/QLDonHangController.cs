﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Schema;
using BLL.Interfaces;
using DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API.Controllers.Server
{
    [Route("api/[controller]")]
    [ApiController]
    public class QLDonHangController : ControllerBase
    {
        private IDonHangBusiness isp;
        public QLDonHangController(IDonHangBusiness isp)
        {
            this.isp = isp;
        }
        [Route("getbyshop/{mashop}/{pageIndex}/{pageSize}")]
        public ResponseModel GetOdersbyShop(string mashop,int pageIndex, int pageSize)
        {
            long total = 0;

            var orders = new ResponseModel();
            orders.Page = pageIndex;
            orders.PageSize = pageSize;
            orders.Data = isp.GetOdersByShop(mashop, pageIndex, pageSize,out total);
            orders.TotalItems = total;
            return orders;
            

        }
        [Route("get-all-tinh")]
        public List<Provinces> getalltinh()
        {
            return isp.getalltinh();
        }
        [Route("get-huyen-by-tinh/{matinh}")]
        public List<Districts> gethuyenbytinh(int matinh)
        {
            return isp.gethuyenbytinh(matinh);
        }
        [Route("get-xa-by-huyen/{mahuyen}")]
        public List<Wards> getxabyhuyen(int mahuyen)
        {
            return isp.getxabyhuyen(mahuyen);
        }
    }
}
