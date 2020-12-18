using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiscaleModelling
{
    public class Cell
    {
        public int ID { set; get; }

        public int NewID { set; get; }

        public bool Selected { set; get; }

        public Cell[] Neighbors { set; get; }

        public Cell() : this(0)
        {
            ;
        }

        public Cell(int id)
        {
            this.ID = ID;
        }


        #region Neighbors
        //NW    N    NE
        //W     [C]  E 
        //SW    S    SE
        

        public Cell NeighborN
        {
            get { return this.Neighbors[0]; }
        }

        public Cell NeighborNW
        {
            get { return this.Neighbors[1]; }
        }

        public Cell NeighborW
        {
            get { return this.Neighbors[2]; }
        }

        public Cell NeighborSW
        {
            get { return this.Neighbors[3]; }
        }

        public Cell NeighborS
        {
            get { return this.Neighbors[4]; }
        }

        public Cell NeighborSE
        {
            get { return this.Neighbors[5]; }
        }

        public Cell NeighborE
        {
            get { return this.Neighbors[6]; }
        }

        public Cell NeighborNE
        {
            get { return this.Neighbors[7]; }
        }
        #endregion
        public IEnumerable<Cell> MooreNeighborhood
        {
            get { return this.Neighbors; }
        }

     
    }
}
