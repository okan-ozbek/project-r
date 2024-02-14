using Player.States;

namespace Player.Interfaces
{
    public interface IIBaseState
    {
        public void Init(BaseState state);
        public void Update();
        public void FixedUpdate();
    }
}