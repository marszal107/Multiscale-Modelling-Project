namespace MultiscaleModelling
{
    partial class Main
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.BoardWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.BoardHeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.caGrainsLabel = new System.Windows.Forms.Label();
            this.caGrainsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.caAddRandomGrainsButton = new System.Windows.Forms.Button();
            this.gridPeriodicCheckBox = new System.Windows.Forms.CheckBox();
            this.caSimulateButton = new System.Windows.Forms.Button();
            this.NextStep_button = new System.Windows.Forms.Button();
            this.InclusionsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addInclusionButton = new System.Windows.Forms.Button();
            this.RadiusNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.InclusionRadiusLabel = new System.Windows.Forms.Label();
            this.SaveBitmap_Button = new System.Windows.Forms.Button();
            this.txtSaveButton = new System.Windows.Forms.Button();
            this.txtLoadButton = new System.Windows.Forms.Button();
            this.Board = new System.Windows.Forms.PictureBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.InclusionsGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InclusionShapeLabel = new System.Windows.Forms.Label();
            this.InclusionWhenComboBox = new System.Windows.Forms.ComboBox();
            this.InclusionShapeComboBox = new System.Windows.Forms.ComboBox();
            this.NumberOfInclusions = new System.Windows.Forms.Label();
            this.CelluralAutomataGroupBox = new System.Windows.Forms.GroupBox();
            this.GBCgroupBox = new System.Windows.Forms.GroupBox();
            this.GBCsimulate = new System.Windows.Forms.Button();
            this.GBCnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ProbabilityLabel = new System.Windows.Forms.Label();
            this.SubstructuresGroupBox = new System.Windows.Forms.GroupBox();
            this.SelectButton = new System.Windows.Forms.Button();
            this.DPcheckBox = new System.Windows.Forms.CheckBox();
            this.BoundariesGroupBox = new System.Windows.Forms.GroupBox();
            this.SelectBoundariesButton = new System.Windows.Forms.Button();
            this.boundariesButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BoundariesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.BoardWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoardHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caGrainsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InclusionsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Board)).BeginInit();
            this.InclusionsGroupBox.SuspendLayout();
            this.CelluralAutomataGroupBox.SuspendLayout();
            this.GBCgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GBCnumericUpDown)).BeginInit();
            this.SubstructuresGroupBox.SuspendLayout();
            this.BoundariesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoundariesNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // BoardWidthNumericUpDown
            // 
            this.BoardWidthNumericUpDown.Location = new System.Drawing.Point(22, 25);
            this.BoardWidthNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.BoardWidthNumericUpDown.Name = "BoardWidthNumericUpDown";
            this.BoardWidthNumericUpDown.Size = new System.Drawing.Size(64, 20);
            this.BoardWidthNumericUpDown.TabIndex = 1;
            this.BoardWidthNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(19, 9);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(35, 13);
            this.WidthLabel.TabIndex = 1;
            this.WidthLabel.Text = "Width";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(19, 54);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(38, 13);
            this.HeightLabel.TabIndex = 2;
            this.HeightLabel.Text = "Height";
            // 
            // BoardHeightNumericUpDown
            // 
            this.BoardHeightNumericUpDown.Location = new System.Drawing.Point(22, 70);
            this.BoardHeightNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.BoardHeightNumericUpDown.Name = "BoardHeightNumericUpDown";
            this.BoardHeightNumericUpDown.Size = new System.Drawing.Size(64, 20);
            this.BoardHeightNumericUpDown.TabIndex = 3;
            this.BoardHeightNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // caGrainsLabel
            // 
            this.caGrainsLabel.AutoSize = true;
            this.caGrainsLabel.Location = new System.Drawing.Point(13, 25);
            this.caGrainsLabel.Name = "caGrainsLabel";
            this.caGrainsLabel.Size = new System.Drawing.Size(87, 13);
            this.caGrainsLabel.TabIndex = 5;
            this.caGrainsLabel.Text = "Number of grains";
            // 
            // caGrainsNumericUpDown
            // 
            this.caGrainsNumericUpDown.Location = new System.Drawing.Point(156, 23);
            this.caGrainsNumericUpDown.Name = "caGrainsNumericUpDown";
            this.caGrainsNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.caGrainsNumericUpDown.TabIndex = 6;
            // 
            // caAddRandomGrainsButton
            // 
            this.caAddRandomGrainsButton.Location = new System.Drawing.Point(10, 75);
            this.caAddRandomGrainsButton.Name = "caAddRandomGrainsButton";
            this.caAddRandomGrainsButton.Size = new System.Drawing.Size(72, 25);
            this.caAddRandomGrainsButton.TabIndex = 7;
            this.caAddRandomGrainsButton.Text = "Add grains";
            this.caAddRandomGrainsButton.UseVisualStyleBackColor = true;
            this.caAddRandomGrainsButton.Click += new System.EventHandler(this.caAddRandomGrainsButton_Click);
            // 
            // gridPeriodicCheckBox
            // 
            this.gridPeriodicCheckBox.AutoSize = true;
            this.gridPeriodicCheckBox.Checked = true;
            this.gridPeriodicCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gridPeriodicCheckBox.Location = new System.Drawing.Point(156, 49);
            this.gridPeriodicCheckBox.Name = "gridPeriodicCheckBox";
            this.gridPeriodicCheckBox.Size = new System.Drawing.Size(64, 17);
            this.gridPeriodicCheckBox.TabIndex = 8;
            this.gridPeriodicCheckBox.Text = "Periodic";
            this.gridPeriodicCheckBox.UseVisualStyleBackColor = true;
            // 
            // caSimulateButton
            // 
            this.caSimulateButton.Location = new System.Drawing.Point(156, 74);
            this.caSimulateButton.Name = "caSimulateButton";
            this.caSimulateButton.Size = new System.Drawing.Size(77, 27);
            this.caSimulateButton.TabIndex = 9;
            this.caSimulateButton.Text = "Simulate";
            this.caSimulateButton.UseVisualStyleBackColor = true;
            this.caSimulateButton.Click += new System.EventHandler(this.caSimulateButton_Click);
            // 
            // NextStep_button
            // 
            this.NextStep_button.Location = new System.Drawing.Point(88, 75);
            this.NextStep_button.Name = "NextStep_button";
            this.NextStep_button.Size = new System.Drawing.Size(62, 26);
            this.NextStep_button.TabIndex = 10;
            this.NextStep_button.Text = "Next step";
            this.NextStep_button.UseVisualStyleBackColor = true;
            this.NextStep_button.Click += new System.EventHandler(this.NextStep_Button_Click);
            // 
            // InclusionsNumericUpDown
            // 
            this.InclusionsNumericUpDown.Location = new System.Drawing.Point(168, 15);
            this.InclusionsNumericUpDown.Name = "InclusionsNumericUpDown";
            this.InclusionsNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.InclusionsNumericUpDown.TabIndex = 11;
            // 
            // addInclusionButton
            // 
            this.addInclusionButton.Location = new System.Drawing.Point(144, 121);
            this.addInclusionButton.Name = "addInclusionButton";
            this.addInclusionButton.Size = new System.Drawing.Size(89, 23);
            this.addInclusionButton.TabIndex = 12;
            this.addInclusionButton.Text = "Add inclusion";
            this.addInclusionButton.UseVisualStyleBackColor = true;
            this.addInclusionButton.Click += new System.EventHandler(this.addInclusionButton_Click);
            // 
            // RadiusNumericUpDown
            // 
            this.RadiusNumericUpDown.Location = new System.Drawing.Point(168, 41);
            this.RadiusNumericUpDown.Name = "RadiusNumericUpDown";
            this.RadiusNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.RadiusNumericUpDown.TabIndex = 13;
            this.RadiusNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // InclusionRadiusLabel
            // 
            this.InclusionRadiusLabel.AutoSize = true;
            this.InclusionRadiusLabel.Location = new System.Drawing.Point(13, 41);
            this.InclusionRadiusLabel.Name = "InclusionRadiusLabel";
            this.InclusionRadiusLabel.Size = new System.Drawing.Size(88, 13);
            this.InclusionRadiusLabel.TabIndex = 15;
            this.InclusionRadiusLabel.Text = "Size of inclusions";
            // 
            // SaveBitmap_Button
            // 
            this.SaveBitmap_Button.Location = new System.Drawing.Point(194, 485);
            this.SaveBitmap_Button.Name = "SaveBitmap_Button";
            this.SaveBitmap_Button.Size = new System.Drawing.Size(88, 23);
            this.SaveBitmap_Button.TabIndex = 17;
            this.SaveBitmap_Button.Text = "Save as *.bmp";
            this.SaveBitmap_Button.UseVisualStyleBackColor = true;
            this.SaveBitmap_Button.Click += new System.EventHandler(this.SaveBitmap_Button_Click);
            // 
            // txtSaveButton
            // 
            this.txtSaveButton.Location = new System.Drawing.Point(194, 511);
            this.txtSaveButton.Name = "txtSaveButton";
            this.txtSaveButton.Size = new System.Drawing.Size(88, 23);
            this.txtSaveButton.TabIndex = 18;
            this.txtSaveButton.Text = "Save as *.txt";
            this.txtSaveButton.UseVisualStyleBackColor = true;
            this.txtSaveButton.Click += new System.EventHandler(this.txtSaveButton_Click);
            // 
            // txtLoadButton
            // 
            this.txtLoadButton.Location = new System.Drawing.Point(194, 540);
            this.txtLoadButton.Name = "txtLoadButton";
            this.txtLoadButton.Size = new System.Drawing.Size(88, 23);
            this.txtLoadButton.TabIndex = 19;
            this.txtLoadButton.Text = "Load from *.txt";
            this.txtLoadButton.UseVisualStyleBackColor = true;
            this.txtLoadButton.Click += new System.EventHandler(this.txtLoadButton_Click);
            // 
            // Board
            // 
            this.Board.BackColor = System.Drawing.Color.White;
            this.Board.Cursor = System.Windows.Forms.Cursors.Default;
            this.Board.Location = new System.Drawing.Point(299, 54);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(500, 500);
            this.Board.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Board.TabIndex = 20;
            this.Board.TabStop = false;
            this.Board.Click += new System.EventHandler(this.Board_Click);
            this.Board.Paint += new System.Windows.Forms.PaintEventHandler(this.Board_Paint);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(194, 569);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(88, 23);
            this.ResetButton.TabIndex = 21;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // InclusionsGroupBox
            // 
            this.InclusionsGroupBox.Controls.Add(this.label1);
            this.InclusionsGroupBox.Controls.Add(this.InclusionShapeLabel);
            this.InclusionsGroupBox.Controls.Add(this.InclusionWhenComboBox);
            this.InclusionsGroupBox.Controls.Add(this.InclusionShapeComboBox);
            this.InclusionsGroupBox.Controls.Add(this.NumberOfInclusions);
            this.InclusionsGroupBox.Controls.Add(this.InclusionRadiusLabel);
            this.InclusionsGroupBox.Controls.Add(this.RadiusNumericUpDown);
            this.InclusionsGroupBox.Controls.Add(this.addInclusionButton);
            this.InclusionsGroupBox.Controls.Add(this.InclusionsNumericUpDown);
            this.InclusionsGroupBox.Location = new System.Drawing.Point(12, 236);
            this.InclusionsGroupBox.Name = "InclusionsGroupBox";
            this.InclusionsGroupBox.Size = new System.Drawing.Size(249, 156);
            this.InclusionsGroupBox.TabIndex = 22;
            this.InclusionsGroupBox.TabStop = false;
            this.InclusionsGroupBox.Text = "Inclusions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Add inclusion:";
            // 
            // InclusionShapeLabel
            // 
            this.InclusionShapeLabel.AutoSize = true;
            this.InclusionShapeLabel.Location = new System.Drawing.Point(13, 70);
            this.InclusionShapeLabel.Name = "InclusionShapeLabel";
            this.InclusionShapeLabel.Size = new System.Drawing.Size(97, 13);
            this.InclusionShapeLabel.TabIndex = 19;
            this.InclusionShapeLabel.Text = "Shape of inclusion:";
            // 
            // InclusionWhenComboBox
            // 
            this.InclusionWhenComboBox.FormattingEnabled = true;
            this.InclusionWhenComboBox.Items.AddRange(new object[] {
            "in the beggining",
            "after the simulation"});
            this.InclusionWhenComboBox.Location = new System.Drawing.Point(116, 94);
            this.InclusionWhenComboBox.Name = "InclusionWhenComboBox";
            this.InclusionWhenComboBox.Size = new System.Drawing.Size(117, 21);
            this.InclusionWhenComboBox.TabIndex = 18;
            // 
            // InclusionShapeComboBox
            // 
            this.InclusionShapeComboBox.FormattingEnabled = true;
            this.InclusionShapeComboBox.Items.AddRange(new object[] {
            "Circle",
            "Square"});
            this.InclusionShapeComboBox.Location = new System.Drawing.Point(116, 67);
            this.InclusionShapeComboBox.Name = "InclusionShapeComboBox";
            this.InclusionShapeComboBox.Size = new System.Drawing.Size(117, 21);
            this.InclusionShapeComboBox.TabIndex = 17;
            // 
            // NumberOfInclusions
            // 
            this.NumberOfInclusions.AutoSize = true;
            this.NumberOfInclusions.Location = new System.Drawing.Point(13, 17);
            this.NumberOfInclusions.Name = "NumberOfInclusions";
            this.NumberOfInclusions.Size = new System.Drawing.Size(105, 13);
            this.NumberOfInclusions.TabIndex = 16;
            this.NumberOfInclusions.Text = "Number of inclusions";
            // 
            // CelluralAutomataGroupBox
            // 
            this.CelluralAutomataGroupBox.Controls.Add(this.NextStep_button);
            this.CelluralAutomataGroupBox.Controls.Add(this.caSimulateButton);
            this.CelluralAutomataGroupBox.Controls.Add(this.gridPeriodicCheckBox);
            this.CelluralAutomataGroupBox.Controls.Add(this.caAddRandomGrainsButton);
            this.CelluralAutomataGroupBox.Controls.Add(this.caGrainsNumericUpDown);
            this.CelluralAutomataGroupBox.Controls.Add(this.caGrainsLabel);
            this.CelluralAutomataGroupBox.Location = new System.Drawing.Point(12, 115);
            this.CelluralAutomataGroupBox.Name = "CelluralAutomataGroupBox";
            this.CelluralAutomataGroupBox.Size = new System.Drawing.Size(249, 115);
            this.CelluralAutomataGroupBox.TabIndex = 23;
            this.CelluralAutomataGroupBox.TabStop = false;
            this.CelluralAutomataGroupBox.Text = "Cellural automata - Moore method";
            // 
            // GBCgroupBox
            // 
            this.GBCgroupBox.Controls.Add(this.GBCsimulate);
            this.GBCgroupBox.Controls.Add(this.GBCnumericUpDown);
            this.GBCgroupBox.Controls.Add(this.ProbabilityLabel);
            this.GBCgroupBox.Location = new System.Drawing.Point(12, 398);
            this.GBCgroupBox.Name = "GBCgroupBox";
            this.GBCgroupBox.Size = new System.Drawing.Size(249, 65);
            this.GBCgroupBox.TabIndex = 24;
            this.GBCgroupBox.TabStop = false;
            this.GBCgroupBox.Text = "Grain Boundary Shape Control";
            // 
            // GBCsimulate
            // 
            this.GBCsimulate.Location = new System.Drawing.Point(145, 30);
            this.GBCsimulate.Name = "GBCsimulate";
            this.GBCsimulate.Size = new System.Drawing.Size(88, 23);
            this.GBCsimulate.TabIndex = 2;
            this.GBCsimulate.Text = "Simulate";
            this.GBCsimulate.UseVisualStyleBackColor = true;
            this.GBCsimulate.Click += new System.EventHandler(this.GBCSimulate_Click);
            // 
            // GBCnumericUpDown
            // 
            this.GBCnumericUpDown.Location = new System.Drawing.Point(13, 33);
            this.GBCnumericUpDown.Name = "GBCnumericUpDown";
            this.GBCnumericUpDown.Size = new System.Drawing.Size(66, 20);
            this.GBCnumericUpDown.TabIndex = 1;
            this.GBCnumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // ProbabilityLabel
            // 
            this.ProbabilityLabel.AutoSize = true;
            this.ProbabilityLabel.Location = new System.Drawing.Point(10, 16);
            this.ProbabilityLabel.Name = "ProbabilityLabel";
            this.ProbabilityLabel.Size = new System.Drawing.Size(72, 13);
            this.ProbabilityLabel.TabIndex = 0;
            this.ProbabilityLabel.Text = "Probability [%]";
            // 
            // SubstructuresGroupBox
            // 
            this.SubstructuresGroupBox.Controls.Add(this.SelectButton);
            this.SubstructuresGroupBox.Controls.Add(this.DPcheckBox);
            this.SubstructuresGroupBox.Location = new System.Drawing.Point(12, 469);
            this.SubstructuresGroupBox.Name = "SubstructuresGroupBox";
            this.SubstructuresGroupBox.Size = new System.Drawing.Size(114, 85);
            this.SubstructuresGroupBox.TabIndex = 25;
            this.SubstructuresGroupBox.TabStop = false;
            this.SubstructuresGroupBox.Text = "Substructures";
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(16, 45);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(88, 23);
            this.SelectButton.TabIndex = 1;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.stateButton_Click);
            // 
            // DPcheckBox
            // 
            this.DPcheckBox.AutoSize = true;
            this.DPcheckBox.Checked = true;
            this.DPcheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DPcheckBox.Location = new System.Drawing.Point(16, 22);
            this.DPcheckBox.Name = "DPcheckBox";
            this.DPcheckBox.Size = new System.Drawing.Size(80, 17);
            this.DPcheckBox.TabIndex = 0;
            this.DPcheckBox.Text = "Dual-phase";
            this.DPcheckBox.UseVisualStyleBackColor = true;
            this.DPcheckBox.Click += new System.EventHandler(this.DPcheckBox_CheckedChanged);
            // 
            // BoundariesGroupBox
            // 
            this.BoundariesGroupBox.Controls.Add(this.SelectBoundariesButton);
            this.BoundariesGroupBox.Controls.Add(this.boundariesButton);
            this.BoundariesGroupBox.Controls.Add(this.label2);
            this.BoundariesGroupBox.Controls.Add(this.BoundariesNumericUpDown);
            this.BoundariesGroupBox.Location = new System.Drawing.Point(12, 566);
            this.BoundariesGroupBox.Name = "BoundariesGroupBox";
            this.BoundariesGroupBox.Size = new System.Drawing.Size(176, 76);
            this.BoundariesGroupBox.TabIndex = 26;
            this.BoundariesGroupBox.TabStop = false;
            this.BoundariesGroupBox.Text = "Boundaries";
            // 
            // SelectBoundariesButton
            // 
            this.SelectBoundariesButton.Location = new System.Drawing.Point(16, 47);
            this.SelectBoundariesButton.Name = "SelectBoundariesButton";
            this.SelectBoundariesButton.Size = new System.Drawing.Size(88, 23);
            this.SelectBoundariesButton.TabIndex = 3;
            this.SelectBoundariesButton.Text = "Select";
            this.SelectBoundariesButton.UseVisualStyleBackColor = true;
            this.SelectBoundariesButton.Click += new System.EventHandler(this.SelectBoundariesButton_Click);
            // 
            // boundariesButton
            // 
            this.boundariesButton.Location = new System.Drawing.Point(116, 46);
            this.boundariesButton.Name = "boundariesButton";
            this.boundariesButton.Size = new System.Drawing.Size(54, 23);
            this.boundariesButton.TabIndex = 2;
            this.boundariesButton.Text = "Show";
            this.boundariesButton.UseVisualStyleBackColor = true;
            this.boundariesButton.Click += new System.EventHandler(this.boundariesButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width";
            // 
            // BoundariesNumericUpDown
            // 
            this.BoundariesNumericUpDown.Location = new System.Drawing.Point(55, 20);
            this.BoundariesNumericUpDown.Name = "BoundariesNumericUpDown";
            this.BoundariesNumericUpDown.Size = new System.Drawing.Size(49, 20);
            this.BoundariesNumericUpDown.TabIndex = 0;
            this.BoundariesNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 649);
            this.Controls.Add(this.BoundariesGroupBox);
            this.Controls.Add(this.SubstructuresGroupBox);
            this.Controls.Add(this.GBCgroupBox);
            this.Controls.Add(this.CelluralAutomataGroupBox);
            this.Controls.Add(this.InclusionsGroupBox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.Board);
            this.Controls.Add(this.txtLoadButton);
            this.Controls.Add(this.txtSaveButton);
            this.Controls.Add(this.SaveBitmap_Button);
            this.Controls.Add(this.BoardHeightNumericUpDown);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.BoardWidthNumericUpDown);
            this.Name = "Main";
            this.Text = "Multiscale Modelling Project";
            ((System.ComponentModel.ISupportInitialize)(this.BoardWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoardHeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caGrainsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InclusionsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Board)).EndInit();
            this.InclusionsGroupBox.ResumeLayout(false);
            this.InclusionsGroupBox.PerformLayout();
            this.CelluralAutomataGroupBox.ResumeLayout(false);
            this.CelluralAutomataGroupBox.PerformLayout();
            this.GBCgroupBox.ResumeLayout(false);
            this.GBCgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GBCnumericUpDown)).EndInit();
            this.SubstructuresGroupBox.ResumeLayout(false);
            this.SubstructuresGroupBox.PerformLayout();
            this.BoundariesGroupBox.ResumeLayout(false);
            this.BoundariesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoundariesNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown BoardWidthNumericUpDown;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.NumericUpDown BoardHeightNumericUpDown;
        private System.Windows.Forms.Label caGrainsLabel;
        private System.Windows.Forms.NumericUpDown caGrainsNumericUpDown;
        private System.Windows.Forms.Button caAddRandomGrainsButton;
        private System.Windows.Forms.CheckBox gridPeriodicCheckBox;
        private System.Windows.Forms.Button caSimulateButton;
        private System.Windows.Forms.Button NextStep_button;
        private System.Windows.Forms.NumericUpDown InclusionsNumericUpDown;
        private System.Windows.Forms.Button addInclusionButton;
        private System.Windows.Forms.NumericUpDown RadiusNumericUpDown;
        private System.Windows.Forms.Label InclusionRadiusLabel;
        private System.Windows.Forms.Button SaveBitmap_Button;
        private System.Windows.Forms.Button txtSaveButton;
        private System.Windows.Forms.Button txtLoadButton;
        private System.Windows.Forms.PictureBox Board;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.GroupBox InclusionsGroupBox;
        private System.Windows.Forms.GroupBox CelluralAutomataGroupBox;
        private System.Windows.Forms.Label NumberOfInclusions;
        private System.Windows.Forms.GroupBox GBCgroupBox;
        private System.Windows.Forms.Button GBCsimulate;
        private System.Windows.Forms.NumericUpDown GBCnumericUpDown;
        private System.Windows.Forms.Label ProbabilityLabel;
        private System.Windows.Forms.GroupBox SubstructuresGroupBox;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.CheckBox DPcheckBox;
        private System.Windows.Forms.ComboBox InclusionShapeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label InclusionShapeLabel;
        private System.Windows.Forms.ComboBox InclusionWhenComboBox;
        private System.Windows.Forms.GroupBox BoundariesGroupBox;
        private System.Windows.Forms.Button boundariesButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown BoundariesNumericUpDown;
        private System.Windows.Forms.Button SelectBoundariesButton;
    }
}

