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
        
            public void test()
            {
                
                if (op == (-3) & z < -1)
                {                
                  label2.Text = "test complete";
                  label4.Text = Convert.ToString(btnText[3]);
                }

               if (op == (-4) & z < -1)
              {
                label2.Text = "test complete";
                label4.Text = Convert.ToString(btnText[7]);
               }

             if (op == (-2) & z < -1)
               {
                label2.Text = "test complete";
                label4.Text = Convert.ToString(btnText[11]);
               }


            //if ((Convert.ToString(btnText[14]) == "c"))
            //{
            //    label2.Text = "test complete";
            //    label4.Text = Convert.ToString(btnText[14]);
            //}


        }
        

    }
}
