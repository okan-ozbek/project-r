using UnityEngine;

namespace Player.Component
{
    public sealed class PlayerInput
    {
        public Vector3 Direction;
        public bool HasPressedSprint;
        public bool HasPressedAttack;
        public bool HasPressedDash;

        public void Update()
        {
            Direction = new Vector3(Input.GetAxisRaw("Horizontal"), 0.0f, Input.GetAxisRaw("Vertical"));

            HasPressedSprint = Input.GetKey(KeyCode.LeftShift);
            HasPressedAttack = Input.GetKey(KeyCode.F);
            HasPressedDash = Input.GetKey(KeyCode.Space);
        }
    }
}