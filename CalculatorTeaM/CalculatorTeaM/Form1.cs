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

        private const int bw = 40, bh = 22; // размер кнопки
        private const int dx = 5, dy = 5; // расстояние между кнопками   

        // кнопки 
        private Button[] btn = new Button[15];

        // текст на кнопках
        char[] btnText = {'7','8','9','+',
                          '4','5','6','-',
                          '1','2','3','=',
                          '0',',','c'};

        // кнопку будем идентифицировать
        // по значению свойства Tag
        int[] btnTag = {7,8,9,-3,
                        4,5,6,-4,
                        1,2,3,-2,
                        0,-1,-5};

        private double ac = 0;  // аккумулятор
        private int op = 0;     // код операции

        private Boolean fd; // fd == true - ждем первую цифру числа,


        public Form1()
        {
            InitializeComponent();

            fd = true;

            // создать кнопки
            int x, y;    // координаты кнопки

            // установить размер клиентской области формы
            this.ClientSize = new Size(4 * bw + 5 * dx, 5 * bh + 7 * dy);

            // задать размер и положение индикатора
            label1.SetBounds(dx, dy, 4 * bw + 3 * dx, bh);
            label1.Text = "0";

            y = label1.Bottom + dy;

            // создать кнопки
            int k = 0; // номер кнопки
            for (int i = 0; i < 4; i++)
            {
                x = dx;
                for (int j = 0; j < 4; j++)
                {
                    if (!((i == 3) && (j == 0)))
                    {
                        // создать и настроить кнопку
                        btn[k] = new Button();
                        btn[k].SetBounds(x, y, bw, bh);
                        btn[k].Tag = btnTag[k];
                        btn[k].Text = btnText[k].ToString();


                        // задать функцию обработки
                        // события Click
                       // this.btn[k].Click += new System.EventHandler(this.Button_Click);

                        if (btnTag[k] < 0)
                        {
                            // кнопка операции
                            btn[k].BackColor = SystemColors.ControlLight;
                        }

                        // поместить кнопку на форму
                        this.Controls.Add(this.btn[k]);

                        x = x + bw + dx;
                        k++;
                    }
                    else // кнопка ноль
                    {
                        // создать и настроить кнопку
                        btn[k] = new Button();
                        btn[k].SetBounds(x, y, bw * 2 + dx, bh);
                        btn[k].Tag = btnTag[k];
                        btn[k].Text = btnText[k].ToString();

                        // задать функцию обработки
                        // события Click
                       // this.btn[k].Click += new System.EventHandler(this.Button_Click);
                
                        // поместить кнопку на форму
                        this.Controls.Add(this.btn[k]);

                        x = x + 2 * bw + 2 * dx;
                        k++;
                        j++;
                    }
                }
                y = y + bh + dy;
            }
        
    }
    }
}
