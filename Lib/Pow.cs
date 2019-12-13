using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Pow : APow
    {
        public Pow(double x, double y) : base(x, y)
        {
        }

        public override double Math()
        {
            return System.Math.Pow(this.X, this.Y);
        }
    }
}
