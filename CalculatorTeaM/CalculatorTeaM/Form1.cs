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
        private const int dx = 19, dy = 17; 

        public Button[] btn = new Button[24];

        string[] btnText = {"y^x","/","*","-",
                            "7"  ,"8","9","+",
                            "4","5","6","cos",
                            "1","2","3","sin",
                            "0",",","C","Sqrt",
                            "="," "," ", " "};

        int[] btnTag = {-11,-7,-6,-4,
                          7, 8, 9,-3,
                          4, 5, 6,-8,
                          1, 2, 3,-9,
                          0,-1,-5,-16
                        -2,-14,-15,-13};

        private double ac = 0; 
        private int op = 0;
        public int z = 0; 
        public bool ch1=false;

        private double n; // число на индикаторе
        
        private Boolean fd;

        private void button1_Click(object sender, EventArgs e)//Test
        {
            tb_Test.Visible = true;
            lbl_Test1.Visible = true;
            lbl_Indication.Visible = false;
            btn_Finish_Test.Visible = true;
            btn_Start_Test.Enabled = false;
            lbl_Test2.Visible = true;
            ch1 = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn_Start_Test.Enabled = true;
            tb_Test.Visible = false;
            lbl_Test1.Visible = false;
            lbl_Indication.Text = "";
            lbl_Indication.Visible = true;
            btn_Finish_Test.Visible = false;
        }

        public Form1()
        {
            InitializeComponent();

            fd = true;
            int x, y;

            this.ClientSize = new Size(7 * bw + 4 * dx, 10 * bh +  dy);

            lbl_History.SetBounds(15 * dx, dy, 2 * bw + 3 * dx, 7 * bh);

            //label1.SetBounds(dx, dy, 8 * bw + 7 * dx, bh);
            lbl_Indication.Text = "0";

            y = lbl_Indication.Bottom + dy;
            int k = 0;

            for (int i = 0; i < 6; i++)
            {
                x = dx;
                for (int j = 0; j < 4; j++)
                {
                    if (!((i == 5) && (j == 0)))
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
                        btn[k].SetBounds(3*dx+2* bw, y, bw * 2 + dx, bh);
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
            if (ch1 == true)
            {
                test();
            }

            Button btn = (Button)sender;

            //Sqrt
            if (Convert.ToInt32(btn.Tag) == -16)
            {
                double tmp = 0, tmp1 = 0;

                tmp = Convert.ToDouble(lbl_Indication.Text);
                lbl_Indication.Text = "";
                tmp1 = Math.Sqrt(tmp);
                lbl_Indication.Text = Convert.ToString(tmp1);
            }

                if (Convert.ToInt32(btn.Tag) > 0)
            {
                if (fd)
                {
                    lbl_Indication.Text = btn.Text;
                    fd = false;
                }
                else
                    lbl_Indication.Text += btn.Text;
                return;
            }

            if (Convert.ToInt32(btn.Tag) == 0)//me
            {
                if (fd) lbl_Indication.Text = btn.Text;
                if (lbl_Indication.Text != "0")
                    lbl_Indication.Text += btn.Text;
                return;
            }

           
            // запятая
            if (Convert.ToInt32(btn.Tag) == -1)//me
            {
                if (fd)
                {
                    lbl_Indication.Text = "0,";
                    fd = false;
                }
                else
                    if (lbl_Indication.Text.IndexOf(",") == -1)
                    lbl_Indication.Text += btn.Text;
                return;
            }

            if (Convert.ToInt32(btn.Tag) == -5)
            {
                ac = 0; // очистить аккумулятор
                op = 0;
                lbl_Indication.Text = "0";
                lbl_History.Text = "";
                fd = true; // снова ждем первую цифру
                return;
            }

            //+
            if (Convert.ToInt32(btn.Tag) == -3)
            {
                fd = false;
                lbl_History.Text = lbl_Indication.Text + " + ";
            }

            //-
            if (Convert.ToInt32(btn.Tag) == -4)
            {
                fd = false;
                lbl_History.Text = lbl_Indication.Text + " - ";
            }

            //*
            if (Convert.ToInt32(btn.Tag) == -6)
            {
                fd = false;
                lbl_History.Text = lbl_Indication.Text + " * ";
            }

            // /
            if (Convert.ToInt32(btn.Tag) == -7)
            {
                fd = false;
                lbl_History.Text = lbl_Indication.Text + " / ";
            }

            //=
            if (Convert.ToInt32(btn.Tag) == -2)
            {
                string T = lbl_Indication.Text;
                n = Convert.ToDouble(lbl_Indication.Text);
                fd = false; 
            }

            if (Convert.ToInt32(btn.Tag) < -1)
            {
                double n;

                z = Convert.ToInt32(btn.Tag);

                n = Convert.ToDouble(lbl_Indication.Text);

                if (ac != 0 )
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
                        case -6:
                            ac *= n;
                            break;
                        case -7:
                            ac /= n;
                            break;
                        case -8:
                            ac = Math.Cos(ac);
                            break;
                        case -9:
                            ac = Math.Sin(ac);
                            break;
                        case -11:
                            ac = Math.Pow(ac,n);
                            break;
                        
                    }




                    lbl_Indication.Text = ac.ToString();//me
                    lbl_History.Text += n + " = " + ac;//перенос строки надо закончить
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
