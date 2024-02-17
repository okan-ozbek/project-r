using Component;
using NUnit.Framework;

namespace Tests.Edit
{
    public class Component
    {
        // TODO this should be refactored to have its own entity class
        [Test]
        public void T0000_NewEntityExists_EntityNotNull()
        {
            var entity = new Entity(new Health(100.0f));

            Assert.IsNotNull(entity);
        }

        [Test]
        public void T0001_CheckIfAliveAfterTenDamage_IsAliveTrueHasDiedFalse()
        {
            var entity = new Entity(new Health(100.0f));
            
            entity.Damageable.TakeDamage(10.0f);
            
            Assert.True(entity.Health.IsAlive());
            Assert.False(entity.Health.HasDied());
        }

        [Test]
        public void T0002_CheckIfAliveAfterHundredDamage_IsAliveFalseHasDiedTrue()
        {
            var entity = new Entity(new Health(100.0f));
            
            entity.Damageable.TakeDamage(100.0f);
            
            Assert.False(entity.Health.IsAlive());
            Assert.True(entity.Health.HasDied());
        }

        [Test]
        public void T0003_CheckIfHealthNotBelowZeroAfterHundredDamage_HealthEqualsZero()
        {
            var entity = new Entity(new Health(100.0f));
            
            entity.Damageable.TakeDamage(100.0f);
            
            Assert.AreEqual(0.0f, entity.Health.Value);
        }
    }
}
