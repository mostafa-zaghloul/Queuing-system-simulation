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
    public partial class Form1 : Form
    {
        public static int numOfRows,numOfCols;
        service_time_dist st;
        public Form1()
        {
            InitializeComponent();
            numOfCols = 8;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Inter_arrival_time.results_table = new int[numOfRows,numOfCols];
            //for (int i = 0; i < numOfRows; i++)
            //{
            //    Inter_arrival_time.results_table[i, 0] = i + 1;
            //}
            results_table.highest_prio = results_table.lowest = results_table.random = false;
            if (radioButton1.Checked)
                results_table.highest_prio = true;
            if (radioButton2.Checked)
                results_table.lowest = true;
            if (radioButton3.Checked)
                results_table.random = true;
            numOfRows = Convert.ToInt32(textBox5.Text);
                st = new service_time_dist();
            st.BringToFront();
            st.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        

    }
}