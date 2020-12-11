using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modneat_cs_project
{
    class TestConnection
    {
        static void Main()
        {
            int seed = Environment.TickCount;
            Connection c1 = new Connection(1, 2, 3, seed);
            Console.Write("connection_id: {0}, is_valid: {1}, input_id: {2}, output_id: {3}, weight: {4}, initial_weight: {5} \n",
                                c1.connection_id, c1.is_valid, c1.input_id, c1.output_id, c1.weight, c1.initial_weight);

            //weight, is_valid以外のフィールドには値を代入できないことを確認する
            c1.weight = 10.0f;
            c1.is_valid = false;

            // 以下は不正
            // c1.connection_id = 1;
            //c1.input_id = 2;
            //c1.output_id = 10;
            //c1.initial_weight = 10.0f;
        }
    }
}
