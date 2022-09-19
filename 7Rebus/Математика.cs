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
    public partial class Математика : Form
    {
        int n = 0;
        string [] answer;
        string[] userAnswers;
        bool[] correctAnswers;
        public Математика()
        {
            InitializeComponent();
            answer = new string[] { "Пять", "Конус", "Вершина" ,"Минус", "Диаметр", "Задача"};
            userAnswers = new string[answer.Length];
            correctAnswers = new bool[answer.Length];
         

        }
       
        public void show(int n)
        {

            switch (n)
            {
                case 0:
                    pictureBox1.BackgroundImage = new Bitmap(_7Rebus.Properties.Resources.пять);
                    break;
                case 1:
                    pictureBox1.BackgroundImage = new Bitmap(_7Rebus.Properties.Resources.конус);
                    break;
                case 2:
                    pictureBox1.BackgroundImage = new Bitmap(_7Rebus.Properties.Resources.вершина);
                    break;
                case 3:
                    pictureBox1.BackgroundImage = new Bitmap(_7Rebus.Properties.Resources.Минус);
                    break;
                case 4:
                    pictureBox1.BackgroundImage = new Bitmap(_7Rebus.Properties.Resources.Диаметр);
                    break;
                case 5:
                    pictureBox1.BackgroundImage = new Bitmap(_7Rebus.Properties.Resources.Задача);
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n++;
            if (n > 5) n=5;
            textBox1.Text = userAnswers[n];
            show(n);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n--;
            if (n < 0) n=0;
            textBox1.Text = userAnswers[n];
            show(n);
        }

        private void Математика_Load(object sender, EventArgs e)
        {
            var bmp = new Bitmap(_7Rebus.Properties.Resources.пять);
            pictureBox1.BackgroundImage = bmp;
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

            MessageBox.Show((correctAnswersLenth * 100 / answer.Length).ToString()); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            userAnswers[n] = textBox1.Text;
        }

       
    }
}
