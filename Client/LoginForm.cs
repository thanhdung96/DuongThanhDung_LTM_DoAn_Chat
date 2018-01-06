using System;
using System.Windows.Forms;

namespace Client
{
    public partial class LoginForm : Form
    {
        public ClientSettings Client { get; set; }

        public LoginForm()
        {
            Client = new ClientSettings();
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Client.Connected += Client_Connected;
            Client.Connect(txtIP.Text, 2014);
            Client.Send("Connect|" + txtNickname.Text + "|connected");
        }

        private void Client_Connected(object sender, EventArgs e)
        {
            this.Invoke(Close);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIP_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtNickname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}