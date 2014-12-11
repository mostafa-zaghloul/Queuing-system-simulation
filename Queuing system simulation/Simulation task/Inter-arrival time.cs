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

    public partial class Inter_arrival_time : Form
    {
        public struct mynum
        {
            public int left, right;

        };
        results_table res;
        public static List<int>inter_arrival_final;
        
        public Inter_arrival_time()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Inter_arrival_time_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<double> cumulative = new List<double> ();
            double x = 0.0;
            for (int i = 0; i < this.dataGridView1.RowCount-1; i++)
            {
                cumulative.Add (Convert.ToDouble(this.dataGridView1.Rows[i].Cells[1].Value));
                cumulative[i] += x ;
                x = cumulative[i];
            }
            List<mynum> range = new List<mynum>();
            int Left = 0;
            mynum y = new mynum();
            
            for (int i = 0; i < this.dataGridView1.RowCount - 1; i++)
            {
                y.left = Left;
                y.right = (int)(cumulative[i]*100)-1;
                range.Add(y);
                Left = (int)(cumulative[i] * 100);
            }
            Random rand = new Random(System.DateTime.Now.Millisecond);
            inter_arrival_final = new List<int>();
            for (int i = 0; i < this.dataGridView1.RowCount - 1; i++)
            {
                int X = rand.Next(0, 99);
                
                for (int j = 0; j < this.dataGridView1.RowCount - 1; j++)
                {
                    if(X>=range[j].left && X<=range[j].right){
                        inter_arrival_final.Add(Convert.ToInt32(this.dataGridView1.Rows[i].Cells[0].Value));
                        break;
                    }
                }
            }
            inter_arrival_final.Add(0);
            res = new results_table();
            res.BringToFront();
            this.Close();
            res.Show();
        }
    }
}
