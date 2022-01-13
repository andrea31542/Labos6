using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labos6
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            Form1 login = new Form1();
            login.UserLoggedIn += Login_UserLoggedIn;
            login.Show(this);
        }

        private void Login_UserLoggedIn(object sender, EventArgs e)
        {
            using (DataSet dataSet = new DataSet())
            {
                //Read xml to dataset and pass file path as parameter
                dataSet.ReadXml("popisKnjiga.xml");
                dataGridView1.DataSource = dataSet.Tables[0];
            }
        }
    
    }

    
}
