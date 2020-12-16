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


        public Connection(int connection_id, int input_id, int output_id, int seed)
        {
            this.connection_id = connection_id;
            this.is_valid = true;
            this.input_id = input_id;
            this.output_id = output_id;

            var random = new System.Random(seed);
            var ini = new IniFile("../setting.ini");
            var read_val = ini.Read("section1", "test");
            Console.Write("‚ ‚ :{0} ", read_val);
            this.weight = ((float)random.Next(-100_000, 100_000) / 100_100.0f);
            this.initial_weight = this.weight;
        }
    }
}