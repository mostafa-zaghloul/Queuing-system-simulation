namespace Simulation_task
{
    partial class results_table
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Customer_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InterArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeServiceBegins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeServiceEnds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDelay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer_num,
            this.InterArrivalTime,
            this.Arrival_time,
            this.ServerIndex,
            this.TimeServiceBegins,
            this.ServiceDuration,
            this.TimeServiceEnds,
            this.TotalDelay});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 509);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Customer_num
            // 
            this.Customer_num.HeaderText = "Customer_num";
            this.Customer_num.Name = "Customer_num";
            this.Customer_num.ReadOnly = true;
            // 
            // InterArrivalTime
            // 
            this.InterArrivalTime.HeaderText = "InterArrivalTime";
            this.InterArrivalTime.Name = "InterArrivalTime";
            this.InterArrivalTime.ReadOnly = true;
            // 
            // Arrival_time
            // 
            this.Arrival_time.HeaderText = "ArrivalTime";
            this.Arrival_time.Name = "Arrival_time";
            this.Arrival_time.ReadOnly = true;
            // 
            // ServerIndex
            // 
            this.ServerIndex.HeaderText = "ServerIndex";
            this.ServerIndex.Name = "ServerIndex";
            this.ServerIndex.ReadOnly = true;
            // 
            // TimeServiceBegins
            // 
            this.TimeServiceBegins.HeaderText = "TimeServiceBegins";
            this.TimeServiceBegins.Name = "TimeServiceBegins";
            this.TimeServiceBegins.ReadOnly = true;
            // 
            // ServiceDuration
            // 
            this.ServiceDuration.HeaderText = "ServiceDuration";
            this.ServiceDuration.Name = "ServiceDuration";
            this.ServiceDuration.ReadOnly = true;
            // 
            // TimeServiceEnds
            // 
            this.TimeServiceEnds.HeaderText = "TimeServiceEnds";
            this.TimeServiceEnds.Name = "TimeServiceEnds";
            this.TimeServiceEnds.ReadOnly = true;
            // 
            // TotalDelay
            // 
            this.TotalDelay.HeaderText = "TotalDelay";
            this.TotalDelay.Name = "TotalDelay";
            this.TotalDelay.ReadOnly = true;
            // 
            // results_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 533);
            this.Controls.Add(this.dataGridView1);
            this.Name = "results_table";
            this.Text = "results_table";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeServiceBegins;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeServiceEnds;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDelay;
    }
}