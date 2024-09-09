using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ThuVienTinhTienKhachSan;
namespace WebTinhTien
{
    public partial class api : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTinhTien_Click(object sender, EventArgs e)
        {
            int luaChonPhong;
            double Gio;

            if (!int.TryParse(phong.SelectedValue, out luaChonPhong) || (luaChonPhong != 1 && luaChonPhong != 2))
            {
                result.Text = "Chọn lại đi.";
                return;
            }

            if (!double.TryParse(sogio.Text,out Gio) || Gio <= 0)
            {
                result.Text = "Thời gian thuê không hợp lệ.";
                return;
            }

            double giaPhong = (luaChonPhong == 1) ? 200000 : 300000;
            double tongTien = giaPhong * Gio;

            result.Text = $"Tổng tiền phải trả là : {tongTien:N0} VND";
        }
    }
}