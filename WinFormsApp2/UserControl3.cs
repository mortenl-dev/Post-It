using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class UserControl3 : UserControl
    {
        Form1 form;
        public UserControl3(Form1 f)
        {
            form = f;
            InitializeComponent();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {

        }

        private void ButtonUC_Click(object sender, EventArgs e)
        {
            form.addTask();
        }
    }
}
