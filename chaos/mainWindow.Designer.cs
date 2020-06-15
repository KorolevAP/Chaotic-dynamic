namespace chaos
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_coeff = new System.Windows.Forms.TextBox();
            this.textBox_startingPoint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_addGraphics = new System.Windows.Forms.Button();
            this.button_ClearGraphics = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_addReverseDiagramm = new System.Windows.Forms.Button();
            this.button_addDiagramm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_maxIter = new System.Windows.Forms.TextBox();
            this.textBox_endingCoeff = new System.Windows.Forms.TextBox();
            this.textBox_startingCoeff = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_IsSin = new System.Windows.Forms.RadioButton();
            this.rb_IsLog = new System.Windows.Forms.RadioButton();
            this.rb_IsTent = new System.Windows.Forms.RadioButton();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView_orbitsTable = new System.Windows.Forms.DataGridView();
            this.n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView_bifurcationTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chart_orbits = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart_biffurcation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_orbitsTable)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bifurcationTable)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_orbits)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_biffurcation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1324, 600);
            this.splitContainer1.SplitterDistance = 531;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer2.Size = new System.Drawing.Size(531, 600);
            this.splitContainer2.SplitterDistance = 218;
            this.splitContainer2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.rb_IsSin);
            this.groupBox1.Controls.Add(this.rb_IsLog);
            this.groupBox1.Controls.Add(this.rb_IsTent);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Входные параметры";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_coeff);
            this.groupBox3.Controls.Add(this.textBox_startingPoint);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.button_addGraphics);
            this.groupBox3.Controls.Add(this.button_ClearGraphics);
            this.groupBox3.Location = new System.Drawing.Point(144, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 174);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Построение орбиты";
            // 
            // textBox_coeff
            // 
            this.textBox_coeff.Location = new System.Drawing.Point(71, 21);
            this.textBox_coeff.Name = "textBox_coeff";
            this.textBox_coeff.Size = new System.Drawing.Size(100, 22);
            this.textBox_coeff.TabIndex = 3;
            this.textBox_coeff.Text = "2";
            // 
            // textBox_startingPoint
            // 
            this.textBox_startingPoint.Location = new System.Drawing.Point(71, 45);
            this.textBox_startingPoint.Name = "textBox_startingPoint";
            this.textBox_startingPoint.Size = new System.Drawing.Size(100, 22);
            this.textBox_startingPoint.TabIndex = 2;
            this.textBox_startingPoint.Text = "0,5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "k";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "x0";
            // 
            // button_addGraphics
            // 
            this.button_addGraphics.Location = new System.Drawing.Point(6, 73);
            this.button_addGraphics.Name = "button_addGraphics";
            this.button_addGraphics.Size = new System.Drawing.Size(174, 26);
            this.button_addGraphics.TabIndex = 10;
            this.button_addGraphics.Text = "Добавить орбиту";
            this.button_addGraphics.UseVisualStyleBackColor = true;
            this.button_addGraphics.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_ClearGraphics
            // 
            this.button_ClearGraphics.Location = new System.Drawing.Point(6, 102);
            this.button_ClearGraphics.Name = "button_ClearGraphics";
            this.button_ClearGraphics.Size = new System.Drawing.Size(174, 26);
            this.button_ClearGraphics.TabIndex = 11;
            this.button_ClearGraphics.Text = "Очистить";
            this.button_ClearGraphics.UseVisualStyleBackColor = true;
            this.button_ClearGraphics.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_addReverseDiagramm);
            this.groupBox2.Controls.Add(this.button_addDiagramm);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox_maxIter);
            this.groupBox2.Controls.Add(this.textBox_endingCoeff);
            this.groupBox2.Controls.Add(this.textBox_startingCoeff);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(336, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 174);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Построение диаграммы";
            // 
            // button_addReverseDiagramm
            // 
            this.button_addReverseDiagramm.Location = new System.Drawing.Point(9, 135);
            this.button_addReverseDiagramm.Name = "button_addReverseDiagramm";
            this.button_addReverseDiagramm.Size = new System.Drawing.Size(184, 23);
            this.button_addReverseDiagramm.TabIndex = 19;
            this.button_addReverseDiagramm.Text = "Построить обратную";
            this.button_addReverseDiagramm.UseVisualStyleBackColor = true;
            this.button_addReverseDiagramm.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_addDiagramm
            // 
            this.button_addDiagramm.Location = new System.Drawing.Point(8, 102);
            this.button_addDiagramm.Name = "button_addDiagramm";
            this.button_addDiagramm.Size = new System.Drawing.Size(187, 26);
            this.button_addDiagramm.TabIndex = 13;
            this.button_addDiagramm.Text = "Построить диаграмму";
            this.button_addDiagramm.UseVisualStyleBackColor = true;
            this.button_addDiagramm.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "N_max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "]";
            // 
            // textBox_maxIter
            // 
            this.textBox_maxIter.Location = new System.Drawing.Point(74, 35);
            this.textBox_maxIter.Name = "textBox_maxIter";
            this.textBox_maxIter.Size = new System.Drawing.Size(100, 22);
            this.textBox_maxIter.TabIndex = 8;
            this.textBox_maxIter.Text = "100";
            // 
            // textBox_endingCoeff
            // 
            this.textBox_endingCoeff.Location = new System.Drawing.Point(108, 68);
            this.textBox_endingCoeff.Name = "textBox_endingCoeff";
            this.textBox_endingCoeff.Size = new System.Drawing.Size(40, 22);
            this.textBox_endingCoeff.TabIndex = 17;
            this.textBox_endingCoeff.Text = "3,6";
            // 
            // textBox_startingCoeff
            // 
            this.textBox_startingCoeff.Location = new System.Drawing.Point(48, 68);
            this.textBox_startingCoeff.Name = "textBox_startingCoeff";
            this.textBox_startingCoeff.Size = new System.Drawing.Size(40, 22);
            this.textBox_startingCoeff.TabIndex = 14;
            this.textBox_startingCoeff.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = ",";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "k [";
            // 
            // rb_IsSin
            // 
            this.rb_IsSin.AutoSize = true;
            this.rb_IsSin.Location = new System.Drawing.Point(12, 92);
            this.rb_IsSin.Name = "rb_IsSin";
            this.rb_IsSin.Size = new System.Drawing.Size(80, 21);
            this.rb_IsSin.TabIndex = 12;
            this.rb_IsSin.Text = "SIn map";
            this.rb_IsSin.UseVisualStyleBackColor = true;
            // 
            // rb_IsLog
            // 
            this.rb_IsLog.AutoSize = true;
            this.rb_IsLog.Checked = true;
            this.rb_IsLog.Location = new System.Drawing.Point(12, 61);
            this.rb_IsLog.Name = "rb_IsLog";
            this.rb_IsLog.Size = new System.Drawing.Size(108, 21);
            this.rb_IsLog.TabIndex = 1;
            this.rb_IsLog.TabStop = true;
            this.rb_IsLog.Text = "Logistic map";
            this.rb_IsLog.UseVisualStyleBackColor = true;
            // 
            // rb_IsTent
            // 
            this.rb_IsTent.AutoSize = true;
            this.rb_IsTent.Location = new System.Drawing.Point(12, 34);
            this.rb_IsTent.Name = "rb_IsTent";
            this.rb_IsTent.Size = new System.Drawing.Size(89, 21);
            this.rb_IsTent.TabIndex = 0;
            this.rb_IsTent.Text = "Tent map";
            this.rb_IsTent.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(531, 378);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView_orbitsTable);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(523, 349);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Orbits table";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView_orbitsTable
            // 
            this.dataGridView_orbitsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_orbitsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.n,
            this.x});
            this.dataGridView_orbitsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_orbitsTable.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_orbitsTable.Name = "dataGridView_orbitsTable";
            this.dataGridView_orbitsTable.RowHeadersWidth = 51;
            this.dataGridView_orbitsTable.RowTemplate.Height = 24;
            this.dataGridView_orbitsTable.Size = new System.Drawing.Size(517, 343);
            this.dataGridView_orbitsTable.TabIndex = 0;
            // 
            // n
            // 
            this.n.HeaderText = "n";
            this.n.MinimumWidth = 6;
            this.n.Name = "n";
            this.n.Width = 125;
            // 
            // x
            // 
            this.x.HeaderText = "x";
            this.x.MinimumWidth = 6;
            this.x.Name = "x";
            this.x.Width = 125;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView_bifurcationTable);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(523, 349);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Bifurcation table";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView_bifurcationTable
            // 
            this.dataGridView_bifurcationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_bifurcationTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView_bifurcationTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_bifurcationTable.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_bifurcationTable.Name = "dataGridView_bifurcationTable";
            this.dataGridView_bifurcationTable.RowHeadersWidth = 51;
            this.dataGridView_bifurcationTable.RowTemplate.Height = 24;
            this.dataGridView_bifurcationTable.Size = new System.Drawing.Size(517, 343);
            this.dataGridView_bifurcationTable.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "n";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "C(n)";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "count";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 600);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart_orbits);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(781, 571);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Орбиты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chart_orbits
            // 
            this.chart_orbits.BackColor = System.Drawing.Color.Gainsboro;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            chartArea1.BorderColor = System.Drawing.Color.DarkGray;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            chartArea1.Name = "ChartArea1";
            this.chart_orbits.ChartAreas.Add(chartArea1);
            this.chart_orbits.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_orbits.Legends.Add(legend1);
            this.chart_orbits.Location = new System.Drawing.Point(3, 3);
            this.chart_orbits.Name = "chart_orbits";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.LabelForeColor = System.Drawing.Color.Gainsboro;
            series1.Legend = "Legend1";
            series1.MarkerBorderWidth = 5;
            series1.MarkerColor = System.Drawing.Color.Lime;
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.MarkerSize = 6;
            series3.MarkerStep = 5;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Triangle;
            series3.Name = "Series3";
            this.chart_orbits.Series.Add(series1);
            this.chart_orbits.Series.Add(series2);
            this.chart_orbits.Series.Add(series3);
            this.chart_orbits.Size = new System.Drawing.Size(775, 565);
            this.chart_orbits.TabIndex = 0;
            this.chart_orbits.Text = "chart1";
            title1.Name = "Title1sdsad";
            this.chart_orbits.Titles.Add(title1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart_biffurcation);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(781, 571);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Диагр-а";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart_biffurcation
            // 
            this.chart_biffurcation.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.chart_biffurcation.BorderlineColor = System.Drawing.Color.DeepSkyBlue;
            chartArea2.Name = "ChartArea1";
            this.chart_biffurcation.ChartAreas.Add(chartArea2);
            this.chart_biffurcation.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart_biffurcation.Legends.Add(legend2);
            this.chart_biffurcation.Location = new System.Drawing.Point(3, 3);
            this.chart_biffurcation.Name = "chart_biffurcation";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Legend = "Legend1";
            series4.MarkerSize = 1;
            series4.Name = "BiffDiagram";
            this.chart_biffurcation.Series.Add(series4);
            this.chart_biffurcation.Size = new System.Drawing.Size(775, 565);
            this.chart_biffurcation.TabIndex = 0;
            this.chart_biffurcation.Text = "chart2";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 600);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainWindow";
            this.Text = "Исследование хаотических динамических систем";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_orbitsTable)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bifurcationTable)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_orbits)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_biffurcation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_ClearGraphics;
        private System.Windows.Forms.Button button_addGraphics;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_maxIter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_coeff;
        private System.Windows.Forms.TextBox textBox_startingPoint;
        private System.Windows.Forms.RadioButton rb_IsLog;
        private System.Windows.Forms.RadioButton rb_IsTent;
        private System.Windows.Forms.DataGridView dataGridView_orbitsTable;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_orbits;
        private System.Windows.Forms.DataGridViewTextBoxColumn n;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.RadioButton rb_IsSin;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button_addDiagramm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_biffurcation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_endingCoeff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_startingCoeff;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView_bifurcationTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button_addReverseDiagramm;
    }
}

