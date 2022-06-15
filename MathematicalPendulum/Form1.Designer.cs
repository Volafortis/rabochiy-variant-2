namespace MathematicalPendulum
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBoxPendulumMove = new System.Windows.Forms.PictureBox();
            this.groupBoxInitialConditions = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.textBoxDT = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDryFrictionCoefficient = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxViscousFrictionCoefficient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStartSpeed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAngle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ggg = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBoxPendulumControl = new System.Windows.Forms.GroupBox();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxPower = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxStartAngle = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxEndAngle = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBoxImpactOfForce = new System.Windows.Forms.GroupBox();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPendulumMove)).BeginInit();
            this.groupBoxInitialConditions.SuspendLayout();
            this.groupBoxPendulumControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.groupBoxImpactOfForce.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPendulumMove
            // 
            this.pictureBoxPendulumMove.Location = new System.Drawing.Point(-149, 25);
            this.pictureBoxPendulumMove.Name = "pictureBoxPendulumMove";
            this.pictureBoxPendulumMove.Size = new System.Drawing.Size(957, 507);
            this.pictureBoxPendulumMove.TabIndex = 0;
            this.pictureBoxPendulumMove.TabStop = false;
            // 
            // groupBoxInitialConditions
            // 
            this.groupBoxInitialConditions.Controls.Add(this.label23);
            this.groupBoxInitialConditions.Controls.Add(this.label22);
            this.groupBoxInitialConditions.Controls.Add(this.textBoxDT);
            this.groupBoxInitialConditions.Controls.Add(this.label13);
            this.groupBoxInitialConditions.Controls.Add(this.label20);
            this.groupBoxInitialConditions.Controls.Add(this.label11);
            this.groupBoxInitialConditions.Controls.Add(this.label12);
            this.groupBoxInitialConditions.Controls.Add(this.label8);
            this.groupBoxInitialConditions.Controls.Add(this.textBoxDryFrictionCoefficient);
            this.groupBoxInitialConditions.Controls.Add(this.label14);
            this.groupBoxInitialConditions.Controls.Add(this.label7);
            this.groupBoxInitialConditions.Controls.Add(this.textBoxViscousFrictionCoefficient);
            this.groupBoxInitialConditions.Controls.Add(this.label6);
            this.groupBoxInitialConditions.Controls.Add(this.label5);
            this.groupBoxInitialConditions.Controls.Add(this.label4);
            this.groupBoxInitialConditions.Controls.Add(this.textBoxWeight);
            this.groupBoxInitialConditions.Controls.Add(this.label3);
            this.groupBoxInitialConditions.Controls.Add(this.textBoxStartSpeed);
            this.groupBoxInitialConditions.Controls.Add(this.label2);
            this.groupBoxInitialConditions.Controls.Add(this.textBoxAngle);
            this.groupBoxInitialConditions.Controls.Add(this.label1);
            this.groupBoxInitialConditions.Controls.Add(this.ggg);
            this.groupBoxInitialConditions.Location = new System.Drawing.Point(51, 399);
            this.groupBoxInitialConditions.Name = "groupBoxInitialConditions";
            this.groupBoxInitialConditions.Size = new System.Drawing.Size(198, 234);
            this.groupBoxInitialConditions.TabIndex = 1;
            this.groupBoxInitialConditions.TabStop = false;
            this.groupBoxInitialConditions.Text = "Начальные условия";
            this.groupBoxInitialConditions.Enter += new System.EventHandler(this.groupBoxInitialConditions_Enter);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(34, 245);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(10, 13);
            this.label23.TabIndex = 24;
            this.label23.Text = ".";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 245);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(10, 13);
            this.label22.TabIndex = 23;
            this.label22.Text = ".";
            // 
            // textBoxDT
            // 
            this.textBoxDT.Location = new System.Drawing.Point(127, 131);
            this.textBoxDT.Name = "textBoxDT";
            this.textBoxDT.Size = new System.Drawing.Size(39, 20);
            this.textBoxDT.TabIndex = 20;
            this.textBoxDT.Text = "0,01";
            this.textBoxDT.TextChanged += new System.EventHandler(this.textBoxDT_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(172, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "   ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 134);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 13);
            this.label20.TabIndex = 21;
            this.label20.Text = "Параметр dt";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(172, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "   ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Коэф. сухого трения";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "кг";
            // 
            // textBoxDryFrictionCoefficient
            // 
            this.textBoxDryFrictionCoefficient.Location = new System.Drawing.Point(127, 190);
            this.textBoxDryFrictionCoefficient.Name = "textBoxDryFrictionCoefficient";
            this.textBoxDryFrictionCoefficient.Size = new System.Drawing.Size(39, 20);
            this.textBoxDryFrictionCoefficient.TabIndex = 12;
            this.textBoxDryFrictionCoefficient.Text = "0,01";
            this.textBoxDryFrictionCoefficient.TextChanged += new System.EventHandler(this.textBoxDryFrictionCoefficient_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 164);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Коэф. вязк. трения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "м/с";
            // 
            // textBoxViscousFrictionCoefficient
            // 
            this.textBoxViscousFrictionCoefficient.Location = new System.Drawing.Point(127, 164);
            this.textBoxViscousFrictionCoefficient.Name = "textBoxViscousFrictionCoefficient";
            this.textBoxViscousFrictionCoefficient.Size = new System.Drawing.Size(39, 20);
            this.textBoxViscousFrictionCoefficient.TabIndex = 15;
            this.textBoxViscousFrictionCoefficient.Text = "0,01";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "°";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "м";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Масса";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(127, 105);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(39, 20);
            this.textBoxWeight.TabIndex = 6;
            this.textBoxWeight.Text = "0,2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Нач. угл. скорость";
            // 
            // textBoxStartSpeed
            // 
            this.textBoxStartSpeed.Location = new System.Drawing.Point(127, 77);
            this.textBoxStartSpeed.Name = "textBoxStartSpeed";
            this.textBoxStartSpeed.Size = new System.Drawing.Size(39, 20);
            this.textBoxStartSpeed.TabIndex = 4;
            this.textBoxStartSpeed.Text = "0,1";
            this.textBoxStartSpeed.TextChanged += new System.EventHandler(this.textBoxStartSpeed_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Угол";
            // 
            // textBoxAngle
            // 
            this.textBoxAngle.Location = new System.Drawing.Point(127, 49);
            this.textBoxAngle.Name = "textBoxAngle";
            this.textBoxAngle.Size = new System.Drawing.Size(39, 20);
            this.textBoxAngle.TabIndex = 2;
            this.textBoxAngle.Text = "90";
            this.textBoxAngle.TextChanged += new System.EventHandler(this.textBoxAngle_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Длина";
            // 
            // ggg
            // 
            this.ggg.Location = new System.Drawing.Point(127, 24);
            this.ggg.Name = "ggg";
            this.ggg.Size = new System.Drawing.Size(39, 20);
            this.ggg.TabIndex = 0;
            this.ggg.Text = "0,3";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(320, 620);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(13, 13);
            this.label21.TabIndex = 22;
            this.label21.Text = "c";
            // 
            // groupBoxPendulumControl
            // 
            this.groupBoxPendulumControl.Controls.Add(this.buttonPause);
            this.groupBoxPendulumControl.Controls.Add(this.buttonStart);
            this.groupBoxPendulumControl.Location = new System.Drawing.Point(51, 342);
            this.groupBoxPendulumControl.Name = "groupBoxPendulumControl";
            this.groupBoxPendulumControl.Size = new System.Drawing.Size(200, 50);
            this.groupBoxPendulumControl.TabIndex = 2;
            this.groupBoxPendulumControl.TabStop = false;
            this.groupBoxPendulumControl.Text = "Управление маятником";
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(107, 21);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(79, 23);
            this.buttonPause.TabIndex = 1;
            this.buttonPause.Text = "Пауза";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(8, 21);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(81, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // chart1
            // 
            this.chart1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipX;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(660, 25);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.LegendText = "\\n";
            series1.LegendToolTip = "Фазовый портрет";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(400, 312);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(247, 330);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.LegendText = "\\n";
            series2.LegendToolTip = "Фазовая траектория";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 2;
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(845, 327);
            this.chart2.TabIndex = 5;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBoxPower
            // 
            this.textBoxPower.Location = new System.Drawing.Point(120, 17);
            this.textBoxPower.Name = "textBoxPower";
            this.textBoxPower.Size = new System.Drawing.Size(39, 20);
            this.textBoxPower.TabIndex = 9;
            this.textBoxPower.Text = "0";
            this.textBoxPower.TextChanged += new System.EventHandler(this.textBoxPower_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Сила";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 128);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "Кол-во фаз.траект.";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(4, 90);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(39, 20);
            this.textBoxNumber.TabIndex = 18;
            this.textBoxNumber.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(172, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Н";
            // 
            // textBoxStartAngle
            // 
            this.textBoxStartAngle.Location = new System.Drawing.Point(127, 46);
            this.textBoxStartAngle.Name = "textBoxStartAngle";
            this.textBoxStartAngle.Size = new System.Drawing.Size(39, 20);
            this.textBoxStartAngle.TabIndex = 13;
            this.textBoxStartAngle.Text = "15";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "φ max";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(172, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "°";
            // 
            // textBoxEndAngle
            // 
            this.textBoxEndAngle.Location = new System.Drawing.Point(127, 72);
            this.textBoxEndAngle.Name = "textBoxEndAngle";
            this.textBoxEndAngle.Size = new System.Drawing.Size(39, 20);
            this.textBoxEndAngle.TabIndex = 16;
            this.textBoxEndAngle.Text = "5";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 75);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "φ min";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(172, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(11, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "°";
            // 
            // groupBoxImpactOfForce
            // 
            this.groupBoxImpactOfForce.Controls.Add(this.label17);
            this.groupBoxImpactOfForce.Controls.Add(this.label18);
            this.groupBoxImpactOfForce.Controls.Add(this.textBoxEndAngle);
            this.groupBoxImpactOfForce.Controls.Add(this.label15);
            this.groupBoxImpactOfForce.Controls.Add(this.label16);
            this.groupBoxImpactOfForce.Controls.Add(this.textBoxStartAngle);
            this.groupBoxImpactOfForce.Controls.Add(this.label9);
            this.groupBoxImpactOfForce.Controls.Add(this.textBoxNumber);
            this.groupBoxImpactOfForce.Controls.Add(this.label19);
            this.groupBoxImpactOfForce.Controls.Add(this.label10);
            this.groupBoxImpactOfForce.Controls.Add(this.textBoxPower);
            this.groupBoxImpactOfForce.Location = new System.Drawing.Point(1287, 41);
            this.groupBoxImpactOfForce.Name = "groupBoxImpactOfForce";
            this.groupBoxImpactOfForce.Size = new System.Drawing.Size(197, 219);
            this.groupBoxImpactOfForce.TabIndex = 3;
            this.groupBoxImpactOfForce.TabStop = false;
            this.groupBoxImpactOfForce.Text = "Воздействие силы";
            this.groupBoxImpactOfForce.Enter += new System.EventHandler(this.groupBoxImpactOfForce_Enter);
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(1116, 330);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(542, 327);
            this.chart3.TabIndex = 23;
            this.chart3.Text = "chart3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 661);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.groupBoxImpactOfForce);
            this.Controls.Add(this.groupBoxPendulumControl);
            this.Controls.Add(this.groupBoxInitialConditions);
            this.Controls.Add(this.pictureBoxPendulumMove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Математический маятник";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPendulumMove)).EndInit();
            this.groupBoxInitialConditions.ResumeLayout(false);
            this.groupBoxInitialConditions.PerformLayout();
            this.groupBoxPendulumControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.groupBoxImpactOfForce.ResumeLayout(false);
            this.groupBoxImpactOfForce.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPendulumMove;
        private System.Windows.Forms.GroupBox groupBoxInitialConditions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStartSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAngle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.GroupBox groupBoxPendulumControl;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxViscousFrictionCoefficient;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxDryFrictionCoefficient;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxDT;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBoxPower;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxStartAngle;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxEndAngle;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBoxImpactOfForce;
        private System.Windows.Forms.TextBox ggg;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
    }
}

