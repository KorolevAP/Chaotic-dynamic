using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chaos
{

    public struct InputParams
    {
        public int itersNum { set; get; }
        public double startingPoint { set; get; }
    }
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private InputParams inputParams;
        private BiffurcationMap createBiffurcationMap()
        {
            BiffurcationMap map;
            double coef = Convert.ToDouble(this.textBox_coeff.Text);
            if (rb_IsTent.Checked)
            {
                return new TentMap(coef);
            }
            else if (rb_IsLog.Checked)
            {
                return new LogisticMap(coef);
            }
            else
            {
                map = new SinMap(coef);
            }
            return map;
        }

        private void setAxis()
        {
            chart_orbits.Series[0].Name = "F(x)";
            chart_orbits.Series[1].Name = "F = x";
            chart_orbits.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart_orbits.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart_orbits.ChartAreas[0].AxisY.Minimum = 0.05;
            chart_orbits.ChartAreas[0].AxisY.Maximum = 1.05;
            chart_orbits.ChartAreas[0].AxisX.Minimum = -0.05;
            chart_orbits.ChartAreas[0].AxisX.Maximum = 1.05;
        }
        void setInputParams()
        {
            inputParams.startingPoint = Convert.ToDouble(textBox_startingPoint.Text);
            inputParams.itersNum =  Convert.ToInt32(textBox_maxIter.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            setInputParams();
            setAxis();
            var map = createBiffurcationMap();
            
            Queue<double> que = new Queue<double>(10);
            double x_0 = Convert.ToDouble(textBox_startingPoint.Text);
            
            
            que.Enqueue(x_0);    
            double x = 0;
            double h = 1.0 / 40;
            for (int j = 0; j < 40; j++)
            {
                chart_orbits.Series[0].Points.AddXY(x, map.nextPoint(x));
                x += h;
            }
            chart_orbits.Series[2].Name = map.mapName;

            string s1 = $"Рассматривали {map.mapName} при x_0 = {x_0}, k = {map.coefficient}  ";
            chart_orbits.Series[1].Points.AddXY(0, 0);
            chart_orbits.Series[1].Points.AddXY(1, 1);
            
            dataGridView_orbitsTable.Rows.Add(0, x_0);
            bool IsFixed = false;
            chart_orbits.Series[2].Color = Color.Red;
            int i = 1;
            for (; i < inputParams.itersNum && x_0 != 0; i++)
            {
                if (IsFixed == true) break;
                double x_1 = map.nextPoint(x_0);
                chart_orbits.Series[2].Points.AddXY(x_0, x_1);
                chart_orbits.Series[2].Points.AddXY(x_1, x_1);
                dataGridView_orbitsTable.Rows.Add(i, x_1);
                x_0 = Math.Round(x_1, 11);
                if (que.Count > 10000) que.Dequeue();

                foreach (var s in que)
                {
                    if (s == x_0)
                    {
                        IsFixed = true;
                        chart_orbits.Series[2].Color = Color.Black;
                        break;
                    }
                }
                que.Enqueue(x_0);
            }
            if (x_0 == 0) { IsFixed = true; chart_orbits.Series[2].Color = Color.Black; }
            if (IsFixed)
            {
                string s2 = $"Точка является периодической с периодом {i}";
                Form form = new ResultWindow(s1, s2);
                form.Show();
            }
            if (!IsFixed)
            {
                string s2 = $"Точка не является периодической";
                Form form = new ResultWindow(s1, s2);
                form.Show();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            chart_orbits.Series[0].Points.ClearQuick();
            chart_orbits.Series[1].Points.ClearQuick();
            chart_orbits.Series[2].Points.ClearQuick();
            chart_biffurcation.Series[0].Points.ClearQuick();
            dataGridView_orbitsTable.Rows.Clear();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            var flag = 0;
            if (rb_IsTent.Checked)
            {
                flag = 1;
                chart_biffurcation.ChartAreas[0].AxisY.Minimum = -0.005;
                chart_biffurcation.ChartAreas[0].AxisY.Maximum = 1.05;
            }
            if (rb_IsLog.Checked)
            {
                flag = 2;
                chart_biffurcation.ChartAreas[0].AxisY.Minimum = -0.1;
                chart_biffurcation.ChartAreas[0].AxisY.Maximum = 1.05;
            }
            if (rb_IsSin.Checked)
            {
                flag = 3;
                chart_biffurcation.ChartAreas[0].AxisY.Minimum = -4.05;
                chart_biffurcation.ChartAreas[0].AxisY.Maximum = 4.05;
            }
           
            double x_0 = Convert.ToDouble(textBox_startingPoint.Text);
            double coef = Convert.ToDouble(textBox_startingCoeff.Text);
            double coef_end = Convert.ToDouble(textBox_endingCoeff.Text);
            double N_max = Convert.ToDouble(textBox_maxIter.Text);
            double h = (-coef + coef_end) / 1000;
            var eps = h / 10;
            chart_biffurcation.ChartAreas[0].AxisX.Minimum = coef - eps;
            chart_biffurcation.ChartAreas[0].AxisX.Maximum = coef_end + eps;
            chart_biffurcation.Series[0].Points.ClearQuick();
            chart_biffurcation.Series[0].Points.SuspendUpdates();
            List<double> check_biff= new List<double>();
            List<double> arr_biff = new List<double>();
            var for_me = new List<int>();
            int check_count = 1;
            var epsilon = 1e-2;
            bool checker = false;
            for (; coef <= coef_end; coef += h)
            {
                check_biff.Clear();
                var x = x_0;
                for (int i = 0; i < 500; i++)
                {
                    x = next_x.next(flag, coef, x);
                }
                check_biff.Add(x);
                for (int i = 0; i < N_max; i++)
                {
                    checker = false;
                    x = next_x.next(flag, coef, x);
                    chart_biffurcation.Series[0].Points.AddXY(coef, x);
                    if (check_biff.Count()<16) foreach(double elem in check_biff)
                    {
                        if (Math.Abs(elem - x) < epsilon) { checker = true; break; }
                    }
                    if (!checker && (check_biff.Count() < 16))
                    {
                        check_biff.Add(x);
                    }
                    //chart2.Series[0].Points.AddXY(coef, x);// next_x.next(flag, coef)(x));
                }
                if (check_biff.Count() != check_count)
                {
                    arr_biff.Add(coef);
                    for_me.Add(check_biff.Count());
                }
                check_count = check_biff.Count();
               
            }
            
             chart_biffurcation.Series[0].Points.ResumeUpdates();
            dataGridView_bifurcationTable.Rows.Clear();
            for(int i = 0; i < arr_biff.Count(); i++)
            {
                dataGridView_bifurcationTable.Rows.Add(i, arr_biff[i],for_me[i]);
            }
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var flag = 0;
            if (rb_IsTent.Checked)
            {
                flag = 1;
                chart_biffurcation.ChartAreas[0].AxisY.Minimum = -0.005;
                chart_biffurcation.ChartAreas[0].AxisY.Maximum = 1.05;
            }
            if (rb_IsLog.Checked)
            {
                flag = 2;
                chart_biffurcation.ChartAreas[0].AxisY.Minimum = -0.1;
                chart_biffurcation.ChartAreas[0].AxisY.Maximum = 1.05;
            }
            if (rb_IsSin.Checked)
            {
                flag = 3;
                chart_biffurcation.ChartAreas[0].AxisY.Minimum = -4.05;
                chart_biffurcation.ChartAreas[0].AxisY.Maximum = 4.05;
            }

            flag = 4;
            double x_0 = Convert.ToDouble(textBox_startingPoint.Text);
            double coef = Convert.ToDouble(textBox_startingCoeff.Text);
            double coef_end = Convert.ToDouble(textBox_endingCoeff.Text);
            double N_max = Convert.ToDouble(textBox_maxIter.Text);
            double h = (-coef + coef_end) / 1000;
            var eps = h / 10;
            chart_biffurcation.ChartAreas[0].AxisX.Minimum = coef - eps;
            chart_biffurcation.ChartAreas[0].AxisX.Maximum = coef_end + eps;
            chart_biffurcation.Series[0].Points.ClearQuick();
            chart_biffurcation.Series[0].Points.SuspendUpdates();
            List<double> check_biff = new List<double>();
            List<double> arr_biff = new List<double>();
            var for_me = new List<int>();
            int check_count = 1;
            var epsilon = 1e-2;
            bool checker = false;
            for (; coef <= coef_end; coef += h)
            {
                check_biff.Clear();
                var x = x_0;
                for (int i = 0; i < 500; i++)
                {
                    x = next_x.next(flag, coef, x);
                }
                check_biff.Add(x);
                for (int i = 0; i < N_max; i++)
                {
                    checker = false;
                    x = next_x.next(flag, coef, x);
                    chart_biffurcation.Series[0].Points.AddXY(coef, x);
                    if (check_biff.Count() < 16) foreach (double elem in check_biff)
                        {
                            if (Math.Abs(elem - x) < epsilon) { checker = true; break; }
                        }
                    if (!checker && (check_biff.Count() < 16))
                    {
                        check_biff.Add(x);
                    }
                    //chart2.Series[0].Points.AddXY(coef, x);// next_x.next(flag, coef)(x));
                }
                if (check_biff.Count() != check_count)
                {
                    arr_biff.Add(coef);
                    for_me.Add(check_biff.Count());
                }
                check_count = check_biff.Count();

            }

            chart_biffurcation.Series[0].Points.ResumeUpdates();
            dataGridView_bifurcationTable.Rows.Clear();
            for (int i = 0; i < arr_biff.Count(); i++)
            {
                dataGridView_bifurcationTable.Rows.Add(i, arr_biff[i], for_me[i]);
            }
        }
    }
}
