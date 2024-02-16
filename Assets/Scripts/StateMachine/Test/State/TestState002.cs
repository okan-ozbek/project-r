using Test;
using UnityEngine;

namespace StateMachine.Test.State
{
    public sealed class TestState002 : TestState
    {
        public TestState002(TestStateMachine context, TestStateEnum name) : base(context, name)
        {
        }
        
        public override void OnStateEnter()
        {
            context.ContextValue = 2;
        }

        public override TestStateEnum GetNewState()
        {
            return TestStateEnum.State003;
        }
    }
}