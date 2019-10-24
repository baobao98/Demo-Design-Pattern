using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Adapter_Design_Pattern.ViDu2;

namespace Adapter_Design_Pattern
{
    public partial class FormVD2 : Form
    {
        public FormVD2()
        {
            InitializeComponent();
        }

        private void BtnChuyen_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.setName(txtInput.Text);
            txtTen.Text = user.getName();
        }

        // giả sử hàm này chính là hàm trên và được viết thêm. mình tách ra thành 2 hàm để cho bạn thấy được sự khác biệt
        private void BtnNew_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.setName(txtInput.Text);
            //Chúng ta vẫn xài code cũ, tuy nhiên:
            //User bây giờ đã được nâng cấp thành customer & ta ko thể nào đi kiếm từng user để đổi lại thành kiểu dữ liệu
            //customer cả. Chính vì thế mà chúng ta sẽ sử dụng 1 bộ chuyển đổi (adapter) để chuyển user -> customer mà 
            //chỉ cần thêm vài dòng không cần sửa lại code
            UserToCustomerAdapter adapter = new UserToCustomerAdapter(user);
            string name = adapter.getFirstName() +" "+ adapter.getLastName();
            txtChuoiChuyenDoi.Text = name;


        }
    }
}
