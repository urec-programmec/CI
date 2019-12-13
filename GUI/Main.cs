using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib;

namespace GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void math_Click(object sender, EventArgs e)
        {
            try
            {
                double
                    x = double.Parse(tbX.Text),
                    y = double.Parse(tbY.Text);
                MessageBox.Show("Реультат: " + new Pow(x, y).Math());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
