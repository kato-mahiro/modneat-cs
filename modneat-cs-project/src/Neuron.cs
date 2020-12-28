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

        public readonly NeuronType neuron_type;
        public readonly float bias;

        float _activate_val;
        float _modulate_val;


        public Neuron(NeuronType type, int seed)
        {
            neuron_type = type;
            _activate_val = 0.0F;
            _modulate_val = 0.0F;
            var ini = new IniFile("../setting.ini");
            float range = ini.ReadFloat("network param", "bias_range");
            var random = new System.Random(seed);
            bias = ((float)random.Next(-100_000, 100_000) / (100_100) * range);
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
}
