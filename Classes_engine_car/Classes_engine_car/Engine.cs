using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_engine_car
{
    public class Engine
    {
        private int _minFuel;
        private int _maxFuel;

        private int _fuel;

        public Engine()
        {
            _fuel = 0;
            _minFuel = 0;
            _maxFuel = 100;
        }

        public bool TrySetFuel(int fuel)
        {
            if (fuel > _maxFuel || fuel < _minFuel)
            {
                return false;
            }

            _fuel = fuel;
            return true;
        }

        public int GetFuel()
        {
            return _fuel;
        }
    }
}
