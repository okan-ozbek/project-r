namespace Component
{
    public class Entity
    {
        public readonly Health Health;
        public readonly Damageable Damageable;

        public Entity(Health health)
        {
            Health = health;
            Damageable = new Damageable(health);
        }
    }
}