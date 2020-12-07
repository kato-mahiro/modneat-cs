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

        NeuronType _neuron_type;
        float _activate_val;
        float _modulate_val;

        public float bias;

        public Neuron(NeuronType type)
        {
            _neuron_type = type;
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
                if (_neuron_type != NeuronType.modulation)
                {
                    _activate_val = value;
                }
                else
                {
                    Console.WriteLine("だめです");
                }
            }
        }
        public float modulate_val
        {
            get { return _modulate_val; }
            set
            {
                if (_neuron_type == NeuronType.modulation)
                {
                    _modulate_val = value;
                }
                else
                {
                    Console.WriteLine("だめです");
                }
            }
        }
    }

    class Test
    {
        static void Main()
        {
            Console.WriteLine("aa");
            Console.ReadLine();
        }
    }
}