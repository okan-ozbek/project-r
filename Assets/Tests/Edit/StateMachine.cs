using System;
using NUnit.Framework;
using Test;
using Assert = UnityEngine.Assertions.Assert;
using TestStateMachine = StateMachine.Test.TestStateMachine;

namespace Tests.Edit
{
    public class StateMachine
    {
        private TestStateMachine _testStateMachine;
        
        [Test]
        public void T0001_InitializeStateMachine_AssertStateMachineNotNull()
        { 
            _testStateMachine = new TestStateMachine();

            Assert.IsNotNull(_testStateMachine);
        }

        [Test]
        public void T0002_CheckStateMachineDictionaryIsEmpty_AssertStatesIsEmpty()
        {
            Assert.IsTrue(_testStateMachine.States.Count == 0);
        }

        [Test]
        public void T0003_CheckStateMachineDictionaryIsFilled_AssertStatesIsFilled()
        {
            _testStateMachine.PopulateStates();
            
            Assert.IsTrue(_testStateMachine.States.Count == Enum.GetNames(typeof(TestStateEnum)).Length);
        }

        [Test]
        public void T0004_CheckStateMachineEntersState001_AssertCurrentStateEqualsState001()
        {
            _testStateMachine.OnStart();
            Assert.IsTrue(_testStateMachine.CurrentState.StateName.Equals(TestStateEnum.State001));
        }

        [Test]
        public void T0005_CheckStateMachineContextValueIs1_AssertContextValueIs1()
        {
            Assert.IsTrue(_testStateMachine.ContextValue == 1);
        }
        
        [Test]
        public void T0006_CheckStateMachineEntersState002_AssertCurrentStateEqualsState002()
        {
            _testStateMachine.OnUpdate();
            Assert.IsTrue(_testStateMachine.CurrentState.StateName.Equals(TestStateEnum.State002));
        }
        
        [Test]
        public void T0007_CheckStateMachineStaysState002WithoutUpdate_AssertCurrentStateEqualsState002()
        {
            Assert.IsTrue(_testStateMachine.CurrentState.StateName.Equals(TestStateEnum.State002));
        }
        
        [Test]
        public void T0008_CheckStateMachineContextValueIs2_AssertContextValueIs2()
        {
            Assert.IsTrue(_testStateMachine.ContextValue == 2);
        }
        
        [Test]
        public void T0009_CheckStateMachineEntersState003_AssertCurrentStateEqualsState003()
        {
            _testStateMachine.OnUpdate();
            Assert.IsTrue(_testStateMachine.CurrentState.StateName.Equals(TestStateEnum.State003));
        }
        
        [Test]
        public void T0010_CheckStateMachineContextValueIs3_AssertContextValueIs3()
        {
            Assert.IsTrue(_testStateMachine.ContextValue == 3);
        }
    }
}