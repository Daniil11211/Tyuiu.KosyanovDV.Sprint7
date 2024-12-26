namespace Forms
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            dataGridViewTable_KDV = new DataGridView();
            buttonOpenFile_KDV = new Button();
            buttonInfo_KDV = new Button();
            buttonSaveFile_KDV = new Button();
            groupBoxSearch_KDV = new GroupBox();
            textBoxSearch_KDV = new TextBox();
            pictureBoxSearch_KDV = new PictureBox();
            buttonSearch_KDV = new Button();
            groupBoxSort_KDV = new GroupBox();
            radioButtonFromEndToStart_KDV = new RadioButton();
            radioButtonFromStartToEnd_KDV = new RadioButton();
            groupBoxCalc_KDV = new GroupBox();
            textBoxRound = new TextBox();
            labelTextRound = new Label();
            textBoxColumn_KDV = new TextBox();
            labelTextColumn_KDV = new Label();
            buttonCalcSum_KDV = new Button();
            buttonCalcAmount = new Button();
            buttonCalcMin_KDV = new Button();
            buttonCalcMax_KDV = new Button();
            buttonCalcAverageValue_KDV = new Button();
            buttonExit_KDV = new Button();
            buttonClear_KDV = new Button();
            openFileDialogTask = new OpenFileDialog();
            saveFileDialogTask = new SaveFileDialog();
            toolTip = new ToolTip(components);
            groupBoxChart_KDV = new GroupBox();
            textBoxChartColumn_KDV = new TextBox();
            labelTextColumn = new Label();
            buttonDeleteChart = new Button();
            buttonBuildChart_KDV = new Button();
            chartPrint_KDV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable_KDV).BeginInit();
            groupBoxSearch_KDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch_KDV).BeginInit();
            groupBoxSort_KDV.SuspendLayout();
            groupBoxCalc_KDV.SuspendLayout();
            groupBoxChart_KDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartPrint_KDV).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTable_KDV
            // 
            dataGridViewTable_KDV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTable_KDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTable_KDV.Location = new Point(33, 287);
            dataGridViewTable_KDV.MinimumSize = new Size(539, 318);
            dataGridViewTable_KDV.Name = "dataGridViewTable_KDV";
            dataGridViewTable_KDV.RowHeadersVisible = false;
            dataGridViewTable_KDV.RowHeadersWidth = 51;
            dataGridViewTable_KDV.Size = new Size(539, 554);
            dataGridViewTable_KDV.TabIndex = 0;
            // 
            // buttonOpenFile_KDV
            // 
            buttonOpenFile_KDV.Anchor = AnchorStyles.Top;
            buttonOpenFile_KDV.Image = (Image)resources.GetObject("buttonOpenFile_KDV.Image");
            buttonOpenFile_KDV.Location = new Point(27, 10);
            buttonOpenFile_KDV.MaximumSize = new Size(150, 68);
            buttonOpenFile_KDV.MinimumSize = new Size(63, 68);
            buttonOpenFile_KDV.Name = "buttonOpenFile_KDV";
            buttonOpenFile_KDV.Size = new Size(100, 68);
            buttonOpenFile_KDV.TabIndex = 1;
            toolTip.SetToolTip(buttonOpenFile_KDV, "Открыть файл...\r\nВыберите ваш csv - файл");
            buttonOpenFile_KDV.UseVisualStyleBackColor = true;
            buttonOpenFile_KDV.Click += buttonOpenFile_KDV_Click;
            // 
            // buttonInfo_KDV
            // 
            buttonInfo_KDV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo_KDV.Image = (Image)resources.GetObject("buttonInfo_KDV.Image");
            buttonInfo_KDV.Location = new Point(1095, 21);
            buttonInfo_KDV.MaximumSize = new Size(185, 86);
            buttonInfo_KDV.MinimumSize = new Size(73, 86);
            buttonInfo_KDV.Name = "buttonInfo_KDV";
            buttonInfo_KDV.Size = new Size(73, 86);
            buttonInfo_KDV.TabIndex = 6;
            toolTip.SetToolTip(buttonInfo_KDV, "Справка о создателе программы");
            buttonInfo_KDV.UseVisualStyleBackColor = true;
            buttonInfo_KDV.Click += buttonInfo_KDV_Click;
            // 
            // buttonSaveFile_KDV
            // 
            buttonSaveFile_KDV.Anchor = AnchorStyles.Top;
            buttonSaveFile_KDV.Image = (Image)resources.GetObject("buttonSaveFile_KDV.Image");
            buttonSaveFile_KDV.Location = new Point(155, 10);
            buttonSaveFile_KDV.MaximumSize = new Size(150, 68);
            buttonSaveFile_KDV.Name = "buttonSaveFile_KDV";
            buttonSaveFile_KDV.Size = new Size(100, 68);
            buttonSaveFile_KDV.TabIndex = 7;
            toolTip.SetToolTip(buttonSaveFile_KDV, "Сохранить файл...");
            buttonSaveFile_KDV.UseVisualStyleBackColor = true;
            buttonSaveFile_KDV.Click += buttonSaveFile_KDV_Click;
            // 
            // groupBoxSearch_KDV
            // 
            groupBoxSearch_KDV.Controls.Add(textBoxSearch_KDV);
            groupBoxSearch_KDV.Controls.Add(pictureBoxSearch_KDV);
            groupBoxSearch_KDV.Controls.Add(buttonSearch_KDV);
            groupBoxSearch_KDV.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxSearch_KDV.Location = new Point(27, 178);
            groupBoxSearch_KDV.MaximumSize = new Size(647, 73);
            groupBoxSearch_KDV.MinimumSize = new Size(363, 73);
            groupBoxSearch_KDV.Name = "groupBoxSearch_KDV";
            groupBoxSearch_KDV.Size = new Size(553, 73);
            groupBoxSearch_KDV.TabIndex = 8;
            groupBoxSearch_KDV.TabStop = false;
            groupBoxSearch_KDV.Text = "Поиск";
            // 
            // textBoxSearch_KDV
            // 
            textBoxSearch_KDV.Anchor = AnchorStyles.Left;
            textBoxSearch_KDV.Location = new Point(52, 33);
            textBoxSearch_KDV.MaximumSize = new Size(464, 34);
            textBoxSearch_KDV.Multiline = true;
            textBoxSearch_KDV.Name = "textBoxSearch_KDV";
            textBoxSearch_KDV.Size = new Size(418, 34);
            textBoxSearch_KDV.TabIndex = 1;
            // 
            // pictureBoxSearch_KDV
            // 
            pictureBoxSearch_KDV.Anchor = AnchorStyles.Left;
            pictureBoxSearch_KDV.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxSearch_KDV.Image = (Image)resources.GetObject("pictureBoxSearch_KDV.Image");
            pictureBoxSearch_KDV.Location = new Point(6, 26);
            pictureBoxSearch_KDV.Name = "pictureBoxSearch_KDV";
            pictureBoxSearch_KDV.Size = new Size(40, 41);
            pictureBoxSearch_KDV.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSearch_KDV.TabIndex = 0;
            pictureBoxSearch_KDV.TabStop = false;
            // 
            // buttonSearch_KDV
            // 
            buttonSearch_KDV.Anchor = AnchorStyles.Left;
            buttonSearch_KDV.Location = new Point(476, 26);
            buttonSearch_KDV.MaximumSize = new Size(96, 39);
            buttonSearch_KDV.MinimumSize = new Size(71, 39);
            buttonSearch_KDV.Name = "buttonSearch_KDV";
            buttonSearch_KDV.Size = new Size(71, 39);
            buttonSearch_KDV.TabIndex = 9;
            buttonSearch_KDV.Text = "Поиск";
            buttonSearch_KDV.UseVisualStyleBackColor = true;
            buttonSearch_KDV.Click += buttonSearch_KDV_Click;
            // 
            // groupBoxSort_KDV
            // 
            groupBoxSort_KDV.Controls.Add(radioButtonFromEndToStart_KDV);
            groupBoxSort_KDV.Controls.Add(radioButtonFromStartToEnd_KDV);
            groupBoxSort_KDV.Location = new Point(27, 117);
            groupBoxSort_KDV.Name = "groupBoxSort_KDV";
            groupBoxSort_KDV.Size = new Size(210, 55);
            groupBoxSort_KDV.TabIndex = 10;
            groupBoxSort_KDV.TabStop = false;
            groupBoxSort_KDV.Text = "Сортировать...";
            // 
            // radioButtonFromEndToStart_KDV
            // 
            radioButtonFromEndToStart_KDV.AutoSize = true;
            radioButtonFromEndToStart_KDV.Location = new Point(105, 24);
            radioButtonFromEndToStart_KDV.Name = "radioButtonFromEndToStart_KDV";
            radioButtonFromEndToStart_KDV.Size = new Size(93, 24);
            radioButtonFromEndToStart_KDV.TabIndex = 1;
            radioButtonFromEndToStart_KDV.TabStop = true;
            radioButtonFromEndToStart_KDV.Text = "от Я до А";
            radioButtonFromEndToStart_KDV.UseVisualStyleBackColor = true;
            // 
            // radioButtonFromStartToEnd_KDV
            // 
            radioButtonFromStartToEnd_KDV.AutoSize = true;
            radioButtonFromStartToEnd_KDV.Location = new Point(6, 24);
            radioButtonFromStartToEnd_KDV.Name = "radioButtonFromStartToEnd_KDV";
            radioButtonFromStartToEnd_KDV.Size = new Size(93, 24);
            radioButtonFromStartToEnd_KDV.TabIndex = 0;
            radioButtonFromStartToEnd_KDV.TabStop = true;
            radioButtonFromStartToEnd_KDV.Text = "от А до Я";
            radioButtonFromStartToEnd_KDV.UseVisualStyleBackColor = true;
            radioButtonFromStartToEnd_KDV.CheckedChanged += radioButtonFromStartToEnd_KDV_CheckedChanged;
            // 
            // groupBoxCalc_KDV
            // 
            groupBoxCalc_KDV.Anchor = AnchorStyles.Top;
            groupBoxCalc_KDV.Controls.Add(textBoxRound);
            groupBoxCalc_KDV.Controls.Add(labelTextRound);
            groupBoxCalc_KDV.Controls.Add(textBoxColumn_KDV);
            groupBoxCalc_KDV.Controls.Add(labelTextColumn_KDV);
            groupBoxCalc_KDV.Controls.Add(buttonCalcSum_KDV);
            groupBoxCalc_KDV.Controls.Add(buttonCalcAmount);
            groupBoxCalc_KDV.Controls.Add(buttonCalcMin_KDV);
            groupBoxCalc_KDV.Controls.Add(buttonCalcMax_KDV);
            groupBoxCalc_KDV.Controls.Add(buttonCalcAverageValue_KDV);
            groupBoxCalc_KDV.Location = new Point(586, 10);
            groupBoxCalc_KDV.Name = "groupBoxCalc_KDV";
            groupBoxCalc_KDV.Size = new Size(495, 175);
            groupBoxCalc_KDV.TabIndex = 11;
            groupBoxCalc_KDV.TabStop = false;
            groupBoxCalc_KDV.Text = "Вычислить...";
            // 
            // textBoxRound
            // 
            textBoxRound.Anchor = AnchorStyles.Left;
            textBoxRound.Location = new Point(357, 130);
            textBoxRound.Name = "textBoxRound";
            textBoxRound.Size = new Size(125, 27);
            textBoxRound.TabIndex = 8;
            // 
            // labelTextRound
            // 
            labelTextRound.Anchor = AnchorStyles.Left;
            labelTextRound.AutoSize = true;
            labelTextRound.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTextRound.Location = new Point(347, 97);
            labelTextRound.Name = "labelTextRound";
            labelTextRound.Size = new Size(135, 25);
            labelTextRound.TabIndex = 7;
            labelTextRound.Text = "Округлить до...";
            // 
            // textBoxColumn_KDV
            // 
            textBoxColumn_KDV.Anchor = AnchorStyles.Left;
            textBoxColumn_KDV.Location = new Point(204, 130);
            textBoxColumn_KDV.Name = "textBoxColumn_KDV";
            textBoxColumn_KDV.Size = new Size(125, 27);
            textBoxColumn_KDV.TabIndex = 6;
            // 
            // labelTextColumn_KDV
            // 
            labelTextColumn_KDV.Anchor = AnchorStyles.Left;
            labelTextColumn_KDV.AutoSize = true;
            labelTextColumn_KDV.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTextColumn_KDV.Location = new Point(194, 97);
            labelTextColumn_KDV.Name = "labelTextColumn_KDV";
            labelTextColumn_KDV.Size = new Size(147, 25);
            labelTextColumn_KDV.TabIndex = 5;
            labelTextColumn_KDV.Text = "Введите столбец";
            // 
            // buttonCalcSum_KDV
            // 
            buttonCalcSum_KDV.Anchor = AnchorStyles.Left;
            buttonCalcSum_KDV.Location = new Point(111, 97);
            buttonCalcSum_KDV.MaximumSize = new Size(119, 60);
            buttonCalcSum_KDV.MinimumSize = new Size(68, 60);
            buttonCalcSum_KDV.Name = "buttonCalcSum_KDV";
            buttonCalcSum_KDV.Size = new Size(68, 60);
            buttonCalcSum_KDV.TabIndex = 4;
            buttonCalcSum_KDV.Text = "Сумма";
            toolTip.SetToolTip(buttonCalcSum_KDV, "Посчитать сумму определённого столбика");
            buttonCalcSum_KDV.UseVisualStyleBackColor = true;
            buttonCalcSum_KDV.Click += buttonCalcSum_KDV_Click;
            // 
            // buttonCalcAmount
            // 
            buttonCalcAmount.Anchor = AnchorStyles.Left;
            buttonCalcAmount.Location = new Point(6, 97);
            buttonCalcAmount.MaximumSize = new Size(119, 60);
            buttonCalcAmount.MinimumSize = new Size(99, 60);
            buttonCalcAmount.Name = "buttonCalcAmount";
            buttonCalcAmount.Size = new Size(99, 60);
            buttonCalcAmount.TabIndex = 3;
            buttonCalcAmount.Text = "Количество";
            toolTip.SetToolTip(buttonCalcAmount, "Подсчитать количество рабочих из таблицы");
            buttonCalcAmount.UseVisualStyleBackColor = true;
            buttonCalcAmount.Click += buttonCalcAmount_Click;
            // 
            // buttonCalcMin_KDV
            // 
            buttonCalcMin_KDV.Anchor = AnchorStyles.Top;
            buttonCalcMin_KDV.Location = new Point(238, 22);
            buttonCalcMin_KDV.MaximumSize = new Size(119, 60);
            buttonCalcMin_KDV.Name = "buttonCalcMin_KDV";
            buttonCalcMin_KDV.Size = new Size(119, 60);
            buttonCalcMin_KDV.TabIndex = 2;
            buttonCalcMin_KDV.Text = "Минимальное значение";
            toolTip.SetToolTip(buttonCalcMin_KDV, "Высчитать минимальное значение определённого столбика...");
            buttonCalcMin_KDV.UseVisualStyleBackColor = true;
            buttonCalcMin_KDV.Click += buttonCalcMin_KDV_Click;
            // 
            // buttonCalcMax_KDV
            // 
            buttonCalcMax_KDV.Anchor = AnchorStyles.Top;
            buttonCalcMax_KDV.Location = new Point(102, 22);
            buttonCalcMax_KDV.MaximumSize = new Size(130, 60);
            buttonCalcMax_KDV.MinimumSize = new Size(130, 60);
            buttonCalcMax_KDV.Name = "buttonCalcMax_KDV";
            buttonCalcMax_KDV.Size = new Size(130, 60);
            buttonCalcMax_KDV.TabIndex = 1;
            buttonCalcMax_KDV.Text = "Максимальное значение";
            toolTip.SetToolTip(buttonCalcMax_KDV, "Высчитать максимальное значение определённого столбика...");
            buttonCalcMax_KDV.UseVisualStyleBackColor = true;
            buttonCalcMax_KDV.Click += buttonCalcMax_KDV_Click;
            // 
            // buttonCalcAverageValue_KDV
            // 
            buttonCalcAverageValue_KDV.Anchor = AnchorStyles.Top;
            buttonCalcAverageValue_KDV.Location = new Point(11, 22);
            buttonCalcAverageValue_KDV.MaximumSize = new Size(119, 60);
            buttonCalcAverageValue_KDV.Name = "buttonCalcAverageValue_KDV";
            buttonCalcAverageValue_KDV.Size = new Size(85, 60);
            buttonCalcAverageValue_KDV.TabIndex = 0;
            buttonCalcAverageValue_KDV.Text = "Среднее значение";
            toolTip.SetToolTip(buttonCalcAverageValue_KDV, "Высчитать среднее значение определённого столбика...");
            buttonCalcAverageValue_KDV.UseVisualStyleBackColor = true;
            buttonCalcAverageValue_KDV.Click += buttonCalcAverageValue_KDV_Click;
            // 
            // buttonExit_KDV
            // 
            buttonExit_KDV.Anchor = AnchorStyles.Top;
            buttonExit_KDV.Image = (Image)resources.GetObject("buttonExit_KDV.Image");
            buttonExit_KDV.Location = new Point(423, 10);
            buttonExit_KDV.MaximumSize = new Size(150, 68);
            buttonExit_KDV.Name = "buttonExit_KDV";
            buttonExit_KDV.Size = new Size(100, 68);
            buttonExit_KDV.TabIndex = 12;
            toolTip.SetToolTip(buttonExit_KDV, "Выход");
            buttonExit_KDV.UseVisualStyleBackColor = true;
            buttonExit_KDV.Click += buttonExit_KDV_Click;
            // 
            // buttonClear_KDV
            // 
            buttonClear_KDV.Anchor = AnchorStyles.Top;
            buttonClear_KDV.Image = (Image)resources.GetObject("buttonClear_KDV.Image");
            buttonClear_KDV.Location = new Point(288, 10);
            buttonClear_KDV.MaximumSize = new Size(150, 68);
            buttonClear_KDV.MinimumSize = new Size(63, 68);
            buttonClear_KDV.Name = "buttonClear_KDV";
            buttonClear_KDV.Size = new Size(100, 68);
            buttonClear_KDV.TabIndex = 13;
            toolTip.SetToolTip(buttonClear_KDV, "Очистить содержимое");
            buttonClear_KDV.UseVisualStyleBackColor = true;
            buttonClear_KDV.Click += buttonClear_KDV_Click;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // groupBoxChart_KDV
            // 
            groupBoxChart_KDV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxChart_KDV.Controls.Add(textBoxChartColumn_KDV);
            groupBoxChart_KDV.Controls.Add(labelTextColumn);
            groupBoxChart_KDV.Controls.Add(buttonDeleteChart);
            groupBoxChart_KDV.Controls.Add(buttonBuildChart_KDV);
            groupBoxChart_KDV.Location = new Point(769, 186);
            groupBoxChart_KDV.MaximumSize = new Size(395, 110);
            groupBoxChart_KDV.MinimumSize = new Size(395, 95);
            groupBoxChart_KDV.Name = "groupBoxChart_KDV";
            groupBoxChart_KDV.Size = new Size(395, 95);
            groupBoxChart_KDV.TabIndex = 14;
            groupBoxChart_KDV.TabStop = false;
            groupBoxChart_KDV.Text = "График...";
            // 
            // textBoxChartColumn_KDV
            // 
            textBoxChartColumn_KDV.Anchor = AnchorStyles.Right;
            textBoxChartColumn_KDV.Location = new Point(246, 51);
            textBoxChartColumn_KDV.Name = "textBoxChartColumn_KDV";
            textBoxChartColumn_KDV.Size = new Size(119, 27);
            textBoxChartColumn_KDV.TabIndex = 3;
            // 
            // labelTextColumn
            // 
            labelTextColumn.Anchor = AnchorStyles.Right;
            labelTextColumn.AutoSize = true;
            labelTextColumn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTextColumn.Location = new Point(236, 23);
            labelTextColumn.Name = "labelTextColumn";
            labelTextColumn.Size = new Size(147, 25);
            labelTextColumn.TabIndex = 2;
            labelTextColumn.Text = "Введите столбец";
            // 
            // buttonDeleteChart
            // 
            buttonDeleteChart.Anchor = AnchorStyles.Right;
            buttonDeleteChart.Image = (Image)resources.GetObject("buttonDeleteChart.Image");
            buttonDeleteChart.Location = new Point(121, 29);
            buttonDeleteChart.Name = "buttonDeleteChart";
            buttonDeleteChart.Size = new Size(87, 51);
            buttonDeleteChart.TabIndex = 1;
            buttonDeleteChart.UseVisualStyleBackColor = true;
            buttonDeleteChart.Click += buttonDeleteChart_Click;
            // 
            // buttonBuildChart_KDV
            // 
            buttonBuildChart_KDV.Anchor = AnchorStyles.Right;
            buttonBuildChart_KDV.Image = (Image)resources.GetObject("buttonBuildChart_KDV.Image");
            buttonBuildChart_KDV.Location = new Point(15, 27);
            buttonBuildChart_KDV.Name = "buttonBuildChart_KDV";
            buttonBuildChart_KDV.Size = new Size(87, 51);
            buttonBuildChart_KDV.TabIndex = 0;
            buttonBuildChart_KDV.UseVisualStyleBackColor = true;
            buttonBuildChart_KDV.Click += buttonBuildChart_KDV_Click;
            // 
            // chartPrint_KDV
            // 
            chartPrint_KDV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chartPrint_KDV.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartPrint_KDV.Legends.Add(legend1);
            chartPrint_KDV.Location = new Point(613, 287);
            chartPrint_KDV.MinimumSize = new Size(539, 318);
            chartPrint_KDV.Name = "chartPrint_KDV";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartPrint_KDV.Series.Add(series1);
            chartPrint_KDV.Size = new Size(539, 540);
            chartPrint_KDV.TabIndex = 15;
            // 
            // FormMain
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(1180, 853);
            Controls.Add(chartPrint_KDV);
            Controls.Add(groupBoxChart_KDV);
            Controls.Add(buttonClear_KDV);
            Controls.Add(buttonExit_KDV);
            Controls.Add(groupBoxCalc_KDV);
            Controls.Add(groupBoxSort_KDV);
            Controls.Add(groupBoxSearch_KDV);
            Controls.Add(buttonSaveFile_KDV);
            Controls.Add(buttonInfo_KDV);
            Controls.Add(buttonOpenFile_KDV);
            Controls.Add(dataGridViewTable_KDV);
            MaximumSize = new Size(1920, 1200);
            MinimumSize = new Size(1198, 664);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterParent;
            Text = "IAgentPlus";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable_KDV).EndInit();
            groupBoxSearch_KDV.ResumeLayout(false);
            groupBoxSearch_KDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch_KDV).EndInit();
            groupBoxSort_KDV.ResumeLayout(false);
            groupBoxSort_KDV.PerformLayout();
            groupBoxCalc_KDV.ResumeLayout(false);
            groupBoxCalc_KDV.PerformLayout();
            groupBoxChart_KDV.ResumeLayout(false);
            groupBoxChart_KDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartPrint_KDV).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridViewTable_KDV;
        private Button buttonOpenFile_KDV;
        private Button buttonInfo_KDV;
        private Button buttonSaveFile_KDV;
        private GroupBox groupBoxSearch_KDV;
        private TextBox textBoxSearch_KDV;
        private Button buttonSearch_KDV;
        private GroupBox groupBoxSort_KDV;
        private RadioButton radioButtonFromEndToStart_KDV;
        private RadioButton radioButtonFromStartToEnd_KDV;
        private GroupBox groupBoxCalc_KDV;
        private Button buttonCalcSum_KDV;
        private Button buttonCalcAmount;
        private Button buttonCalcMin_KDV;
        private Button buttonCalcMax_KDV;
        private Button buttonCalcAverageValue_KDV;
        private Button buttonExit_KDV;
        private Button buttonClear_KDV;
        private PictureBox pictureBoxSearch_KDV;
        private ToolTip toolTip;
        private OpenFileDialog openFileDialogTask;
        private SaveFileDialog saveFileDialogTask;
        private TextBox textBoxColumn_KDV;
        private Label labelTextColumn_KDV;
        private GroupBox groupBoxChart_KDV;
        private TextBox textBoxChartColumn_KDV;
        private Label labelTextColumn;
        private Button buttonDeleteChart;
        private Button buttonBuildChart_KDV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPrint_KDV;
        private TextBox textBoxRound;
        private Label labelTextRound;
    }
}
