namespace OOP_abstract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIT_Click(object sender, EventArgs e)
        {
            SinhVienIT sinhVienIT = new SinhVienIT();
            sinhVienIT.diemJava = 5;
            sinhVienIT.diemCss = 8;

            MessageBox.Show(sinhVienIT.diemTB().ToString());
        }

        private void btnBiz_Click(object sender, EventArgs e)
        {
            SinhVienBiz sinhVienBiz = new SinhVienBiz();
            sinhVienBiz.banHang = 7;
            sinhVienBiz.keToan = 4;
            sinhVienBiz.marketting = 6;

            MessageBox.Show(sinhVienBiz.diemTB().ToString());

        }
    }
}
