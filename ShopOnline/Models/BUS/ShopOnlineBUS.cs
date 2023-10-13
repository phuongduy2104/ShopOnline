using ShopOnlineConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopOnline.Models.BUS
{
    public class ShopOnlineBUS
    {
        public static IEnumerable<SanPham1> DanhSach()
        {
            var db = new ShopOnlineConnectionDB();
            return db.Query<SanPham1>("select * from SanPham1 where TinhTrang = 0");
        }
        public static SanPham1 ChiTiet(String a)
        {
            var db = new ShopOnlineConnectionDB();
            return db.SingleOrDefault<SanPham1> ("select * from SanPham1 where MaSanPham = @0",a);
        }
  
    }
}