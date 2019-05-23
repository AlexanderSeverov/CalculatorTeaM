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
                //string tmp = Convert.ToString(btnText[3]);

                //if (transchosepic != tmp)
                //{
                //    lbl_Test1.Text = "test failed";
                //    //continue;
                //}

                lbl_Test1.Text = "test complete";
                lbl_Test2.Text = Convert.ToString(btnText[3]);
            }

           

             if (op == (-3) & z < -1)
               {
                lbl_Test1.Text = "test complete";
                lbl_Test2.Text = Convert.ToString(btnText[7]);
               }
              

            if (transchose == (-2))
               {
                lbl_Test1.Text = "test complete";
                lbl_Test2.Text = Convert.ToString(btnText[20]);
               }
           

            if (op == (-6) & z < -1)
               {
                lbl_Test1.Text = "test complete";
                lbl_Test2.Text = Convert.ToString(btnText[2]);
               }
            

            if (op == (-7) & z < -1)
              {
                lbl_Test1.Text = "test complete";
                lbl_Test2.Text = Convert.ToString(btnText[1]);
              }
            

            if (op == (-10) & z < -1)
              {
                lbl_Test1.Text = "test complete";
                lbl_Test2.Text = Convert.ToString(btnText[0]);
              }
            


            if (transchose == (-11))
            {
                lbl_Test1.Text = "test complete";
                lbl_Test2.Text = Convert.ToString(btnText[19]);
            }
           


            if (transchose == (-9))
            {
                lbl_Test1.Text = "test complete";
                lbl_Test2.Text = Convert.ToString(btnText[15]);
            }
           


            if (transchose == (-8))
            {
                lbl_Test1.Text = "test complete";
                lbl_Test2.Text = Convert.ToString(btnText[11]);
            }

            if (transchose == (-5))
            {
                lbl_Test1.Text = "test complete";
                lbl_Test2.Text = Convert.ToString(btnText[18]);
            }

            if (transchose == (-1))
            {
                lbl_Test1.Text = "test complete";
                lbl_Test2.Text = Convert.ToString(btnText[17]);
            }




        }
        

    }
}
