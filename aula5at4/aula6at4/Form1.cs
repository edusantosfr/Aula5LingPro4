using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula6at4
{
    public partial class Form1 : Form
    {
        int value1=0, value2=1, value3;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("0");
            listBox1.Items.Add("1");
            do
            {
                value3 = value1 + value2;
                if (value3 < 70){
                    listBox1.Items.Add(value3);
                }
                value1 = value2;
                value2 = value3;
            }
            while (value3 <= 70);
        }
    }
}
