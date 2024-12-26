using Methods;
using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Forms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask.Filter = "*.csv|*.csv|(*.*)|*.*";
            saveFileDialogTask.Filter = "(*.csv)|*.csv|(*.*)|*.*";

            radioButtonFromEndToStart_KDV.CheckedChanged += radioButtonFromEndToStart_KDV_CheckedChanged;
            radioButtonFromStartToEnd_KDV.CheckedChanged += radioButtonFromStartToEnd_KDV_CheckedChanged;
        }


        static int rows;
        static int cols;
        string openFilePath;
        static string[,] matrixValues;
        DataService ds = new DataService();

        public static string[,] LoadDataFromFile(string path)
        {
            try
            {
                string fileData = File.ReadAllText(path);

                fileData = fileData.Replace('\n', '\r');
                string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

                rows = lines.Length;
                cols = lines[0].Split(';').Length;

                matrixValues = new string[rows, cols];

                for (int i = 0; i < rows; i++)
                {
                    string[] line = lines[i].Split(";");
                    for (int j = 0; j < cols; j++)
                    {
                        matrixValues[i, j] = line[j];
                    }
                }
                return matrixValues;
            }
            catch
            {
                MessageBox.Show("Ошибка при чтении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void buttonOpenFile_KDV_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogTask.ShowDialog();
                openFilePath = openFileDialogTask.FileName;

                matrixValues = LoadDataFromFile(openFilePath);

                dataGridViewTable_KDV.ColumnCount = cols;
                dataGridViewTable_KDV.RowCount = rows - 1;

                for (int i = 0; i < matrixValues.GetLength(1); i++)
                {
                    dataGridViewTable_KDV.Columns[i].HeaderCell.Value = matrixValues[0, i];
                }


                for (int r = 1; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        dataGridViewTable_KDV.Rows[r-1].Cells[c].Value = matrixValues[r, c];
                    }
                }

                dataGridViewTable_KDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                chartPrint_KDV.Enabled = true;

                buttonClear_KDV.Enabled = true;
                buttonSaveFile_KDV.Enabled = true;

                groupBoxCalc_KDV.Enabled = true;
                groupBoxSearch_KDV.Enabled = true;
                groupBoxSort_KDV.Enabled = true;
                groupBoxChart_KDV.Enabled = true;

                radioButtonFromStartToEnd_KDV.Enabled = true;
                radioButtonFromEndToStart_KDV.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Файл не был выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveFile_KDV_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogTask.FileName = "Данные.csv";
                saveFileDialogTask.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialogTask.ShowDialog();

                string path = saveFileDialogTask.FileName;

                FileInfo fileInfo = new FileInfo(path);
                bool fileExist = fileInfo.Exists;
                if (fileExist)
                {
                    File.Delete(path);
                }

                int rows = dataGridViewTable_KDV.RowCount;
                int cols = dataGridViewTable_KDV.ColumnCount;

                string header = "";
                for (int j = 0; j < cols; j++)
                {
                    header += dataGridViewTable_KDV.Columns[j].HeaderText;
                    if (j != cols - 1)
                    {
                        header += ";";
                    }
                }
                File.AppendAllText(path, header + Environment.NewLine, Encoding.UTF8);

                string str = "";

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (j != cols - 1)
                        {
                            str = str + dataGridViewTable_KDV.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str = str + dataGridViewTable_KDV.Rows[i].Cells[j].Value;
                        }
                    }
                    File.AppendAllText(path, str + Environment.NewLine, Encoding.UTF8);
                    str = "";
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            chartPrint_KDV.Enabled = false;

            buttonClear_KDV.Enabled = false;
            buttonSaveFile_KDV.Enabled = false;

            groupBoxCalc_KDV.Enabled = false;
            groupBoxSearch_KDV.Enabled = false;
            groupBoxSort_KDV.Enabled = false;
            groupBoxChart_KDV.Enabled = false;

            radioButtonFromStartToEnd_KDV.Enabled = false;
            radioButtonFromEndToStart_KDV.Enabled = false;


            dataGridViewTable_KDV.ColumnCount = 200;
            dataGridViewTable_KDV.RowCount = 200;
            for (int i = 0; i < cols; i++)
            {
                dataGridViewTable_KDV.Columns[i].Width = 35;
            }
        }

        private void buttonCalcAverageValue_KDV_Click(object sender, EventArgs e)
        {
            try
            {
            int[] arrayValues = ds.GetArrayColumn(matrixValues, Convert.ToInt32(textBoxColumn_KDV.Text) - 1);
            double res = ds.CalcAverageValue(arrayValues, Convert.ToInt32(textBoxRound.Text));
            MessageBox.Show($"Среднее значение: {res}", "Вычислить среднее значение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Некорректный ввод данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonCalcMax_KDV_Click(object sender, EventArgs e)
        {
            try
            {
                int[] arrayValues = ds.GetArrayColumn(matrixValues, Convert.ToInt32(textBoxColumn_KDV.Text) - 1);
                double res = ds.CalcMax(arrayValues);
                MessageBox.Show($"Максимальное значение: {res}", "Вычислить максимальное значение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Некорректный ввод данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCalcMin_KDV_Click(object sender, EventArgs e)
        {
            try
            {
                int[] arrayValues = ds.GetArrayColumn(matrixValues, Convert.ToInt32(textBoxColumn_KDV.Text) - 1);
                double res = ds.CalcMin(arrayValues);
                MessageBox.Show($"Минимальное значение: {res}", "Вычислить минимальное значение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Некорректный ввод данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCalcAmount_Click(object sender, EventArgs e)
        {
            try
            {
                int res = matrixValues.GetLength(0) - 1;
                MessageBox.Show($"Количество сотрудников: {res}", "Вычислить количество", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Произошла непредвиденная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCalcSum_KDV_Click(object sender, EventArgs e)
        {
            try
            {
                int[] arrayValues = ds.GetArrayColumn(matrixValues, Convert.ToInt32(textBoxColumn_KDV.Text) - 1);
                double res = ds.CalcSum(arrayValues);
                MessageBox.Show($"Сумма: {res}", "Вычислить сумму", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Некорректный ввод данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExit_KDV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClear_KDV_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewTable_KDV.Rows.Clear();
                dataGridViewTable_KDV.Columns.Clear();
            }
            catch
            {
                MessageBox.Show("Произошла непредвиденная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_KDV_Click(object sender, EventArgs e)
        {
            FormInfo info = new FormInfo();
            info.ShowDialog();
        }

        private void buttonSearch_KDV_Click(object sender, EventArgs e)
        {
            string search = textBoxSearch_KDV.Text.Trim();


            if (string.IsNullOrEmpty(search))
            {
                MessageBox.Show("Поле пусто");
                return;
            }
            else if (!(string.IsNullOrEmpty(search)))
            {


                for (int i = 1; i < dataGridViewTable_KDV.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewTable_KDV.Columns.Count; j++)
                    {
                        DataGridViewRow row = dataGridViewTable_KDV.Rows[i];

                        if (row.Cells[j].Value != null && row.Cells[j].Value.ToString().Equals(search, StringComparison.InvariantCultureIgnoreCase))
                        {
                            row.Selected = true;
                            dataGridViewTable_KDV.FirstDisplayedScrollingRowIndex = i;
                            break;
                        }
                    }
                }
            }
        }

        private void radioButtonFromStartToEnd_KDV_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFromStartToEnd_KDV.Checked)
            {
                this.dataGridViewTable_KDV.Sort(this.dataGridViewTable_KDV.Columns[7], ListSortDirection.Ascending);
            }
        }

        private void radioButtonFromEndToStart_KDV_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButtonFromEndToStart_KDV.Checked)
            {
                this.dataGridViewTable_KDV.Sort(this.dataGridViewTable_KDV.Columns[7], ListSortDirection.Descending);
            }
        }

        private void buttonBuildChart_KDV_Click(object sender, EventArgs e)
        {
            try
            {
                int[] valueArray = ds.GetArrayColumn(matrixValues, Convert.ToInt32(textBoxChartColumn_KDV.Text) - 1);

                int columnIndex = int.Parse(textBoxChartColumn_KDV.Text);
                
                    chartPrint_KDV.ChartAreas[0].AxisX.Title =
                        $"{dataGridViewTable_KDV.Columns[columnIndex - 1].HeaderCell.Value}";
                
            for (int i = 1; i < valueArray.Length; i++)
                {
                    chartPrint_KDV.Series[0].Points.AddXY(i, valueArray[i]);
                }
        }
            catch
            {
                MessageBox.Show("Некорректный формат данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void buttonDeleteChart_Click(object sender, EventArgs e)
        {
            chartPrint_KDV.Series[0].Points.Clear();
        }

        private void dataGridViewTable_KDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
