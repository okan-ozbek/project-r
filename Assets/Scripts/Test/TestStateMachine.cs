using StateMachine;
using UnityEngine.Assertions;

namespace Test
{
    public class TestStateMachine : StateManager<TestStateEnum>
    {
        public void Run()
        {
            States.Add(TestStateEnum.State001, new TestState001(TestStateEnum.State001));
            States.Add(TestStateEnum.State002, new TestState002(TestStateEnum.State002));
            States.Add(TestStateEnum.State003, new TestState003(TestStateEnum.State003));

            CurrentState = States[TestStateEnum.State001];
            OnStateEnter();
            
            Assert.IsTrue(CurrentState.Name.Equals(TestStateEnum.State001));
            
            OnStateUpdate();
            Assert.IsTrue(CurrentState.Name.Equals(TestStateEnum.State002));
            
            OnStateUpdate();
            Assert.IsTrue(CurrentState.Name.Equals(TestStateEnum.State003));
            
        }
    }
}