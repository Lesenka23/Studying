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

        public bool FillTank(int fuel, out string reason)
        {
            if (_engine == null)
            {
                reason = "Engine is null";
                return false;
            }

            if (_engine.TrySetFuel(fuel))
            {
                reason = "All ok";
                return true;
            }

            reason = "fuel is not valid";
            return false;
        }
    }
}
