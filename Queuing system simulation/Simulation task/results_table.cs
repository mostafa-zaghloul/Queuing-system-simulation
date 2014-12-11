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
    public partial class results_table : Form
    {
        List<int> arrivalTime,time_service_begin,time_service_end,delay,server_time,server_index;

        List<bool> server_state;
        List<int[]> Results_table;
        public results_table()
        {
            
            InitializeComponent();
            arrivalTime = new List<int>();
            arrivalTime.Add(0);
            time_service_begin = new List<int>();
            for(int i=1;i<Form1.numOfRows;i++)
            {
                arrivalTime.Add(arrivalTime[i-1]+Inter_arrival_time.inter_arrival_final[i]);
            }
            server_state = new List<bool>();
            server_state.Add(false);
            server_state.Add(false);
            calculate();
        }

        private void calculate() {
            time_service_end=new List<int>();
            delay = new List<int>();
            server_index = new List<int>();
            server_time = new List<int>();
            for (int i = 0; i < server_state.Count; i++)
            {
                server_time.Add(0);
            } 
            for (int i = 0; i < Form1.numOfRows; i++)
            {
                
                int num = choose_server(i);
                if (num != -1)
                {
                    time_service_begin.Add(arrivalTime[i]);
                    server_index.Add(num);
                    time_service_end.Add(time_service_begin[i] + service_time_dist.service_time_final[i]);
                    server_time[num] = time_service_end[i];
                    delay.Add(0);
                }
                else
                {
                    int MIN=100;
                    server_index.Add(0);
                    
                    for (int j = 0; j < server_time.Count; j++)
                    {
                        if (server_time[j] < MIN) {
                            MIN = server_time[j];
                            server_index[i] = j ;
                            num = j ;
                        }
                    }
                    time_service_begin.Add(MIN);
                    time_service_end.Add(time_service_begin[i] + service_time_dist.service_time_final[i]);
                    server_time[num] = time_service_end[i];
                    delay.Add(time_service_begin[i]-arrivalTime[i]);
                }
            }
            print_table();
        }
        private void print_table() {
            Results_table= new List<int[]>();
            int[] tmp;
            for (int i = 0; i < Form1.numOfRows; i++) {
                tmp = new int[Form1.numOfCols];
                tmp[0] = i + 1;
                tmp[1] = Inter_arrival_time.inter_arrival_final[i];
                tmp[2] = arrivalTime[i];
                tmp[3] = server_index[i];
                tmp[4] = time_service_begin[i];
                tmp[5] = service_time_dist.service_time_final[i];
                tmp[6] = time_service_end[i];
                tmp[7] = delay[i];
                Results_table.Add(tmp);
            }
            for(int i=0; i<Form1.numOfRows;i++)
            {
                this.dataGridView1.Rows.Add();
                for (int j = 0; j < Form1.numOfCols;j++ ) 
                    this.dataGridView1.Rows[i].Cells[j].Value= Results_table[i][j];
              
            }
        }
        private int choose_server(int index) {
            for (int j = 0; j < server_time.Count; j++)
            {
                if (server_time[j] <= arrivalTime[index])
                {
                    return j;
                }
            }
           /* for (int i = 0; i < server_state.Count; i++)
            {
                if (server_state[i] == false)
                {
                    server_state[i] = true;
                    return i;
                }
            }*/
            return -1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
