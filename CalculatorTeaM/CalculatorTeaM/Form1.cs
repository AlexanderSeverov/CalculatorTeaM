using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorTeaM
{
    public partial class Form1 : Form
    {

        private const int bw = 50, bh = 50; 
        private const int dx = 19, dy = 21; 

    
        private Button[] btn = new Button[15];

     
        char[] btnText = {'7','8','9','+',
                          '4','5','6','-',
                          '1','2','3','=',
                          '0',',','c'};

       
        int[] btnTag = {7,8,9,-3,
                        4,5,6,-4,
                        1,2,3,-2,
                        0,-1,-5};

        private double ac = 0; 
        private int op = 0;    

        

        private Boolean fd;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label2.Visible = true;
            label1.Visible = false;
            button2.Visible = true;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            textBox1.Visible = false;
            label2.Visible = false;
            label1.Text = "";
            label1.Visible = true;
            button2.Visible = false;
        }

        public Form1()
        {
            InitializeComponent();

            fd = true;


            int x, y;


            this.ClientSize = new Size(10 * bw + 10 * dx, 10 * bh + 10 * dy);


            label1.SetBounds(dx, dy, 8 * bw + 7 * dx, bh);
            label1.Text = "0";

            y = label1.Bottom + dy;


            int k = 0;
            for (int i = 0; i < 4; i++)
            {
                x = dx;
                for (int j = 0; j < 4; j++)
                {
                    if (!((i == 3) && (j == 0)))
                    {

                        btn[k] = new Button();
                        btn[k].SetBounds(x, y, bw, bh);
                        btn[k].Tag = btnTag[k];
                        btn[k].Text = btnText[k].ToString();


                        this.btn[k].Click += new System.EventHandler(this.Button_Click);

                        if (btnTag[k] < 0)
                        {

                            btn[k].BackColor = SystemColors.ControlLight;
                        }


                        this.Controls.Add(this.btn[k]);

                        x = x + bw + dx;
                        k++;
                    }
                    else
                    {

                        btn[k] = new Button();
                        btn[k].SetBounds(x, y, bw * 2 + dx, bh);
                        btn[k].Tag = btnTag[k];
                        btn[k].Text = btnText[k].ToString();


                         this.btn[k].Click += new System.EventHandler(this.Button_Click);


                        this.Controls.Add(this.btn[k]);

                        x = x + 2 * bw + 2 * dx;
                        k++;
                        j++;
                    }
                }
                y = y + bh + dy;
            }
        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;

            if (Convert.ToInt32(btn.Tag) > 0)
            {
                if (fd)
                {
       
                    label1.Text = btn.Text;
                    fd = false;
                }
                else
                    label1.Text += btn.Text;
                return;
            }

            if (Convert.ToInt32(btn.Tag) == -5)
            {
                ac = 0; 
                op = 0;
                label1.Text = "0";

                fd = true; 
                return;
            }

            if (Convert.ToInt32(btn.Tag) < -1)
            {
                double n; 

                n = Convert.ToDouble(label1.Text);

         
                if (ac != 0)
                {
                    switch (op)
                    {
                        case -3:
                            ac += n;
                            break;
                        case -4:
                            ac -= n;
                            break;
                        case -2:
                            ac = n;
                            break;
                    }
                    label1.Text = ac.ToString("N");
                }
                else
                {
                    ac = n;
                }

                op = Convert.ToInt32(btn.Tag); 
                fd = true; // 
            }
        }
    }
}
