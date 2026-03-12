using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] ticket = new int[6];
            Random random = new Random();
            for (int i = 0; i < 6; i++)
            {
                ticket[i] = random.Next(0, 9);
            }
            label3.Text = string.Join("", ticket);
            if (ticket[0] + ticket[1] + ticket[2] == ticket[3] + ticket[4] + ticket[5])
            {
                label3.ForeColor = Color.Green;
                label4.Text = "Счастливый билет";
                label4.ForeColor = Color.Green;
            }
            else
            {
                label3.ForeColor = Color.Red;
                label4.Text = "Обычный билет";
                label4.ForeColor = Color.Red;
            }
        }
    }
}

