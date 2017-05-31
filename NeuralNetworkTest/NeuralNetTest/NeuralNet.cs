using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetTest
{
    public class Layer
    {
        List<Neuron> Neurons { get; set; }

        public Layer(int Length)
        {
            Neurons = new List<Neuron>(Length);
        }
    }

    public class Neuron
    {
        List<Dendrite> Dendrites { get; set; }

        public Neuron()
        {

        }
    }

    public class Dendrite
    {
         
    }
}
