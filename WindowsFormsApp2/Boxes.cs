using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Boxes
    {
        private bool touched;
        private int priority;
        public int counter; 
        public bool hasKnight;
        public static int count;

        public Boxes()
        {
            this.touched = false;
            this.hasKnight = false;
            this.priority = 1;
            this.counter = 0;
        }

        public bool isTouched()
        {
            return touched;
        }

        public void setTouched(bool touched)
        {
            this.touched = touched;
        }

        public int getPriority()
        {
            return priority;
        }

        public void setPriority(int priority)
        {
            this.priority = priority;
        }

        public bool getKnight()
        {
            return this.hasKnight;
        }

        public void setKnight(bool knight)
        {
            this.hasKnight = knight;
        }
    }
}
