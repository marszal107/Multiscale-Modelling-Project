using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiscaleModelling
{
    public class AlgorithmCA
    {

        private const int MAX_GRAIN_ID = 150;
        public int Width { set; get; }
        public int Height { set; get; }
        protected Grid grid;
        protected int? idForSelectedGrain;
        private delegate bool ChooseFunction(Cell cell);

        private ChooseFunction selectedNeighborhood;


        public Grid Grid
        {
            get
            {
                return this.grid;
            }

            set
            {
                this.grid = value;
                this.Width = this.grid.Width;
                this.Height = this.grid.Height;
            }
        }

        public int[] GetNotUsedIds()
        {
            bool[] usesArr = Enumerable.Repeat(false, MAX_GRAIN_ID).ToArray();
            usesArr[0] = true; // pusta
            usesArr[1] = true; // wtracenie
            usesArr[2] = true; // ziarno

            this.grid.ResetCurrentCellPosition();

            //iteracja komorek

            do
            {
                usesArr[this.grid.CurrentCell.ID] = true;
            } while (this.grid.Next());

            List<int> ret = new List<int>();

            for (int i = 0; i < usesArr.Length; ++i)
            {
                if (usesArr[i] == false)
                    ret.Add(i);
            }

            return ret.ToArray();

        }

        //algorytm cellurar automata
        public void AddRandomGrains(int number)
        {
            int[] notUsedIds = GetNotUsedIds();

            for (int i = 0; i < number; ++i)
            {
                if (i < notUsedIds.Length)
                {
                    Cell c;

                    //szukanie pustej komorki
                    do
                    {
                        c = this.grid.GetCell(RandomHelper.Next(this.Width), RandomHelper.Next(this.Height));
                    } while (c.ID != 0 || c.Selected);
                    c.ID = notUsedIds[i];
                }

                else
                {
                    //brak id
                    break;
                }
            }

        }

        public void AddRandomInclusions(int number, int radius)
        {
            
            for (int i = 0; i < number; i++)
            {
                Cell c;
                int temp_x = RandomHelper.Next(this.Width);
                int temp_y = RandomHelper.Next(this.Height);

                c = this.grid.GetCell(temp_x, temp_y);
                c.ID = 1;
                c.NewID = 1;

                int r = radius;
                AddCircleInclusion(temp_x, temp_y, r);
            }
        }

        private bool isInCircle(int r, int y, int x)
        {
            return ((x * x) + (y * y)) <= r * r;
        }

        public void AddCircleInclusion(int x, int y, int r)
        {
            for (int i = y - r; i <= y + r; i++)
            {
                for (int j = x - r; j <= x + r; j++)
                {

                    if (isInCircle(r, Math.Abs(y - i), Math.Abs(x - j)) && i >= 0 && j >= 0 && this.Width > j && this.Height > i)
                    {
                        this.AddInclusion(i, j);
                    }

                }
            }
        }

        protected void AddInclusion(int x, int y)
        {
            Cell c = grid.GetCell(x, y);
            c.ID = 1;
            c.NewID = 1;
        }

      

        public async Task StartAsync(string name, PictureBox board, CancellationToken ct)
        {
            
            selectedNeighborhood = Moore;
            while (await StepAsync())
            {
                board.Invoke(new Action(delegate ()
                {
                    board.Refresh();
                }));
                if (ct.IsCancellationRequested)
                {
                    ct.ThrowIfCancellationRequested();
                }
            }
        }

        public async Task NextStepAns(string name, PictureBox board, CancellationToken ct)
        {
            
            selectedNeighborhood = Moore;
            await StepAsync();
            board.Invoke(new Action(delegate ()
            {
                board.Refresh();
            }));

            if (ct.IsCancellationRequested)
            {
                ct.ThrowIfCancellationRequested();
            }
        }

        public async Task<bool> StepAsync()
        {
            
            for (int x = 0; x < this.grid.Width; x++)
            {
                for (int y = 0; y < this.grid.Width; y++)
                {
                    Cell c = this.grid.GetCell(x - 1, y);
                    if (c.ID == 2)
                    {
                        await StepAsync();
                        c.Selected = true;
                    }
                }

            }

            
            int changes = 0;
            grid.ResetCurrentCellPosition();
            //iteracja komorek linia po linii
            do
            {

                //wzrost ziaren tylko w pustej komorce
                if (grid.CurrentCell.ID == 0)
                {
                    if (selectedNeighborhood(grid.CurrentCell))
                    {
                        ++changes;
                    }
                }
            } while (grid.Next());

            if (changes > 0)
            {
                //kopiowanie wartosci
                this.grid.CopyNewIDtoID();
                return true;
            }
            return false;
        }

       

        public void SelectGrain(int x, int y)
        {
            int selectedId = this.grid.GetCell(x, y).ID;
            this.grid.ResetCurrentCellPosition();

            do
            {
                if (this.grid.CurrentCell.ID == selectedId)
                {
                    this.grid.CurrentCell.Selected = true;

                    if (this.idForSelectedGrain.HasValue)
                    {
                        this.grid.CurrentCell.ID = this.idForSelectedGrain.Value;
                        this.grid.CurrentCell.NewID = this.idForSelectedGrain.Value;
                    }
                }
            } while (this.grid.Next());
        }


        public void EndSelectGrains()
        {
            this.grid.ResetCurrentCellPosition();

            do
            {
                if (!this.grid.CurrentCell.Selected && this.grid.CurrentCell.ID > 1) // 0 - empty cell, 1 - inclusion
                {
                    this.grid.CurrentCell.ID = 0;
                    this.grid.CurrentCell.NewID = 0;
                }
            } while (this.grid.Next());
        }

        
        protected bool Moore(Cell c)
        {
            CounterReturn cr = this.MooreMostCommonCell(c);

            if (cr != null)
            {
                this.grid.CurrentCell.NewID = cr.ID;
                return true;
            }
            return false;
        }


        protected CounterReturn MooreMostCommonCell(Cell c)
        {
            Counter counter = new Counter();
            counter.AddCells(c.MooreNeighborhood);
            return counter.MostCommonID;
        }

    }
}
