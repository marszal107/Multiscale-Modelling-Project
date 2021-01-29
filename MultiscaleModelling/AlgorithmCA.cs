using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

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

        private Main _main;

        private Cell _cell;

        



        public AlgorithmCA(Main main)
        {
            _main = main;
        }

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
            var selectedWhen = _main.InclusionWhen;
            if (selectedWhen == "in the beggining")
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
                    var selectedValue = _main.InclusionShape;
                    if (selectedValue == "Circle")
                    {
                        AddCircleInclusion(temp_x, temp_y, r);
                    }
                    else if (selectedValue == "Square")
                    {
                        AddRectangle(temp_x, temp_y, r);
                    }
                    else
                    {
                        continue;
                    }

                }

            }

            else if (selectedWhen == "after the simulation")
            {
             
                for (int i = 0; i < number; i++)
                {
                    int temp_x = RandomHelper.Next(this.Width);
                    int temp_y = RandomHelper.Next(this.Height);

                    Cell c = this.grid.GetCell(temp_x, temp_y);
                    Cell c2 = this.grid.GetCell(temp_x + 1, temp_y);
                    Cell c3 = this.grid.GetCell(temp_x, temp_y + 1);

                    if (c.ID > 1 && (c.ID != c2.ID || c.ID != c3.ID))
                    {
                        int r = radius;
                        var selectedValue = _main.InclusionShape;
                        if (selectedValue == "Circle")
                        {
                            AddCircleInclusion(temp_y, temp_x, r);
                        }
                        else if (selectedValue == "Square")
                        {
                            AddRectangle(temp_y, temp_x, r);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        i--;
                    }


                }
            }
        }

        private bool isInCircle(int r, int y, int x)
        {
            return ((x * x) + (y * y)) <= r * r;
        }

        public void AddRectangle(int x, int y, int r)
        {
            for (int i = y - r; i <= y + r; i++)
            {
                for (int j = x - r; j <= x + r; j++)
                {

                    if (i >= 0 && j >= 0 && this.Width > j && this.Height > i)
                    {
                        this.AddInclusion(i, j);
                    }

                }
            }
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
                     
                        c.Selected = true;
                        //await StepAsync();
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

       

        public void StartSelectGrains(string changeId)
        {
            if (changeId=="Dual-phase")
            {
                this.idForSelectedGrain = 2;
            }
            else
            {
                this.idForSelectedGrain = null;
            }

            this.grid.ResetCurrentCellPosition();

            //reset
            do
            {
                this.grid.CurrentCell.Selected = false;
            } while (this.grid.Next());
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
            if (_main.Structure == "Dual-phase")
            {
                do
                {
                    if (!this.grid.CurrentCell.Selected && this.grid.CurrentCell.ID > 1) // 0 - empty cell, 1 - inclusion
                    {
                        this.grid.CurrentCell.ID = 0;
                        this.grid.CurrentCell.NewID = 0;
                    }
                } while (this.grid.Next());
            }
            else if (_main.Structure == "Substructure")
            {
                do
                {
                    if (!this.grid.CurrentCell.Selected && this.grid.CurrentCell.ID > 1) // 0 - empty cell, 1 - inclusion
                    {
                        this.grid.CurrentCell.ID = 0;
                        this.grid.CurrentCell.NewID = 0;
                    }
                } while (this.grid.Next());
            }
        }

        public void StartSelectBoundaries()
        {
           
            this.idForSelectedGrain = 2;
           
            this.grid.ResetCurrentCellPosition();

            //reset
            do
            {
                this.grid.CurrentCell.Selected = false;
            } while (this.grid.Next());
        }

        public void SelectBoundary(int x, int y)
        {
            int selectedId = this.grid.GetCell(x, y).ID;
            this.grid.ResetCurrentCellPosition();

           
            int length = 0;
            do
            {
                if (this.grid.CurrentCell.ID == selectedId)
                {
                    this.grid.CurrentCell.Selected = true;

                    if (this.idForSelectedGrain.HasValue)
                    {
                        Cell c = this.grid.GetCell(x - 1, y);
                        Cell c2 = this.grid.GetCell(x, y);
                        Cell c3 = this.grid.GetCell(x, y + 1);

                        if (c.ID > 1 && (c.ID != c2.ID || c.ID != c3.ID))
                        {
                            c.ID = 1;
                            c.NewID = 1;
                            length++;
                        }
                    }
                }
            } while (this.grid.Next());
            
        }


        public void EndSelectBoundaries()
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

        public bool Step_GBC(int probability)
        {
            Random rnd = new Random();
            int changes = 0;
            this.grid.ResetCurrentCellPosition();

            //iteracja komorek linia po linii
            do
            {
                
                if (this.grid.CurrentCell.ID == 0)
                {
                    //warunek 1
                    int id = -1;
                    int max = -1;
                    var x = grid.CurrentCell.MooreNeighborhood.Where(a => !a.Selected).GroupBy(a => a.ID).Select(a => new { Id = a.Key, Value = a.Count() }).ToList();
                    for (int i = 0; i < x.Count; i++)
                    {
                        if (x[i].Id == 0 || x[i].Id == 1 || x[i].Id == 2)
                            continue;
                        if (x[i].Value > max)
                        {
                            id = x[i].Id;
                            max = x[i].Value;
                        }
                    }
                    if (max >= 5 && id > 1)
                    {
                        ++changes;
                        grid.CurrentCell.NewID = id;
                        continue;
                    }


                    //warunek 2
                    id = -1;
                    max = -1;
                    x = grid.CurrentCell.NearestMoore.Where(a => !a.Selected).GroupBy(a => a.ID).Select(a => new { Id = a.Key, Value = a.Count() }).ToList();
                    for (int i = 0; i < x.Count; i++)
                    {

                        if (x[i].Id == 0 || x[i].Id == 1 || x[i].Id == 2)
                            continue;
                        if (x[i].Value > max)
                        {
                            id = x[i].Id;
                            max = x[i].Value;
                        }
                    }
                    if (max >= 3 && id > 1)
                    {
                        ++changes;
                        grid.CurrentCell.NewID = id;
                        continue;
                    }


                    //warunek 3
                    id = -1;
                    max = -1;
                    x = grid.CurrentCell.FurtherMooreNeighborhood.Where(a => !a.Selected).GroupBy(a => a.ID).Select(a => new { Id = a.Key, Value = a.Count() }).ToList();
                    for (int i = 0; i < x.Count; i++)
                    {
                        if (x[i].Id == 0 || x[i].Id == 1 || x[i].Id == 2)
                            continue;
                        if (x[i].Value > max)
                        {
                            id = x[i].Id;
                            max = x[i].Value;
                        }
                    }
                    if (max >= 3 && id > 1)
                    {
                        ++changes;
                        grid.CurrentCell.NewID = id;
                        continue;
                    }

                    //warunek 4

                    id = -1;
                    max = -1;
                    x = grid.CurrentCell.MooreNeighborhood.Where(a => !a.Selected).GroupBy(a => a.ID).Select(a => new { Id = a.Key, Value = a.Count() }).ToList();
                    for (int i = 0; i < x.Count; i++)
                    {
                        if (x[i].Id == 0 || x[i].Id == 1 || x[i].Id == 2)
                            continue;
                        if (x[i].Value > max)
                        {
                            id = x[i].Id;
                            max = x[i].Value;
                        }
                    }
                    int number = rnd.Next(0, 100);
                    if (id > 1 && number < probability)
                    {
                        ++changes;
                        grid.CurrentCell.NewID = id;
                        continue;
                    }

                }
            } while (this.grid.Next());

            if (changes > 0)
            {
                //kopiowanie wartosci
                this.grid.CopyNewIDtoID();
                return true;
            }
            return false;
        }

        public async Task StartAsyncSub(string name, PictureBox board, CancellationToken ct)
        {
            selectedNeighborhood = Moore;
            while (await StepAsyncSub())
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

        public async Task NextStepAnsSub(string name, PictureBox board, CancellationToken ct)
        {

            selectedNeighborhood = Moore;
            await StepAsyncSub();
            board.Invoke(new Action(delegate ()
            {
                board.Refresh();
            }));

            if (ct.IsCancellationRequested)
            {
                ct.ThrowIfCancellationRequested();
            }
        }

        public async Task<bool> StepAsyncSub()
        {

            for (int x = 0; x < this.grid.Width; x++)
            {
                for (int y = 0; y < this.grid.Width; y++)
                {
                    Cell c = this.grid.GetCell(x - 1, y);
                    if (c.ID == 2)
                    {

                        c.Selected = true;
                        //await StepAsync();
                    }
                    
                }

            }


            int changes = 0;
            grid.ResetCurrentCellPosition();
            int[] notUsedIds2 = AddRandomGrainsSub(_main.CAGrains);
            do
            {
                /*int current_ID = grid.CurrentCell.ID;
                if (notUsedIds2.Contains<int>(current_ID))*/
                if (notUsedIds2.Contains<int>(grid.CurrentCell.ID))
                //if (notUsedIds2.Contains<int>(grid.CurrentCell.ID))
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

        
        public int[] AddRandomGrainsSub(int number)
        {

            int[] notUsedIds2 = GetNotUsedIds();
            for (int i = 0; i < number; ++i)
            {
                int temp_x = RandomHelper.Next(this.Width);
                int temp_y = RandomHelper.Next(this.Height);
                this.grid.currentPosX = temp_x;
                this.grid.currentPosY = temp_y;
                Cell c = this.grid.CurrentCell;

                if (i < notUsedIds2.Length || c.ID != 2)
                {
                    
                    c.ID = notUsedIds2[i];
                    
                }

                else
                {
                    //brak id
                    break;
                }
                
            }
            return notUsedIds2;

        }
    }

}
