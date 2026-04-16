using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZludovaPractica
{
    public class SimulationEngine
    {
        public bool TryStep(
            AbstractModule[][] map,
            in int turnNumber,
            out int processedCount,
            ref int totalFuelConsumed)
        {
            processedCount = 0;
            if (map == null || map.Length == 0)
            {
                return false;
            }
            foreach (AbstractModule[] row in map)
            {
                if (row == null)
                {
                    continue;
                }
                foreach (AbstractModule module in row)
                {
                    if (module == null)
                    {
                        continue;
                    }
                    int fuelBefore = module.FuelLeft;
                    module.Act();
                    int fuelAfter = module.FuelLeft;
                    totalFuelConsumed += fuelBefore - fuelAfter;
                    processedCount++;
                }
            }
            return processedCount > 0;
        }
        public static void ShiftMapCoords(AbstractModule[][] map, in Coord offset)
        {
        foreach (AbstractModule[] row in map)
        {
            if (row == null)
                continue;

            foreach (AbstractModule module in row)
            {
                if (module == null)
                    continue;

                Coord current = module.GetPosition();
                Coord newPos = current + offset;

                module.SetPosition(newPos);
            }
        }
    }
    }
}
