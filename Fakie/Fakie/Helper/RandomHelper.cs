using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakie.Helper
{
    public sealed class RandomHelper
    {
        public static int Number(int length)
        {
            var random = new Random();
            return random.Next((int) Math.Pow(10, length > 1 ? length - 1 : 1),(int) Math.Pow(10, length) - 1);
        }
    }
}
