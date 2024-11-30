namespace Bt3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Sự kiện xảy ra khi Form load (nếu cần thêm xử lý khi form khởi động)
        private void Form1_Load(object sender, EventArgs e)
        {
            // Ví dụ: Thiết lập mặc định
            txtHo.Text = "";
            txtTen.Text = "";
        }

        // Sự kiện thay đổi nội dung TextBox "Họ Lót"
        private void txtHo_TextChanged(object sender, EventArgs e)
        {
            // Xử lý nếu cần, ví dụ kiểm tra độ dài hoặc cảnh báo
            if (txtHo.Text.Length > 50)
            {
                MessageBox.Show("Họ lót không được dài hơn 50 ký tự!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Nút "Họ Lót"
        private void btnHoLot_Click(object sender, EventArgs e)
        {
            string hoLot = txtHo.Text; // Lấy giá trị từ TextBox "Họ lót"

            if (string.IsNullOrWhiteSpace(hoLot)) // Kiểm tra rỗng
            {
                MessageBox.Show("Vui lòng nhập họ lót!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị thông tin Họ Lót
            MessageBox.Show($"Họ lót: {hoLot}", "Thông tin");
        }

        // Nút "Họ và Tên"
        private void btnHoTen_Click(object sender, EventArgs e)
        {
            string hoLot = txtHo.Text; // Lấy giá trị từ TextBox "Họ lót"
            string ten = txtTen.Text;  // Lấy giá trị từ TextBox "Tên"

            if (string.IsNullOrWhiteSpace(hoLot) || string.IsNullOrWhiteSpace(ten)) // Kiểm tra rỗng
            {
                MessageBox.Show("Vui lòng nhập đầy đủ họ lót và tên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị thông tin Họ và Tên
            MessageBox.Show($"Họ và tên đầy đủ: {hoLot} {ten}", "Thông tin");
        }

        // Nút "Thêm chương trình"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string hoLot = txtHo.Text; // Lấy giá trị từ TextBox "Họ lót"
            string ten = txtTen.Text;  // Lấy giá trị từ TextBox "Tên"

            if (string.IsNullOrWhiteSpace(hoLot) || string.IsNullOrWhiteSpace(ten)) // Kiểm tra rỗng
            {
                MessageBox.Show("Vui lòng nhập đầy đủ họ lót và tên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ví dụ: Xử lý lưu thông tin hoặc hiển thị
            MessageBox.Show($"Thông tin đã được thêm: {hoLot} {ten}", "Thông báo");
        }
    }
}
