using System;
using static System.Math;
using System.Windows.Forms;

namespace NeronNumber
{
    public partial class Form1 : Form
    {
        public class Neuron
        {

            private double[] _weights;
            private double[] _inputs;

            public Neuron(double[] inputs, double[] weights)
            {
                _weights = weights;
                _inputs = inputs;
            }

            public double[] Weights { get => _weights; set => _weights = value; }
            public double[] Inputs { get => _inputs; set => _inputs = value; }
            public double Output { get => Activator(_inputs, _weights); }

            private double Activator(double[] i, double[] w)//преобразования
            {
                double sum = 0;
                for (int l = 0; l < i.Length; ++l)
                    sum += i[l] * w[l];//линейные
                return Pow(1 + Exp(-sum), -1);//нелинейные
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
