using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dongvat
{
    // Ăn cỏ
    namespace Anco
    {
        public class Bo
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public float Weight { get; set; }
        }

        public class Trau
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public float Weight { get; set; }
        }

        public class De
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public float Weight { get; set; }
        }
    }

    // Ăn thịt
    namespace Anthit
    {
        public class CaSau
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public float Weight { get; set; }
        }

        public class Ho
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public float Weight { get; set; }
        }

        public class SuTu
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public float Weight { get; set; }
        }
    }

    // Ăn tạp
    namespace Antap
    {
        public class Nguoi
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public float Weight { get; set; }
        }
    }
}
