using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labos6
{
    class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }

        protected override void OnShow(EventArgs e)
        {
            base.OnShown(e);
            Login login = new Login();
            login.Show(this); 
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(499, 314);
            this.Name = "FormMain";
            this.ResumeLayout(false);

        }
    }
}
