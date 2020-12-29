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


        public Neuron(NeuronType type)
        {
            neuron_type = type;
            _activate_val = 0.0F;
            _modulate_val = 0.0F;
            var ini = new IniFile("../setting.ini");
            float range = ini.ReadFloat("network param", "bias_range");
            var randomByte = new byte[4];
            using (var rng = new System.Security.Cryptography.RNGCryptoServiceProvider())
            {
                rng.GetBytes(randomByte);
                int random_int = System.BitConverter.ToInt32(randomByte, 0) % 1_000_000;
                bias = (float)(random_int * range) / (1_000_000);
            }
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
