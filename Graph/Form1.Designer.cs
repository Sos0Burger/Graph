namespace Graph
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.yaxisBar = new System.Windows.Forms.TrackBar();
            this.xaxisBar = new System.Windows.Forms.TrackBar();
            this.Ytext = new System.Windows.Forms.Label();
            this.Xtext = new System.Windows.Forms.Label();
            this.YValue = new System.Windows.Forms.Label();
            this.Xvalue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yaxisBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xaxisBar)).BeginInit();
            this.SuspendLayout();
            // 
            // graph
            // 
            chartArea3.Name = "ChartArea1";
            this.graph.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.graph.Legends.Add(legend3);
            this.graph.Location = new System.Drawing.Point(12, 24);
            this.graph.Name = "graph";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "sin(x)";
            this.graph.Series.Add(series3);
            this.graph.Size = new System.Drawing.Size(579, 398);
            this.graph.TabIndex = 0;
            this.graph.Text = "graph";
            this.graph.Click += new System.EventHandler(this.chart1_Click);
            // 
            // yaxisBar
            // 
            this.yaxisBar.Location = new System.Drawing.Point(597, 103);
            this.yaxisBar.Name = "yaxisBar";
            this.yaxisBar.Size = new System.Drawing.Size(191, 45);
            this.yaxisBar.TabIndex = 1;
            this.yaxisBar.Scroll += new System.EventHandler(this.yaxisBar_Scroll);
            // 
            // xaxisBar
            // 
            this.xaxisBar.Location = new System.Drawing.Point(597, 273);
            this.xaxisBar.Name = "xaxisBar";
            this.xaxisBar.Size = new System.Drawing.Size(191, 45);
            this.xaxisBar.TabIndex = 2;
            this.xaxisBar.Scroll += new System.EventHandler(this.xaxisBar_Scroll);
            // 
            // Ytext
            // 
            this.Ytext.AutoSize = true;
            this.Ytext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ytext.Location = new System.Drawing.Point(676, 69);
            this.Ytext.Name = "Ytext";
            this.Ytext.Size = new System.Drawing.Size(32, 31);
            this.Ytext.TabIndex = 3;
            this.Ytext.Text = "Y";
            // 
            // Xtext
            // 
            this.Xtext.AutoSize = true;
            this.Xtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Xtext.Location = new System.Drawing.Point(676, 239);
            this.Xtext.Name = "Xtext";
            this.Xtext.Size = new System.Drawing.Size(32, 31);
            this.Xtext.TabIndex = 4;
            this.Xtext.Text = "X";
            // 
            // YValue
            // 
            this.YValue.AutoSize = true;
            this.YValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YValue.Location = new System.Drawing.Point(676, 151);
            this.YValue.Name = "YValue";
            this.YValue.Size = new System.Drawing.Size(32, 31);
            this.YValue.TabIndex = 5;
            this.YValue.Text = "Y";
            // 
            // Xvalue
            // 
            this.Xvalue.AutoSize = true;
            this.Xvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Xvalue.Location = new System.Drawing.Point(676, 321);
            this.Xvalue.Name = "Xvalue";
            this.Xvalue.Size = new System.Drawing.Size(32, 31);
            this.Xvalue.TabIndex = 6;
            this.Xvalue.Text = "X";
            this.Xvalue.Click += new System.EventHandler(this.Xvalue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Xvalue);
            this.Controls.Add(this.YValue);
            this.Controls.Add(this.Xtext);
            this.Controls.Add(this.Ytext);
            this.Controls.Add(this.xaxisBar);
            this.Controls.Add(this.yaxisBar);
            this.Controls.Add(this.graph);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Graph";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yaxisBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xaxisBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
        private System.Windows.Forms.TrackBar yaxisBar;
        private System.Windows.Forms.TrackBar xaxisBar;
        private System.Windows.Forms.Label Ytext;
        private System.Windows.Forms.Label Xtext;
        private System.Windows.Forms.Label YValue;
        private System.Windows.Forms.Label Xvalue;
    }
}

