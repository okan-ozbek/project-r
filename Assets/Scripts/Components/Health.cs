namespace Components
{
    public class Health
    {
        public float Value { get; private set; }

        public Health(float value)
        {
            Value = value;
        }

        public void ChangeHealth(float newHealthValue)
        {
            Value = newHealthValue;
        }

        public bool IsAlive()
        {
            return (Value > 0.0f);
        }

        public bool HasDied()
        {
            return (Value <= 0.0f);
        }
    }
}