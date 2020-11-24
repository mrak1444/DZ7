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
    public partial class Form1 : Form
    {
        int _count;
        public Form1()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            Game.Text = "Играть";
            btnReset.Text = "Сброс";
            lblNumber.Text = "0";
            StepNum.Text = "0";
            TimerGame.Text = "0";
            RndNum.Text = "Загаданное число";
            this.Text = "Удвоитель";
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            StepNum.Text = (int.Parse(StepNum.Text) + 1).ToString();
            Game.Text = "Стоп";
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            StepNum.Text = (int.Parse(StepNum.Text) + 1).ToString();
            Game.Text = "Стоп";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            StepNum.Text = (int.Parse(StepNum.Text) + 1).ToString();
            Game.Text = "Стоп";
        }

        private void Game_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled)
            {
                timer1.Tick += Tick;
                Game.Text = "Сдаться";
                Random rnd = new Random();
                int value = rnd.Next(1, 50);
                RndNum.Text = value.ToString();
            }
            else
            {
                timer1.Tick -= Tick;
                Game.Text = "Играть";
                TimerGame.Text = "0";
                _count = 0;
            }
        }

        private void Tick(object t, EventArgs eventArgs)
        {
            TimerGame.Text = (++_count).ToString();
        }

        private void StopGame_Click(object sender, EventArgs e)
        {

        }
    }
}
