using Test;
using UnityEngine;

namespace StateMachine.Test.State
{
    public sealed class TestState001 : TestState
    {
        public TestState001(TestStateMachine context, TestStateEnum name) : base(context, name)
        {
        }

        public override void OnStateEnter()
        {
            context.ContextValue = 1;
        }

        public override TestStateEnum GetNewState()
        {
            return TestStateEnum.State002;
        }
    }
}