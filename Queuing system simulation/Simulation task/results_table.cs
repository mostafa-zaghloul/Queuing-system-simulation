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
        public static bool highest_prio, random, lowest;
        List<int> arrivalTime,time_service_begin,time_service_end,server_time,server_index;
        public static List<int> delay;
        List<bool> server_state;
        List<int[]> Results_table;
        charts chr;
        public results_table()
        {
            chr = new charts();
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
                    if(num==0)

                        time_service_end.Add(time_service_begin[i] + service_time_dist.service_time_final[i]);
                    else

                        time_service_end.Add(time_service_begin[i] + service_time_2_dist.service_time_final[i]);
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
                chr.print_1(i,delay[i]);
                int num=0; 
                for(int j=0; j< delay.Count; j++)
                {
                    if(delay[j]==delay[i])
                        num++;
                }
                chr.print_2(delay[i], num);
                if (server_state[i] == true)
                    chr.print_3(i, 1);
                else
                    chr.print_3(i, 0);
            }
        }
        private int lowest_utilization(int index)
        {
            for (int j = 0; j < server_time.Count; j++)
            {
                if (server_time[j] <= arrivalTime[index])
                {
                    return j;
                }
            }
            int MIN = 100;
            server_index.Add(0);
            int num = -1;
            for (int j = 0; j < server_time.Count; j++)
            {
                if (server_time[j] < MIN)
                {
                    MIN = server_time[j];
                    server_index[index] = j;
                    num = j;
                }
            }
            time_service_begin.Add(MIN);
            return num;
        }
        private int highest_priority(int index)
        {
            for (int j = 0; j < server_time.Count; j++)
            {
                if (server_time[j] <= arrivalTime[index])
                {
                    return j;
                }
            }
            int MIN = 100;
            server_index.Add(0);
            int num = -1;
            for (int j = 0; j < server_time.Count; j++)
            {
                if (server_time[j] < MIN)
                {
                    MIN = server_time[j];
                    server_index[index] = j;
                    num = j;
                }
            }
            time_service_begin.Add(MIN);
            return num;
        }
        private int random_server(int index)
        {
            for (int j = 0; j < server_time.Count; j++)
            {
                if (server_time[j] <= arrivalTime[index])
                {
                    return j;
                }
            }
            int MIN = 100;
            server_index.Add(0);
            int num = -1;
            for (int j = 0; j < server_time.Count; j++)
            {
                if (server_time[j] < MIN)
                {
                    MIN = server_time[j];
                    server_index[index] = j;
                    num = j;
                }
            }
            time_service_begin.Add(MIN);
            return num;
        }
        private int choose_server(int index) {

            if (lowest == true)
                return lowest_utilization(index);
            else if (highest_prio == true)
                return highest_priority(index);
            else
                return random_server(index);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
