using System;
using System.Threading;
using System.Windows.Forms;

namespace Zadanie_4_dz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            for(int i = 0;i<=100; i++)
            {
                progressBar1.Value = i;
                Thread.Sleep(500);
            }
            button1.Enabled = true;
        }
    }
}
