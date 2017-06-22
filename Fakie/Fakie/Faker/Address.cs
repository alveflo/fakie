using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Fakie.Helper;

namespace Fakie.Faker
{
    public class Address
    {
        public static string ZipCode => $"{RandomHelper.Number(3)} {RandomHelper.Number(2)}";
    }
}
