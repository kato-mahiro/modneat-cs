using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modneat_cs_project
{
    class Connection
    {
        public readonly int connection_id;
        public bool is_valid;
        public readonly int input_id;
        public readonly int output_id;

        public float weight;
        public readonly float initial_weight;


        public Connection(int connection_id, int input_id, int output_id)
        {
            this.connection_id = connection_id;
            this.is_valid = true;
            this.input_id = input_id;
            this.output_id = output_id;

            var ini = new IniFile("../setting.ini");
            float range = ini.ReadFloat("network param", "weight_range");

            var randomByte = new byte[4];
            using (var rng = new System.Security.Cryptography.RNGCryptoServiceProvider())
            {
                rng.GetBytes(randomByte);
                int random_int = System.BitConverter.ToInt32(randomByte, 0) % 1_000_000;
                this.weight = (float)(random_int * range) / (1_000_000);
            }
            this.initial_weight = this.weight;
        }
    }
}
