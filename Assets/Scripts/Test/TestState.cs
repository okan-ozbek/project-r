using StateMachine;

namespace Test
{
    public abstract class TestState : BaseState<TestStateEnum>
    {
        protected TestState(TestStateEnum name) : base(name)
        {
        }
    }
}