using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtBox.Focus();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string typed_msg;
            typed_msg = txtBox.Text.Trim();
            lstMsg.Items.Add(typed_msg);
            txtBox.Clear();
            txtBox.Focus();
            if (string.IsNullOrWhiteSpace(txtBox.Text))
                return;

        }



        private void txtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtBox.Text))
                    return;
            }
        }

    }
}
