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
            GroupBoxSetariAlg.Location = new Point(11, 12);
            GroupBoxSetariAlg.Name = "GroupBoxSetariAlg";
            GroupBoxSetariAlg.Size = new Size(701, 137);
            GroupBoxSetariAlg.TabIndex = 0;
            GroupBoxSetariAlg.TabStop = false;
            GroupBoxSetariAlg.Text = "Setari Algoritm";
            // 
            // numRezultateDorite
            // 
            numRezultateDorite.Location = new Point(527, 63);
            numRezultateDorite.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numRezultateDorite.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numRezultateDorite.Name = "numRezultateDorite";
            numRezultateDorite.Size = new Size(156, 31);
            numRezultateDorite.TabIndex = 7;
            numRezultateDorite.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.Location = new Point(527, 37);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(165, 25);
            resultsLabel.TabIndex = 6;
            resultsLabel.Text = "Nr. Rezultate Dorite";
            // 
            // numRataMutatie
            // 
            numRataMutatie.Location = new Point(354, 63);
            numRataMutatie.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numRataMutatie.Name = "numRataMutatie";
            numRataMutatie.Size = new Size(141, 31);
            numRataMutatie.TabIndex = 3;
            numRataMutatie.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // numGeneratie
            // 
            numGeneratie.Location = new Point(189, 63);
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
            labelNrGeneratii.Location = new Point(189, 37);
            labelNrGeneratii.Name = "labelNrGeneratii";
            labelNrGeneratii.Size = new Size(109, 25);
            labelNrGeneratii.TabIndex = 4;
            labelNrGeneratii.Text = "Nr. Generatii";
            // 
            // labelMutatie
            // 
            labelMutatie.AutoSize = true;
            labelMutatie.Location = new Point(354, 37);
            labelMutatie.Name = "labelMutatie";
            labelMutatie.Size = new Size(137, 25);
            labelMutatie.TabIndex = 2;
            labelMutatie.Text = "Rata Mutatie(%)";
            // 
            // numPopulatie
            // 
            numPopulatie.Location = new Point(26, 63);
            numPopulatie.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numPopulatie.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numPopulatie.Name = "numPopulatie";
            numPopulatie.Size = new Size(141, 31);
            numPopulatie.TabIndex = 1;
            numPopulatie.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // labelMarimePop
            // 
            labelMarimePop.AutoSize = true;
            labelMarimePop.Location = new Point(26, 37);
            labelMarimePop.Name = "labelMarimePop";
            labelMarimePop.Size = new Size(150, 25);
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
            groupBoxLParamMasina.Location = new Point(719, 27);
            groupBoxLParamMasina.Name = "groupBoxLParamMasina";
            groupBoxLParamMasina.Size = new Size(607, 233);
            groupBoxLParamMasina.TabIndex = 1;
            groupBoxLParamMasina.TabStop = false;
            groupBoxLParamMasina.Text = "Limite Parametri Masina";
            // 
            // labelLinie2
            // 
            labelLinie2.AutoSize = true;
            labelLinie2.Location = new Point(289, 87);
            labelLinie2.Name = "labelLinie2";
            labelLinie2.Size = new Size(33, 25);
            labelLinie2.TabIndex = 14;
            labelLinie2.Text = "---";
            // 
            // labelLinie3
            // 
            labelLinie3.AutoSize = true;
            labelLinie3.Location = new Point(289, 142);
            labelLinie3.Name = "labelLinie3";
            labelLinie3.Size = new Size(33, 25);
            labelLinie3.TabIndex = 13;
            labelLinie3.Text = "---";
            // 
            // labelLinie
            // 
            labelLinie.AutoSize = true;
            labelLinie.Location = new Point(289, 37);
            labelLinie.Name = "labelLinie";
            labelLinie.Size = new Size(33, 25);
            labelLinie.TabIndex = 12;
            labelLinie.Text = "---";
            // 
            // numPutereMotorMax
            // 
            numPutereMotorMax.Location = new Point(329, 33);
            numPutereMotorMax.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numPutereMotorMax.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numPutereMotorMax.Name = "numPutereMotorMax";
            numPutereMotorMax.Size = new Size(94, 31);
            numPutereMotorMax.TabIndex = 11;
            numPutereMotorMax.Value = new decimal(new int[] { 300, 0, 0, 0 });
            // 
            // numRezervorMax
            // 
            numRezervorMax.Location = new Point(329, 87);
            numRezervorMax.Maximum = new decimal(new int[] { 80, 0, 0, 0 });
            numRezervorMax.Minimum = new decimal(new int[] { 40, 0, 0, 0 });
            numRezervorMax.Name = "numRezervorMax";
            numRezervorMax.Size = new Size(94, 31);
            numRezervorMax.TabIndex = 10;
            numRezervorMax.Value = new decimal(new int[] { 80, 0, 0, 0 });
            // 
            // numRotiMin
            // 
            numRotiMin.Location = new Point(189, 142);
            numRotiMin.Maximum = new decimal(new int[] { 22, 0, 0, 0 });
            numRotiMin.Minimum = new decimal(new int[] { 15, 0, 0, 0 });
            numRotiMin.Name = "numRotiMin";
            numRotiMin.Size = new Size(94, 31);
            numRotiMin.TabIndex = 9;
            numRotiMin.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // numRotiMax
            // 
            numRotiMax.Location = new Point(329, 142);
            numRotiMax.Maximum = new decimal(new int[] { 22, 0, 0, 0 });
            numRotiMax.Minimum = new decimal(new int[] { 15, 0, 0, 0 });
            numRotiMax.Name = "numRotiMax";
            numRotiMax.Size = new Size(94, 31);
            numRotiMax.TabIndex = 8;
            numRotiMax.Value = new decimal(new int[] { 22, 0, 0, 0 });
            // 
            // numRezervorMin
            // 
            numRezervorMin.Location = new Point(189, 87);
            numRezervorMin.Maximum = new decimal(new int[] { 80, 0, 0, 0 });
            numRezervorMin.Minimum = new decimal(new int[] { 40, 0, 0, 0 });
            numRezervorMin.Name = "numRezervorMin";
            numRezervorMin.Size = new Size(94, 31);
            numRezervorMin.TabIndex = 7;
            numRezervorMin.Value = new decimal(new int[] { 40, 0, 0, 0 });
            // 
            // numPutereMotMin
            // 
            numPutereMotMin.Location = new Point(189, 33);
            numPutereMotMin.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numPutereMotMin.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numPutereMotMin.Name = "numPutereMotMin";
            numPutereMotMin.Size = new Size(94, 31);
            numPutereMotMin.TabIndex = 6;
            numPutereMotMin.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // labelPutereMotor
            // 
            labelPutereMotor.AutoSize = true;
            labelPutereMotor.Location = new Point(17, 37);
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
            groupBoxComenzi.Location = new Point(11, 153);
            groupBoxComenzi.Name = "groupBoxComenzi";
            groupBoxComenzi.Size = new Size(701, 107);
            groupBoxComenzi.TabIndex = 2;
            groupBoxComenzi.TabStop = false;
            groupBoxComenzi.Text = "Comenzi";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.ForeColor = Color.DimGray;
            labelStatus.Location = new Point(229, 45);
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
            buttonStart.Size = new Size(199, 55);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "START";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // groupBoxRezultate
            // 
            groupBoxRezultate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxRezultate.Controls.Add(chartPareto);
            groupBoxRezultate.Location = new Point(11, 267);
            groupBoxRezultate.Name = "groupBoxRezultate";
            groupBoxRezultate.Size = new Size(1320, 383);
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
            chartPareto.Size = new Size(1309, 348);
            chartPareto.TabIndex = 0;
            chartPareto.Text = "Grafic Rezultate";
            chartPareto.Click += chartPareto_Click;
            // 
            // groupBoxTopRezultate
            // 
            groupBoxTopRezultate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxTopRezultate.Controls.Add(resultListBox);
            groupBoxTopRezultate.Location = new Point(1357, 12);
            groupBoxTopRezultate.Name = "groupBoxTopRezultate";
            groupBoxTopRezultate.Size = new Size(326, 633);
            groupBoxTopRezultate.TabIndex = 4;
            groupBoxTopRezultate.TabStop = false;
            groupBoxTopRezultate.Text = "Top Rezultate";
            // 
            // resultListBox
            // 
            resultListBox.FormattingEnabled = true;
            resultListBox.ItemHeight = 25;
            resultListBox.Location = new Point(7, 37);
            resultListBox.Margin = new Padding(4, 5, 4, 5);
            resultListBox.Name = "resultListBox";
            resultListBox.Size = new Size(310, 579);
            resultListBox.TabIndex = 0;
            resultListBox.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1696, 663);
            Controls.Add(groupBoxTopRezultate);
            Controls.Add(groupBoxRezultate);
            Controls.Add(groupBoxComenzi);
            Controls.Add(groupBoxLParamMasina);
            Controls.Add(GroupBoxSetariAlg);
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
