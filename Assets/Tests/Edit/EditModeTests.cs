using Components;
using NUnit.Framework;

namespace Tests.Edit
{
    public class EditModeTests
    {
        private Entity _entity;

        [Test]
        public void T0000_NewEntityExists_NotNull()
        {
            _entity = new Entity(new Health(100.0f));

            Assert.IsNotNull(_entity);
        }

        [Test]
        public void T0001_CheckIfAliveAfter10Damage_IsAliveTrueHasDiedFalse()
        {
            _entity.Damageable.TakeDamage(10);
            
            Assert.True(_entity.Health.IsAlive());
            Assert.False(_entity.Health.HasDied());
        }

        [Test]
        public void T0002_CheckIfAliveAfter150Damage_IsAliveFalseHasDiedTrue()
        {
            _entity.Damageable.TakeDamage(150);
            
            Assert.False(_entity.Health.IsAlive());
            Assert.True(_entity.Health.HasDied());
        }

        [Test]
        public void T0003_CheckIfHealthNotBelowZero_HealthValueAbove0()
        {
            _entity.Damageable.TakeDamage(150);
            
            Assert.GreaterOrEqual(_entity.Health.Value, 0.0f);
        }
    }
}
