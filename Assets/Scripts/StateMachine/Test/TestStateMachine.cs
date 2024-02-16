using StateMachine.Test.State;
using Test;

namespace StateMachine.Test
{
    public sealed class TestStateMachine : TestStateManager<TestStateEnum>
    {
        public int ContextValue;
        
        public void PopulateStates()
        {
            States.Add(TestStateEnum.State001, new TestState001(this, TestStateEnum.State001));
            States.Add(TestStateEnum.State002, new TestState002(this, TestStateEnum.State002));
            States.Add(TestStateEnum.State003, new TestState003(this, TestStateEnum.State003));
        }

        public void OnStart()
        {
            CurrentState = States[TestStateEnum.State001];
            Start();
        }

        public void OnUpdate()
        {
            Update();
        }
    }
}