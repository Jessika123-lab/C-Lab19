using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader SR = new StreamReader(openFileDialog1.FileName);
                int a = Convert.ToInt32(SR.ReadLine());
                int[] A = new int[a];
                int sum = 0;
                for (int i = 0; i < a; i++)
                {
                    A[i] = Convert.ToInt32(SR.ReadLine());
                }

                for (int i = 0; i < a; i++)
                {
                    sum += A[i];
                }

                sum = sum / a;

                textBox1.Text = Convert.ToString(sum);
                SR.Close();
            }
        }
    }
}
