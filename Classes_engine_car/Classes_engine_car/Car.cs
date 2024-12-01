namespace Classes_engine_car
{
    public class Car
    {
        private Engine _engine;

        public Car(Engine engine)
        {
            if (engine != null)
            {
                _engine = engine;
            }
            else
            {
                _engine = new Engine();
            }
        }

        public bool TryFillTank(int fuel)
        {
            if (_engine == null)
            {
                return false;
            }

            if (_engine.TryIncreaseFuel(fuel))
            {
                return true;
            }

            return false;
        }

        public int GetFuel()
        {
            return _engine.GetFuel();
        }
    }
}
