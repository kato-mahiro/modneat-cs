using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modneat_cs_project
{
    class Test
    {
        static void Main()
        {
            Neuron n1 = new Neuron(Neuron.NeuronType.normal);
            Console.Write("a:{0}, m:{1},  b:{2}, type:{3}", n1.activate_val, n1.modulate_val, n1.bias, n1.neuron_type);
            Neuron n2 = new Neuron(Neuron.NeuronType.input);
            Neuron n3 = new Neuron(Neuron.NeuronType.output);
            Neuron n4 = new Neuron(Neuron.NeuronType.modulation);
        }
    }
}
