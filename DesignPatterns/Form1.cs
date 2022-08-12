using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatterns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetClientObject();
        }
        void GetClientObject()
        {
            CottonFactory cf = new ConcreteSpinning();
            Client standard = new Client(cf);
            label1.Text = standard.clientSpinning.GetType().ToString();
            label2.Text = standard.clientWeaving.GetType().ToString();

            CottonFactory df = new ConcreteWeaving();
            Client delicate = new Client(df);
            label3.Text = delicate.clientSpinning.GetType().ToString();
            label4.Text = delicate.clientWeaving.GetType().ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
