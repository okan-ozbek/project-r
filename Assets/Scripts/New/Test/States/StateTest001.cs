using System;
using New.Enums;

namespace New.Test.States
{
    public class StateTest001 : TestBaseState
    {
        public StateTest001(TestStateMachine context) : base(TestStatesEnum.Test001, context) { }

        public override void OnEnter()
        {
            base.OnEnter();

            Console.WriteLine(Context.Message);
        }

        public override void CheckStateSwitch()
        {
            Context.TransitionTo(TestStatesEnum.Test002);
        }
    }
}