/* Алгазин Константин
Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, а человек пытается его угадать
за минимальное число попыток. Компьютер говорит, больше или меньше загаданное число введенного.  
a) Для ввода данных от человека используется элемент TextBox;
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ7
{
    public partial class Form2 : Form
    {
        int value;
        int coun = 0;
        public Form2()
        {
            InitializeComponent();
            RunGame.Text = "Загадать число";
            this.Text = "Угадайка";
        }

        private void RunGame_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            value = rnd.Next(1, 100);
            RunNum.Enabled = true;
        }

        private void RunNum_Click(object sender, EventArgs e)
        {
            coun++;
            Counter.Text = coun.ToString();
            label2.Text = ReadNum.Text;
            if(int.Parse(ReadNum.Text) < value)
            {
                label2.Text = "Мало!";
            }
            else if(int.Parse(ReadNum.Text) > value)
            {
                label2.Text = "Много!";
            }
            else
            {
                label2.Text = "Ты угадал!!!";
                RunNum.Enabled = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
