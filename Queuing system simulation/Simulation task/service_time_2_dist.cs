using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulation_task
{
    public partial class service_time_2_dist : Form
    {
        public service_time_2_dist()
        {
            InitializeComponent();
        }
        public struct mynum
        {
            public int left, right;

        };
        public static List<int> service_time_final;

        private void button1_Click(object sender, EventArgs e)
        {
            List<double> cumulative = new List<double>();
            double x = 0.0;
            for (int i = 0; i < this.dataGridView1.RowCount - 1; i++)
            {
                cumulative.Add(Convert.ToDouble(this.dataGridView1.Rows[i].Cells[1].Value));
                cumulative[i] += x;
                x = cumulative[i];
            }
            List<mynum> range = new List<mynum>();
            int num = 0;
            mynum y = new mynum();
            Inter_arrival_time inter1;

            for (int i = 0; i < this.dataGridView1.RowCount - 1; i++)
            {
                y.left = num;
                y.right = (int)(cumulative[i] * 100) - 1;
                range.Add(y);
                num = (int)(cumulative[i] * 100);
            }
            Random rand = new Random(System.DateTime.Now.Millisecond);
            service_time_final = new List<int>();
            for (int i = 0; i < Form1.numOfRows; i++)
            {
                int X = rand.Next(0, 99);

                for (int j = 0; j < this.dataGridView1.RowCount - 1; j++)
                {
                    if (X >= range[j].left && X <= range[j].right)
                    {
                        service_time_final.Add(Convert.ToInt32(this.dataGridView1.Rows[j].Cells[0].Value));
                        break;
                    }
                }
            }
            inter1 = new Inter_arrival_time();
            inter1.BringToFront();
            this.Close();
            inter1.Show();
        }
    }
}
