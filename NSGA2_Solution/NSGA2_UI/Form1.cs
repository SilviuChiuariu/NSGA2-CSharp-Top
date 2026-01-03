using System;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace NSGA2_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigurareGraficInitiala();
        }

        private void ConfigurareGraficInitiala()
        {
            if (chartPareto.Series.Count == 0)
            {
                chartPareto.Series.Add("Solutii");
            }

            var serie = chartPareto.Series[0];
            serie.ChartType = SeriesChartType.Point;
            serie.MarkerStyle = MarkerStyle.Circle;
            serie.MarkerSize = 8;
            serie.Color = Color.LightSeaGreen;

            var area = chartPareto.ChartAreas[0];

            area.AxisX.Title = "Acceleratie (0-100 km/h) [sec]";
            area.AxisX.TitleFont = new Font("Arial", 10, FontStyle.Bold);
            area.AxisX.LabelStyle.Format = "F2";
            area.AxisX.MajorGrid.Enabled = false;

            area.AxisY.Title = "Autonomie (Range) [km]";
            area.AxisY.TitleFont = new Font("Arial", 10, FontStyle.Bold);
            area.AxisY.LabelStyle.Format = "F0";
            area.AxisY.MajorGrid.Enabled = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //validare parametri
            if (numPutereMotMin.Value > numPutereMotorMax.Value)
            {
                ShowError("La Motor: Valoarea Minima trebuie sa fie mai mica decat cea Maxima!");
                return;
            }
            if (numRezervorMin.Value > numRezervorMax.Value)
            {
                ShowError("La Rezervor: Valoarea Minima trebuie sa fie mai mica decat cea Maxima!");
                return;
            }
            if (numRotiMin.Value > numRotiMax.Value)
            {
                ShowError("La Roti: Valoarea Minima trebuie sa fie mai mica decat cea Maxima!");
                return;
            }

            //pregatire interfata
            labelStatus.Text = "Status: Se ruleaza...";
            labelStatus.ForeColor = Color.Orange;
            Cursor = Cursors.WaitCursor;

            chartPareto.Series[0].Points.Clear();
            Application.DoEvents();

            //colectare date
            int populatie = (int)numPopulatie.Value;
            double minMotor = (double)numPutereMotMin.Value;
            double maxMotor = (double)numPutereMotorMax.Value;
            double minRezervor = (double)numRezervorMin.Value;
            double maxRezervor = (double)numRezervorMax.Value;
            double minRoti = (double)numRotiMin.Value;
            double maxRoti = (double)numRotiMax.Value;

            Random rand = new Random();

            double bestAccel_Val = double.MaxValue; // timp (recordul)
            double bestAccel_Range = 0;             // range ei
                                                    // conf ei
            double bestAccel_MotorVal = 0;
            double bestAccel_RezervorVal = 0;
            double bestAccel_RotiVal = 0;

            double bestRange_Val = 0;               // dist 
            double bestRange_Accel = 0;             // acc ei
                                                    // conf ei
            double bestRange_MotorVal = 0;
            double bestRange_RezervorVal = 0;
            double bestRange_RotiVal = 0;

            // =================================================================
            //partea de simulare --> se va inlocui cu ce primesc de la petru

            for (int i = 0; i < populatie; i++)
            {
                // generare 
                double motor = minMotor + (rand.NextDouble() * (maxMotor - minMotor));
                double rezervor = minRezervor + (rand.NextDouble() * (maxRezervor - minRezervor));
                double roti = minRoti + (rand.NextDouble() * (maxRoti - minRoti));

                // formule 
                double acceleratie = (3500 / motor) + (rezervor / 60) + (roti / 10);
                double range = (rezervor * 12) - (motor / 3) - (roti * 2) + rand.Next(-15, 15);

                // desenare Punct + Tooltip
                DataPoint punct = new DataPoint(acceleratie, range);
                string info = $"SOLUTIA #{i + 1}\nMotor: {motor:F0} CP\nRezervor: {rezervor:F0} L\nRoti: {roti:F0}\nAccel: {acceleratie:F2} s\nRange: {range:F0} km";
                punct.ToolTip = info;
                chartPareto.Series[0].Points.Add(punct);

                if (acceleratie < bestAccel_Val)
                {
                    bestAccel_Val = acceleratie;
                    bestAccel_Range = range;

                    // salv configuratia exct
                    bestAccel_MotorVal = motor;
                    bestAccel_RezervorVal = rezervor;
                    bestAccel_RotiVal = roti;
                }

                if (range > bestRange_Val)
                {
                    bestRange_Val = range;
                    bestRange_Accel = acceleratie;

                    // salv configuratia exct
                    bestRange_MotorVal = motor;
                    bestRange_RezervorVal = rezervor;
                    bestRange_RotiVal = roti;
                }
            }
            // =================================================================

            //actualizare rez
            //completam datele pentru cea mai rapida
            textBoxRezAccViteza.Text = bestAccel_Val.ToString("F2");     //timp
            textBoxRezAutoViteza.Text = bestAccel_Range.ToString("F0");  //range

            textBoxRezPutereViteza.Text = bestAccel_MotorVal.ToString("F0");
            textBoxRezRezerViteza.Text = bestAccel_RezervorVal.ToString("F0");
            textBoxRezRotiViteza.Text = bestAccel_RotiVal.ToString("F0");

            //compleatan datele pentru cel mai bun range
            textBoxRezAutoRange.Text = bestRange_Val.ToString("F0");          // range
            textBoxRezAccRange.Text = bestRange_Accel.ToString("F2");  // timp

            textBoxRezPutereRange.Text = bestRange_MotorVal.ToString("F0");
            textBoxRezRezervRange.Text = bestRange_RezervorVal.ToString("F0");
            textBoxRezRotiRange.Text = bestRange_RotiVal.ToString("F0");

            labelStatus.Text = "Gata!";
            labelStatus.ForeColor = Color.Green;
            Cursor = Cursors.Default;
        }

        private void ShowError(string mesaj)
        {
            MessageBox.Show(mesaj, "Eroare Parametri", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void chartPareto_Click(object sender, EventArgs e)
        {

        }
    }
}
