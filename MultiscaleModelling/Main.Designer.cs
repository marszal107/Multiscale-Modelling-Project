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
            this.NumberOfInclusions = new System.Windows.Forms.Label();
            this.CelluralAutomataGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.BoardWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoardHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caGrainsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InclusionsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Board)).BeginInit();
            this.InclusionsGroupBox.SuspendLayout();
            this.CelluralAutomataGroupBox.SuspendLayout();
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
            this.caSimulateButton.Size = new System.Drawing.Size(65, 27);
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
            this.InclusionsNumericUpDown.Location = new System.Drawing.Point(156, 15);
            this.InclusionsNumericUpDown.Name = "InclusionsNumericUpDown";
            this.InclusionsNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.InclusionsNumericUpDown.TabIndex = 11;
            // 
            // addInclusionButton
            // 
            this.addInclusionButton.Location = new System.Drawing.Point(135, 75);
            this.addInclusionButton.Name = "addInclusionButton";
            this.addInclusionButton.Size = new System.Drawing.Size(86, 23);
            this.addInclusionButton.TabIndex = 12;
            this.addInclusionButton.Text = "Add inclusion";
            this.addInclusionButton.UseVisualStyleBackColor = true;
            this.addInclusionButton.Click += new System.EventHandler(this.addInclusionButton_Click);
            // 
            // RadiusNumericUpDown
            // 
            this.RadiusNumericUpDown.Location = new System.Drawing.Point(156, 41);
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
            this.InclusionRadiusLabel.Location = new System.Drawing.Point(13, 48);
            this.InclusionRadiusLabel.Name = "InclusionRadiusLabel";
            this.InclusionRadiusLabel.Size = new System.Drawing.Size(101, 13);
            this.InclusionRadiusLabel.TabIndex = 15;
            this.InclusionRadiusLabel.Text = "Radius of inclusions";
            // 
            // SaveBitmap_Button
            // 
            this.SaveBitmap_Button.Location = new System.Drawing.Point(22, 358);
            this.SaveBitmap_Button.Name = "SaveBitmap_Button";
            this.SaveBitmap_Button.Size = new System.Drawing.Size(88, 23);
            this.SaveBitmap_Button.TabIndex = 17;
            this.SaveBitmap_Button.Text = "Save as *.bmp";
            this.SaveBitmap_Button.UseVisualStyleBackColor = true;
            this.SaveBitmap_Button.Click += new System.EventHandler(this.SaveBitmap_Button_Click);
            // 
            // txtSaveButton
            // 
            this.txtSaveButton.Location = new System.Drawing.Point(22, 387);
            this.txtSaveButton.Name = "txtSaveButton";
            this.txtSaveButton.Size = new System.Drawing.Size(88, 23);
            this.txtSaveButton.TabIndex = 18;
            this.txtSaveButton.Text = "Save as *.txt";
            this.txtSaveButton.UseVisualStyleBackColor = true;
            this.txtSaveButton.Click += new System.EventHandler(this.txtSaveButton_Click);
            // 
            // txtLoadButton
            // 
            this.txtLoadButton.Location = new System.Drawing.Point(22, 416);
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
            this.Board.Location = new System.Drawing.Point(247, 12);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(500, 500);
            this.Board.TabIndex = 20;
            this.Board.TabStop = false;
            this.Board.Click += new System.EventHandler(this.Board_Click);
            this.Board.Paint += new System.Windows.Forms.PaintEventHandler(this.Board_Paint);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(22, 445);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(88, 23);
            this.ResetButton.TabIndex = 21;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // InclusionsGroupBox
            // 
            this.InclusionsGroupBox.Controls.Add(this.NumberOfInclusions);
            this.InclusionsGroupBox.Controls.Add(this.InclusionRadiusLabel);
            this.InclusionsGroupBox.Controls.Add(this.RadiusNumericUpDown);
            this.InclusionsGroupBox.Controls.Add(this.addInclusionButton);
            this.InclusionsGroupBox.Controls.Add(this.InclusionsNumericUpDown);
            this.InclusionsGroupBox.Location = new System.Drawing.Point(12, 236);
            this.InclusionsGroupBox.Name = "InclusionsGroupBox";
            this.InclusionsGroupBox.Size = new System.Drawing.Size(229, 104);
            this.InclusionsGroupBox.TabIndex = 22;
            this.InclusionsGroupBox.TabStop = false;
            this.InclusionsGroupBox.Text = "Inclusions";
            // 
            // NumberOfInclusions
            // 
            this.NumberOfInclusions.AutoSize = true;
            this.NumberOfInclusions.Location = new System.Drawing.Point(13, 22);
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
            this.CelluralAutomataGroupBox.Size = new System.Drawing.Size(229, 115);
            this.CelluralAutomataGroupBox.TabIndex = 23;
            this.CelluralAutomataGroupBox.TabStop = false;
            this.CelluralAutomataGroupBox.Text = "Cellural automata - Moore method";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 546);
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
    }
}

