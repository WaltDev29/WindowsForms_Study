using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0612_DataGridView
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }
        Random rand = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            int num = rand.Next(2);
            Data newData = new Data(now.ToString(), num);
            dataBindingSource.Add(newData);

            if (chart1.Series[0].Points.Count >= 10) chart1.Series[0].Points.RemoveAt(0);
            chart1.Series[0].Points.AddXY(now.ToString(), num);
        }
    }
}
