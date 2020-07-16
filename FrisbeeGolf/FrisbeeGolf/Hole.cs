using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrisbeeGolf
{
    class Hole
    {
        private int par;

        private int score;

        private bool nonZero;

        public int getScore()
        {
            return score;
        }

        public void setScore(int score)
        {
            this.score = score;
        }

        public bool getNonZero()
        {
            return nonZero;
        }

        public void setNonZero(bool nonZero)
        {
            this.nonZero = nonZero;
        }

        public int getParChange()
        {
            return score - par;
        }

        public int getPar()
        {
            return par;
        }

        public void setPar(int par)
        {
            this.par = par;
        }

    }
}
