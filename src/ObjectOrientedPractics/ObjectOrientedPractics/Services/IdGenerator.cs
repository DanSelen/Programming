using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    internal class IdGenerator
    {
        private static int _counter;
        public static int GetNextId()
        {
            return ++_counter;
        }
    }
}
