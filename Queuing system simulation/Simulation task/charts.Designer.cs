namespace Simulation_task
{
    partial class charts
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.CustomersQueueGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.QueueSizeHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BusyTime1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BusyTime2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl3.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersQueueGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueueSizeHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BusyTime1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BusyTime2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage7);
            this.tabControl3.Controls.Add(this.tabPage8);
            this.tabControl3.Controls.Add(this.tabPage9);
            this.tabControl3.Controls.Add(this.tabPage10);
            this.tabControl3.Location = new System.Drawing.Point(46, 27);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(1206, 481);
            this.tabControl3.TabIndex = 2;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.CustomersQueueGraph);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1198, 455);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "Customers Queue Graph";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.QueueSizeHistogram);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1198, 455);
            this.tabPage8.TabIndex = 2;
            this.tabPage8.Text = "Queue Size Histogram";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.BusyTime1);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(1198, 455);
            this.tabPage9.TabIndex = 3;
            this.tabPage9.Text = "Server Busy Time – Server 1";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.BusyTime2);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(1198, 455);
            this.tabPage10.TabIndex = 4;
            this.tabPage10.Text = "Server Busy Time – Server 2";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // CustomersQueueGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.CustomersQueueGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.CustomersQueueGraph.Legends.Add(legend1);
            this.CustomersQueueGraph.Location = new System.Drawing.Point(34, 6);
            this.CustomersQueueGraph.Name = "CustomersQueueGraph";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.CustomersQueueGraph.Series.Add(series1);
            this.CustomersQueueGraph.Size = new System.Drawing.Size(972, 428);
            this.CustomersQueueGraph.TabIndex = 0;
            this.CustomersQueueGraph.Text = "CustomersQueueGraph";
            // 
            // QueueSizeHistogram
            // 
            chartArea2.Name = "ChartArea1";
            this.QueueSizeHistogram.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.QueueSizeHistogram.Legends.Add(legend2);
            this.QueueSizeHistogram.Location = new System.Drawing.Point(113, 13);
            this.QueueSizeHistogram.Name = "QueueSizeHistogram";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.QueueSizeHistogram.Series.Add(series2);
            this.QueueSizeHistogram.Size = new System.Drawing.Size(972, 428);
            this.QueueSizeHistogram.TabIndex = 1;
            this.QueueSizeHistogram.Text = "QueueSizeHistogram";
            // 
            // BusyTime1
            // 
            chartArea3.Name = "ChartArea1";
            this.BusyTime1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.BusyTime1.Legends.Add(legend3);
            this.BusyTime1.Location = new System.Drawing.Point(113, 13);
            this.BusyTime1.Name = "BusyTime1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.BusyTime1.Series.Add(series3);
            this.BusyTime1.Size = new System.Drawing.Size(972, 428);
            this.BusyTime1.TabIndex = 1;
            this.BusyTime1.Text = "BusyTime1";
            // 
            // BusyTime2
            // 
            chartArea4.Name = "ChartArea1";
            this.BusyTime2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.BusyTime2.Legends.Add(legend4);
            this.BusyTime2.Location = new System.Drawing.Point(113, 13);
            this.BusyTime2.Name = "BusyTime2";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.BusyTime2.Series.Add(series4);
            this.BusyTime2.Size = new System.Drawing.Size(972, 428);
            this.BusyTime2.TabIndex = 1;
            this.BusyTime2.Text = "BusyTime2";
            // 
            // charts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 535);
            this.Controls.Add(this.tabControl3);
            this.Name = "charts";
            this.Text = "charts";
            this.tabControl3.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            this.tabPage10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersQueueGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueueSizeHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BusyTime1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BusyTime2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.DataVisualization.Charting.Chart CustomersQueueGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart QueueSizeHistogram;
        private System.Windows.Forms.DataVisualization.Charting.Chart BusyTime1;
        private System.Windows.Forms.DataVisualization.Charting.Chart BusyTime2;
    }
}