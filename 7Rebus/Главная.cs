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
    public partial class Главная : Form
    {
        public Главная()
        {
            InitializeComponent();
            математика = new Математика();
            русский = new Русский();
            физкультура = new Физкультура();
        }
        Математика математика;
        Русский русский;
        Физкультура физкультура;
        private void button1_Click(object sender, EventArgs e)
        {
            математика.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            русский.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
физкультура.Show();
            Hide();
        }
    }            

}
