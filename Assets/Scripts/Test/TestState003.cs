using StateMachine;
using UnityEngine;

namespace Test
{
    public sealed class TestState003 : BaseState<TestStateEnum>
    {
        public TestState003(TestStateEnum name) : base(name)
        {
        }
        
        public override void OnStateEnter()
        {
            Debug.Log("Entered state 003");
        }

        public override void OnStateLeave()
        {
            Debug.Log("Left state 003");
        }

        public override TestStateEnum GetNewState()
        {
            return TestStateEnum.State001;
        }
    }
}