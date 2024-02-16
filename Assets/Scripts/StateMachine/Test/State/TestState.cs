using Test;

namespace StateMachine.Test.State
{
    public abstract class TestState : BaseState<TestStateEnum>
    {
        protected TestStateMachine context;
        
        protected TestState(TestStateMachine context, TestStateEnum name) : base(name)
        {
            this.context = context;
        }
    }
}