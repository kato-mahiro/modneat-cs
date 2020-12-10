using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modneat_cs_project
{
    class TestNeuron
    {
        static void Main()
        {
            int seed = Environment.TickCount;
            Neuron normal = new Neuron(Neuron.NeuronType.normal, seed++);
            normal.activate_val = 1.0f;
            Console.Write("a:{0}, m:{1},  b:{2}, type:{3}\n", normal.activate_val, normal.modulate_val, normal.bias, normal.neuron_type);

            Neuron input = new Neuron(Neuron.NeuronType.input, seed++);
            input.activate_val = 1.0f;
            Console.Write("a:{0}, m:{1},  b:{2}, type:{3}\n", input.activate_val, input.modulate_val, input.bias, input.neuron_type);

            Neuron output = new Neuron(Neuron.NeuronType.output, seed++);
            output.activate_val = 1.0f;
            Console.Write("a:{0}, m:{1},  b:{2}, type:{3}\n", output.activate_val, output.modulate_val, output.bias, input.neuron_type);

            Neuron modulation = new Neuron(Neuron.NeuronType.modulation, seed++);
            modulation.modulate_val = 1.0f;
            Console.Write("a:{0}, m:{1},  b:{2}, type:{3}\n", modulation.activate_val, modulation.modulate_val, modulation.bias, modulation.neuron_type);

            // 意図的にエラーを出します
            normal.modulate_val = 1.0f;
            input.modulate_val = 1.0f;
            output.modulate_val = 1.0f;
            modulation.activate_val = 1.0f;
        }
    }
}
