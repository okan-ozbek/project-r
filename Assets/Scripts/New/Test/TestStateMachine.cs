using System.Collections.Generic;
using New.Enums;
using New.State_Machine;
using New.Test.States;

namespace New.Test
{
    public class TestStateMachine : GenericFiniteStateMachine<TestStatesEnum>
    {
        public string Message => "Hello world";
    
        private void Start()
        {
            SetStates(TestStatesEnum.Test001);
        }

        private void Update()
        {
        
        }
    
        protected override Dictionary<TestStatesEnum, GenericBaseState<TestStatesEnum>> GetStates()
        {
            return new Dictionary<TestStatesEnum, GenericBaseState<TestStatesEnum>>()
            {
                { TestStatesEnum.Test001, new StateTest001(this) },
                { TestStatesEnum.Test002, new StateTest002(this) }
            };
        }
    }
}