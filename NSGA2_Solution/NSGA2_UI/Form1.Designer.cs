namespace NSGA2_UI
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            GroupBoxSetariAlg = new GroupBox();
            numRataMutatie = new NumericUpDown();
            numGeneratie = new NumericUpDown();
            labelNrGeneratii = new Label();
            labelMutatie = new Label();
            numPopulatie = new NumericUpDown();
            labelMarimePop = new Label();
            groupBoxLParamMasina = new GroupBox();
            labelLinie2 = new Label();
            labelLinie3 = new Label();
            labelLinie = new Label();
            numPutereMotorMax = new NumericUpDown();
            numRezervorMax = new NumericUpDown();
            numRotiMin = new NumericUpDown();
            numRotiMax = new NumericUpDown();
            numRezervorMin = new NumericUpDown();
            numPutereMotMin = new NumericUpDown();
            labelPutereMotor = new Label();
            labelRezervor = new Label();
            labelRoti = new Label();
            groupBoxComenzi = new GroupBox();
            labelStatus = new Label();
            buttonStart = new Button();
            groupBoxRezultate = new GroupBox();
            chartPareto = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxTopRezultate = new GroupBox();
            label9 = new Label();
            textBoxRezRotiRange = new TextBox();
            textBoxRezRezervRange = new TextBox();
            label10 = new Label();
            label11 = new Label();
            textBoxRezAutoRange = new TextBox();
            textBoxRezPutereRange = new TextBox();
            textBoxRezAccRange = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label8 = new Label();
            textBoxRezRotiViteza = new TextBox();
            textBoxRezRezerViteza = new TextBox();
            label7 = new Label();
            label6 = new Label();
            textBoxRezAutoViteza = new TextBox();
            textBoxRezPutereViteza = new TextBox();
            textBoxRezAccViteza = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            GroupBoxSetariAlg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numRataMutatie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGeneratie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPopulatie).BeginInit();
            groupBoxLParamMasina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPutereMotorMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRezervorMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRotiMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRotiMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRezervorMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPutereMotMin).BeginInit();
            groupBoxComenzi.SuspendLayout();
            groupBoxRezultate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartPareto).BeginInit();
            groupBoxTopRezultate.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBoxSetariAlg
            // 
            GroupBoxSetariAlg.Controls.Add(numRataMutatie);
            GroupBoxSetariAlg.Controls.Add(numGeneratie);
            GroupBoxSetariAlg.Controls.Add(labelNrGeneratii);
            GroupBoxSetariAlg.Controls.Add(labelMutatie);
            GroupBoxSetariAlg.Controls.Add(numPopulatie);
            GroupBoxSetariAlg.Controls.Add(labelMarimePop);
            GroupBoxSetariAlg.Location = new Point(12, 12);
            GroupBoxSetariAlg.Name = "GroupBoxSetariAlg";
            GroupBoxSetariAlg.Size = new Size(523, 136);
            GroupBoxSetariAlg.TabIndex = 0;
            GroupBoxSetariAlg.TabStop = false;
            GroupBoxSetariAlg.Text = "Setari Algoritm";
            // 
            // numRataMutatie
            // 
            numRataMutatie.Location = new Point(355, 64);
            numRataMutatie.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numRataMutatie.Name = "numRataMutatie";
            numRataMutatie.Size = new Size(141, 31);
            numRataMutatie.TabIndex = 3;
            numRataMutatie.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // numGeneratie
            // 
            numGeneratie.Location = new Point(189, 64);
            numGeneratie.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numGeneratie.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            numGeneratie.Name = "numGeneratie";
            numGeneratie.Size = new Size(141, 31);
            numGeneratie.TabIndex = 5;
            numGeneratie.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // labelNrGeneratii
            // 
            labelNrGeneratii.AutoSize = true;
            labelNrGeneratii.Location = new Point(189, 36);
            labelNrGeneratii.Name = "labelNrGeneratii";
            labelNrGeneratii.Size = new Size(109, 25);
            labelNrGeneratii.TabIndex = 4;
            labelNrGeneratii.Text = "Nr. Generatii";
            // 
            // labelMutatie
            // 
            labelMutatie.AutoSize = true;
            labelMutatie.Location = new Point(355, 36);
            labelMutatie.Name = "labelMutatie";
            labelMutatie.Size = new Size(137, 25);
            labelMutatie.TabIndex = 2;
            labelMutatie.Text = "Rata Mutatie(%)";
            // 
            // numPopulatie
            // 
            numPopulatie.Location = new Point(25, 64);
            numPopulatie.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numPopulatie.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numPopulatie.Name = "numPopulatie";
            numPopulatie.Size = new Size(141, 31);
            numPopulatie.TabIndex = 1;
            numPopulatie.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // labelMarimePop
            // 
            labelMarimePop.AutoSize = true;
            labelMarimePop.Location = new Point(25, 36);
            labelMarimePop.Name = "labelMarimePop";
            labelMarimePop.Size = new Size(141, 25);
            labelMarimePop.TabIndex = 0;
            labelMarimePop.Text = "Marime Populati";
            // 
            // groupBoxLParamMasina
            // 
            groupBoxLParamMasina.Controls.Add(labelLinie2);
            groupBoxLParamMasina.Controls.Add(labelLinie3);
            groupBoxLParamMasina.Controls.Add(labelLinie);
            groupBoxLParamMasina.Controls.Add(numPutereMotorMax);
            groupBoxLParamMasina.Controls.Add(numRezervorMax);
            groupBoxLParamMasina.Controls.Add(numRotiMin);
            groupBoxLParamMasina.Controls.Add(numRotiMax);
            groupBoxLParamMasina.Controls.Add(numRezervorMin);
            groupBoxLParamMasina.Controls.Add(numPutereMotMin);
            groupBoxLParamMasina.Controls.Add(labelPutereMotor);
            groupBoxLParamMasina.Controls.Add(labelRezervor);
            groupBoxLParamMasina.Controls.Add(labelRoti);
            groupBoxLParamMasina.Location = new Point(554, 12);
            groupBoxLParamMasina.Name = "groupBoxLParamMasina";
            groupBoxLParamMasina.Size = new Size(504, 211);
            groupBoxLParamMasina.TabIndex = 1;
            groupBoxLParamMasina.TabStop = false;
            groupBoxLParamMasina.Text = "Limite Parametri Masina";
            // 
            // labelLinie2
            // 
            labelLinie2.AutoSize = true;
            labelLinie2.Location = new Point(289, 86);
            labelLinie2.Name = "labelLinie2";
            labelLinie2.Size = new Size(33, 25);
            labelLinie2.TabIndex = 14;
            labelLinie2.Text = "---";
            // 
            // labelLinie3
            // 
            labelLinie3.AutoSize = true;
            labelLinie3.Location = new Point(289, 141);
            labelLinie3.Name = "labelLinie3";
            labelLinie3.Size = new Size(33, 25);
            labelLinie3.TabIndex = 13;
            labelLinie3.Text = "---";
            // 
            // labelLinie
            // 
            labelLinie.AutoSize = true;
            labelLinie.Location = new Point(289, 36);
            labelLinie.Name = "labelLinie";
            labelLinie.Size = new Size(33, 25);
            labelLinie.TabIndex = 12;
            labelLinie.Text = "---";
            // 
            // numPutereMotorMax
            // 
            numPutereMotorMax.Location = new Point(328, 34);
            numPutereMotorMax.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numPutereMotorMax.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numPutereMotorMax.Name = "numPutereMotorMax";
            numPutereMotorMax.Size = new Size(95, 31);
            numPutereMotorMax.TabIndex = 11;
            numPutereMotorMax.Value = new decimal(new int[] { 300, 0, 0, 0 });
            // 
            // numRezervorMax
            // 
            numRezervorMax.Location = new Point(328, 86);
            numRezervorMax.Maximum = new decimal(new int[] { 80, 0, 0, 0 });
            numRezervorMax.Minimum = new decimal(new int[] { 40, 0, 0, 0 });
            numRezervorMax.Name = "numRezervorMax";
            numRezervorMax.Size = new Size(95, 31);
            numRezervorMax.TabIndex = 10;
            numRezervorMax.Value = new decimal(new int[] { 80, 0, 0, 0 });
            // 
            // numRotiMin
            // 
            numRotiMin.Location = new Point(188, 141);
            numRotiMin.Maximum = new decimal(new int[] { 22, 0, 0, 0 });
            numRotiMin.Minimum = new decimal(new int[] { 15, 0, 0, 0 });
            numRotiMin.Name = "numRotiMin";
            numRotiMin.Size = new Size(95, 31);
            numRotiMin.TabIndex = 9;
            numRotiMin.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // numRotiMax
            // 
            numRotiMax.Location = new Point(328, 141);
            numRotiMax.Maximum = new decimal(new int[] { 22, 0, 0, 0 });
            numRotiMax.Minimum = new decimal(new int[] { 15, 0, 0, 0 });
            numRotiMax.Name = "numRotiMax";
            numRotiMax.Size = new Size(95, 31);
            numRotiMax.TabIndex = 8;
            numRotiMax.Value = new decimal(new int[] { 22, 0, 0, 0 });
            // 
            // numRezervorMin
            // 
            numRezervorMin.Location = new Point(188, 86);
            numRezervorMin.Maximum = new decimal(new int[] { 80, 0, 0, 0 });
            numRezervorMin.Minimum = new decimal(new int[] { 40, 0, 0, 0 });
            numRezervorMin.Name = "numRezervorMin";
            numRezervorMin.Size = new Size(95, 31);
            numRezervorMin.TabIndex = 7;
            numRezervorMin.Value = new decimal(new int[] { 40, 0, 0, 0 });
            // 
            // numPutereMotMin
            // 
            numPutereMotMin.Location = new Point(188, 34);
            numPutereMotMin.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numPutereMotMin.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numPutereMotMin.Name = "numPutereMotMin";
            numPutereMotMin.Size = new Size(95, 31);
            numPutereMotMin.TabIndex = 6;
            numPutereMotMin.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // labelPutereMotor
            // 
            labelPutereMotor.AutoSize = true;
            labelPutereMotor.Location = new Point(17, 36);
            labelPutereMotor.Name = "labelPutereMotor";
            labelPutereMotor.Size = new Size(153, 25);
            labelPutereMotor.TabIndex = 5;
            labelPutereMotor.Text = "Putere Motor(Cp):";
            // 
            // labelRezervor
            // 
            labelRezervor.AutoSize = true;
            labelRezervor.Location = new Point(17, 88);
            labelRezervor.Name = "labelRezervor";
            labelRezervor.Size = new Size(122, 25);
            labelRezervor.TabIndex = 4;
            labelRezervor.Text = "Rezervor(Litri):";
            // 
            // labelRoti
            // 
            labelRoti.AutoSize = true;
            labelRoti.Location = new Point(17, 143);
            labelRoti.Name = "labelRoti";
            labelRoti.Size = new Size(84, 25);
            labelRoti.TabIndex = 3;
            labelRoti.Text = "Roti(dm):";
            // 
            // groupBoxComenzi
            // 
            groupBoxComenzi.Controls.Add(labelStatus);
            groupBoxComenzi.Controls.Add(buttonStart);
            groupBoxComenzi.Location = new Point(12, 153);
            groupBoxComenzi.Name = "groupBoxComenzi";
            groupBoxComenzi.Size = new Size(523, 106);
            groupBoxComenzi.TabIndex = 2;
            groupBoxComenzi.TabStop = false;
            groupBoxComenzi.Text = "Comenzi";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.ForeColor = Color.DimGray;
            labelStatus.Location = new Point(228, 45);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(167, 25);
            labelStatus.TabIndex = 1;
            labelStatus.Text = " Status: Asteptare ...";
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.Lime;
            buttonStart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStart.ForeColor = Color.FromArgb(0, 64, 0);
            buttonStart.Location = new Point(6, 30);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(198, 55);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "START";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // groupBoxRezultate
            // 
            groupBoxRezultate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxRezultate.Controls.Add(chartPareto);
            groupBoxRezultate.Location = new Point(12, 267);
            groupBoxRezultate.Name = "groupBoxRezultate";
            groupBoxRezultate.Size = new Size(1046, 384);
            groupBoxRezultate.TabIndex = 3;
            groupBoxRezultate.TabStop = false;
            groupBoxRezultate.Text = "Rezultate";
            // 
            // chartPareto
            // 
            chartPareto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartPareto.BackColor = Color.Transparent;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.Title = "Acceleration (0-100)";
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.Title = "Range";
            chartArea1.Name = "ChartArea1";
            chartPareto.ChartAreas.Add(chartArea1);
            chartPareto.Location = new Point(6, 30);
            chartPareto.Name = "chartPareto";
            chartPareto.Size = new Size(1034, 348);
            chartPareto.TabIndex = 0;
            chartPareto.Text = "Grafic Rezultate";
            chartPareto.Click += chartPareto_Click;
            // 
            // groupBoxTopRezultate
            // 
            groupBoxTopRezultate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxTopRezultate.Controls.Add(label9);
            groupBoxTopRezultate.Controls.Add(textBoxRezRotiRange);
            groupBoxTopRezultate.Controls.Add(textBoxRezRezervRange);
            groupBoxTopRezultate.Controls.Add(label10);
            groupBoxTopRezultate.Controls.Add(label11);
            groupBoxTopRezultate.Controls.Add(textBoxRezAutoRange);
            groupBoxTopRezultate.Controls.Add(textBoxRezPutereRange);
            groupBoxTopRezultate.Controls.Add(textBoxRezAccRange);
            groupBoxTopRezultate.Controls.Add(label12);
            groupBoxTopRezultate.Controls.Add(label13);
            groupBoxTopRezultate.Controls.Add(label14);
            groupBoxTopRezultate.Controls.Add(label8);
            groupBoxTopRezultate.Controls.Add(textBoxRezRotiViteza);
            groupBoxTopRezultate.Controls.Add(textBoxRezRezerViteza);
            groupBoxTopRezultate.Controls.Add(label7);
            groupBoxTopRezultate.Controls.Add(label6);
            groupBoxTopRezultate.Controls.Add(textBoxRezAutoViteza);
            groupBoxTopRezultate.Controls.Add(textBoxRezPutereViteza);
            groupBoxTopRezultate.Controls.Add(textBoxRezAccViteza);
            groupBoxTopRezultate.Controls.Add(label5);
            groupBoxTopRezultate.Controls.Add(label4);
            groupBoxTopRezultate.Controls.Add(label3);
            groupBoxTopRezultate.Controls.Add(label2);
            groupBoxTopRezultate.Controls.Add(label1);
            groupBoxTopRezultate.Location = new Point(1083, 12);
            groupBoxTopRezultate.Name = "groupBoxTopRezultate";
            groupBoxTopRezultate.Size = new Size(326, 422);
            groupBoxTopRezultate.TabIndex = 4;
            groupBoxTopRezultate.TabStop = false;
            groupBoxTopRezultate.Text = "Top Rezultate";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(188, 351);
            label9.Name = "label9";
            label9.Size = new Size(47, 25);
            label9.TabIndex = 29;
            label9.Text = "Roti:";
            // 
            // textBoxRezRotiRange
            // 
            textBoxRezRotiRange.Location = new Point(188, 379);
            textBoxRezRotiRange.Name = "textBoxRezRotiRange";
            textBoxRezRotiRange.ReadOnly = true;
            textBoxRezRotiRange.Size = new Size(113, 31);
            textBoxRezRotiRange.TabIndex = 28;
            // 
            // textBoxRezRezervRange
            // 
            textBoxRezRezervRange.Location = new Point(188, 317);
            textBoxRezRezervRange.Name = "textBoxRezRezervRange";
            textBoxRezRezervRange.ReadOnly = true;
            textBoxRezRezervRange.Size = new Size(113, 31);
            textBoxRezRezervRange.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(188, 289);
            label10.Name = "label10";
            label10.Size = new Size(84, 25);
            label10.TabIndex = 26;
            label10.Text = "Rezervor:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(188, 226);
            label11.Name = "label11";
            label11.Size = new Size(66, 25);
            label11.TabIndex = 25;
            label11.Text = "Putere:";
            // 
            // textBoxRezAutoRange
            // 
            textBoxRezAutoRange.Location = new Point(188, 151);
            textBoxRezAutoRange.Name = "textBoxRezAutoRange";
            textBoxRezAutoRange.ReadOnly = true;
            textBoxRezAutoRange.Size = new Size(113, 31);
            textBoxRezAutoRange.TabIndex = 24;
            // 
            // textBoxRezPutereRange
            // 
            textBoxRezPutereRange.Location = new Point(188, 255);
            textBoxRezPutereRange.Name = "textBoxRezPutereRange";
            textBoxRezPutereRange.ReadOnly = true;
            textBoxRezPutereRange.Size = new Size(113, 31);
            textBoxRezPutereRange.TabIndex = 23;
            // 
            // textBoxRezAccRange
            // 
            textBoxRezAccRange.Location = new Point(188, 89);
            textBoxRezAccRange.Name = "textBoxRezAccRange";
            textBoxRezAccRange.ReadOnly = true;
            textBoxRezAccRange.Size = new Size(113, 31);
            textBoxRezAccRange.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(188, 201);
            label12.Name = "label12";
            label12.Size = new Size(113, 25);
            label12.TabIndex = 21;
            label12.Text = "Configuratie:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(188, 123);
            label13.Name = "label13";
            label13.Size = new Size(105, 25);
            label13.TabIndex = 20;
            label13.Text = "Autonomie:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(188, 61);
            label14.Name = "label14";
            label14.Size = new Size(100, 25);
            label14.TabIndex = 19;
            label14.Text = "Acceleratie:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 351);
            label8.Name = "label8";
            label8.Size = new Size(47, 25);
            label8.TabIndex = 18;
            label8.Text = "Roti:";
            // 
            // textBoxRezRotiViteza
            // 
            textBoxRezRotiViteza.Location = new Point(19, 379);
            textBoxRezRotiViteza.Name = "textBoxRezRotiViteza";
            textBoxRezRotiViteza.ReadOnly = true;
            textBoxRezRotiViteza.Size = new Size(113, 31);
            textBoxRezRotiViteza.TabIndex = 17;
            // 
            // textBoxRezRezerViteza
            // 
            textBoxRezRezerViteza.Location = new Point(19, 317);
            textBoxRezRezerViteza.Name = "textBoxRezRezerViteza";
            textBoxRezRezerViteza.ReadOnly = true;
            textBoxRezRezerViteza.Size = new Size(113, 31);
            textBoxRezRezerViteza.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 289);
            label7.Name = "label7";
            label7.Size = new Size(84, 25);
            label7.TabIndex = 15;
            label7.Text = "Rezervor:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 226);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 14;
            label6.Text = "Putere:";
            // 
            // textBoxRezAutoViteza
            // 
            textBoxRezAutoViteza.Location = new Point(19, 151);
            textBoxRezAutoViteza.Name = "textBoxRezAutoViteza";
            textBoxRezAutoViteza.ReadOnly = true;
            textBoxRezAutoViteza.Size = new Size(113, 31);
            textBoxRezAutoViteza.TabIndex = 13;
            // 
            // textBoxRezPutereViteza
            // 
            textBoxRezPutereViteza.Location = new Point(19, 255);
            textBoxRezPutereViteza.Name = "textBoxRezPutereViteza";
            textBoxRezPutereViteza.ReadOnly = true;
            textBoxRezPutereViteza.Size = new Size(113, 31);
            textBoxRezPutereViteza.TabIndex = 12;
            // 
            // textBoxRezAccViteza
            // 
            textBoxRezAccViteza.Location = new Point(19, 89);
            textBoxRezAccViteza.Name = "textBoxRezAccViteza";
            textBoxRezAccViteza.ReadOnly = true;
            textBoxRezAccViteza.Size = new Size(113, 31);
            textBoxRezAccViteza.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 201);
            label5.Name = "label5";
            label5.Size = new Size(113, 25);
            label5.TabIndex = 10;
            label5.Text = "Configuratie:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 123);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 9;
            label4.Text = "Autonomie:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 61);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 8;
            label3.Text = "Acceleratie:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 27);
            label2.Name = "label2";
            label2.Size = new Size(160, 25);
            label2.TabIndex = 7;
            label2.Text = "Cel mai bun range:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 27);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 6;
            label1.Text = "Cea mai rapida:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1421, 663);
            Controls.Add(groupBoxTopRezultate);
            Controls.Add(groupBoxRezultate);
            Controls.Add(groupBoxComenzi);
            Controls.Add(groupBoxLParamMasina);
            Controls.Add(GroupBoxSetariAlg);
            Name = "Form1";
            Text = "Form1";
            GroupBoxSetariAlg.ResumeLayout(false);
            GroupBoxSetariAlg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numRataMutatie).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGeneratie).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPopulatie).EndInit();
            groupBoxLParamMasina.ResumeLayout(false);
            groupBoxLParamMasina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPutereMotorMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRezervorMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRotiMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRotiMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRezervorMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPutereMotMin).EndInit();
            groupBoxComenzi.ResumeLayout(false);
            groupBoxComenzi.PerformLayout();
            groupBoxRezultate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartPareto).EndInit();
            groupBoxTopRezultate.ResumeLayout(false);
            groupBoxTopRezultate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GroupBoxSetariAlg;
        private Label labelMarimePop;
        private NumericUpDown numPopulatie;
        private NumericUpDown numGeneratie;
        private Label labelNrGeneratii;
        private NumericUpDown numRataMutatie;
        private Label labelMutatie;
        private GroupBox groupBoxLParamMasina;
        private Label labelPutereMotor;
        private Label labelRezervor;
        private Label labelRoti;
        private NumericUpDown numPutereMotMin;
        private NumericUpDown numPutereMotorMax;
        private NumericUpDown numRezervorMax;
        private NumericUpDown numRotiMin;
        private NumericUpDown numRotiMax;
        private NumericUpDown numRezervorMin;
        private Label labelLinie;
        private Label labelLinie2;
        private Label labelLinie3;
        private GroupBox groupBoxComenzi;
        private Label labelStatus;
        private Button buttonStart;
        private GroupBox groupBoxRezultate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPareto;
        private GroupBox groupBoxTopRezultate;
        private Label label2;
        private Label label1;
        private TextBox textBoxRezAccViteza;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label9;
        private TextBox textBoxRezRotiRange;
        private TextBox textBoxRezRezervRange;
        private Label label10;
        private Label label11;
        private TextBox textBoxRezAutoRange;
        private TextBox textBoxRezPutereRange;
        private TextBox textBoxRezAccRange;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label8;
        private TextBox textBoxRezRotiViteza;
        private TextBox textBoxRezRezerViteza;
        private Label label7;
        private Label label6;
        private TextBox textBoxRezAutoViteza;
        private TextBox textBoxRezPutereViteza;
    }
}
