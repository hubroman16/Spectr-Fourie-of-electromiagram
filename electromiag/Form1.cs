using System.Numerics;
using MathNet.Numerics.IntegralTransforms;
using System.Windows.Forms;
using System;

namespace electromiag
{
    public partial class Form1 : Form
    {
        private double[] GenerateEMG(int n, int state)
        {
            const double samplingRate = 2000.0;
            const double f1 = 100.0;
            const double f2 = 400.0;
            const double f3 = 800.0;
            const double p1 = 0.6;
            const double p2 = 0.3;
            const double p3 = 0.1;

            double[] emg = new double[n];
            Random rand = new Random();

            switch (state)
            {
                case 0: // resting state
                    for (int i = 0; i < n; i++)
                    {
                        emg[i] = rand.NextDouble() * 0.1 - 0.05;
                    }
                    break;
                case 1: // contraction state
                    for (int i = 0; i < n; i++)
                    {
                        double t = (double)i / samplingRate;
                        emg[i] = Math.Sin(2.0 * Math.PI * f1 * t) * p1
                            + Math.Sin(2.0 * Math.PI * f2 * t) * p2
                            + Math.Sin(2.0 * Math.PI * f3 * t) * p3
                            + rand.NextDouble() * 0.1 - 0.05;
                    }
                    break;
                case 2: // relaxation state
                    for (int i = 0; i < n; i++)
                    {
                        double t = (double)i / samplingRate;
                        emg[i] = Math.Sin(2.0 * Math.PI * f1 * t) * p1 * 0.5
                            + Math.Sin(2.0 * Math.PI * f2 * t) * p2 * 0.5
                            + Math.Sin(2.0 * Math.PI * f3 * t) * p3 * 0.5
                            + rand.NextDouble() * 0.1 - 0.05;
                    }
                    break;
            }

            return emg;
        }
        private double[] ComputeSpectrum(double[] data)
        {
            double[] spectrum = new double[data.Length / 2];

            Complex[] complexData = new Complex[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                complexData[i] = new Complex(data[i], 0.0);
            }

            MathNet.Numerics.IntegralTransforms.Fourier.Forward(complexData, FourierOptions.Matlab);

            for (int i = 0; i < spectrum.Length; i++)
            {
                spectrum[i] = complexData[i].Magnitude;
            }

            return spectrum;
        }

        private void restingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (restingCheckBox.Checked)
            {
                contractionCheckBox.Checked = false;
                relaxationCheckBox.Checked = false;
                double[] emg = GenerateEMG(4096, 0);
                emgChart.Series[0].Points.Clear();
                for (int i = 0; i < emg.Length; i++)
                {
                    emgChart.Series[0].Points.AddXY((double)i, emg[i]);
                }
                double[] spectrum = ComputeSpectrum(emg);
                spectrumChart.Series[0].Points.Clear();
                for (int i = 0; i < spectrum.Length; i++)
                {
                    spectrumChart.Series[0].Points.AddXY(i * 1000.0 / 4096.0, spectrum[i]);
                }
            }
        }

        private void contractionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (contractionCheckBox.Checked)
            {
                restingCheckBox.Checked = false;
                relaxationCheckBox.Checked = false;
                double[] emg = GenerateEMG(4096, 1);
                emgChart.Series[0].Points.Clear();
                for (int i = 0; i < emg.Length; i++)
                {
                    emgChart.Series[0].Points.AddXY((double)i, emg[i]);
                }
                double[] spectrum = ComputeSpectrum(emg);
                spectrumChart.Series[0].Points.Clear();
                for (int i = 0; i < spectrum.Length; i++)
                {
                    spectrumChart.Series[0].Points.AddXY(i * 1000.0 / 4096.0, spectrum[i]);
                }
            }
        }

        private void relaxationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (relaxationCheckBox.Checked)
            {
                restingCheckBox.Checked = false;
                contractionCheckBox.Checked = false;
                double[] emg = GenerateEMG(4096, 2);
                emgChart.Series[0].Points.Clear();
                for (int i = 0; i < emg.Length; i++)
                {
                    emgChart.Series[0].Points.AddXY((double)i, emg[i]);
                }
                double[] spectrum = ComputeSpectrum(emg);
                spectrumChart.Series[0].Points.Clear();
                for (int i = 0; i < spectrum.Length; i++)
                {
                    spectrumChart.Series[0].Points.AddXY(i * 1000.0 / 4096.0, spectrum[i]);
                }
            }
        }
        public Form1()
        {
            InitializeComponent();

        }
    }
}
