﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyxekhach.AbstractModel
{
    internal class AccountDao
    {
        private AbstractDbFactory factory;

        public AccountDao(AbstractDbFactory factory)
        {
            this.factory = factory;
        }

        public bool Add(Account account)
        {
            var con = factory.CreateConnection();
            con.Open();

            var cmd = factory.CreateCommand("insert into TaiKhoan values (@MaNV, @TenNV,@ChucVu,@TenTK, @MatKhau)", con);
            var ManV = factory.SqlParameter("@MaNV", SqlDbType.NVarChar);
            var TenNV = factory.SqlParameter("@TenNV", SqlDbType.NVarChar);
            var ChucVu = factory.SqlParameter("@ChucVu", SqlDbType.NVarChar);
            var TenTK = factory.SqlParameter("@TenTK", SqlDbType.NVarChar);
            var MatKhau = factory.SqlParameter("@MatKhau", SqlDbType.NVarChar);

            ManV.Value = account.MaNV;
            TenNV.Value = account.TenNv;
            ChucVu.Value = account.ChucVu;
            TenTK.Value = account.TenTK;
            MatKhau.Value = account.MatKhau;
            cmd.Parameters.Add(ManV);
            cmd.Parameters.Add(TenNV);
            cmd.Parameters.Add(ChucVu);
            cmd.Parameters.Add(TenTK);
            cmd.Parameters.Add(MatKhau);
            var ok = cmd.ExecuteNonQuery() > 0;
            con.Close();
            return ok;
        }
    }
}