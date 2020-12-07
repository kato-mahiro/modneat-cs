using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modneat_cs_project
{
    class Neuron
    {
        public enum NeuronType { input, output, normal, modulation }

        public NeuronType neuron_type;
        public float bias;

        float _activate_val;
        float _modulate_val;


        public Neuron(NeuronType type)
        {
            neuron_type = type;
            _activate_val = 0.0F;
            _modulate_val = 0.0F;
            var random = new System.Random();
            bias = (random.Next(-100, 100));
        }

        public float activate_val
        {
            get { return _activate_val; }
            set
            {
                if (neuron_type != NeuronType.modulation)
                {
                    _activate_val = value;
                }
                else
                {
                    Console.WriteLine("ERROR: 修飾ニューロンにはactivate_valをセットできません。");
                }
            }
        }
        public float modulate_val
        {
            get { return _modulate_val; }
            set
            {
                if (neuron_type == NeuronType.modulation)
                {
                    _modulate_val = value;
                }
                else
                {
                    Console.WriteLine("ERROR: 修飾ニューロンでないニューロンには modulate_valをセットできません。");
                }
            }
        }
    }

    class Test
    {
        static void Main()
        {
            Neuron n1 = new Neuron(Neuron.NeuronType.normal);
            Console.Write("a:{0}, m:{1},  b:{2}, type:{3}", n1.activate_val, n1.modulate_val, n1.bias, n1.neuron_type);
            Neuron n2 = new Neuron(Neuron.NeuronType.input);
            Neuron n3 = new Neuron(Neuron.NeuronType.output);
            Neuron n4 = new Neuron(Neuron.NeuronType.modulation);
            Console.ReadLine();

        }
    }
}