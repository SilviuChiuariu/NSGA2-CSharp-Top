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
            if (numPopulatie.Value <= 0)
            {
                ShowError("Marimea Populatiei trebuie sa fie un numar pozitiv!");
                return;
            }
            if (numGeneratie.Value <= 0)
            {
                ShowError("Numarul de Generatii trebuie sa fie un numar pozitiv!");
                return;
            }
            if (numRataMutatie.Value < 0 || numRataMutatie.Value > 100)
            {
                ShowError("Rata de Mutatie trebuie sa fie intre 0 si 99!");
                return;
            }
            
            chartPareto.Series[0].Points.Clear();
            Application.DoEvents();

            // colectare date
            double minMotor = (double)numPutereMotMin.Value;
            double maxMotor = (double)numPutereMotorMax.Value;
            double minRezervor = (double)numRezervorMin.Value;
            double maxRezervor = (double)numRezervorMax.Value;
            double minRoti = (double)numRotiMin.Value;
            double maxRoti = (double)numRotiMax.Value;

            // variabile algoritm NSGA-II
            int num_populatie = (int)numPopulatie.Value;
            Individ[] populatie = new Individ[num_populatie];
            int generatii = (int)numGeneratie.Value;
            int rata_mutatie = (int)numRataMutatie.Value;

            Random rand = new Random();

            // =================================================================
            // generare populatie

            for (int i = 0; i < num_populatie; i++)
            {
                resultListBox.Items.Clear();

                // generare 
                double motor = minMotor + (rand.NextDouble() * (maxMotor - minMotor));
                double rezervor = minRezervor + (rand.NextDouble() * (maxRezervor - minRezervor));
                double roti = minRoti + (rand.NextDouble() * (maxRoti - minRoti));

                // formule 
                double acceleratie = (3500 / motor) + (rezervor / 60) + (roti / 10);
                double range = (rezervor * 12) - (motor / 3) - (roti * 2) + rand.Next(-15, 15);

                // salvare in populatie
                populatie[i] = new Individ(motor, rezervor, roti, acceleratie, range);

                // desenare Punct
                DataPoint punct = new DataPoint(acceleratie, range);
                chartPareto.Series[0].Points.Add(punct);

            }

            labelStatus.Text = "Gata!";
            labelStatus.ForeColor = Color.Green;

            string membriPopulatie = "";

            for (int i = 0; i < num_populatie; i++)
            {
                membriPopulatie = membriPopulatie + $"Motor: {populatie[i].putere_motor:F0} CP; Rezervor: {populatie[i].capacitate_rezervor:F0} L; Roti: {populatie[i].dimensiune_roti:F0};" +
                    $"Accel: {populatie[i].acceleratie:F2} s\nRange: {populatie[i].autonomie_range:F0} km \n";

            }
            Cursor = Cursors.Default;
            MessageBox.Show(membriPopulatie, "Membri populatie", MessageBoxButtons.OK, MessageBoxIcon.Question,
                                   MessageBoxDefaultButton.Button1, 0);

            // ===============NSGA-II==========================

            for (int gen = 0; gen < generatii; gen++)
            {
                // Creare generatie noua
                Individ[] populatie_copii = new Individ[num_populatie];
                for (int i = 0; i < num_populatie / 2; i++)
                {
                    // Tournament Selection
                    // fitness-ul este in functie de rang si crowding
                    Individ mother = Individ.TournamentSelection(populatie);
                    Individ father = Individ.TournamentSelection(populatie);

                    // Crossover 
                    Individ[] children = Individ.Crossover(mother, father);

                    // Mutatie 
                    Individ.Mutation(children[0], (double)rata_mutatie);
                    Individ.Mutation(children[1], (double)rata_mutatie);

                    // Adaugare copii in noua generatie
                    populatie_copii[2 * i] = children[0];
                    populatie_copii[2 * i + 1] = children[1];
                }

                // Combinare populatii parinti + copii
                Individ[] populatie_totala = new Individ[num_populatie * 2];
                Array.Copy(populatie, populatie_totala, num_populatie);
                Array.Copy(populatie_copii, 0, populatie_totala, num_populatie, num_populatie);

                // non-dominated sorting
                for (int i = 0; i < num_populatie * 2; i++)
                {
                    for (int j = 0; j < num_populatie * 2; j++)
                    {
                        if (i != j)
                        {
                            // verificare dominare
                            if ((populatie_totala[i].acceleratie < populatie_totala[j].acceleratie && populatie_totala[i].autonomie_range > populatie_totala[j].autonomie_range) ||
                               (populatie_totala[i].acceleratie <= populatie_totala[j].acceleratie && populatie_totala[i].autonomie_range > populatie_totala[j].autonomie_range) ||
                               (populatie_totala[i].acceleratie < populatie_totala[j].acceleratie && populatie_totala[i].autonomie_range >= populatie_totala[j].autonomie_range))
                            {
                                populatie_totala[i].dominates.Add(populatie_totala[j]);
                            }
                            else if ((populatie_totala[j].acceleratie < populatie_totala[i].acceleratie && populatie_totala[j].autonomie_range > populatie_totala[i].autonomie_range) ||
                                    (populatie_totala[j].acceleratie <= populatie_totala[i].acceleratie && populatie_totala[j].autonomie_range > populatie_totala[i].autonomie_range) ||
                                    (populatie_totala[j].acceleratie < populatie_totala[i].acceleratie && populatie_totala[j].autonomie_range >= populatie_totala[i].autonomie_range))
                            {
                                populatie_totala[i].domination_count++;
                            }
                        }
                    }


                }

                // creare fronturi 
                List<List<Individ>> fronturi = new List<List<Individ>>();

                // primul front
                List<Individ> F1 = new List<Individ>();
                for (int i = 0; i < num_populatie; i++)
                {
                    if (populatie_totala[i].domination_count == 0)
                    {
                        populatie_totala[i].rank = 1;
                        F1.Add(populatie_totala[i]);
                    }
                }
                fronturi.Add(F1);

                // hardcodare max 40 fronturi
                for (int i=1;i<40;i++)
                {
                    fronturi.Add(Individ.buildFront(fronturi[i-1], populatie_totala));
                }
                

                // calculare crowding distance
                foreach (var front in fronturi)
                {
                    int frontSize = front.Count;
                    if (frontSize > 0)
                    {
                        // initializare distanta
                        for (int i = 0; i < frontSize; i++)
                        {
                            front[i].crowding_distance = 0;
                        }
                        // sortare dupa acceleratie
                        front.Sort((a, b) => a.acceleratie.CompareTo(b.acceleratie));
                        front[0].crowding_distance = double.MaxValue;
                        front[frontSize - 1].crowding_distance = double.MaxValue;
                        double accel_min = front[0].acceleratie;
                        double accel_max = front[frontSize - 1].acceleratie;
                        for (int i = 1; i < frontSize - 1; i++)
                        {
                            front[i].crowding_distance += (front[i + 1].acceleratie - front[i - 1].acceleratie) / (accel_max - accel_min);
                        }
                        // sortare dupa range
                        front.Sort((a, b) => a.autonomie_range.CompareTo(b.autonomie_range));
                        front[0].crowding_distance = double.MaxValue;
                        front[frontSize - 1].crowding_distance = double.MaxValue;
                        double range_min = front[0].autonomie_range;
                        double range_max = front[frontSize - 1].autonomie_range;
                        for (int i = 1; i < frontSize - 1; i++)
                        {
                            front[i].crowding_distance += (front[i + 1].autonomie_range - front[i - 1].autonomie_range) / (range_max - range_min);
                        }
                    }
                }
                populatie = new Individ[num_populatie];
                int count = 0;
                foreach (var front in fronturi)
                {
                    if (count + front.Count <= num_populatie)
                    {
                        // adaugare intreg front
                        foreach (var indiv in front)
                        {
                            populatie[count] = indiv;
                            count++;
                        }
                    }
                    else
                    {
                        // sortare dupa crowding distance descrescator
                        front.Sort((a, b) => b.crowding_distance.CompareTo(a.crowding_distance));
                        int remaining = num_populatie - count;
                        for (int i = 0; i < remaining; i++)
                        {
                            populatie[count] = front[i];
                            count++;
                        }
                        break; // populatia este completa
                    }
                }

            }

            // afisare rezultate
            resultListBox.Visible = true;
            for (int i = 0; i < (int)numRezultateDorite.Value; i++)
            {

                DataPoint punct = new DataPoint(populatie[i].acceleratie, populatie[i].autonomie_range);

                punct.MarkerStyle = MarkerStyle.Star5;
                punct.MarkerSize = 12;
                punct.Color = Color.Red;

                chartPareto.Series[0].Points.Add(punct);
                resultListBox.Items.Add(resultListBox.Items.Count + 1 + ". Accel: " + populatie[i].acceleratie.ToString("F2") + " s - Range: " + populatie[i].autonomie_range.ToString("F0") + " km");
            }  

        }


        private void ShowError(string mesaj)
        {
            MessageBox.Show(mesaj, "Eroare Parametri", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void chartPareto_Click(object sender, EventArgs e)
        {

        }
        private void resultsLabel_Click(object sender, EventArgs e)
        {

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        

    }
}
