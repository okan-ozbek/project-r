using New.Enums;

namespace New.Test.States
{
    public class StateTest002 : TestBaseState
    {
        public StateTest002(TestStateMachine context) : base(TestStatesEnum.Test002, context) { }

        public override void CheckStateSwitch()
        {
            Context.TransitionTo(TestStatesEnum.Test001);
        }
    }
}