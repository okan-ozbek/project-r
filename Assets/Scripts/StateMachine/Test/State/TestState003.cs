using Test;
using UnityEngine;

namespace StateMachine.Test.State
{
    public sealed class TestState003 : TestState
    {
        public TestState003(TestStateMachine context, TestStateEnum name) : base(context, name)
        {
        }
        
        public override void OnStateEnter()
        {
            context.ContextValue = 3;
        }

        public override TestStateEnum GetNewState()
        {
            return TestStateEnum.State001;
        }
    }
}