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
                
              if (op == (-4) & z < -1)
                {                
                  lbl_Test1.Text = "test complete";
                  lbl_Test2.Text = Convert.ToString(btnText[3]);
                }
              else
                {
                lbl_Test1.Text = "test failed";
                 }

             if (op == (-3) & z < -1)
               {
                lbl_Test1.Text = "test complete";
                lbl_Test2.Text = Convert.ToString(btnText[7]);
               }
               else
                   {
                lbl_Test1.Text = "test failed";
                 }

            if (transchose == (-2))
               {
                lbl_Test1.Text = "test complete";
                lbl_Test2.Text = Convert.ToString(btnText[20]);
               }
            else
            {
                lbl_Test1.Text = "test failed";
            }

            if (op == (-6) & z < -1)
               {
                lbl_Test1.Text = "test complete";
                lbl_Test2.Text = Convert.ToString(btnText[2]);
               }
            else
              {
                lbl_Test1.Text = "test failed";
              }

            if (op == (-7) & z < -1)
              {
                lbl_Test1.Text = "test complete";
                lbl_Test2.Text = Convert.ToString(btnText[1]);
              }
            else
               {
                lbl_Test1.Text = "test failed";
               }

            if (op == (-10) & z < -1)
              {
                lbl_Test1.Text = "test complete";
                lbl_Test2.Text = Convert.ToString(btnText[0]);
              }
              else
             {
                lbl_Test1.Text = "test failed";
              }


    


        }
        

    }
}
