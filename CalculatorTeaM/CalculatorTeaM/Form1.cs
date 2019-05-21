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

    
        public Button[] btn = new Button[15];


        char[] btnText = {
                          '7','8','9','+',
                          '4','5','6','-',
                          '1','2','3','=',
                          '0',',','c'};


        int[] btnTag = {
                        7,8,9,-3,
                        4,5,6,-4,
                        1,2,3,-2,
                        0,-1,-5};

        private double ac = 0; 
        private int op = 0;
        public int z = 0; 
        public bool ch1=false;

        Boolean w;

        private Boolean fd;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label2.Visible = true;
            label1.Visible = false;
            button2.Visible = true;
            button1.Enabled = false;
            label4.Visible = true;
            ch1 = true;
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

        private void button4_Click(object sender, EventArgs e)
        {
            double tmp = 0, tmp1 = 0;

            tmp = Convert.ToDouble(label1.Text);
            label1.Text = "";
            tmp1 = Math.Sin(tmp);
            label1.Text = Convert.ToString(tmp1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double tmp = 0,tmp1=0;

            tmp = Convert.ToDouble(label1.Text);
            label1.Text = "";
            tmp1 = Math.Cos(tmp);
            label1.Text = Convert.ToString(tmp1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double tmp = 0, tmp1 = 0;

            tmp = Convert.ToDouble(label1.Text);
            label1.Text = "";
            tmp1 = Math.Sqrt(tmp);
            label1.Text = Convert.ToString(tmp1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double tmp = 0, tmp1 = 0,tmp2=0;

            tmp = Convert.ToDouble(label1.Text);

            tmp1 = Convert.ToDouble(textBox2.Text);
            tmp2 = Math.Pow(tmp,tmp1);

            label1.Text = Convert.ToString(tmp2);

            textBox2.Text = "";

            textBox2.Visible = false;
            label3.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button6.Visible = true;

            textBox2.Visible = true;
            label3.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            w = true;
            fd = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();

            fd = true;


            int x, y;


            this.ClientSize = new Size(10 * bw + 10 * dx, 9 * bh +  dy);

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
            if (ch1 == true)
            {
                test();
            }

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

            if (Convert.ToInt32(btn.Tag) == 0)//me
            {
                if (fd) label1.Text = btn.Text;
                if (label1.Text != "0")
                    label1.Text += btn.Text;
                return;
            }

            // запятая
            if (Convert.ToInt32(btn.Tag) == -1)//me
            {
                if (fd)
                {
                    label1.Text = "0,";
                    fd = false;
                }
                else
                    if (label1.Text.IndexOf(",") == -1)
                    label1.Text += btn.Text;
                return;
            }

            if (Convert.ToInt32(btn.Tag) == -5)
            {
                ac = 0; // очистить аккумулятор
                op = 0;
                label1.Text = "0";
                label2.Text = "";
                fd = true; // снова ждем первую цифру
                return;
            }

            if (Convert.ToInt32(btn.Tag) < -1)
            {
                double n;

                z = Convert.ToInt32(btn.Tag);

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
                    label1.Text = ac.ToString();//me
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
