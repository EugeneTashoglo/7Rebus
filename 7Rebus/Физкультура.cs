using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7Rebus
{
    public partial class Физкультура : Form
    {
        int n = 0;
        string[] answer;
        string[] userAnswers;
        bool[] correctAnswers;
        public Физкультура()
        {
            InitializeComponent();
            answer = new string[] { "Коньки", "Лыжи", "Прыжок", "Спорт", "Физкультура", "Штанга" };
            userAnswers = new string[answer.Length];
            correctAnswers = new bool[answer.Length];
        }
        public void show(int n)
        {

            switch (n)
            {
                case 0:
                    pictureBox1.BackgroundImage = new Bitmap(_7Rebus.Properties.Resources.коньки);
                    break;
                case 1:
                    pictureBox1.BackgroundImage = new Bitmap(_7Rebus.Properties.Resources.Лыжи);
                    break;
                case 2:
                    pictureBox1.BackgroundImage = new Bitmap(_7Rebus.Properties.Resources.Прыжок);
                    break;
                case 3:
                    pictureBox1.BackgroundImage = new Bitmap(_7Rebus.Properties.Resources.спорт);
                    break;
                case 4:
                    pictureBox1.BackgroundImage = new Bitmap(_7Rebus.Properties.Resources.физкультура);
                    break;
                case 5:
                    pictureBox1.BackgroundImage = new Bitmap(_7Rebus.Properties.Resources.Штанга);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int correctAnswersLenth = 0;
            for (int i = 0; i < userAnswers.Length; i++)
            {


                bool correct = userAnswers[i] == answer[i];
                if (correct)
                {
                    correctAnswersLenth++;
                    correctAnswers[i] = correct;
                }
            }

            MessageBox.Show("Вы прошли ребус на: " + correctAnswersLenth * 100 / answer.Length + " %");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            userAnswers[n] = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n--;
            if (n < 0) n= 0;
            textBox1.Text = userAnswers[n];
            show(n);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n++;
            if (n > 5) n=5;
            textBox1.Text = userAnswers[n];
            show(n);
        }

        private void Физкультура_Load(object sender, EventArgs e)
        {
            var bmp = new Bitmap(_7Rebus.Properties.Resources.коньки);
            pictureBox1.BackgroundImage = bmp;
        }
    }
}
