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
        public bool TryIncreaseFuel(int fuel)
        {
            if (fuel > _maxFuel || fuel < _minFuel)
            {
                return false;
            }

            if (_fuel + fuel <= _maxFuel)
            {
                _fuel += fuel;
                return true;
            }

            return false;
        }

        public int GetFuel()
        {
            return _fuel;
        }
    }
}
