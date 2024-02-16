using StateMachine;
using UnityEngine;

namespace Test
{
    public sealed class TestState002 : BaseState<TestStateEnum>
    {
        public TestState002(TestStateEnum name) : base(name)
        {
        }
        
        public override void OnStateEnter()
        {
            Debug.Log("Entered state 002");
        }

        public override void OnStateLeave()
        {
            Debug.Log("Left state 002");
        }

        public override TestStateEnum GetNewState()
        {
            return TestStateEnum.State003;
        }
    }
}