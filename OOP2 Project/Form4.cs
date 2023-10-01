using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        int startpos = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 3;
            progressBar1.Value = startpos;
            label3.Text = startpos + "%";
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                loginForm log = new loginForm();
                log.Show();
                this.Hide();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
