using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plusNumbers(object sender, EventArgs e)
        {
            int valueOne;
            int valueTwo;

            if (!int.TryParse(value1.Text, out valueOne))
            {
                MessageBox.Show("El primer valor no es un número querida");
                return;
            }

            if (!int.TryParse(value2.Text, out valueTwo))
            {
                MessageBox.Show("El segundo valor no es un número querida");
                return;
            }

            int result = valueOne + valueTwo;
            Result.Text = result.ToString();
        }
    }
}
