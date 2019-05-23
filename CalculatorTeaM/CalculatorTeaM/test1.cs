using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorTeaM
{
    public partial class Form1 : Form
    {
        public int zf =-50;
        
       
        public void test1()
        {

            if (inum == 0)
            {
                ac = 4;
                op = -3;
                n = 9;               
            }

            if (inum == 1)
            {
                ac = 4;
                op = -4;
                n = 9;
            }

            if (inum == 2)
            {
                ac = 4;
                op = -6;
                n = 9;
            }

            if (inum == 3)
            {
                ac = 4;
                op = -7;
                n = 9;
            }

            if (inum == 4)
            {
                ac = 4;
                op = -10;
                n = 9;
            }

            inum++;
        }

    }
}
