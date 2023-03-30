using System;
using System.Windows.Forms;

namespace Graph
{
    public partial class Form1 : Form
    {
        double x = 0;
        double max = 50;
        double step = 0.5;
        double yaxis = 0;
        double xaxis = 1;
        public Form1()
        {
            InitializeComponent();
            yaxisBar.Maximum = 100;
            yaxisBar.Minimum = -100;

            xaxisBar.Maximum = 50;
            xaxisBar.Minimum = 1;

            Xvalue.Text = xaxis.ToString();
            YValue.Text = yaxis.ToString();

            drawGraph();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void yaxisBar_Scroll(object sender, EventArgs e)
        {
            yaxis = (double)yaxisBar.Value / 10;
            YValue.Text = Convert.ToString((double)yaxisBar.Value / 10);
            drawGraph();

        }

        private void xaxisBar_Scroll(object sender, EventArgs e)
        {
            xaxis = (double)xaxisBar.Value / 10;
            Xvalue.Text = Convert.ToString((double)xaxisBar.Value / 10);
            drawGraph();

        }
        public void drawGraph()
        {
            graph.Series[0].Points.Clear();
            while (x < max)
            {
                graph.Series[0].Points.AddXY(x, Math.Sin(x * xaxis) + yaxis);
                x += step;
            }
            x = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Xvalue_Click(object sender, EventArgs e)
        {

        }
    }
}