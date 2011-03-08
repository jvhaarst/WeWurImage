using System;
using System.Security.Principal;
using System.Windows.Forms;

namespace wewurimage {
    public partial class WeWurForm : Form {
        public WeWurForm() {
            InitializeComponent();
            // Put logged in user into textbox
            textBoxAccount.Text = WindowsIdentity.GetCurrent().Name.Split('\\')[1];
        }

        private void buttonFetch_Click(object sender, EventArgs e) {
            Account User = new Account();
            User.AccountName = textBoxAccount.Text;
            pictureBoxAccountImage.Image = User.AccountPicture;
        }        
    }
}
