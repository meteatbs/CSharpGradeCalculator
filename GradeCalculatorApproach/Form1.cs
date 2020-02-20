using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCalculatorApproach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize, proje, final,ort;
            double vizeavg, projeavg, finalavg;
            vize = double.Parse(VizeNotu.Text);
            proje = double.Parse(ProjeNotu.Text);
            final = double.Parse(FinalNotu.Text);
            vizeavg = (vize / 100) * 30;
            projeavg = (proje / 100) * 10;
            finalavg = (final / 100) * 60;
            ort = vizeavg + projeavg + finalavg;
            Yuzdelik.Text = ort.ToString();
            Yuzdelik.Visible = true;
            if (ort >= 89.5)
            {
                Harflik.Text = "AA";
                Harflik.Visible = true;
            }
            else if (ort >= 79.5)
            {
                Harflik.Text = "BA";
                Harflik.Visible = true;
            }
            else if (ort >= 74.5)
            {
                Harflik.Text = "BB";
                Harflik.Visible = true;
            }
            else if (ort >= 69.5)
            {
                Harflik.Text = "CB";
                Harflik.Visible = true;
            }
            else if (ort >= 59.5)
            {
                Harflik.Text = "CC";
                Harflik.Visible = true;
            }
            else if (ort >= 50)
            {
                Harflik.Text = "DC";
                Harflik.Visible = true;
            }
            else if (ort >= 40)
            {
                Harflik.Text = "DD";
                Harflik.Visible = true;
            }
            else if (ort >= 0)
            {
                Harflik.Text = "FF";
                Harflik.Visible = true;
            }

        }
    }
}
