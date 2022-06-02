using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using System.Windows.Forms.DataVisualization.Charting;


namespace MathematicalPendulum
{
    public partial class Form1 : Form
    {
        private Draw draw;
        private PendulumCalculate calculate;
        double p;
        int check;
        double _time;

        public Form1()
        {

            InitializeComponent();

            chart1.ChartAreas[0].AxisX.Minimum = -2;
            chart1.ChartAreas[0].AxisX.Maximum = 2;
            chart1.ChartAreas[0].AxisY.Minimum = -10;
            chart1.ChartAreas[0].AxisY.Maximum = 10;
            chart2.ChartAreas[0].AxisX.Interval = 1;
            chart2.ChartAreas[0].AxisX.Minimum = 0;


            timer1.Interval = 10;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            check = 0;
            _time = -1;
            label23.Text = null;
            foreach (Control gb in this.Controls)
            {
                if (gb is GroupBox)
                {
                    foreach (Control tb in gb.Controls)
                    {
                        if (tb is TextBox)
                        {
                            tb.Enabled = false;
                        }
                    }
                }
            }

            chart1.Series.Clear(); 
            chart2.Series.Clear(); 

            for (int i = 0; i < Convert.ToInt32(textBoxNumber.Text); i++)
            {
                string str = (i + 1).ToString();
                Series S = chart1.Series.Add(str);
                S.ChartType = SeriesChartType.Line;
                Series S1 = chart2.Series.Add(str);
                S1.ChartType = SeriesChartType.Line;
            }

            draw = new Draw(pictureBoxPendulumMove.Width, pictureBoxPendulumMove.Height);
            calculate = new PendulumCalculate(Convert.ToDouble(textBoxLength.Text),
                Convert.ToDouble(textBoxAngle.Text),
                Convert.ToDouble(textBoxWeight.Text),
                pictureBoxPendulumMove.Width, pictureBoxPendulumMove.Height, Convert.ToDouble(textBoxViscousFrictionCoefficient.Text), Convert.ToDouble(textBoxDryFrictionCoefficient.Text), Convert.ToDouble(textBoxStartSpeed.Text), Convert.ToDouble(textBoxPower.Text), Convert.ToDouble(textBoxStartAngle.Text), Convert.ToDouble(textBoxEndAngle.Text), Convert.ToInt32(textBoxNumber.Text), Convert.ToDouble(textBoxDT.Text));

            p = calculate.CurrentAngle;
            calculate.FillList();

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < Convert.ToInt32(textBoxNumber.Text); i++)
            {
                double[] mas = calculate.PhaseCalculate(calculate.data[i].angle, calculate.data[i].speed, calculate.data[i].time);
                calculate.data[i] = new PointD(mas[0], mas[1], mas[2]);

                if (calculate.data[i].angle <= 0 && p >= 0)
                {
                    check++;
                    if (_time == -1)
                    {
                        _time = calculate.time;
                    }
                    else
                    {
                        double razn = calculate.time - _time;
                        _time = calculate.time;
                        label23.Text = Convert.ToString(razn);
                        Console.WriteLine(razn);
                    }
                    
                    label22.Text = Convert.ToString(check);
                }

                p = calculate.data[i].angle;
              
                chart1.Series[i].Points.AddXY(calculate.data[i].angle, calculate.data[i].speed);
                chart2.Series[i].Points.AddXY(calculate.data[i].time, calculate.data[i].angle);
            }
            pictureBoxPendulumMove.Image = draw.DrawPendulum(calculate.CalculateFollowingProvision());
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            foreach (Control gb in this.Controls)
            {
                if (gb is GroupBox)
                {
                    foreach (Control tb in gb.Controls)
                    {
                        if (tb is TextBox)
                        {
                            tb.Enabled = true;
                        }
                    }
                }
            }
        }

        private void groupBoxImpactOfForce_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPower_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStartSpeed_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAngle_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxInitialConditions_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxDryFrictionCoefficient_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
