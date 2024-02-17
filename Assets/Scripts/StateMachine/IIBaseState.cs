using UnityEngine;

namespace StateMachine
{
    public interface IIBaseState<out TStates>
    {
        public void OnStateEnter();
        public void OnStateUpdate();
        public void OnStateFixedUpdate();
        public void OnStateLeave();
        public void OnStateTriggerEnter(Collider other);
        public void OnStateCollisionEnter(Collision other);

        public TStates GetNewState();
    }
}