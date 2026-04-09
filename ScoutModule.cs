using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public sealed class ScoutModule : AbstractModule
    {
        public ScoutModule(Coord position, int fuel) : base(position, fuel)
        {
        }
        public override void Act()
        {
            if(Fuel<=0)
            {
                return;

            }
            Position = Position + new Coord(1, 0);
            ConsumeFuel(1);

        }
    }
}
