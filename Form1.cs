using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Labos6
{
    public partial class Form1 : Form
    {
        public event EventHandler UserLoggedIn;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool UserIsValid()
        {
            XElement korisnici = XElement.Load("korisnici.xml");

            var users = from user in korisnici.Elements("korisnik")
                select new
                {
                    username = (string)user.Element("korisnickoIme"),
                    password = (string)user.Element("lozinka")
                };



            foreach (var user in users)
            {
                if (string.Compare(user.username, textBoxUserName.Text, true) == 0 && user.password == textBoxPassword.Text)
                    return true;
            }
            return false;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (UserIsValid())
            {
                if (UserLoggedIn != null)
                {
                    UserLoggedIn(this, EventArgs.Empty);
                }
                Close();
            }

            MessageBox.Show("Invalid username or password", "User Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
