namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            string[] dt = { "Kinh", "Hoa", "K'Me", "H'Mong", "Khác" };
            foreach (string s in dt)
            {
                cblist.Items.Add(s);
            }
        }

        private void cblist_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Dân tộc được chọn: " + cblist.SelectedItem.ToString());
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            string s = "Dân tộc được chọn: ";
            if (cblist.SelectedIndex >= 0)
                ketqua.Text = cblist.SelectedIndex.ToString();
            else ketqua.Text = "Bạn chưa chọn dân tộc";
        }
    }
}