using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetTest
{
    public class Perceptron
    {
        List<double> Inputs { get; set; }
        List<double> Weight { get; set; }
        CryptoRandom Randomizer;

        public Perceptron()
        {
            Init();
        }

        public Perceptron(List<double> Inputs)
        {
            Init();

            foreach (var val in Inputs)
                AddInput(val);
        }

        public void Init()
        {
            Inputs = new List<double>();
            Weight = new List<double>();
            Randomizer = new CryptoRandom();
        }

        public void AddInput(double value)
        {
            Inputs.Add(value);
            Weight.Add(Randomizer.RandomValue);
        }

        public void Train()
        {

        }
    }

    public class CryptoRandom
    {
        public double RandomValue { get; set; }

        public CryptoRandom()
        {
            using (RNGCryptoServiceProvider p = new RNGCryptoServiceProvider())
            {
                Random r = new Random(p.GetHashCode());
                this.RandomValue = r.NextDouble();
            }
        }
    }
}
