﻿using DAL.Helper;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public partial class KhachHangRepository:IKhachHangRepository
    {
        private IDatabaseHelper _dbHelper;
        public KhachHangRepository(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }
        public List<KhachHangModel> GetKh()
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "getkh");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<KhachHangModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<KhachHangModel> getbyid(string id)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "getkhid","@id",id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<KhachHangModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<DiaChiModel> GeDiachi(string id)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "getdiachi", "@makh",id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<DiaChiModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
