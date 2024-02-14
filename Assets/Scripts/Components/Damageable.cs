namespace Components
{
    public class Damageable 
    {
        private readonly Health _health;

        public Damageable(Health health) 
        {
            _health = health;
        }

        public void TakeDamage(float amount)
        {
            if (_health.IsAlive()) 
            {
                var newHealthValue = _health.Value - amount;
                
                if (newHealthValue < 0.0f) 
                {
                    newHealthValue = 0.0f;
                }

                _health.ChangeHealth(newHealthValue);
            }
        }
    }
}