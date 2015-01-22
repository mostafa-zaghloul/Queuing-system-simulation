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
    public partial class charts : Form
    {
        public charts()
        {
            InitializeComponent();
        }
        private void initialize_charts()
        {
            CustomersQueueGraph.Series["Series1"].Points.Clear();
            QueueSizeHistogram.Series["Series1"].Points.Clear();
            BusyTime1.Series["Series1"].Points.Clear();
            BusyTime2.Series["Series1"].Points.Clear();
            
        }
        public void print_1(int i, int j)
        {
            CustomersQueueGraph.Series["Series1"].Points.AddXY(i, j);
        }
        public void print_2(int i, int j)
        {

            QueueSizeHistogram.Series["Series1"].Points.AddXY(i,j);
        }
        public void print_3(int i, int j)
        {

            BusyTime1.Series["Series1"].Points.AddXY(i,j);
            BusyTime2.Series["Series1"].Points.AddXY(i,j);
        }
        
    }
}
