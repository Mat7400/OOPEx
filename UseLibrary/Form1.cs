using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseLibrary
{
    public partial class Form1 : Form
    {
        CalcValut.calcValut calc = new CalcValut.calcValut();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //используем калькулятор из библиотеки написанной "дргуим программистом"
            double res = calc.kalkulateKurs(100,CalcValut.valut.USD);
            MessageBox.Show(res.ToString());
        }
    }
}
