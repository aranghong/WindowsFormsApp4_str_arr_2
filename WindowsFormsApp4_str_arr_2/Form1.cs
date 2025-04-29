using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4_str_arr_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string str = "멈추지 않는 한 얼마나 천천히 가는지는 중요하지 않다. -공자";

            string str_1 = str.Remove(str.IndexOf('-'),3);
            str_1.Trim();
            textBox1.Text = "1. " + str_1.Trim() + "\r\n";


            string[] temp = (str.Substring(str.IndexOf('얼'), str.LastIndexOf('는') - str.IndexOf('얼'))).Split(' ');
            textBox1.Text += "2. " + temp[0].Trim() + "/" + temp[1].Trim() + "/" + temp[2].Trim() + "\r\n";


            string str_3 = str.Remove(str.IndexOf("."), 1);
            str_3 = str_3.Remove(str_3.IndexOf("-"), 1);
            str_3 = str_3.Replace(' ', ',');
            textBox1.Text += "3. " + str_3 + "\r\n";



        }
    }
}
