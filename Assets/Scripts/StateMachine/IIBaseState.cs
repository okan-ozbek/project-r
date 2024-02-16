using Player.States;

namespace StateMachine
{
    public interface IIBaseState<out TStates>
    {
        public void OnStateEnter();
        public void OnStateUpdate();
        public void OnStateLeave();

        public TStates GetNewState();
    }
}