using UnityEngine;

namespace Player.Component
{
    public class PlayerInput
    {
        public Vector3 Direction;
        public bool HasPressedSprint;
        public bool HasPressedJump;

        public void Update()
        {
            Direction = new Vector3(Input.GetAxisRaw("Horizontal"), 0.0f, Input.GetAxisRaw("Vertical"));

            HasPressedSprint = Input.GetKey(KeyCode.LeftShift);
            HasPressedJump = Input.GetKey(KeyCode.Space);
        }
    }
}