using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Selectors;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KocTasMall.Registration
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username;
            string password;
            username = textBoxUName.Text;
            password = textBoxPassword.Text;

            try
            {
                string querry = textBoxUName.Text + textBoxPassword.Text;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
