using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZludovaPractica
{
    public abstract class AbstractModule
    {
        protected Coord Position;
        protected int Fuel;

        public AbstractModule(Coord position, int fuel)
        {
            Position = position;
            Fuel = fuel;
        }

        public abstract void Act();

        public virtual void ConsumeFuel(int amount)
        {
            if (Fuel - amount < 0)
            {
                Fuel = 0;
            }
            else
            {
                Fuel = Fuel - amount;
            }
        }
        public int FuelLeft
        {
            get { return Fuel; }
        }

        public Coord GetPosition()
        {
            return Position;
        }

        public void SetPosition(Coord newPosition)
        {
            Position = newPosition;
        }
    }
}
