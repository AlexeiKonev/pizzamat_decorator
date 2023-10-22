using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    public partial class Form1 : Form
    {
        Pizza pizza;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void cheese_Click(object sender, EventArgs e)
        {
            pizza = new Cheese(pizza);
        }

        private void mushrum_Click(object sender, EventArgs e)
        {
            pizza = new Mushrum(pizza);
        }

        private void result_Click(object sender, EventArgs e)
        {
            if (pizza != null)
            {
            textBox1.Text = pizza.GetDescription()+ pizza.GetCost();

            }
        }

        private void ananas_Click(object sender, EventArgs e)
        {
            pizza = new Ananas(pizza);
        }

        private void pomodoro_Click(object sender, EventArgs e)
        {
            pizza = new Pommodoro();
        }

        private void peperoni_Click(object sender, EventArgs e)
        {
            pizza = new Peperoni();
        }
    }
}
