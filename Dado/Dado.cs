using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dado
{
    class Dado
    {
        private static Random dado;

        public Dado()
        {
            dado = new Random();
        }

        public int lanzar()
        {
            return dado.Next(1,7);
        }
    }
}
