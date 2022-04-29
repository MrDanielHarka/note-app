using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace note_app2
{
    class Save_as
    {
        public string Teve { get; private set; }
        public Save_as(string egysor)
        {
            string[] seged = egysor.Split();

            Teve = seged[0];
        }

    }
}
