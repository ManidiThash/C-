using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imigrationdepartment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item.GetType().Equals(typeof(TextBox)))
                {
                    TextBox tl = item as TextBox;
                    tl.Text = string.Empty;

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();

            Window3 fir = new Window3();
            fir.ShowDialog();
            Close();
        }
    }
}
