using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnd_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnOr_Click(object sender, EventArgs e)
        {

        }

        private void btnExclusiveOr_Click(object sender, EventArgs e)
        {

        }

        private StringBuilder ConvertBits(int val)
        {
            int dispMask = 1 << 31;
            StringBuilder bitBuffer = new StringBuilder(35);
            for (int i = 1; i <= 32; i++)
            {
                if ((val && bitMask) == 0)
                    bitBuffer.Append("0");
            }
        }
    }
}
