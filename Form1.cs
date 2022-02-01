using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishSh_t_Conversion
{
    public partial class FishShit : Form
    {
        public FishShit()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            const double G_PER_L = (double)3.78541178;

            double gallon;
            double liter;

            gallon = double.Parse(GallonsTextBox.Text);

            liter = G_PER_L * gallon;

            LitersTextBox.Text = liter.ToString();
        }
    }
}
