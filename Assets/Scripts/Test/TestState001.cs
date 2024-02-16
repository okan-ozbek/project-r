using System.Threading;
using StateMachine;
using UnityEngine;

namespace Test
{
    public sealed class TestState001 : BaseState<TestStateEnum>
    {
        public TestState001(TestStateEnum name) : base(name)
        {
        }

        public override void OnStateEnter()
        {
            Debug.Log("Entered state 001");
        }

        public override void OnStateLeave()
        {
            Debug.Log("Left state 001");
        }

        public override TestStateEnum GetNewState()
        {
            return TestStateEnum.State002;
        }
    }
}