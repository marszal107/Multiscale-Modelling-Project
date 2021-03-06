﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.Drawing.Imaging;
using System.Threading;


namespace MultiscaleModelling
{
    public partial class Main : Form
    {
        #region Properties
        private int GridWidth
        {
            get { return (int)this.BoardWidthNumericUpDown.Value; }
        }

        private int GridHeight
        {
            get { return (int)this.BoardHeightNumericUpDown.Value; }
        }

        private bool GridPeriodic
        {
            get { return this.gridPeriodicCheckBox.Checked; }
        }

        public int CAGrains
        {
            get { return (int)this.caGrainsNumericUpDown.Value; }
        }

        private int Inclusions
        {
            get { return (int)this.InclusionsNumericUpDown.Value; }
        }

        private int InclusionsRadius
        {
            get { return (int)this.RadiusNumericUpDown.Value; }
        }

        private int Probability
        {
            get { return (int)this.GBCnumericUpDown.Value; }
        }


        private int BoundariesWidth
        {
            get { return (int)this.BoundariesNumericUpDown.Value; }
        }

        public string InclusionShape
        {
            get { return (string)InclusionShapeComboBox.SelectedItem;}
        }

        public string InclusionWhen
        {
            get { return (string)InclusionWhenComboBox.SelectedItem; }
        }

        public string Structure
        {
            get { return (string)StructureComboBox.SelectedItem; }
        }
        

        #endregion Properties

        private Grid grid;
        private AlgorithmCA ca;
        private List<Brush> brushes;
        private Task t;
        private CancellationTokenSource tokenSource = new CancellationTokenSource();
        

        
        private Dictionary<Button, EventsOfButton> stateButtons;
        private Button activeStateButton = null;
        public Main()
        {
            this.ca = new AlgorithmCA(this);

            InitializeComponent();
            this.SetupBrushes();
            this.SetupGrid();
            this.SetupStateButtons();
            
        }

        private void SetupGrid()
        {
            this.grid = new Grid(this.GridWidth, this.GridHeight, this.GridPeriodic);
            this.ca.Grid = this.grid;
            this.SetupBoard();
        }
        private void SetupBoard()
        {
            this.Board.Width = this.GridWidth;
            this.Board.Height = this.GridHeight;
            this.Board.Refresh();
        }
        private void SetupBrushes()
        {
            this.brushes = new List<Brush>();
            this.brushes.Add(Brushes.Black);
            this.brushes.Add(Brushes.Red);
            foreach (PropertyInfo pf in typeof(Brushes).GetProperties().Where(p => p.Name != "Black" && p.Name != "Red"))
            {
                this.brushes.Add(pf.GetValue(null, null) as Brush);
            }


            this.brushes.Insert(0, Brushes.Black);
        }


        private void SetupStateButtons()
        {
            this.stateButtons = new Dictionary<Button, EventsOfButton>();

            this.stateButtons.Add(this.SelectButton, new EventsOfButton { BoardClick = SelectGrain, On = SelectGrain_Start, Off = SelectGrain_End });
            this.stateButtons.Add(this.boundariesButton, new EventsOfButton { BoardClick = SelectBoundaries, On = SelectBoundaries_Start, Off = SelectBoundaries_End });
            this.stateButtons.Add(this.SelectBoundariesButton, new EventsOfButton { BoardClick = SelectBoundaries, On = SelectBoundaries_Start, Off = SelectBoundaries_End });
        }

        private void Board_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            for (int y = 0; y < this.grid.Height; ++y)
            {
                for (int x = 0; x < this.grid.Width; ++x)
                {
                    Cell c = this.grid.GetCell(x, y);
                    if (c.ID != 0)
                    {
                        e.Graphics.FillRectangle(this.brushes[c.ID], x, y, 1, 1);
                    }
                }
            }
        }
        private void caAddRandomGrainsButton_Click(object sender, EventArgs e)
        {
            ca.AddRandomGrains(this.CAGrains);
            Board.Refresh();
        }

        private void caSimulateButton_Click(object sender, EventArgs e)
        {
            var name = "Moore";
            tokenSource = new CancellationTokenSource();

            t = Task.Run(async () =>
            {
                try
                {
                    await ca.StartAsync(name, Board, tokenSource.Token);
                }
                catch (OperationCanceledException)
                {
                    Debug.WriteLine($"\n{nameof(OperationCanceledException)} thrown\n");
                }
            }, tokenSource.Token);
        }



        private void ResetButton_Click(object sender, EventArgs e)
        {
            tokenSource.Cancel();
            this.SetupGrid();
            this.SetupBoard();
        }
        private void NextStep_Button_Click(object sender, EventArgs e)
        {
            var name = "Moore";
            tokenSource = new CancellationTokenSource();
            t = Task.Run(async () => await ca.NextStepAns(name, Board, tokenSource.Token), tokenSource.Token);

        }
        private void SaveBitmap_Button_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(Board.ClientSize.Width, Board.ClientSize.Height);
            Board.DrawToBitmap(bmp, Board.ClientRectangle);
            bmp.Save("board.bmp");
        }

        private void gridPeriodicCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtSaveButton_Click(object sender, EventArgs e)
        {
            string filepath = "board.txt";
            System.IO.File.WriteAllBytes(filepath, new byte[0]);
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true))
            {
                for (int x = 0; x < this.grid.Height; ++x)
                {
                    for (int y = 0; y < this.grid.Width; ++y)
                    {
                        Cell c = this.grid.GetCell(x, y);
                        file.WriteLine(x + "," + y + "," + c.ID);
                    }
                }
            }
        }

        private void addInclusionButton_Click(object sender, EventArgs e)
        {
            ca.AddRandomInclusions(this.Inclusions, this.InclusionsRadius);
            Board.Refresh();
        }

        private void txtLoadButton_Click(object sender, EventArgs e)
        {
            string path = "board.txt";
            string line;

            if (System.IO.File.Exists(path))
            {
                System.IO.StreamReader file = null;
                try
                {
                    file = new System.IO.StreamReader(path);
                    while ((line = file.ReadLine()) != null)
                    {
                        String[] coordinates = line.Split(',');
                        int tmp_x = System.Convert.ToInt32(coordinates[0]);
                        int tmp_y = System.Convert.ToInt32(coordinates[1]);
                        int tmp_id = System.Convert.ToInt32(coordinates[2]);

                        Cell c = this.grid.GetCell(tmp_x, tmp_y);
                        c.ID = tmp_id;
                        c.NewID = tmp_id;
                    }
                }
                finally
                {
                    if (file != null)
                        file.Close();
                }
            }
            Console.ReadLine();
            this.Board.Refresh();

        }

        
        private void Board_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            int x = me.X;
            int y = me.Y;

            if (this.activeStateButton != null && this.stateButtons.ContainsKey(this.activeStateButton) && this.stateButtons[this.activeStateButton].BoardClick != null)
            {
                this.stateButtons[activeStateButton].BoardClick(x, y);
                this.Board.Refresh();
            }
        }

        private void GBCSimulate_Click(object sender, EventArgs e)
        {
            int chance = Probability;
            while (ca.Step_GBC(chance))
            {
                Board.Refresh();
            }
        }

        private void stateButton_Click(object sender, EventArgs e)
        {
            
                foreach (Button btn in stateButtons.Keys)
                {
                    btn.BackColor = SystemColors.Control;
                    btn.ForeColor = SystemColors.ControlText;
                }

                Button clickedButton = sender as Button;


                if (this.activeStateButton != null && this.stateButtons.ContainsKey(this.activeStateButton) && this.stateButtons[this.activeStateButton].Off != null)
                {
                    this.stateButtons[this.activeStateButton].Off();
                }


                if (this.activeStateButton != clickedButton)
                {
                    this.activeStateButton = clickedButton;
                    clickedButton.BackColor = SystemColors.Highlight;
                    clickedButton.ForeColor = SystemColors.HighlightText;


                    if (this.activeStateButton != null && this.stateButtons.ContainsKey(this.activeStateButton) && this.stateButtons[this.activeStateButton].On != null)
                    {
                        this.stateButtons[this.activeStateButton].On();
                    }
                }


                else
                {
                    activeStateButton = null;
                }
            
        }

        private void SelectGrain_Start()
        {
            this.ca.StartSelectGrains(this.Structure);
        }

        private void SelectGrain(int x, int y)
        {
            if (Structure == "Dual-phase")
            {
                this.ca.SelectGrain(x, y);
                this.Board.Refresh();
            }
            else if (Structure == "Substructure")
            {
                this.ca.SelectGrain(x, y);
                this.Board.Refresh();
            }
        }

        private void SelectGrain_End()
        {
            this.ca.EndSelectGrains();
            this.Board.Refresh();
        }

       private void SelectBoundaries_Start()
        {
            this.ca.StartSelectBoundaries();
        }

        private void SelectBoundaries(int x, int y)
        {
            this.ca.SelectBoundary(x, y);
            this.Board.Refresh();
        }

        private void SelectBoundaries_End()
        {
            this.ca.EndSelectBoundaries();
            this.Board.Refresh();
        }
        private void boundariesButton_Click(object sender, EventArgs e)
        {
            foreach (Button btn in stateButtons.Keys)
            {
                btn.BackColor = SystemColors.Control;
                btn.ForeColor = SystemColors.ControlText;
            }

            Button clickedButton = sender as Button;


            if (this.activeStateButton != null && this.stateButtons.ContainsKey(this.activeStateButton) && this.stateButtons[this.activeStateButton].Off != null)
            {
                this.stateButtons[this.activeStateButton].Off();
            }


            if (this.activeStateButton != clickedButton)
            {
                this.activeStateButton = clickedButton;
                clickedButton.BackColor = SystemColors.Highlight;
                clickedButton.ForeColor = SystemColors.HighlightText;


                if (this.activeStateButton != null && this.stateButtons.ContainsKey(this.activeStateButton) && this.stateButtons[this.activeStateButton].On != null)
                {
                    this.stateButtons[this.activeStateButton].On();
                    int length = 0;
                    for (int y = 0; y < this.grid.Width - 1; ++y)
                    {
                        for (int x = 1; x < this.grid.Height; ++x)
                        {
                            Cell c = this.grid.GetCell(x - this.BoundariesWidth, y);
                            Cell c2 = this.grid.GetCell(x, y);
                            Cell c3 = this.grid.GetCell(x, y + this.BoundariesWidth);

                            if (c.ID > 1 && (c.ID != c2.ID || c.ID != c3.ID))
                            {
                                c.ID = 1;
                                c.NewID = 1;
                                length++;
                            }

                        }
                    }
                    HashSet<int> set = new HashSet<int>();

                    grid.ResetCurrentCellPosition();
                    do
                    {
                        set.Add(grid.CurrentCell.ID);

                    } while (grid.Next());

                    for (int y = this.grid.Width; y > 0 - 1; --y)
                    {
                        for (int x = this.grid.Height; x > 0; --x)
                        {
                            Cell c = this.grid.GetCell(x + this.BoundariesWidth, y);
                            Cell c2 = this.grid.GetCell(x, y);
                            Cell c3 = this.grid.GetCell(x, y - this.BoundariesWidth);

                            if (c.ID > 1 && (c.ID != c2.ID || c.ID != c3.ID))
                            {
                                c.ID = 1;
                                c.NewID = 1;
                                length++;
                            }

                        }
                    }
                    this.Board.Refresh();

                    
                    

                    grid.ResetCurrentCellPosition();
                    do
                    {
                        set.Add(grid.CurrentCell.ID);

                    } while (grid.Next());

                    var total = set.Count - 1;
                    double averangeGrain = (this.grid.Height * this.grid.Width) / total;
                    
                    


                    DialogResult result;
                    result = MessageBox.Show("Total Length [px]:" + length + "\nAverange size [px]:" + averangeGrain);
                }
            }


            else
            {
                activeStateButton = null;
            }

        }

        private void SelectBoundariesButton_Click(object sender, EventArgs e)

        {
            foreach (Button btn in stateButtons.Keys)
            {
                btn.BackColor = SystemColors.Control;
                btn.ForeColor = SystemColors.ControlText;
            }

            Button clickedButton = sender as Button;


            if (this.activeStateButton != null && this.stateButtons.ContainsKey(this.activeStateButton) && this.stateButtons[this.activeStateButton].Off != null)
            {
                this.stateButtons[this.activeStateButton].Off();
            }


            if (this.activeStateButton != clickedButton)
            {
                this.activeStateButton = clickedButton;
                clickedButton.BackColor = SystemColors.Highlight;
                clickedButton.ForeColor = SystemColors.HighlightText;


                if (this.activeStateButton != null && this.stateButtons.ContainsKey(this.activeStateButton) && this.stateButtons[this.activeStateButton].On != null)
                {
                    this.stateButtons[this.activeStateButton].On();
                  
                }
            }


            else
            {
                activeStateButton = null;
            }

        }

        private void SubstructureGenerateButton_Click(object sender, EventArgs e)
        {
            ca.AddRandomGrainsSub(this.CAGrains);
            Board.Refresh();
            var name = "Moore";
            tokenSource = new CancellationTokenSource();

            t = Task.Run(async () =>
            {
                try
                {
                    await ca.StartAsyncSub(name, Board, tokenSource.Token);
                }
                catch (OperationCanceledException)
                {
                    Debug.WriteLine($"\n{nameof(OperationCanceledException)} thrown\n");
                }
            }, tokenSource.Token);
        }
    }
    
}