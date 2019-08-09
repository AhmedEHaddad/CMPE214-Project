using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CMPE214_Project
{
    public partial class FormAdmin : Form
    {
        bool isLoginValid = false;
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.textBoxUsername.Clear();
            this.textBoxPssw.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm f1 = new mainForm();
            f1.Show();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"c:\Project XML Files\login.xml");
            foreach (XmlNode node in doc.SelectNodes("//user"))
            {
                string username = node.SelectSingleNode("username").InnerText;
                string password = node.SelectSingleNode("password").InnerText;
                if (username == textBoxUsername.Text && password == textBoxPssw.Text)
                {
                    isLoginValid = true;
                }
            }
            if (isLoginValid)
            {

                MessageBox.Show("You're Successfuly Authenicated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isLoginValid = false;
            }
            else
                MessageBox.Show("Wrong Credentials", "invalid", MessageBoxButtons.OK);
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
        }
    }
}
