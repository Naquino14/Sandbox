using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeBasedML
{
    #nullable disable
    public class Neuron
    {
        private const float sigmoidCutoff = 10;

        public bool isInput = false;
        public List<Neuron> incoming;
        public List<Neuron> outgoing;
        public float activation;
        public float weight;
        public float bias;

        public float Sigmoid(float x)
        { return 1 / (1 + MathF.Exp(-x)); }

        public Neuron(bool isInput = false)
        {
            this.isInput = isInput;
        }

        public Neuron(List<Neuron> incoming = null, List<Neuron> outgoing = null)
        {
            this.incoming = incoming;
            this.outgoing = outgoing;
        }

        ~Neuron()
        { /* for later? */ }

        public void Activate(float x = 0)
        {
            if (isInput)
                activation = Sigmoid(x);
            else
            {
                float sum = 0;
                foreach (Neuron n in incoming)
                    sum += n.activation * n.weight;
                this.activation = Sigmoid(sum + bias);
            }
        }
    }
}
