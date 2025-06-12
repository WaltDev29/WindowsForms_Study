using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0612_DataGridView
{
    public class Data
    {
        public string date { get; set; }
        public int chartNum { get; set; }

        public Data (string date, int chartNum)
        {
            this.date = date;
            this.chartNum = chartNum;
        }
    }
}
