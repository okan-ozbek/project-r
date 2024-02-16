namespace Components
{
    public class Entity
    {
        public Health Health;
        public Damageable Damageable;

        public Entity(Health health)
        {
            Health = health;
            Damageable = new Damageable(health);
        }
    }
}