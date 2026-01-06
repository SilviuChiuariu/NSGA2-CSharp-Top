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
            numRezultateDorite = new NumericUpDown();
            resultsLabel = new Label();
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
            resultListBox = new ListBox();
            GroupBoxSetariAlg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numRezultateDorite).BeginInit();
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
            GroupBoxSetariAlg.Controls.Add(numRezultateDorite);
            GroupBoxSetariAlg.Controls.Add(resultsLabel);
            GroupBoxSetariAlg.Controls.Add(numRataMutatie);
            GroupBoxSetariAlg.Controls.Add(numGeneratie);
            GroupBoxSetariAlg.Controls.Add(labelNrGeneratii);
            GroupBoxSetariAlg.Controls.Add(labelMutatie);
            GroupBoxSetariAlg.Controls.Add(numPopulatie);
            GroupBoxSetariAlg.Controls.Add(labelMarimePop);
            GroupBoxSetariAlg.Location = new Point(8, 7);
            GroupBoxSetariAlg.Margin = new Padding(2);
            GroupBoxSetariAlg.Name = "GroupBoxSetariAlg";
            GroupBoxSetariAlg.Padding = new Padding(2);
            GroupBoxSetariAlg.Size = new Size(491, 82);
            GroupBoxSetariAlg.TabIndex = 0;
            GroupBoxSetariAlg.TabStop = false;
            GroupBoxSetariAlg.Text = "Setari Algoritm";
            // 
            // numRezultateDorite
            // 
            numRezultateDorite.Location = new Point(369, 38);
            numRezultateDorite.Margin = new Padding(2);
            numRezultateDorite.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numRezultateDorite.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numRezultateDorite.Name = "numRezultateDorite";
            numRezultateDorite.Size = new Size(109, 23);
            numRezultateDorite.TabIndex = 7;
            numRezultateDorite.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numRezultateDorite.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.Location = new Point(369, 22);
            resultsLabel.Margin = new Padding(2, 0, 2, 0);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(109, 15);
            resultsLabel.TabIndex = 6;
            resultsLabel.Text = "Nr. Rezultate Dorite";
            resultsLabel.Click += resultsLabel_Click;
            // 
            // numRataMutatie
            // 
            numRataMutatie.Location = new Point(248, 38);
            numRataMutatie.Margin = new Padding(2);
            numRataMutatie.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numRataMutatie.Name = "numRataMutatie";
            numRataMutatie.Size = new Size(99, 23);
            numRataMutatie.TabIndex = 3;
            numRataMutatie.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // numGeneratie
            // 
            numGeneratie.Location = new Point(132, 38);
            numGeneratie.Margin = new Padding(2);
            numGeneratie.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numGeneratie.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            numGeneratie.Name = "numGeneratie";
            numGeneratie.Size = new Size(99, 23);
            numGeneratie.TabIndex = 5;
            numGeneratie.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // labelNrGeneratii
            // 
            labelNrGeneratii.AutoSize = true;
            labelNrGeneratii.Location = new Point(132, 22);
            labelNrGeneratii.Margin = new Padding(2, 0, 2, 0);
            labelNrGeneratii.Name = "labelNrGeneratii";
            labelNrGeneratii.Size = new Size(73, 15);
            labelNrGeneratii.TabIndex = 4;
            labelNrGeneratii.Text = "Nr. Generatii";
            // 
            // labelMutatie
            // 
            labelMutatie.AutoSize = true;
            labelMutatie.Location = new Point(248, 22);
            labelMutatie.Margin = new Padding(2, 0, 2, 0);
            labelMutatie.Name = "labelMutatie";
            labelMutatie.Size = new Size(92, 15);
            labelMutatie.TabIndex = 2;
            labelMutatie.Text = "Rata Mutatie(%)";
            // 
            // numPopulatie
            // 
            numPopulatie.Location = new Point(18, 38);
            numPopulatie.Margin = new Padding(2);
            numPopulatie.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numPopulatie.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numPopulatie.Name = "numPopulatie";
            numPopulatie.Size = new Size(99, 23);
            numPopulatie.TabIndex = 1;
            numPopulatie.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // labelMarimePop
            // 
            labelMarimePop.AutoSize = true;
            labelMarimePop.Location = new Point(18, 22);
            labelMarimePop.Margin = new Padding(2, 0, 2, 0);
            labelMarimePop.Name = "labelMarimePop";
            labelMarimePop.Size = new Size(101, 15);
            labelMarimePop.TabIndex = 0;
            labelMarimePop.Text = "Marime Populatie";
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
            groupBoxLParamMasina.Location = new Point(503, 16);
            groupBoxLParamMasina.Margin = new Padding(2);
            groupBoxLParamMasina.Name = "groupBoxLParamMasina";
            groupBoxLParamMasina.Padding = new Padding(2);
            groupBoxLParamMasina.Size = new Size(425, 140);
            groupBoxLParamMasina.TabIndex = 1;
            groupBoxLParamMasina.TabStop = false;
            groupBoxLParamMasina.Text = "Limite Parametri Masina";
            // 
            // labelLinie2
            // 
            labelLinie2.AutoSize = true;
            labelLinie2.Location = new Point(202, 52);
            labelLinie2.Margin = new Padding(2, 0, 2, 0);
            labelLinie2.Name = "labelLinie2";
            labelLinie2.Size = new Size(22, 15);
            labelLinie2.TabIndex = 14;
            labelLinie2.Text = "---";
            // 
            // labelLinie3
            // 
            labelLinie3.AutoSize = true;
            labelLinie3.Location = new Point(202, 85);
            labelLinie3.Margin = new Padding(2, 0, 2, 0);
            labelLinie3.Name = "labelLinie3";
            labelLinie3.Size = new Size(22, 15);
            labelLinie3.TabIndex = 13;
            labelLinie3.Text = "---";
            // 
            // labelLinie
            // 
            labelLinie.AutoSize = true;
            labelLinie.Location = new Point(202, 22);
            labelLinie.Margin = new Padding(2, 0, 2, 0);
            labelLinie.Name = "labelLinie";
            labelLinie.Size = new Size(22, 15);
            labelLinie.TabIndex = 12;
            labelLinie.Text = "---";
            // 
            // numPutereMotorMax
            // 
            numPutereMotorMax.Location = new Point(230, 20);
            numPutereMotorMax.Margin = new Padding(2);
            numPutereMotorMax.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numPutereMotorMax.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numPutereMotorMax.Name = "numPutereMotorMax";
            numPutereMotorMax.Size = new Size(66, 23);
            numPutereMotorMax.TabIndex = 11;
            numPutereMotorMax.Value = new decimal(new int[] { 300, 0, 0, 0 });
            // 
            // numRezervorMax
            // 
            numRezervorMax.Location = new Point(230, 52);
            numRezervorMax.Margin = new Padding(2);
            numRezervorMax.Maximum = new decimal(new int[] { 80, 0, 0, 0 });
            numRezervorMax.Minimum = new decimal(new int[] { 40, 0, 0, 0 });
            numRezervorMax.Name = "numRezervorMax";
            numRezervorMax.Size = new Size(66, 23);
            numRezervorMax.TabIndex = 10;
            numRezervorMax.Value = new decimal(new int[] { 80, 0, 0, 0 });
            // 
            // numRotiMin
            // 
            numRotiMin.Location = new Point(132, 85);
            numRotiMin.Margin = new Padding(2);
            numRotiMin.Maximum = new decimal(new int[] { 22, 0, 0, 0 });
            numRotiMin.Minimum = new decimal(new int[] { 15, 0, 0, 0 });
            numRotiMin.Name = "numRotiMin";
            numRotiMin.Size = new Size(66, 23);
            numRotiMin.TabIndex = 9;
            numRotiMin.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // numRotiMax
            // 
            numRotiMax.Location = new Point(230, 85);
            numRotiMax.Margin = new Padding(2);
            numRotiMax.Maximum = new decimal(new int[] { 22, 0, 0, 0 });
            numRotiMax.Minimum = new decimal(new int[] { 15, 0, 0, 0 });
            numRotiMax.Name = "numRotiMax";
            numRotiMax.Size = new Size(66, 23);
            numRotiMax.TabIndex = 8;
            numRotiMax.Value = new decimal(new int[] { 22, 0, 0, 0 });
            // 
            // numRezervorMin
            // 
            numRezervorMin.Location = new Point(132, 52);
            numRezervorMin.Margin = new Padding(2);
            numRezervorMin.Maximum = new decimal(new int[] { 80, 0, 0, 0 });
            numRezervorMin.Minimum = new decimal(new int[] { 40, 0, 0, 0 });
            numRezervorMin.Name = "numRezervorMin";
            numRezervorMin.Size = new Size(66, 23);
            numRezervorMin.TabIndex = 7;
            numRezervorMin.Value = new decimal(new int[] { 40, 0, 0, 0 });
            // 
            // numPutereMotMin
            // 
            numPutereMotMin.Location = new Point(132, 20);
            numPutereMotMin.Margin = new Padding(2);
            numPutereMotMin.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numPutereMotMin.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numPutereMotMin.Name = "numPutereMotMin";
            numPutereMotMin.Size = new Size(66, 23);
            numPutereMotMin.TabIndex = 6;
            numPutereMotMin.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // labelPutereMotor
            // 
            labelPutereMotor.AutoSize = true;
            labelPutereMotor.Location = new Point(12, 22);
            labelPutereMotor.Margin = new Padding(2, 0, 2, 0);
            labelPutereMotor.Name = "labelPutereMotor";
            labelPutereMotor.Size = new Size(103, 15);
            labelPutereMotor.TabIndex = 5;
            labelPutereMotor.Text = "Putere Motor(Cp):";
            // 
            // labelRezervor
            // 
            labelRezervor.AutoSize = true;
            labelRezervor.Location = new Point(12, 53);
            labelRezervor.Margin = new Padding(2, 0, 2, 0);
            labelRezervor.Name = "labelRezervor";
            labelRezervor.Size = new Size(83, 15);
            labelRezervor.TabIndex = 4;
            labelRezervor.Text = "Rezervor(Litri):";
            // 
            // labelRoti
            // 
            labelRoti.AutoSize = true;
            labelRoti.Location = new Point(12, 86);
            labelRoti.Margin = new Padding(2, 0, 2, 0);
            labelRoti.Name = "labelRoti";
            labelRoti.Size = new Size(57, 15);
            labelRoti.TabIndex = 3;
            labelRoti.Text = "Roti(dm):";
            // 
            // groupBoxComenzi
            // 
            groupBoxComenzi.Controls.Add(labelStatus);
            groupBoxComenzi.Controls.Add(buttonStart);
            groupBoxComenzi.Location = new Point(8, 92);
            groupBoxComenzi.Margin = new Padding(2);
            groupBoxComenzi.Name = "groupBoxComenzi";
            groupBoxComenzi.Padding = new Padding(2);
            groupBoxComenzi.Size = new Size(491, 64);
            groupBoxComenzi.TabIndex = 2;
            groupBoxComenzi.TabStop = false;
            groupBoxComenzi.Text = "Comenzi";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.ForeColor = Color.DimGray;
            labelStatus.Location = new Point(160, 27);
            labelStatus.Margin = new Padding(2, 0, 2, 0);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(110, 15);
            labelStatus.TabIndex = 1;
            labelStatus.Text = " Status: Asteptare ...";
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.Lime;
            buttonStart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStart.ForeColor = Color.FromArgb(0, 64, 0);
            buttonStart.Location = new Point(4, 18);
            buttonStart.Margin = new Padding(2);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(139, 33);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "START";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // groupBoxRezultate
            // 
            groupBoxRezultate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxRezultate.Controls.Add(chartPareto);
            groupBoxRezultate.Location = new Point(8, 160);
            groupBoxRezultate.Margin = new Padding(2);
            groupBoxRezultate.Name = "groupBoxRezultate";
            groupBoxRezultate.Padding = new Padding(2);
            groupBoxRezultate.Size = new Size(924, 230);
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
            chartPareto.Location = new Point(4, 18);
            chartPareto.Margin = new Padding(2);
            chartPareto.Name = "chartPareto";
            chartPareto.Size = new Size(916, 209);
            chartPareto.TabIndex = 0;
            chartPareto.Text = "Grafic Rezultate";
            chartPareto.Click += chartPareto_Click;
            // 
            // groupBoxTopRezultate
            // 
            groupBoxTopRezultate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxTopRezultate.Controls.Add(resultListBox);
            groupBoxTopRezultate.Location = new Point(950, 7);
            groupBoxTopRezultate.Margin = new Padding(2);
            groupBoxTopRezultate.Name = "groupBoxTopRezultate";
            groupBoxTopRezultate.Padding = new Padding(2);
            groupBoxTopRezultate.Size = new Size(228, 380);
            groupBoxTopRezultate.TabIndex = 4;
            groupBoxTopRezultate.TabStop = false;
            groupBoxTopRezultate.Text = "Top Rezultate";
            // 
            // resultListBox
            // 
            resultListBox.FormattingEnabled = true;
            resultListBox.ItemHeight = 15;
            resultListBox.Location = new Point(5, 22);
            resultListBox.Name = "resultListBox";
            resultListBox.Size = new Size(218, 349);
            resultListBox.TabIndex = 0;
            resultListBox.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1187, 398);
            Controls.Add(groupBoxTopRezultate);
            Controls.Add(groupBoxRezultate);
            Controls.Add(groupBoxComenzi);
            Controls.Add(groupBoxLParamMasina);
            Controls.Add(GroupBoxSetariAlg);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            GroupBoxSetariAlg.ResumeLayout(false);
            GroupBoxSetariAlg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numRezultateDorite).EndInit();
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
        private ListBox resultListBox;
        private NumericUpDown numRezultateDorite;
        private Label resultsLabel;
    }
}
