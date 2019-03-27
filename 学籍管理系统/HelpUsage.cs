using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学籍管理系统
{
    public partial class HelpUsage : Form
    {
        public HelpUsage()
        {
            InitializeComponent();
        }

        private void CloseHelpUsage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
